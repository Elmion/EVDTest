﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GameTester
{   [Serializable]
    public class Card : ICloneable
    {
        public Access access; 
        public string Description;
        public string Header;
        public Guid ImageRef;
        public List<Effect> effects;

        public void Click()
        {
            for (int i = 0; i < effects.Count; i++)
            {
                effects[i].DoEffect();
            }
        }
        public object Clone()
        {
            Card OUT;
            BinaryFormatter serealizer = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                serealizer.Serialize(ms, this);
                ms.Position = 0;
                OUT = (Card)serealizer.Deserialize(ms);
            }
            return OUT;
        }
    }
}
