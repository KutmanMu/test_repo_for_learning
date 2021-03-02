using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Enemy
    {
        public int Attack { get; set; } = 3;
        public int Health { get; set; } = 10;

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
