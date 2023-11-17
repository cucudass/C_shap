using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Program;
namespace Class_06 {
    class Program {
        static void Main(string[] args) {
            #region SRP 5대 원칙
            //Monster spider = new Monster("독거미", 20, 50);
            //Information info = new Information();

            //spider.Patrol();
            //info.MonsterInfo(spider);
            #endregion

            #region OCP 5대 원칙
            //Marine marine = new Marine();
            //Ghost ghost = new Ghost();
            //UnitManager unitManager = new UnitManager();

            //unitManager.Command(marine);
            //unitManager.Command(new FireBet());
            //unitManager.Command(ghost);
            #endregion

            #region ISP 5대 원칙
            //Wraith wraith = new Wraith();
            //Battlecruiser battlecruiser = new Battlecruiser();
            //Valkyrie valkyrie = new Valkyrie();
            //Dropship dropship = new Dropship();
            //wraith.Move();
            //wraith.Attack();
            //wraith.Skill();
            //battlecruiser.Skill();
            //valkyrie.Attack();
            //dropship.Skill();
            #endregion

            #region DIP 5대 원칙
            //Knife knife = new Knife();
            //Player player = new Player();
            //player.ChangeWeapon(knife);
            //player.Info();
            #endregion

            #region LSP 5대 원칙
            //Dron dron = new Dron();
            //dron.Ground();
            //dron.Move();
            #endregion
        }
    }
}
