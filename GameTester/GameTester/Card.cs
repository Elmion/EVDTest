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
        public Guid uid;
        public string Description;
        public string Header { get; set; }
        public Guid ImageRef;
        public List<ParametredAction> effects;
        public List<ParametredAction> accesses;
        public void Click()
        {
            for (int i = 0; i < effects.Count; i++)
            {
                effects[i].Run(Effect.Instance);
            }
        }
        public bool Check()
        {
            bool OUT = true;
            if (accesses.Count == 0) OUT = false; //если доступов нет то такая карта не играется.????
            for (int i = 0; i < accesses.Count; i++)
            {
               OUT = OUT && (bool)accesses[i].RunAsFunc(Access.Instance);
            }
            return OUT;
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
