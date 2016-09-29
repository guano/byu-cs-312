using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

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
            HullNode solvedHull = getHull(pointList);

            // Print it to the screen
            Pen greenPen = new Pen(Color.Green);

            HullNode currentNode = solvedHull;
            do {
                g.DrawLine(greenPen, currentNode.point, currentNode.next.point);
                currentNode = currentNode.next;
                // This might not draw the last line. but it should almost draw everything.
            } while (currentNode.next != solvedHull);   // When we get all the way around, stop
            
        }


        // This is the real function that calculates a hull.
        public HullNode getHull(List<System.Drawing.PointF> pointList) {
            if (pointList.Count == 1) {
                // The only thing in the list gets to become a new linked list!
                return new HullNode(pointList[0]);
            } else {
                // half is the number of half of the list
                int half = pointList.Count / 2;

                // Make two new lists to be half of the master list
                List<System.Drawing.PointF> L = new List<PointF>();
                List<System.Drawing.PointF> R = new List<PointF>();

                // Go through the master list and divide it into the two lists.
                foreach(System.Drawing.PointF p in pointList) {
                    if (half > 0) {
                        L.Add(p);
                        half--;
                    } else {
                        R.Add(p);
                    }
                }

                // We merge the two smaller hulls together and return that.
                return mergeHulls(getHull(L), getHull(R));
            }
        }

        // The real meat of the algorithm is in here. >:)
        public HullNode mergeHulls(HullNode L, HullNode R) {
            // Merge the top

            // Merge the bottom

            // Merge the lists together


            return null;
        }

        // We are running our own linked list, because I don't trust the built-in version
        // In our linked list first is just an arbitrary point along the hull.
        // Each point points to the next point clockwise around the hull.
        public class HullNode {
            public HullNode next;
            public System.Drawing.PointF point;

            // When we make a new node, it is its own list- it has a point, and the next in the list is itself
            public HullNode(System.Drawing.PointF point) {
                this.point = point;
                this.next = this;
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
