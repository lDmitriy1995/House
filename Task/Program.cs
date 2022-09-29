using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Model;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CatalogEdition catalogEdition = new CatalogEdition();
            catalogEdition[1].GetEditionInfo();

        }



       
    }
}
