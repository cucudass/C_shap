using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program {
    class SingleResponsibility {

    }
    #region 단일체계원칙
    /*
     * 하나의 객체는 반드시 하나의 동작만을 수행해야 한다.
     */
    public class Monster {
        private string name;
        private int attack;
        private int health;

        public Monster(string name, int attack, int health) {
            this.name = name;
            this.attack = attack;
            this.health = health;
        }

        public void Patrol() {
            Console.WriteLine("순찰 하는 중...");
        }

        //몬스터 정보를 보내주는 함수....
        public string Representation() {
            return $"name: {name}\nattack: {attack}\nhealth: {health}";
        }
        #endregion
    }
}
