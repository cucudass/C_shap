using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program {
    #region 리스코프 치환 원칙
    /*
     * 상위 클래스와 하위 클래스가 있을 때 상위 클래스가 호출하는 동작에서 하위 클래스가
     * 상위 클래스를 완변하게 대체할 수 있어야 하는 원칙
     */
    #endregion
    public abstract class Zerg {
        protected int attack = 0;
        protected int defence = 0;

        public Zerg(int attack, int defence) {
            this.attack = attack;
            this.defence = defence;
        }

        public abstract void Move();
    }

    public abstract class GroundUnit : Zerg {
        public GroundUnit(int attack, int defence) : base(attack, defence) { }

        public void Ground() {
            Console.WriteLine("on the Ground");
        }

        public override void Move() {
            Console.WriteLine("GroundUnit Move");
        }
    }

    public abstract class FlyUnit : Zerg {
        public FlyUnit(int attack, int defence) : base(attack, defence) { }

        public void Fly() {
            Console.WriteLine("on the Fly");
        }

        public override void Move() {
            Console.WriteLine("FlyUnit Move");
        }
    }

    public class Dron : GroundUnit {
        public Dron() : base(1, 10) { }

        public override void Move() {
            Console.WriteLine("Dron is Walk...");
        }
    }

    public class Mutalisk : FlyUnit {
        public Mutalisk() : base(9, 1) { }

        public override void Move() {
            Console.WriteLine("Mutalisk is fly...");
        }
    }


}
