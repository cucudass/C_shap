using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program {
    #region 의존관계 역전 원칙
    /*
     * 상위 계층이 하위 계층에 의존하는 전통적인 관계를 반전시킴으로써,
     * 상위 계층이 하위 계층의 구현으로부터 독립될 수 있도록 설계하는 원칙
     */
    public abstract class Weapon {
        protected int attack = 0;
        protected int durability = 0;

        public int Attack => attack;
        public int Durability => durability;

        public Weapon(int attack, int durability) {
            this.attack = attack;
            this.durability = durability;
        }

        public abstract void Information();
        public abstract void Action();
    }

    public class Rifle : Weapon {
        public Rifle() : base(20, 50) { }

        public override void Action() {
            Console.WriteLine("Rifle Action");
        }
        public override void Information() {
            Console.WriteLine("Rifle Attack: " + Attack + ", 내구도: " + Durability);
        }
    }
    public class Axe : Weapon {
        public Axe() : base(10, 30) { }

        public override void Action() {
            Console.WriteLine("Axe Action");
        }
        public override void Information() {
            Console.WriteLine("Axe Attack: " + Attack + ", 내구도: " + Durability);
        }
    }
    public class Knife : Weapon {
        public Knife() : base(5, 15) { }

        public override void Action() {
            Console.WriteLine("Knife Action");
        }
        public override void Information() {
            Console.WriteLine("Knife Attack: " + Attack + ", 내구도: " + Durability);
        }
    }

    public class Player {
        private Weapon weapon = null;
        private int health;

        public Player() {
        }

        public Player(int health, Weapon weapon) {
            this.health = health;
            this.weapon = weapon;
        }

        public void ChangeWeapon(Weapon weapon) {
            this.weapon = weapon;
        }
        public void Info() {
            weapon.Information();
        }
        public void Action() {
            weapon.Action();
        }
    }

    #endregion
}
