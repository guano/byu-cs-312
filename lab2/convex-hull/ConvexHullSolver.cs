using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Linq;

namespace _2_convex_hull {
    class ConvexHullSolver {
        System.Drawing.Graphics g;
        System.Windows.Forms.PictureBox pictureBoxView;

        public ConvexHullSolver(System.Drawing.Graphics g, System.Windows.Forms.PictureBox pictureBoxView) {
            this.g = g;
            this.pictureBoxView = pictureBoxView;
        }

        public void Refresh() {
            // Use this especially for debugging and whenever you want to see what you have drawn so far
            pictureBoxView.Refresh();
        }

        public void Pause(int milliseconds) {
            // Use this especially for debugging and to animate your algorithm slowly
            pictureBoxView.Refresh();
            System.Threading.Thread.Sleep(milliseconds);
        }


        // All of my code is the following
        public void Solve(List<System.Drawing.PointF> pointList) {
            // Solve the hull problem

            // Gotta have a sorted list!
            List<System.Drawing.PointF> sortedList = pointList.OrderBy(o=>o.X).ToList();
            
            HullNode solvedHull = getHull(sortedList);

            // Print it to the screen
            Pen greenPen = new Pen(Color.Green);

            HullNode currentNode = solvedHull;
            do {
                g.DrawLine(greenPen, currentNode.point, currentNode.next.point);
                currentNode = currentNode.next;
                // This might not draw the last line. but it should almost draw everything.
            } while (currentNode != solvedHull);   // When we get all the way around, stop
            
        }


        // This is the real function that calculates a hull.
        public HullNode getHull(List<System.Drawing.PointF> pointList) {
            if (pointList.Count == 1) {
                // The only thing in the list gets to become a new linked list!
                Console.WriteLine("base case. x = " + pointList[0].X);
                return new HullNode(pointList[0]);
            } else {
                // half is the number of half of the list
                int half = pointList.Count / 2;

                // I was told that Take and Skip are magical, but I am wary of this casting that is happening.
                List<System.Drawing.PointF> L = pointList.Take(half).ToList();
                List<System.Drawing.PointF> R = pointList.Skip(half).ToList();

                // We merge the two smaller hulls together and return that.
                Console.WriteLine("merging 2 hulls of total size: " + pointList.Count);
                return mergeHulls(getHull(L), getHull(R));
            }
        }

