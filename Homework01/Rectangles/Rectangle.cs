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
            this.Id = id;
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
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

        public bool CheckHorizontal(double x, double x1)
        {
            bool result = (x >= this.X && x < GetX1()) || (x1 >= this.X && x1 <= this.GetX1());

            return result;
        }

        public bool CheckVertical(double y, double y1)
        {
            bool result = (y >= this.Y && y1 <= GetY1()) || (y1 >= this.Y && y1 <= this.GetY1());

            return result;
        }

        public bool CheckIntersect(Rectangle rectangle)
        {
            return CheckHorizontal(rectangle.X, rectangle.GetX1()) &&
                CheckVertical(rectangle.Y, rectangle.GetY1());
        }
    }
}
