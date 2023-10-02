// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace EnumerationPractice
{
    class Practice
    {

        public enum StatType
        {
            Strength,
            Agility,
            Resilience,
            Perception

        }

        public class Stat
        {
            public int Strength { get; set; }
            public int Agility { get; set; }
            public int Resilience { get; set; }
            public int Perception { get; set; }
            

            public int StatCheck(string UserAssignedValue, int PointsAvailable)
            {
                var TryParse = Int32.TryParse(UserAssignedValue, out var StringToInt);
                if (!TryParse || StringToInt < 0)
                {
                    Console.WriteLine("Put in a proper value you moron!");
                    var NewValue = Console.ReadLine();
                    StatCheck(NewValue, PointsAvailable);
                }
                return StringToInt;
            }

            public void AssignStat(StatType type, string UserAssign, int AvailablePoints)
            {
                var UserInputValue = StatCheck(UserAssign, AvailablePoints);

                switch (type)
                {
                    case StatType.Strength:
                        Strength = UserInputValue;
                        break;
                    case StatType.Agility:
                        Agility = UserInputValue;
                        break;
                    case StatType.Resilience:
                        Resilience = UserInputValue;
                        break;
                    case StatType.Perception:
                        Perception = UserInputValue;
                        break;

                }

                AvailablePoints -= UserInputValue;
                Console.WriteLine($"Points left: {AvailablePoints}");
            }
        }
        static void Main(string[] args)
        {
            
            Stat stat = new Stat();
            int AvailablePoints = 30;

            Console.WriteLine("Assign Strength: ");
            var AssignStrengthPoints = Console.ReadLine();
            stat.AssignStat(StatType.Strength, AssignStrengthPoints, AvailablePoints);
            Console.WriteLine("Assign Agility: ");
            var AssignAgilityPoints = Console.ReadLine();
            stat.AssignStat(StatType.Agility, AssignAgilityPoints, AvailablePoints);
            Console.WriteLine("Assign Perception: ");
            var AssignResiliencePoints = Console.ReadLine();
            stat.AssignStat(StatType.Resilience, AssignResiliencePoints, AvailablePoints);
            Console.WriteLine("Assign Perception: ");
            var AssignPerceptionPoints = Console.ReadLine();
            stat.AssignStat(StatType.Perception, AssignPerceptionPoints, AvailablePoints);

            Console.WriteLine(stat.Strength.ToString());
            Console.WriteLine(stat.Agility.ToString());
            Console.WriteLine(stat.Perception.ToString());
    
        }
    }
}
