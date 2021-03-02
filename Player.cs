using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Player
    {
        public int Attack { get; set; } = 2;
        public int Health { get; set; } = 9;

        public int GetAttack() 
        {
            return Attack;
        }

        public int GetHealth() 
        {
            return Health;
        }
    }
}
