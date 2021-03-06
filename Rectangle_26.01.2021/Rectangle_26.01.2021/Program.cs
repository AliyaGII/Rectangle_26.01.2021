﻿using System;

namespace Rectangle_26._01._2021
{
    class Rectangle
    {
        private double side1 { 
            get; 
        }
        private double side2 { 
            get;
        }
        private double area { 
            get; set;
        }
        private double perimeter { 
            get; set; 
        }
        public Rectangle() { }
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double AreaCalcul(double side1, double side2)
        {
            area = side1 * side2;
            return area;
        }
        public double PerimeterCalcul(double side1, double side2)
        {
            perimeter = 2 * (side1 + side2);
            return perimeter;
        }
        public double Area { 
            get { 
                return area; 
            } 
        }
        public double Perimeter { 
            get { 
                return perimeter; 
            } 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            double side1, side2;
            Console.Write("side1 = ");
            side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("side2 = ");
            side2 = Convert.ToDouble(Console.ReadLine());
            rect.AreaCalcul(side1, side2);
            Console.WriteLine($"Area : {rect.Area}");
            rect.PerimeterCalcul(side1, side2);
            Console.WriteLine($"Perimeter : {rect.Perimeter}");
        }
    }
}
