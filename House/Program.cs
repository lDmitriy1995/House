using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    public enum typeOFMateryal { brick,wool}
    public enum profession {anElectrican,StoneMan, plumber }

    public class Program
    {
        static void Main(string[] args)
        {

            House house = new House();
            house.StartConstruction();


        }
    }
}
