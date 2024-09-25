namespace ConsoleApp6
{
    internal class GameManager
    {
        public string playerName;
        PlayerStatus playerStatus;
        Shop shop = new Shop();
        Inventory inventory = new Inventory();

        //이름 생성
        void CreateName()
        {
            Console.WriteLine("스파르타 던전에 오신 여러분 환영합니다.");
            Console.WriteLine("원하시는 이름을 설정해주세요.");
            playerName = Console.ReadLine();  // playerName을 static 변수에 저장
            playerStatus = new PlayerStatus($"{playerName}", 1, "전사", 10, 5, 100, 1500); //초기세팅
        }

        //게임 시작 화면
        void Start()
        {
            Console.Clear();
            Console.WriteLine($"입력하신 이름은 {playerName}입니다.");
            Console.WriteLine($"{playerName}님은 던전으로 들어가기전 활동을 할 수 있습니다.\n");
            Console.WriteLine("1. 상태 보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. 상점");
            Console.WriteLine("4. 던전입장\n");
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            int selectNum = int.Parse(Console.ReadLine());
            while (true)
            {
                if (selectNum >= 1 && selectNum <= 4)
                {
                    break;
                }
                Console.WriteLine("잘못된 입력입니다.");
                selectNum = int.Parse(Console.ReadLine());
            }

            switch (selectNum)
            {
                case 1:
                    Console.WriteLine("\n상태 보기");
                    Statas();
                    break;
                case 2:
                    Console.WriteLine("\n인벤토리");
                    Inventory();
                    break;
                case 3:
                    Console.WriteLine("\n상점");
                    Shop();
                    break;
                case 4:
                    Console.WriteLine("\n던전");
                    GoDungeon();
                    break;
            }

        }

        //상태보기
        void Statas()
        { //1h 9m강의듣는중
            //string extra = playerStatus.ExtraAd == 0 ? $"공격력: {playerStatus.ExtraAd}" : $"공격력: {playerStatus.AD}";

            Console.Clear();
            Console.WriteLine("캐릭터의 정보가 표시됩니다.\n");
            Console.WriteLine($"Lv. {playerStatus.Level} Chad {playerStatus.Job}");
            Console.WriteLine(playerStatus.ExtraAd == 0 ? $"공격력: {playerStatus.AD}" : $"공격력: {playerStatus.AD} (+{playerStatus.ExtraAd})");
            Console.WriteLine(playerStatus.ExtraDf == 0 ? $"방어력: {playerStatus.DF}" : $"방어력: {playerStatus.DF} (+{playerStatus.ExtraDf})");
            Console.WriteLine($"체 력: {playerStatus.Health}\nGold: {playerStatus.Gold}G\n\n0. 나가기\n");
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            int num = int.Parse(Console.ReadLine());

            while (true)
            {
                if (num == 0)
                {
                    Start();
                }
                Console.Write("나가시려면 숫자 0을 입력해주세요.");
                num = int.Parse(Console.ReadLine());


            }
        }

        //인벤토리
        void Inventory()
        {
            Console.Clear();
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.\n");
            Console.WriteLine("[보유 아이템 목록]");
            inventory.ShowItem();
            Console.WriteLine("\n\n1. 장착 관리\n0. 나가기\n\n 원하시는 행동을 입력해주세요.\n");
            int num = int.Parse(Console.ReadLine());
            while (true)
            {
                if (num == 0)
                {
                    Start();
                }
                else if (num == 1)
                {
                    equipmentmanagement();
                }
                Console.WriteLine("잘못된 입력입니다.");
                num = int.Parse(Console.ReadLine());
            }


        }

        //장착관리
        void equipmentmanagement()
        {
            Console.Clear();
            Console.WriteLine("\n인벤토리 - 장착관리\n보유 중인 아이템을 관리할 수 있습니다.\n");
            Console.WriteLine("[아이템 목록]\n");
            inventory.SelectShowItem();
            Console.WriteLine("\n0. 나가기\n\n원하시는 행동을 입력해주세요.");
            while (true)
            {
                int num = int.Parse(Console.ReadLine());
                if (num == 0)
                {
                    Start();
                }
                else if (num >= 1 && num <= inventory.inventoryIndex)
                {
                    inventory.EquipItem(num - 1); //배열은 0부터 니까 -1
                    inventory.ShowItem();
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                    num = int.Parse(Console.ReadLine());
                }

            }
        }
        //상점
        void Shop()
        {
            Console.Clear();
            Console.WriteLine($"\n\n필요한 아이템을 얻을 수 있는 상점입니다.\n[보유 골드]{playerStatus.Gold}G\n");
            Console.WriteLine("[아이템 목록]");
            shop.ShowShopItem();
            Console.WriteLine("\n\n1.아이템 구매\n0.나가기\n\n원하시는 행동을 입력해주세요.");
            int num = int.Parse(Console.ReadLine());
            while (true)
            {
                if (num == 0)
                {
                    Start();
                }
                else if (num == 1)
                {
                    ItemPhase();
                }
                Console.WriteLine("잘못된 입력입니다.");
                num = int.Parse(Console.ReadLine());
            }
        }

        //아이템 구매
        void ItemPhase()
        {
            Console.Clear();
            Console.WriteLine("\n\n상점 - 아이템 구매\n필요한 아이템을 얻을 수 있는 상점입니다.");
            Console.WriteLine($"[보유골드]\n{playerStatus.Gold}G\n\n[아이템 목록]");
            shop.PurchaseShopItemList(); //숫자 표기

            Console.WriteLine("0. 나가기\n원하시는 행동을 입력해주세요.");
            string input = Console.ReadLine();
            int num;

            while (!int.TryParse(input, out num) || (num != 0 && (num < 1 || num > shop.shopItemsCount)))
            {
                Console.WriteLine("잘못된 입력입니다.");
                input = Console.ReadLine();
            }
            while (true)
            {
                if (num == 0)
                {
                    Start();
                }
                else if (num >= 1 && num <= shop.shopItemsCount)
                {
                    shop.PurchaseItem(num, playerStatus, inventory);
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                    input = Console.ReadLine();
                }
                Console.WriteLine("\n\n1. 다른 아이템 구매\n0. 나가기");
                input = Console.ReadLine();
                if (num == 1)
                {
                    ItemPhase();
                }

            }

        }

        //던전입장
        public void GoDungeon()
        {
            Dungeon dungeon = new Dungeon();
            Console.Clear();
            Console.WriteLine("던전입장\n이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.\n");
            Console.WriteLine("1. 쉬운 던전     | 방어력 5 이상 권장");
            Console.WriteLine("2. 일반 던전     | 방어력 11 이상 권장");
            Console.WriteLine("3. 어려운 던전    | 방어력 17 이상 권장\n0. 나가기\n\n원하시는 행동을 입력해주세요.\n");

            while (true)
            {
                int num = int.Parse(Console.ReadLine());

                if (num >= 1 && num <= 3)
                {
                    dungeon.SelectDungeon(num);
                    break;
                }
                else if (num == 0)
                {
                    Start();
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                    num = int.Parse(Console.ReadLine());
                }
            }
        }

        //메인함수
        static void Main(string[] args)
        {
            GameManager gameManager = new GameManager();

            gameManager.CreateName();
            gameManager.Start();


        }
    }
}
