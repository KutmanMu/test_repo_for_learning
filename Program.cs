using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Player player = new Player();
            Enemy enemy = new Enemy();

            Console.WriteLine("Player : The value of Attack : {0}" , player.GetAttack());
            Console.WriteLine("Enemy : The value of Attack : {0}" , enemy.GetAttack());

            Console.ReadKey();


        }

    }
}
