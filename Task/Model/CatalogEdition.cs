using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Model
{
    public class CatalogEdition
    {

        private List<Edition> editions = new List<Edition>();
        public CatalogEdition()
        {



            editions.Add(new Book()
            {
                Title = "Алые Паруса",
                AuthorsName = "Александр Грин",
                YearOfPublic = new DateTime(1916)
                ,
                Publisher = "Александр Грин"
            });

            editions.Add(new Article("Алые Паруса", "Александр Грин"));

        }

        public Edition this[int number]
        {
            get 
            {
                return editions[number];
            }

            set 
            {
                editions[number] = value;
            }


        }

     

    }
}
