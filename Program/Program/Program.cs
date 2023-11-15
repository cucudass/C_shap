using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program {
    class Program {
        static void Main(string[] args) {
            #region SRP 5대 원칙
            //Monster spider = new Monster("독거미", 20, 50);
            //Information info = new Information();

            //spider.Patrol();
            //info.MonsterInfo(spider);
            #endregion

            #region OCP 5대 원칙
            Marine marine = new Marine();
            Ghost ghost = new Ghost();
            UnitManager unitManager = new UnitManager();

            unitManager.Command(marine);
            unitManager.Command(new FireBet());
            unitManager.Command(ghost);
            #endregion
        }
    }
}
