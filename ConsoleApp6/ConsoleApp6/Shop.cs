namespace ConsoleApp6
{
    internal class Shop
    {
        private List<Item> shopItems;
        public int shopItemsCount = 0;

        //상점 아이템 리스트
        public Shop()
        {
            shopItems = new List<Item>
            {
                new Item("수련자 갑옷",0,5,"수련에 도움을 주는 갑옷입니다.",1000),
                new Item("무쇠갑옷",0,9,"무쇠로 만들어져 튼튼한 갑옷입니다.",1500),
                new Item("스파르타의 갑옷",0,15,"스파르타의 전사들이 사용했다는 전설의 갑옷입니다.",3500),
                new Item("낡은 검",2,0,"쉽게 볼 수 있는 낡은 검 입니다.",600),
                new Item("청동 도끼",5,0,"어디선가 사용됐던거 같은 도끼입니다.",1500),
                new Item("스파르타의 창",7,0,"스파르타의 전사들이 사용했다는 전설의 창입니다.",4500)

            };
        }

        //상점 아이템 보여주기
        public void ShowShopItem()
        {

            for (int i = 0; i < shopItems.Count; i++)
            {
                string isBought = shopItems[i].AlreadyHave ? "[구매완료]" : $"{shopItems[i].Gold}G";
                Console.WriteLine($"- {shopItems[i].Name} | 공격력+{shopItems[i].Ad} |" +
                    $"방어력+{shopItems[i].Df} | {shopItems[i].Describe} | {isBought}");
            }

        }

        //상점 아이템 선택할 수 있게 숫자 보여주기
        public void PurchaseShopItemList()
        {
            shopItemsCount = shopItems.Count;
            for (int i = 0; i < shopItems.Count; i++)
            {
                string isBought = shopItems[i].AlreadyHave ? "[구매완료]" : $"{shopItems[i].Gold}G";
                Console.WriteLine($"-{i + 1} {shopItems[i].Name} | 공격력+{shopItems[i].Ad} |" +
                    $"방어력+{shopItems[i].Df} | {shopItems[i].Describe} | {isBought}");
            }
        }

        //구매로직, 입력한 번호에 맞는 아이템 리스트 인벤토리에 추가, 골드계산
        public void PurchaseItem(int itemIndex, PlayerStatus playerStatus, Inventory inventory)
        {

            //if(itemIndex < 0 || itemIndex >= shopItems.Count)
            //{
            //    Console.WriteLine("잘못된 입력입니다.");
            //    return;
            //}

            Item selectedItem = shopItems[itemIndex - 1]; //입력숫자는 1부터 상점리스트는 0부터

            if (playerStatus.Gold >= selectedItem.Gold)
            {
                inventory.AddItem(selectedItem);
                selectedItem.AlreadyHave = true;
                playerStatus.Gold -= selectedItem.Gold;
                Console.WriteLine($"골드가 {playerStatus.Gold}G 남았습니다.");
            }
            else
            {
                Console.WriteLine("골드가 부족합니다.");
            }
        }
    }
}
