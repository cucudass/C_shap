using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program {
    public interface IItem {
        void Use();
    }
    public interface IWaitTime {
        void Wait(float timer);
    }

    public class Player {
        public void OnTriggerEnter(IItem item) {
            item.Use();
        }
    }
    public class GameObject {
        private int guID;

        public int GUID {
            set { guID = value; }
            get { return guID; }
        }

        public GameObject Clon() {
            // 1.class를 생성한다.
            GameObject clon = new GameObject();
            // 2.class 안에 있는 데이터를 넣어준다.
            clon.guID = GUID;
            // 3.class 를 반환한다.
            return clon;
        }

    }

    class Program {
        static void Main(string[] args) {
            #region 얕은 복사
            //GameObject gameObject1 = new GameObject();
            //GameObject gameObject2 = gameObject1.Clon();
            //gameObject2.GUID = 99;
            //Console.WriteLine("gameObject1의 GUID: " + gameObject1.GUID);
            //Console.WriteLine("gameObject2의 GUID: " + gameObject2.GUID);
            #endregion

            #region 깊은 복사
            //GameObject clon1 = new GameObject();
            //clon1.GUID = 1;
            //GameObject clon2 = clon1.Clon();
            //clon2.GUID = 3;
            //Console.WriteLine("clon1의 GUID: " + clon1.GUID);
            //Console.WriteLine("clon2의 GUID: " + clon2.GUID);
            #endregion

            #region 인터페이스
            /*
             인터페이스 참조 변수를 선언할 수 있지만, 인스턴스를 생성할 수 없다.
             */
            //Player player = new Player();
            //player.OnTriggerEnter(new Magnet());
            //player.OnTriggerEnter(new Shield());
            //player.OnTriggerEnter(new Missile());
            #endregion

            #region 추상클래스
            Juggling juggling = new Juggling();
            juggling.Information();
            juggling.Skill();
            #endregion

        }
    }
}
