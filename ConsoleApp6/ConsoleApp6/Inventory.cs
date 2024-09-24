using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Inventory
    {
        private List<Item> myItems = new List<Item>();
        public int inventoryIndex = 0;

        // 인벤토리에 아이템 추가
        public void AddItem(Item item)
        {
            myItems.Add(item);
        }

        //보유 아이템 보여주기
        public void ShowItem()
        {
            inventoryIndex = myItems.Count;
            if (myItems.Count < 1)
            {
                Console.WriteLine("보유중인 아이템이 없습니다.");
            }
            else
            {
                for(int i = 0; i < myItems.Count; i++)
                {
                    string equippedStatus = myItems[i].IsEquipped ? "[E]" : ""; //아이템이 장착되어있으면 E 아니면 공백
                    Console.WriteLine($"- {equippedStatus}{myItems[i].Name} | 공격력+{myItems[i].Ad} | 방어력+{myItems[i].Df} | {myItems[i].Describe}");
                }
            }
        }

        //보유 아이템 선택할 수 있게 숫자 보여주기 / 구매파트에서 사용
        public void SelectShowItem()
        {
            for (int i = 0; i < myItems.Count; i++)
            {
                Console.WriteLine($"- {i+1} {myItems[i].Name} | 공격력+{myItems[i].Ad} | 방어력+{myItems[i].Df} | {myItems[i].Describe}");
            }
        }

        //아이템 장착하기
        public void EquipItem(int itemIndex)
        {
            foreach(var item in myItems)
            {
                if(item.IsEquipped) //아이템이 장착되있으면 해제
                {
                    item.IsEquipped = false;
                    Console.WriteLine("아이템 장착이 해제되었습니다.");
                }
                else
                {
                    myItems[itemIndex].IsEquipped = true; //안되있으면 장착
                    Console.WriteLine("아이템 장착 되었습니다.");
                }
            }            
        }

    }
}
