using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTester.Hero
{
    interface IConnectEngine
    {
        bool Have(string Name);
        int  Count(string Name);
        bool Use(string Name, int Count);
        void Add(string Name, int Count);
        bool Remove(string Name, int Count);
    }
    interface ISaveLoad
    {
        bool Save();
        bool Load();
    }
}
