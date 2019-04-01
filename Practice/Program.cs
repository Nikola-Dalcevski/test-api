using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog jecky = new Dog() { Name = "Jacky", Color = "White", Age = 4 };
            Dog.Chip chip = new Dog.Chip("Vukasin", "11 Oktomvri");
            jecky.AddChip(chip);
            Dog.IdentifyDog(jecky);
            Console.ReadLine();
        }
    }
}
