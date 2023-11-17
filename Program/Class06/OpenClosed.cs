using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program {
    #region 개방 폐쇄 원칙
    /*
     객체의 확장은 열려있어야 하며, 객체의 수정에는 닫혀이어야 한다.
     */
    public abstract class Unit {
        protected int health;
        protected int defense;

        public Unit() {

        }

        public abstract void Move();

        public void Command(Unit unit) {
            unit.Move();
        }
    }

    public class Marine : Unit {
        public Marine() {

        }

        public override void Move() {
            Console.WriteLine("Marine Move");
        }
    }

    public class FireBet : Unit {
        public FireBet() {

        }

        public override void Move() {
            Console.WriteLine("FireBet Move");
        }
    }

    public class Ghost : Unit {
        public override void Move() {
            Console.WriteLine("Ghost Move");
        }
    }

    public class UnitManager {
        public void Command(Unit unit) {
            unit.Move();
        }
    }
    #endregion
}
