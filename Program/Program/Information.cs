using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program {
    class Information {
        public Information() { }

        public void MonsterInfo(Monster monster) {
            Console.WriteLine(monster.Representation());
        }
    }

}
