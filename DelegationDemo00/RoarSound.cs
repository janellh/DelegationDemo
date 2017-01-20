//upload
//second
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegationDemo00
{
    class RoarSound : ISoundBehaviour 
    {
        public void makeSound()
        {
            Console.WriteLine("Roar");
        }
    }
}
