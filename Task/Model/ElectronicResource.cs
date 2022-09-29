using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Model
{
     public class ElectronicResource:Edition
    {
        public string ThirtTitle { get; set; }
        public string AuthorsThirtName { get; set; }    

        public string Link { get; set; }    
        public string Annotation { get; set; }

        public override void GetEditionInfo()
        {
            Console.WriteLine("{0}, {1}, {2}, {3} ", ThirtTitle, AuthorsThirtName, Link,Annotation);
        }


    }
}
