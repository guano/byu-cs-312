using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetworkRouting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearAll()
        {
            startNodeIndex = -1;
            stopNodeIndex = -1;
            sourceNodeBox.Clear();
            sourceNodeBox.Refresh();
            targetNodeBox.Clear();
            targetNodeBox.Refresh();
            arrayTimeBox.Clear();
            arrayTimeBox.Refresh();
            heapTimeBox.Clear();
            heapTimeBox.Refresh();
            differenceBox.Clear();
            differenceBox.Refresh();
            pathCostBox.Clear();
            pathCostBox.Refresh();
            arrayCheckBox.Checked = false;
            arrayCheckBox.Refresh();
            return;
        }

        private void clearSome()
        {
            arrayTimeBox.Clear();
            arrayTimeBox.Refresh();
            heapTimeBox.Clear();
            heapTimeBox.Refresh();
            differenceBox.Clear();
            differenceBox.Refresh();
            pathCostBox.Clear();
            pathCostBox.Refresh();
            return;
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            int randomSeed = int.Parse(randomSeedBox.Text);
            int size = int.Parse(sizeBox.Text);

            Random rand = new Random(randomSeed);
            seedUsedLabel.Text = "Random Seed Used: " + randomSeed.ToString();

            clearAll();
            this.adjacencyList = generateAdjacencyList(size, rand);
            List<PointF> points = generatePoints(size, rand);
            resetImageToPoints(points);
            this.points = points;
        }

        // Generates the distance matrix.  Values of -1 indicate a missing edge.  Loopbacks are at a cost of 0.
        private const int MIN_WEIGHT = 1;
        private const int MAX_WEIGHT = 100;
        private const double PROBABILITY_OF_DELETION = 0.35;

        private const int NUMBER_OF_ADJACENT_POINTS = 3;

        private List<HashSet<int>> generateAdjacencyList(int size, Random rand)
        {
            List<HashSet<int>> adjacencyList = new List<HashSet<int>>();

            for (int i = 0; i < size; i++)
            {
                HashSet<int> adjacentPoints = new HashSet<int>();
                while (adjacentPoints.Count < 3)
                {
                    int point = rand.Next(size);
                    if (point != i) adjacentPoints.Add(point);
                }
                adjacencyList.Add(adjacentPoints);
            }

            return adjacencyList;
        }

        private List<PointF> generatePoints(int size, Random rand)
        {
            List<PointF> points = new List<PointF>();
            for (int i = 0; i < size; i++)
            {
                points.Add(new PointF((float) (rand.NextDouble() * pictureBox.Width), (float) (rand.NextDouble() * pictureBox.Height)));
            }
            return points;
        }

        private void resetImageToPoints(List<PointF> points)
        {
            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics graphics = Graphics.FromImage(pictureBox.Image);
            Pen pen;

            if (points.Count < 100)
                pen = new Pen(Color.Blue);
            else
                pen = new Pen(Color.LightBlue);
            foreach (PointF point in points)
            {
                graphics.DrawEllipse(pen, point.X, point.Y, 2, 2);
            }

            this.graphics = graphics;
            pictureBox.Invalidate();
        }

        // These variables are instantiated after the "Generate" button is clicked
        private List<PointF> points = new List<PointF>();
        private Graphics graphics;
        private List<HashSet<int>> adjacencyList;

        // Use this to generate paths (from start) to every node; then, just return the path of interest from start node to end node
        private void solveButton_Click(object sender, EventArgs e)
        {
            // This was the old entry point, but now it is just some form interface handling
            bool ready = true;

            if(startNodeIndex == -1)
            {
                sourceNodeBox.Focus();
                sourceNodeBox.BackColor = Color.Red;
                ready = false;
            }
            if(stopNodeIndex == -1)
            {
                if(!sourceNodeBox.Focused)
                    targetNodeBox.Focus();
                targetNodeBox.BackColor = Color.Red;
                ready = false;
            }
            if (points.Count > 0)
            {
                resetImageToPoints(points);
                paintStartStopPoints();
            }
            else
            {
                ready = false;
            }
            if(ready)
            {
                clearSome();
                solveButton_Clicked();  // Here is the new entry point
            }
        }

        private void solveButton_Clicked()
        {
            // *** Implement this method, use the variables "startNodeIndex" and "stopNodeIndex" as the indices for your start and stop points, respectively ***

            /* Just prints all the adjacent points
            for (int index = 0; index < points.Count; index++) {
                foreach (int temp in adjacencyList[index]) {
                    Console.WriteLine("Adjacent points to " + index + ": " + temp);
                }
            }
            */

            // We make our sets.
            HashSet<int> visited = new HashSet<int>();
            HashSet<int> unvisited = new HashSet<int>();

            // And our distance list
            //List<double> distance = new List<double>();
            double[] distance = new double[points.Count];

            // And our graph-following list
            //List<int> previous = new List<int>();
            int[] previous = new int[points.Count];


            // Now we need to set up our unvisited set and distance list
            for (int i = 0; i < points.Count; i++) {    // Go through all our points
                unvisited.Add(i);                       // Add that point to the unvisited set
                distance[i] = double.PositiveInfinity;  // distances are infinity
                previous[i] = -1;                       // Tree is not at all connected at the start
            }

            visited.Add(startNodeIndex);                // Start by visiting the first node
            unvisited.Remove(startNodeIndex);           // So it isn't unvisited anymore
            distance[startNodeIndex] = 0;               // Distance to the start node is zero!

            // Finish visiting the first node (update distances)
            foreach (int outNode in adjacencyList[startNodeIndex])
            {
                Console.Write("updating " + outNode + " right now.");
                if (unvisited.Contains(outNode)         // If outNode is not yet visited and the new distance is less than the current distance
                    && distanceBetweenNodes(points[startNodeIndex], points[outNode]) + distance[startNodeIndex] < distance[outNode]
                    )
                {
                    Console.Write(" Updating its distance!\n");
                    // Store the new distance!
                    distance[outNode] = distanceBetweenNodes(points[startNodeIndex], points[outNode]) + distance[startNodeIndex];
                    previous[outNode] = startNodeIndex;// Set up graph.
                } else {
                    Console.Write(" NOT updating its distance\n");
                }
            }

            while (!visited.Contains(stopNodeIndex)) {  // As soon as we've visited the end node, we've won!
                // 1. visit the next closest unvisited node
                int currentNode = getNextNode(unvisited, distance);
                if (currentNode == -1) {
                    Console.WriteLine("CANNOT VISIT ANY MORE NODES");
                    return;
                }
                visited.Add(currentNode);               // We are now visiting this node
                unvisited.Remove(currentNode);          // so it is not unvisited any more

                // 2. For all the (unvisited) nodes it can go to, update their distance if it is now less from the current node
                foreach (int outNode in adjacencyList[currentNode]) {
                    //Console.Write("updating " + outNode + " right now.");
                    if (unvisited.Contains(outNode)     // If outNode is not yet visited and the new distance is less than the current distance
                        && distanceBetweenNodes(points[currentNode], points[outNode]) + distance[currentNode] < distance[outNode]
                        ) {
                        // Store the new distance!
                      //  Console.Write(" Updating its distance!\n");
                        distance[outNode] = distanceBetweenNodes(points[currentNode], points[outNode]) + distance[currentNode];
                        previous[outNode] = currentNode;// Set up graph.
                    } else {
                        //Console.Write(" NOT updating its distance\n");
                    }
                }

            }

            // now we have good stuff.
            Console.WriteLine("Last node " + stopNodeIndex + " distance: " + distance[stopNodeIndex]);
            int tamp = stopNodeIndex;
            while (tamp != startNodeIndex) {
                Console.WriteLine(tamp + " connects to ");
                this.graphics.DrawLine(new Pen(Color.SlateBlue), points[tamp], points[previous[tamp]]);
                // draw the number
                double dist = distanceBetweenNodes(points[tamp], points[previous[tamp]]);

                tamp = previous[tamp];
            }
            Console.WriteLine(tamp);

        }

        // A simple function to get the distance between two points
        public static double distanceBetweenNodes(PointF point1, PointF point2) {
            double a = point2.X - point1.X;
            double b = point2.Y - point1.Y;
            return Math.Sqrt(a * a + b * b);
        }


        // Gets the next closest unvisited node. Returns -1 if there is no node to visit
        // Currently doing a naive search through the entire list every time. 
        // TODO: implement this with a priority queue instead.
        private int getNextNode(HashSet<int>unvisited, double[] distance) {//List<double>distance) {
            double currentBest = double.PositiveInfinity;
            int currentBestIndex = -1;

            for (int i = 0; i< distance.Length; i++) {
                if (distance[i] != double.PositiveInfinity && unvisited.Contains(i) && distance[i] < currentBest) {
                    currentBest = distance[i];
                    currentBestIndex = i;
                }
            }
            return currentBestIndex;
        }

        private Boolean startStopToggle = true;
        private int startNodeIndex = -1;
        private int stopNodeIndex = -1;
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (points.Count > 0)
            {
                Point mouseDownLocation = new Point(e.X, e.Y);
                int index = ClosestPoint(points, mouseDownLocation);
                if (startStopToggle)
                {
                    startNodeIndex = index;
                    sourceNodeBox.ResetBackColor();
                    sourceNodeBox.Text = "" + index;
                }
                else
                {
                    stopNodeIndex = index;
                    targetNodeBox.ResetBackColor();
                    targetNodeBox.Text = "" + index;
                }
                resetImageToPoints(points);
                paintStartStopPoints();
            }
        }

        private void sourceNodeBox_Changed(object sender, EventArgs e)
        {
            if (points.Count > 0)
            {
                try{ startNodeIndex = int.Parse(sourceNodeBox.Text); }
                catch { startNodeIndex = -1; }
                if (startNodeIndex < 0 | startNodeIndex > points.Count-1)
                    startNodeIndex = -1;
                if(startNodeIndex != -1)
                {
                    sourceNodeBox.ResetBackColor();
                    resetImageToPoints(points);
                    paintStartStopPoints();
                    startStopToggle = !startStopToggle;
                }
            }
        }

        private void targetNodeBox_Changed(object sender, EventArgs e)
        {
            if (points.Count > 0)
            {
                try { stopNodeIndex = int.Parse(targetNodeBox.Text); }
                catch { stopNodeIndex = -1; }
                if (stopNodeIndex < 0 | stopNodeIndex > points.Count-1)
                    stopNodeIndex = -1;
                if(stopNodeIndex != -1)
                {
                    targetNodeBox.ResetBackColor();
                    resetImageToPoints(points);
                    paintStartStopPoints();
                    startStopToggle = !startStopToggle;
                }
            }
        }
        
        private void paintStartStopPoints()
        {
            if (startNodeIndex > -1)
            {
                Graphics graphics = Graphics.FromImage(pictureBox.Image);
                graphics.DrawEllipse(new Pen(Color.Green, 6), points[startNodeIndex].X, points[startNodeIndex].Y, 1, 1);
                this.graphics = graphics;
                pictureBox.Invalidate();
            }

            if (stopNodeIndex > -1)
            {
                Graphics graphics = Graphics.FromImage(pictureBox.Image);
                graphics.DrawEllipse(new Pen(Color.Red, 2), points[stopNodeIndex].X - 3, points[stopNodeIndex].Y - 3, 8, 8);
                this.graphics = graphics;
                pictureBox.Invalidate();
            }
        }

        private int ClosestPoint(List<PointF> points, Point mouseDownLocation)
        {
            double minDist = double.MaxValue;
            int minIndex = 0;

            for (int i = 0; i < points.Count; i++)
            {
                double dist = Math.Sqrt(Math.Pow(points[i].X-mouseDownLocation.X,2) + Math.Pow(points[i].Y - mouseDownLocation.Y,2));
                if (dist < minDist)
                {
                    minIndex = i;
                    minDist = dist;
                }
            }

            return minIndex;
        }
    }
}
