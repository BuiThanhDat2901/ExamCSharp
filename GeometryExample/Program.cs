using System;
using Ex1;


namespace GeometryExample
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter the dimenstions of the cylinder");
            Cylinder cylinder = new Cylinder();
            cylinder.Radius = 38.64;
            cylinder.Height = 22.48;
            cylinder.Process();
            cylinder.Result();
        }
    }
}