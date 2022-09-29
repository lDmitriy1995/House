using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    public interface IPart
    {
        string color { get; set; }
        TimeSpan constructionTime { get; set; }

        int count { get; set; }

        typeOFMateryal typeOFMateryal { get; set; }

        double materyalPrice { get; set; }

        int sort { get; set; } 

        bool  isComplited { get; set; }  


        TimeSpan GetConstructionTime();
        double GetConstructionCost();




    }
}
