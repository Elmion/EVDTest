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
        public int game_move = 1;
        public int Age
        {
            get
            {

                return (int)Math.Ceiling(19f * (1 - Math.Exp(-game_move/400f)))-1;
            }
        }
        public List<Resurce> Resurces = new List<Resurce>();
        public List<InvetoryItem> Inventory = new List<InvetoryItem>();

        public HeroTemp()
        {
            game_move = 1;
            Resurces.Add(new Resurce { Name = GameTester.Resurces.Health, Value = 100 });
            Resurces.Add(new Resurce { Name = GameTester.Resurces.Money, Value = 0 });
        }
        public HeroTemp(int move)
        {
            game_move = move;
            Resurces.Add(new Resurce { Name = GameTester.Resurces.Health, Value = 100 });
            Resurces.Add(new Resurce { Name = GameTester.Resurces.Money, Value = 0 });
        }
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
        Health,
        Time
    }
}
