namespace Homework01.Rectangles
{
    using System.Collections.Generic;

    public class Rectangle
    {
        private string _id;
        private double _width;
        private double _height;
        private double _x;
        private double _y;

        public static Dictionary<string, Rectangle> Collection = new Dictionary<string, Rectangle>();

        public Rectangle(string id, double width, double height, double x, double y)
        {
            Id = id;
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public double Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public double X
        {
            get { return _x; }
            set { _x = value; }
        }

        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public double GetX1()
        {
            return _x + _width;
        }

        public double GetY1()
        {
            return _y + _height;
        }

        public bool OverlapHorizontally(double otherX, double otherX1)
        {


            bool result = !(X > otherX1 || otherX > GetX1());

            return result;
        }

        public bool OverlapVertically(double otherY, double otherY1)
        {
            bool result = !(Y > otherY1 || otherY > GetY1());

            return result;
        }

        public bool CheckIntersect(Rectangle rectangle)
        {
            bool overlapHorizontally = OverlapHorizontally(rectangle.X, rectangle.GetX1());
            bool overlapVertically = OverlapVertically(rectangle.Y, rectangle.GetY1());

            bool intersect = overlapHorizontally && overlapVertically;

            return intersect;
        }
    }
}
