using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_03 {
    #region 메소드 숨기기
    public class Weapon {
        protected int attack = 0;

        public void Infomation() {
            Console.WriteLine("Weapon 정보");
        }

        public virtual void Action() {
            Console.WriteLine("Weapon의 동작");
        }

    }

    public class Sword : Weapon {
        public new void Infomation() {
            Console.WriteLine("Sword 정보");
        }

        public override void Action() {
            Console.WriteLine("Sword의 동작");
        }
    }
    #endregion

    #region 프로퍼티
    public class Transform {
        private int x;
        private int y;
        private int z;

        public int X {
            set {
                if (value >= 100) {
                    Console.WriteLine("예기치 못한 값이 들어왔습니다.");
                    return;
                } else
                    x = value;
            }
            get { return x; }
        }
    }
    #endregion

    #region 함수의 오버로딩
    public class Gameobject {
        public void Destroy() {
            Console.WriteLine("Destroy GameObject");
        }
        public void Destroy(float timer) {
            Console.WriteLine("Destroy GameObject Destroy Tiem : " + timer);
        }

        public void GetComponent(string name, int id) {
            Console.WriteLine($"name : {name}\nid : {id}");
        }
        public void SetActive(bool active = true) {
            Console.WriteLine("GameObject state: " + active);
        }
    }
    #endregion
    class Program {
        static void Main(string[] args) {
            #region 프로퍼티
            /*
            Transform transform = new Transform();
            transform.X = 100;
            Console.WriteLine(transform.X);
            */
            #endregion

            #region 메소드 숨기기
            //Sword sword = new Sword();
            //sword.Infomation();
            //sword.Action();
            #endregion

            #region 가상함수
            /*
            Weapon weapon = new Sword();
            weapon.Infomation();
            weapon.Action();
            */
            #endregion

            #region 함수오버로딩
            /*
            Gameobject gameObject = new Gameobject();
            gameObject.Destroy();
            gameObject.Destroy(5f);
            //명명된 매개변수
            gameObject.GetComponent(id: 5, name: "Sphere");
            gameObject.GetComponent("Box", 10);
            //선택적 매개변수
            gameObject.SetActive();
            gameObject.SetActive(false);
            */
            #endregion

        }
    }
}
