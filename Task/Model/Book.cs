using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Model
{
    public class Book:Edition
    {
       public string Title { get; set; }

       public string AuthorsName { get; set; }  

        public DateTime YearOfPublic { get; set; }  

        public string Publisher { get; set; }

        public override void GetEditionInfo()
        {
            Console.WriteLine("{0}, {1}, {3} ",Name,Year,Director );
        }

    }
}
