using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    public class Roof : IPart
    {


        public string color { get; set; }
        public TimeSpan constructionTime { get; set; }
        public int count { get; set; }
        public typeOFMateryal typeOFMateryal { get; set; }
        public double materyalPrice { get; set; }

        public int sort { get; set; } = 5;

        public bool isComplited { get; set; }
        public double GetConstructionCost()
        {
            return materyalPrice * count;
        }

        public TimeSpan GetConstructionTime()
        {
            return TimeSpan.FromTicks(constructionTime.Ticks * count);
        }
    }
}
