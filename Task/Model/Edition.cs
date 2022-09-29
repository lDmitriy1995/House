using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Model
{
    public abstract class Edition
    {
       public string Name { get; set; }
       public string Adress { get; set; }  
       public  int Year { get; set; }

      public string Director { get; set; }

      public abstract void GetEditionInfo();



    }
}
