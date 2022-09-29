using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Car:Trans
    {
        public Car(int MaxSpeed = 240)
        {
            maxSpeed = MaxSpeed;
        }

        public readonly int maxSpeed;

        public string brand { get; set; }
        public string number { get; set; }

        private int speed_;
        public int speed
        {

            get
            {
                return speed_;
            }


            set
            {
                if (value > maxSpeed)
                {
                    throw new Exception("Ошибка установленного значения");
                }
                else
                {
                    speed_ = value;

                }


            }


        }

        //public string loadCapacity { get; set; }

        public override void GetTransInfo()
        {
            string str = string.Format(" Тип транспортного средства: {0} ", CarType);
            Console.WriteLine(str);

            Console.WriteLine(base.WeightInfo()); 
        }
    }
}
