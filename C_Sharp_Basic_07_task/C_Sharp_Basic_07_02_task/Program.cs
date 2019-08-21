using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsConsole
{
    abstract class Animal
    {
        protected string name;
        public Animal(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
    }
    class Predator : Animal
    {
        public bool eatsOnlyPlants;
        public Predator(string name) : base(name)
        {
        }
        public Predator() : base("Predator")
        {
            eatsOnlyPlants = false;
        }
    }
    class Herbivore : Animal
    {
        protected bool eatsOnlyPlants;
        public Herbivore(string name) : base(name)
        {
        }
        public Herbivore() : base("Herbivore")
        {
            eatsOnlyPlants = true;
        }
    }
    class Wolf : Predator
    {
        public Wolf() : base("Wolf")
        {
        }
    }
    class Fox : Predator
    {
        public Fox() : base("Fox")
        {
        }
    }
    class Hare : Herbivore
    {
        public Hare() : base("Hare")
        {
        }
    }
    class Deer : Herbivore
    {
        public Deer() : base("Deer")
        {
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int predator = 0, herbivore = 0, wolf = 0, fox = 0, hare = 0, deer = 0;
            Animal[] animals = new Animal[6];
            animals[0] = new Predator();
            animals[1] = new Hare();
            animals[2] = new Deer();
            animals[3] = new Fox();
            animals[4] = new Herbivore();
            animals[5] = new Wolf();
            foreach (Animal animal in animals)
            {
                if (animal is Predator)
                {
                    predator++;
                }
                if (animal is Herbivore)
                {
                    herbivore++;
                }
                if (animal is Wolf)
                {
                    wolf++;
                }
                if (animal is Fox)
                {
                    fox++;
                }
                if (animal is Hare)
                {
                    hare++;
                }
                if (animal is Deer)
                {
                    deer++;
                }
            }
            // results: predator, herbivore, wolf, fox, hare, deer
        }
    }
}
