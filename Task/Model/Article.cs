using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Model
{
    public class Article:Edition
    {
        public string SecTitle { get; set; }
        public string AuthorsSecondName { get; set; }   
        public string TitleJournal { get; set; }

        public int  Number { get; set; }

        public DateTime  YearOfSecPublic { get; set; }

        public override void GetEditionInfo()
        {

            Console.WriteLine("{0}, {1}, {2} ", Name, Year, Director);
            Console.WriteLine("{0}, {1}, {2}, {3}, {4} "
                ,SecTitle,AuthorsSecondName,TitleJournal,Number,YearOfSecPublic);
        }

        public Article (string SecTitle, string TitleJournal)
        {
            this.SecTitle = SecTitle;
            this.TitleJournal = TitleJournal;   
        }




    }
}
