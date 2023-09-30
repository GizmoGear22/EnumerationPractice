// See https://aka.ms/new-console-template for more information
using System;

namespace EnumerationPractice
{
    class Practice
    {

        public enum StatType
        {
            Strength,
            Agility,
            Perception

        }

        public class Stat
        {
            public int Strength { get; set; }
            public int Agility { get; set; }
            public int Perception { get; set; }

           
            public void AssignStat(StatType type, string UserAssign)
            {
                var StringToInt = Convert.ToInt32(UserAssign);
                switch (type)
                {
                    case StatType.Strength:
                        Strength = StringToInt;
                        break;
                    case StatType.Agility:
                        Agility = StringToInt;
                        break;
                    case StatType.Perception:
                        Perception = StringToInt;
                        break;

                }
            }
        }
        static void Main(string[] args)
        {
            
            Stat stat = new Stat();

            Console.WriteLine("Assign Strength: ");
            var AssignStrength = Console.ReadLine();
            Console.WriteLine("Assign Agility: ");
            var AssignAgility = Console.ReadLine();
            Console.WriteLine("Assign Perception: ");
            var AssignPerception = Console.ReadLine();

            stat.AssignStat(StatType.Strength, AssignStrength);
            stat.AssignStat(StatType.Agility, AssignAgility);
            stat.AssignStat(StatType.Perception, AssignPerception);

            Console.WriteLine(stat.Strength.ToString());
            Console.WriteLine(stat.Agility.ToString());
            Console.WriteLine(stat.Perception.ToString());
    
        }
    }
}
