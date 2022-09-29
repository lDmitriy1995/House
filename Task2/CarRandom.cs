using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class CarRandom
    {
        private List<Trans> cars = new List<Trans>();

        public void AddTrans(Trans transport)
        {
            cars.Add(transport);
        }
        public void PrintInfo()
        {
            foreach (Trans item in cars)
            {
                item.GetTransInfo();
            }
        }

    }
}
