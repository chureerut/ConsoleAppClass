using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClass.Model
{
    interface IAnimal
    {
        void animalSound();
    }
    // Pig "implements" the IAnimal interface
    class Pig3 : IAnimal
    {
        public void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }
}
