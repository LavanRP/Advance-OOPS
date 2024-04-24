using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class Duck : IAnimal
    {
        public string Name { get; set; }
        public string Habitat { get; set; }
        public string EatingHabit { get; set; }
        public void DisplayName()
        {
            Name = "Duck";
            Console.WriteLine($"Animal name: {Name}");
        }
        public void DisplayInfo(string habitat,string eatingHabit)
        {
            Habitat = habitat;
            EatingHabit = eatingHabit;
            Console.WriteLine($"Habitat : {Habitat}\nEatingHabit : {EatingHabit}");
        }
    }
}