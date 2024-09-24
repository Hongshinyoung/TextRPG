using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class PlayerStatus
    {
        public int Level { get; set; }
        public string Job {  get; set; }
        public int AD {  get; set; }
        public int DF {  get; set; }
        public int Health { get; set; }
        public int Gold { get; set; }

        public PlayerStatus(int level, string job, int ad, int df, int health, int gold) 
        { 
            Level = level;
            Job = job;
            AD = ad;
            DF = df;
            Health = health;
            Gold = gold;
        }
        public PlayerStatus() 
        {

        }

    }
}
