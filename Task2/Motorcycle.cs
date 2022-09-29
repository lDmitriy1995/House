using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Motorcycle : Trans
    {
        public Motorcycle(int CarWeight, int MaxWeight) : base(CarWeight, MaxWeight)
        {

        }

        public string MotorType { get; set; }

        public string MotoNumber { get; set; }

        public int MotoSpeed { get; set; }

        public bool whellChairs { get; set; }

        public override void GetTransInfo()
        {
            Console.WriteLine("Private information"); ;
        }

        public override string WeightInfo()
        {
            return string.Format("Грузоподъемность равна: {0} ",
                (MaxWeight - CarWeight) / 0.25);
        }
    }
}
