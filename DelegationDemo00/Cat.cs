using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegationDemo00
{
    class Cat
    {
        private ISoundBehaviour sound = new MeowSound();

        public void makeSound()
        {
            this.sound.makeSound();
        }

        public void setSoundBehaviour(ISoundBehaviour newsound)
        {
            this.sound = newsound;
        }  
    }
}
