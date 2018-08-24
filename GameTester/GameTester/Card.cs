using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTester
{
    public class Card
    {
        public Access access; 
        public string Description;
        public string Header;
        public List<Effect> effects;

        public void Click()
        {
            for (int i = 0; i < effects.Count; i++)
            {
                effects[i].DoEffect();
            }
        }
    }
}
