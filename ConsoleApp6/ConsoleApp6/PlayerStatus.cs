using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class PlayerStatus
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string Job {  get; set; }
        public int AD {  get; set; }
        public int DF {  get; set; }
        public int Health { get; set; }
        public int Gold { get; set; }
        public bool isDead => Health <= 0;
        public int ExtraAd {  get; set; }
        public int ExtraDf { get; set; }

        public PlayerStatus(string name, int level, string job, int ad, int df, int health, int gold) 
        { 
            Name = name;
            Level = level;
            Job = job;
            AD = ad;
            DF = df;
            Health = health;
            Gold = gold;
        }

        public int Attack => new Random().Next(AD -5, AD +5);

        public void TakeDamage(int damage)
        {
            //실제 데미지 = 데미지 - 방어력/ 방어력이 높으면 0
            int actualDamage = damage - DF > 0 ? damage - DF : 0;
            Health -= actualDamage;
            Console.WriteLine($"{Name}(이)가 {actualDamage}의 데미지를 입었습니다.\n남은체력: {Health}");

            if(isDead)
            {
                Console.WriteLine($"{Name}(이)가 사망했습니다.");
            }
        }

    }
}
