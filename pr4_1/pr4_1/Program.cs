using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace pr4_1
{
    class Spell
    {
        public int Mana { get; set; }
        private string Effect { get; set; }

        public Spell(int mana, string effect) {
            Mana = mana;
            Effect = effect;
        }

        public void Use()
        {
            Console.WriteLine(Effect);
        }
        
    }
    class Magician
    {
        public string Name { get; set; }
        public int Mana { set; get; }
        public Magician(string name, int mana) {
        Name= name;
        Mana = mana;
        }
       
        public void CastSpell(Spell spell)
        {
            Console.WriteLine(Name + " колдует!");
            if (Mana >= spell.Mana)
            {
                spell.Use();
                Mana -= spell.Mana;
               
            }
            else
            {
                Console.WriteLine("для использования " + spell + " не  хватает " + (Math.Abs(spell.Mana - Mana)) + " единиц маны. Хлебните зелья!");
            }
        }
        static void Main()
        {

            Spell alohomora = new Spell(60, "замок открывается!");
            Spell vingardiumLeviosa = new Spell(60, "предмет поднимается в воздух!");

            Magician garryPotter = new Magician("Гарри Поттер", 100);

            garryPotter.CastSpell(alohomora);
            garryPotter.CastSpell(vingardiumLeviosa);

            Console.ReadKey(true);
        }
    }
}
