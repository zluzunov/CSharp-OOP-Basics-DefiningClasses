namespace Homework01.Rectangles
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Rectangle
    {
        protected const char Vertical = '|';
        protected const char Horizontal = '-';

        private string _id;
        private int _width;
        private int _height;
        private double _x;
        private double _y;

        public static Dictionary<string, Rectangle> Collection = new Dictionary<string, Rectangle>();

        public Rectangle(string id, int width, int height, double x, double y)
        {
            Id = id;
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public int Height
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

        public void Draw()
        {
            var rectangleString = new StringBuilder();

            rectangleString.Append(GetFirstLast());

            for (int i = 0; i < Height-2; i++)
            {
                rectangleString.Append(GetRow());
            }

            rectangleString.Append(GetFirstLast());

            Console.Write(rectangleString);
        }

        private string GetRow()
        {
            var currentRow = new StringBuilder();
            currentRow.Append(Vertical);
            int spaces = Width;
            for (int i = 0; i < spaces; i++)
            {
                currentRow.Append(' ');
            }

            currentRow.Append(Vertical);
            currentRow.Append('\n');

            return currentRow.ToString();
        }

        private string GetFirstLast()
        {
            var currentRow = new StringBuilder();

            currentRow.Append(Vertical);

            for (int i = 0; i < Width; i++)
            {
                currentRow.Append(new char[] { Horizontal });
            }

            currentRow.Append(new char[] {Vertical, '\n'});

            return currentRow.ToString();
        }
    }
}
