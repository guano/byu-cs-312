using System;
using System.Collections.Generic;
using System.Text;


namespace TSP
{

    /// <summary>
    /// Represents a city, which is a node in the Traveling Salesman Problem
    /// </summary>
    class City
    {

        public City(double x, double y)
        {
            _X = x;
            _Y = y;
            _elevation = 0.0;
        }

        public City(double x, double y, double elevation)
        {
            _X = x;
            _Y = y;
            _elevation = elevation;
        }

        private double _X;
        private double _Y;
        private double _elevation;
        private const double SCALE_FACTOR = 1000;

        // These are C# property accessors
        public double X
        {
            get { return _X; }
            set { _X = value; }
        }

        public double Y
        {
            get { return _Y; }
            set { _Y = value; }
        }


        /// <summary>
        /// How much does it cost to get from this city to the destination?
        /// Note that this is an asymmetric cost function.
        /// 
        /// In advanced mode, it returns infinity when there is no connection.
        /// </summary>
        public double costToGetTo (City destination) 
        {
            // Cartesian distance
            double magnitude = Math.Sqrt(Math.Pow(this.X - destination.X, 2) + Math.Pow(this.Y - destination.Y, 2));

            // For Medium and Hard modes, add in an asymmetric cost (in easy mode it is zero).
            magnitude += (destination._elevation - this._elevation);
            if (magnitude < 0.0) magnitude = 0.0;

            magnitude *= SCALE_FACTOR;

            // In hard mode, remove edges; this slows down the calculation...
            if (modeManager.isEdgeRemoved(this,destination))
                magnitude = Double.PositiveInfinity;

            return Math.Round(magnitude);
        }


        // This is makes distances asymmetric
        // 0 <= Maximum elevation <= 1
        public const double MAX_ELEVATION = 0.10;

        // The mode manager applies to all the cities...
        private static HardMode modeManager;
        public static void setModeManager(HardMode modeManager)
        {
            City.modeManager = modeManager;
        }

    }
}
