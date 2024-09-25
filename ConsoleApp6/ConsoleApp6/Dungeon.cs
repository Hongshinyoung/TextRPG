namespace ConsoleApp6
{
    internal class Dungeon
    {
        public int dungeonIndex = 0; //스테이지 1,2,3
        public int dungeonModeIndex = 0; //이지,노말,하드
        Stage stage;
        GameManager manager;
        Monster monster;

        public void SelectDungeon(int select)
        {
            switch(select)
            {
                case 1:
                    EasyDungeon();
                    break;
                case 2:
                    NormalDungeon();
                    break;
                case 3:
                    HardDungeon();
                    break;
            }
            

        }

        //스테이지 배경 만들기
        //public void ShowDungeon()
        //{
        //    for (int i = 0; i< 60; i++)
        //    {
        //        Console.SetCursorPosition(i, 4);
        //        Console.Write("■");
        //        Console.SetCursorPosition(i, 24);
        //        Console.Write("■");
        //    }

        //    for(int j = 4; j< 24; j++)
        //    {
        //        Console.SetCursorPosition(0, j);
        //        Console.Write("■");
        //        Console.SetCursorPosition(60, j);
        //        Console.Write("■");
        //    }
        //}

        public void EasyDungeon()
        {
            monster = new Goblin("Goblin");
            Console.Clear();
            Console.WriteLine($"쉬운 던전에 입장하였습니다.\n쉬움 던전 - 스테이지1\n");
            Console.WriteLine($"{monster.Name} 몬스터가 등장하였습니다.");
            Console.WriteLine("{monster.Name}과 전투를 시작합니다.\n1.  공격\n2. 방어\n3. 도망\n");

            while(true)
            {
                int num = int.Parse( Console.ReadLine());
                switch(num)
                {
                    case 1:
                        Console.WriteLine($"공격하여 데미지를 주었습니다.");
                        break;
                    case 2:
                        Console.WriteLine("방어력이 증가하여 {}데미지를 {}막고 {}를 피해입었습니다.");
                        break;
                    case 3:
                        Console.WriteLine("도망갑니다..");
                        return;
                }
            }

        }

        public void NormalDungeon()
        {
            Console.Clear();
            Console.WriteLine($"노말 던전에 입장하였습니다.\n쉬움 던전 - 스테이지1\n\n");
            //ShowDungeon();
        }

        public void HardDungeon()
        {
            Console.Clear();
            Console.WriteLine($"하드 던전에 입장하였습니다.\n쉬움 던전 - 스테이지1\n\n");
            //ShowDungeon();
        }

    }
}
