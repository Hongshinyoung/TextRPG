using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Stage : Warrior
    {
        //- 이 클래스는 플레이어와 몬스터, 그리고 보상 아이템들을 멤버 변수로 가지며, `Start`라는 메서드를 통해 스테이지를 시작하게 됩니다.
        Warrior warrior = new Warrior();
        Monster monster = new Monster();
        void Start()
        {
            Console.WriteLine("스테이지가 시작됩니다!");
        }

        //- 스테이지가 시작되면, 플레이어와 몬스터가 교대로 턴을 진행합니다.
        //- 플레이어나 몬스터 중 하나가 죽으면 스테이지가 종료되고, 그 결과를 출력해줍니다.
        void EndStage()
        {

        }
        //- 스테이지가 끝날 때, 플레이어가 살아있다면 보상 아이템 중 하나를 선택하여 사용할 수 있습니다.
    }
}
