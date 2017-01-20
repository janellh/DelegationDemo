using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegationDemo00
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat();
            // Delegation
            c.makeSound();          // Output: Meow
            // now to change the sound it makes
            ISoundBehaviour newsound = new RoarSound();
            ISoundBehaviour sound = new MeowSound();
            c.setSoundBehaviour(newsound);
            // Delegation           
            c.makeSound();          // Output: Roar!

            Console.ReadKey();
        }
    }
}
