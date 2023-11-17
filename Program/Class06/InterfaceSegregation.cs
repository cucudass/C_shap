using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program {
    #region 인터페이스 분리원칙
    /*
     * 클라이언트가 자신이 사용하지 않는 함수에 의존하지 않아여 하며,
     * 인터페이스가 구체적이고 작은 다위로 분리하여 사용하는 원칙
     */
    #endregion

    public interface IMovealbe {
        void Move();
    }
    public interface IAttackable {
        void Attack();
    }
    public interface ISkillable {
        void Skill();
    }

    class Wraith : IMovealbe, IAttackable, ISkillable {
        public void Attack() {
            Console.WriteLine("Wraith Attack");
        }

        public void Move() {
            Console.WriteLine("Wraith Attack");
        }

        public void Skill() {
            Console.WriteLine("Wraith Skill");
        }
    }

    class Battlecruiser : IMovealbe, IAttackable, ISkillable {
        public void Attack() {
            Console.WriteLine("Battlecruiser Attack");
        }

        public void Move() {
            Console.WriteLine("Battlecruiser Move");
        }

        public void Skill() {
            Console.WriteLine("Battlecruiser Skill");
        }
    }

    class Valkyrie : IMovealbe, IAttackable {
        public void Attack() {
            Console.WriteLine("Valkyrie Attack");
        }

        public void Move() {
            Console.WriteLine("Valkyrie Move");
        }
    }

    class Dropship : IMovealbe, ISkillable {
        public void Move() {
            Console.WriteLine("Dropship Move");
        }

        public void Skill() {
            Console.WriteLine("Dropship Skill");
        }
    }
}
