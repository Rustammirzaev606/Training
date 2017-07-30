using System;
namespace InheritanceApplication
{
    class Shape
    {
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
        protected int width;
        protected int height;
    }

    // Derived class
    class Rectangle : Shape
    {
        public int getArea()
        {
            return (width * height);
        }
    }

    class RectangleTester
    {
        static void Main(string[] args)
        {
            Rectangle Rect = new Rectangle();
            int x, y;
            Console.WriteLine("Enter width of rectangle: ");
            string tempX = Console.ReadLine();
            int.TryParse(tempX, out x);
            Console.WriteLine("Enter heigh of rectangle: ");
            string tempY = Console.ReadLine();
            int.TryParse(tempY, out y);
            Rect.setWidth(x);
            Rect.setHeight(y);

            // Print the area of the object.
            Console.WriteLine("Total area: {0}", Rect.getArea());
            Console.ReadKey();
        }
    }
}