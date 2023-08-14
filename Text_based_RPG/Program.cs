using System;

namespace classes_in_C
{
    class Wizard
    {
        public string name;
        public string favouriteSpell;
        public int spellSlots;
        public float experience;

        public Wizard(string _name,
                      string _favouriteSpell)
        {
            name = _name;
            favouriteSpell = _favouriteSpell;
            spellSlots = 2;
            experience = 0f;
        }

        public void CastSpell()
        {
            if (spellSlots > 0)
            {
            Console.WriteLine(name + " casts " + favouriteSpell);
            spellSlots--;
            experience += 0.3f;
            } else
            {
                Console.WriteLine(name + " is out of spells");
            }

        }
        public void Meditate()
        {
            Console.WriteLine(name + " meditates to regain spell slots");
            spellSlots = 2;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Wizard wizard01 = new Wizard( "Fresh D", "Sprechgesang");
            Console.WriteLine("You have " + wizard01.spellSlots + " left");

            wizard01.CastSpell();
            Wizard wizard02 = new Wizard(" Voldemort "," Avada Kedavra ");
            wizard02.CastSpell();           




            //wait before closing
            Console.ReadKey();
        }
    }
}