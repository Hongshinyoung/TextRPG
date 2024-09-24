using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal interface ICharacter
    {
        string Name { get; }
        float Health { get; set; }
        float Attack { get; }
        bool IsDead { get; }

        void TakeDamage(int damage);
    }
}
