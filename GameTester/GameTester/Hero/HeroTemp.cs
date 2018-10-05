using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTester
{
    public class HeroTemp
    {
        public static readonly HeroTemp Instance = new HeroTemp();

        public List<Resurce> Resurces = new List<Resurce>();
        public List<InvetoryItem> Inventory = new List<InvetoryItem>();
        public List<Understanding> Сompetence = new List<Understanding>();

        public HeroTemp()
        {
            Resurces.Add(new Resurce { Name = GameTester.Resurces.Health, Value = 100 });
            Resurces.Add(new Resurce { Name = GameTester.Resurces.Money, Value = 0 });
        }
        public HeroTemp(int move)
        {
            Resurces.Add(new Resurce { Name = GameTester.Resurces.Health, Value = 100 });
            Resurces.Add(new Resurce { Name = GameTester.Resurces.Money, Value = 0 });
        }
    }
    public class Understanding
    {
        public Science Name;
        public int Value;
    }
    public class Resurce
    {
        public Resurces Name;
        public int Value;
    }
    public class InvetoryItem
    {
        public string Name;
        public Type t;
        public object Value;
    }
    public enum Resurces
    {
        Money,
        Health
    }
    public enum Science
    {
       Common,

    }
}
