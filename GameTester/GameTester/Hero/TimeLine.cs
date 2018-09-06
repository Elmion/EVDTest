using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTester
{
    class TimeLine
    {
        
        public int Days = 1;
        public int NewBornAge
        {
            get
            {
                return (int)Math.Ceiling(19f * (1 - Math.Exp(-game_move / 400f))) - 1;
            }
        }
        public void Tik()
        {

        }
    }
    class Era
    {

    }
}
