using System;

namespace Ex1
{
    public class Cylinder
    {
        public double BaseArea { get; set;  }
        public double LateralArea { get; set;  }
        public double TotalArea { get; set;  }
        public double Volume { get; set;  }
        public double Radius { get; set; }
        public double Height { get; set; }

        public void Process()
        {
            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volume = Math.PI * Radius * Radius * Height;
        }

        public void Result()
        {
            Console.WriteLine("Cylinder Charactericstics");
            Console.WriteLine($"Radius = {Radius}, Height = {Height}");
            Console.WriteLine($"Base = {BaseArea.ToString("0.00")}, Lateral = {LateralArea.ToString("0.00")}, Total = {TotalArea.ToString("0.00")}, Volume = {Volume.ToString("0.00")}");
        }
    }
}