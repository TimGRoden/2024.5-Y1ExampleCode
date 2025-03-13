using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L159_Abstract_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Shape s = new Shape(); //Doesn't work, can't instantiate an abstract concept.
            Square s = new Square();

            Shape[] shapes = 
            {
                new Square(),
                new Square(),
                //new Shape() //Doesn't work, can't instantiate an abstract concept.
            };
        }
    }

    public abstract class Shape
    {
        public string name = "Stephen";
        public void greetBarry()
        {
            Console.WriteLine("Hi there Barry! Welcome to 'Shape'.");
        }
        public abstract double getArea();

        public abstract void drawScaledShape(double scaleFactor);
    }

    public class Square : Shape
    {
        public override double getArea()
        {
            return 4;
        }

        public override void drawScaledShape(double scaleFactor)
        {
            Console.WriteLine("Whelp, this doesn't work...");
        }
    }
}
