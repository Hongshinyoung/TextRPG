using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Item
    {

        public string Name {  get; set; }
        public int Ad {  get; set; }
        public int Df { get; set; }
        public string Describe { get; set; }
        public int Gold { get; set; }
        public bool IsEquipped {  get; set; }
        public bool AlreadyHave {  get; set; }
        public Item(string name, int ad, int df, string describe, int gold)
        {
            Name = name;
            Ad = ad;
            Df = df;
            Describe = describe;
            Gold = gold;
            IsEquipped = false;
            AlreadyHave = false;
        }

    }
}
