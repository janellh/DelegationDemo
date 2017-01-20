using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegationDemo00
{
    class MeowSound : ISoundBehaviour 
    {
        public void makeSound() 
        {
                Console.WriteLine("Meow");
        }
    }
}
