using System;

namespace Ex2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var tiger = new Tiger();
            var lion = new Lion();
            
            tiger.SetMe("Tiger",100);
            lion.SetMe("Lion",200);
            
            tiger.Show();
            lion.Show();
        }
    }

    public abstract class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }


        public void Show()
        {
            Console.WriteLine($"Name: {Name}, Weight: {Weight}");
        }
        public abstract void SetMe(string name, double weight);
    }

    public class Tiger : Animal
    {
        public override void SetMe(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }
    }

    public class Lion : Animal
    {
        public override void SetMe(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }
    }
}