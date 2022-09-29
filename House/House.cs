using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace House
{
    public class House
    {
        private List<IPart> parts = new List<IPart>();

        public House()
        {

        }

        public List<IWorker> CreateTeam()
        {
            List<IWorker> workers = new List<IWorker>();
            Random rnd = new Random();

            for (int i = 0; i < rnd.Next(5,50); i++)
            {
                Worker worker = new Worker();
                worker.name = "Рабочий  #" + i;
                worker.profession = (profession)rnd.Next(0,2);
                worker.pricePerHour = rnd.Next(100,5000);
                worker.workLists = new List<IPart>();
                workers.Add(worker);
            }

            return workers;

        }

        

        public  void CreateHouse(int num)
        {

            switch (num)
            {
                case 1:
                    {
                        Basement basement = new Basement();
                        basement.color = null;
                        basement.constructionTime = new TimeSpan(5,8,0,0);
                        basement.count = 1;
                        basement.materyalPrice = 8000;
                        parts.Add(basement);

                        for (int i = 0; i < 8; i++)
                        {
                            Walls walls = new Walls();
                            walls.color = null;
                            walls.constructionTime = new TimeSpan(0, 9, 2, 0);
                            walls.count = 8;
                            walls.materyalPrice = 600;
                            parts.Add(walls);
                        }

                        for (int i = 0; i < 8; i++)
                        {
                            Door door = new Door();
                            door.color = null;
                            door.constructionTime = new TimeSpan(0, 2, 0, 0);
                            door.count = 5;
                            door.materyalPrice = 100;
                            parts.Add(door);
                        }

                        for (int i = 0; i < 6; i++)
                        {
                            Window window = new Window();
                            window.color = null;
                            window.constructionTime = new TimeSpan(0, 3, 2, 1);
                            window.count = 12;
                            window.materyalPrice = 300;
                            parts.Add(window);
                        }

                        for (int i = 0; i < 4; i++)
                        {
                            Roof roof = new Roof();
                            roof.color = null;
                            roof.constructionTime = new TimeSpan(1, 4, 8, 02);
                            roof.count = 1;
                            roof.materyalPrice = 500;
                            parts.Add(roof);
                            
                        }

                    }
                    break;







            }


            


        }


        public void StartConstruction()
        {
            CreateHouse(1);
            List<IWorker> people = CreateTeam();

            int k = people.Count();
            Random rnd = new Random();


            foreach ( IPart item in parts)
            {
               if(!item.isComplited)
                {
                    // people.FirstOrDefault(f => !f.isBusy);

                    people[rnd.Next(0,k-1)].workLists.Add(item);


                    for (int i = 0; i < item.constructionTime.Hours; i++)
                    {
                        Console.WriteLine(".");
                        Thread.Sleep(10);
                    }

                    Console.WriteLine("-------compleate--------");
                    item.isComplited = true;



                }

            }

            foreach (Worker item in people.Where(w=>w.workLists.Count>0))
            {
                item.PrintSeloryInfo();
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------");
            foreach (Worker item in people.Where(w => w.workLists.Count < 0))
            {
                item.PrintSeloryInfo();
            }
        }








    }
}
