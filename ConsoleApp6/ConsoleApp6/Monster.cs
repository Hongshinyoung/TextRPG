using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Monster : ICharacter
    {
        public string Name { get; }
        public float Health { get; set; }
        public float Attack { get; }
        public bool IsDead { get; }

        public void TakeDamage(int damage)
        {

        }
    }
}
