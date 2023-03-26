using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr4_2
{
    class Possilka
    {
        public string Description { get; private set; }
        public int Weight {  set; get; }
        public Possilka(int weight, string description)
        {

            Description = description;
            Weight = weight;

        }
        public void Use() 
        { 
            Console.WriteLine(Weight); 
        }
        class MailService
        {
            public string Name { get; private set; }
            private int Limit { get; set; }
            public MailService(string name, int limit)
            {
                Name = name;
                Limit = limit;
            }
            public void Send_Mailing(Possilka possilka)
            {
                if (possilka.Weight <= Limit)
                {
                    Console.WriteLine("поссылка" + possilka + " отправлена");
                    possilka.Use();
                    Limit -= possilka.Weight;
                }
                else { Console.WriteLine("вес отправленных поссылок превысил лимит"); }
            }
        }
        static void Main()
        {

            Possilka pervaya = new Possilka(90,"поссылка с ништяками");
            Possilka vtoraya = new Possilka(20, "поссылка вкуснях");

            MailService Limit = new MailService("лимит", 100);

            Limit.Send_Mailing(pervaya);
            Limit.Send_Mailing(vtoraya);


            Console.ReadKey(true);
        }
    }
}
