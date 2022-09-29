using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{


    public class Program
    {
        static void Main(string[] args)
        {

            Transport transport = new Transport();
            transport.CarType = "";
            transport.CarWeight = 0;
            transport.MaxWeight = 0;
            //add
            transport.Cost = 0;
            transport.TransportCode = "";

            ITrans trans = new Transport();
            trans.CarType = "";
            trans.CarWeight = 0;
            trans.MaxWeight = 0;


            Random rnd = new Random();
            CarRandom carRandom = new CarRandom();

            for (int i = 0; i < 5; i++)
            {
                try
                {
                    var cr = new Car();
                    cr.CarType = "Car type #" + i;
                    cr.CarWeight = rnd.Next(500, 1700);
                    cr.MaxWeight = rnd.Next(1000, 2500);
                    cr.brand = "brand type #" + i;
                    cr.speed = rnd.Next(100, 500);


                    carRandom.AddTrans(cr);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            for (int i = 0; i < 5; i++)
            {
                var mc = new Motorcycle(rnd.Next(0, 2500), rnd.Next(0, 500));
                mc.CarType = "Motorcycle type #" + i;
                mc.CarWeight = 150;
                mc.MotoNumber = "MC" + rnd.Next(1, 895623);
                mc.MotorType = "MotoType #" + i;

                carRandom.AddTrans(mc);
            }

            carRandom.PrintInfo();
        }
    }
}