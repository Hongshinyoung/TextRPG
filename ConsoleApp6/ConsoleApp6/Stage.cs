using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Stage : Warrior
    {
        private PlayerStatus player;
        private ICharacter monster;


        public Stage(PlayerStatus player, ICharacter monster)
        {
            this.player = player;
            this.monster = monster;
        }

        public void StartBattle()
        {
            while(!player.isDead && !monster.IsDead)
            {
                
            }
        }

    }
}