        // The real meat of the algorithm is in here. >:)
        public HullNode mergeHulls(HullNode L, HullNode R) {
            HullNode currentNode = L;
            do {
                //g.DrawLine(greenPen, currentNode.point, currentNode.next.point);
                currentNode = currentNode.next;
                // This might not draw the last line. but it should almost draw everything.
            } while (currentNode != L);   // When we get all the way around, stop

            currentNode = R;
            do {
                //g.DrawLine(greenPen, currentNode.point, currentNode.next.point);
                currentNode = currentNode.next;
                // This might not draw the last line. but it should almost draw everything.
            } while (currentNode != R);   // When we get all the way around, stop


            // Merge the top
            HullNode l_top = getRightMost(L);       // Get the rightmost point of L
            HullNode r_top = getLeftMost(R);         // And the leftmost point of R
            while (true) {
                // Going counterclockwise on L, make new lines to the new points from the right
                HullNode l_counterclockwise = l_top;
                HullNode l_next;

                double currentSlope = (r_top.point.Y - l_counterclockwise.point.Y) / (r_top.point.X - l_counterclockwise.point.X); // Rise over run
                double nextSlope;
                while (true) {// While slope gets more negative
                    
                    l_next = l_counterclockwise.previous;    // Going even more counterclockwise
                    nextSlope = (r_top.point.Y - l_next.point.Y) / (r_top.point.X - l_next.point.X);
                    if(nextSlope >= currentSlope) {  // Oh no! We have gone too far!
                        break;
                    }

                    // nextSlope is more negative. We are going in the right direction.
                    currentSlope = nextSlope;
                    l_counterclockwise = l_next;
                }
                // When we break out of the loop here, we have found the most negative slope for the given r.

                // Time to find the most positive slope for our found l.
                // Going clockwise on R, make new lines to the found l.
                HullNode r_clockwise = r_top;
                HullNode r_next;
                
                while (true) {
                    r_next = r_clockwise.next;    // Going clockwise
                    nextSlope = (r_next.point.Y - l_counterclockwise.point.Y) / (r_next.point.X - l_counterclockwise.point.X);  // Rise over run

                    if (nextSlope <= currentSlope) { // Oh no! We have gone too far!
                        break;
                    }

                    // Nextslope is more positive. We are going in the right direction
                    currentSlope = nextSlope;
                    r_clockwise = r_next;
                }

                // If neither r nor l have changed, we have found the very top line.
                if (r_clockwise == r_top && l_counterclockwise == l_top) {
                    break;  // We have found the top and r_top and l_top are the correct nodes
                }

                r_top = r_clockwise;    // Reset the variables to iterate again
                l_top = l_counterclockwise;    // Reset the variables to iterate again.
            }

            // Merge the bottom
            HullNode l_bottom = getRightMost(L);       // Get the rightmost point of L
            HullNode r_bottom = getLeftMost(R);         // And the leftmost point of R
            while (true) {
                // Going clockwise on L, draw new lines to the set point on R
                HullNode l_clockwise = l_bottom;
                HullNode l_next;

                double currentSlope = (r_bottom.point.Y - l_clockwise.point.Y) / (r_bottom.point.X - l_clockwise.point.X);  // Rise over run
                double nextSlope;

                while (true) {  // While the slope gets even more POSITIVE
                    l_next = l_clockwise.next; // Going clockwise
                    nextSlope = (r_bottom.point.Y - l_next.point.Y) / (r_bottom.point.X - l_next.point.X);
                    if (nextSlope <= currentSlope) { // We are trying to get positive! This is too far!
                        break;
                    }

                    // nextSlope is more positive. We are going in the right direction
                    currentSlope = nextSlope;
                    l_clockwise = l_next;
                }
                // When we break out of the above loop, we have found the most POSITIVE slope for the given r.

                // Time to find the most NEGATIVE slope for our found l.
                // Going COUNTERCLOCKWISE on R, draw new lines to our found l.
                HullNode r_counterclockwise = r_bottom;
                HullNode r_next;

                while (true) {
                    r_next = r_counterclockwise.previous; // Going COUNTERCLOCKWISE
                    nextSlope = (r_next.point.Y - l_clockwise.point.Y) / (r_next.point.X - l_clockwise.point.X);    // Rise over run


                    if (nextSlope >= currentSlope) { // Oh no! We gound a greater slope! we want negative!
                        break;
                    }

                    //Next slope is more negative. We are going in the right direction
                    currentSlope = nextSlope;
                    r_counterclockwise = r_next;
                }

                // If neither r nor l have changed, we have found the very top line.
                if (r_counterclockwise == r_bottom && l_clockwise == l_bottom) {
                    break;  // We have found the top and r_top and l_top are the correct nodes
                }

                r_bottom = r_counterclockwise;    // Reset the variables to iterate again
                l_bottom = l_clockwise;    // Reset the variables to iterate again.
            }


            // When the above two sections have finished, we should have
            // r_bottom, l_bottom
            // r_top, l_top
            // They need to be connected together, and all nodes between them need to be eliminated.

            // Merge the lists together
            // It is as simple as changing the next and previous pointers to point to the correct nodes.
            r_bottom.next = l_bottom;
            l_bottom.previous = r_bottom;
            l_top.next = r_top;
            r_top.previous = l_top;

            // To return, just return one of the nodes. They all point to each other.
            return r_top;
        }

        // We are running our own linked list, because I don't trust the built-in version
        // In our linked list first is just an arbitrary point along the hull.
        // Each point points to the next point clockwise around the hull.
        public class HullNode {
            public HullNode next;       // Clockwise
            public HullNode previous;   // Counterclockwise
            public System.Drawing.PointF point;

            // When we make a new node, it is its own list- it has a point, and the next in the list is itself
            public HullNode(System.Drawing.PointF point) {
                this.point = point;
                this.next = this;
                this.previous = this;
            }
        }

        public HullNode getLeftMost(HullNode first) {
            HullNode currentNode = first;       // Setting up for the loop
            HullNode currentLeftMost = first;   // All else fails, the first is the leftmost

            // Go through the entire hull to find the node with the leftmost point
            do {
                if (currentNode.point.X < currentLeftMost.point.X) {
                    currentLeftMost = currentNode;
                }
                currentNode = currentNode.next;
            } while (currentNode != first);
            return currentLeftMost;
        }

        public HullNode getRightMost(HullNode first) {
            HullNode currentNode = first;       // Setting up for the loop
            HullNode currentRightMost = first;   // All else fails, the first is the leftmost

            // Go through the entire hull to find the node with the leftmost point
            do {
                if (currentNode.point.X > currentRightMost.point.X) {
                    currentRightMost = currentNode;
                }
                currentNode = currentNode.next;
            } while (currentNode != first);
            return currentRightMost;
        }

    }
}
