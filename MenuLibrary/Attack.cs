using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuLibrary
{
    public class Attack
    {
        public static int Attacking()
        {
            int health = 100, randHit;
            Random random = new Random();
            randHit = random.Next(1, 21);



            return health -= randHit;
        }
    }
}
