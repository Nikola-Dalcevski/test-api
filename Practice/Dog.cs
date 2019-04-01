using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }
        public Chip DogChip { get; set; }

        public void AddChip(Chip chip)
        {
            DogChip = chip;
        }

        public static void IdentifyDog(Dog dog)
        {
             Console.WriteLine($"The dog {dog.Name} is {dog.Age} years old and its {dog.Color} color");
            if (dog.DogChip != null) Console.WriteLine($"The dog {dog.Name} is owned by {dog.DogChip.Owner} on the {dog.DogChip.Address} whit id: {dog.DogChip.ID}");
        }
           
                                                 


                           

        public class Chip
        {
            public int ID { get; set; }
            public string Owner { get; set; }
            public string Address { get; set; }

            public Chip(string owner, string adress)
            {
                Owner = owner;
                Address = adress;
                Random rd = new Random();
                ID = rd.Next(1000, 9999);
                
            }
        }
    }
}
