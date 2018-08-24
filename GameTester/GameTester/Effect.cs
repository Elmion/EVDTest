using System;
using System.Collections.Generic;
using System.Collections;
using System.Reflection;
using System.Xml;
namespace GameTester
{
    public class Effect
    {
        Delegate effectMethod;
        List<object> Params;

        public Effect(string Name, List<object> Params)
        {
            this.effectMethod = Delegate.CreateDelegate(typeof(Action<List<object>>), this, typeof(Effect).GetMethod(Name));
            this.Params = Params;
        }
        public void DoEffect()
        {
            effectMethod.DynamicInvoke(Params);
        }
        public void Effect1(List<object> input)
        {
            Console.WriteLine(input[0]);
        }
        public void Effect2(List<object> input)
        {
            Console.WriteLine(input[1] + " " + input[0]);
        }
        /// <summary>
        /// Изменяет именованый ресурс на значение . Если его нет то предварительно, он будет создан с нулевым значением
        /// </summary>
        /// <param name="input"> Сначала имя ресурса, потом значние со знаком</param>
        public void ChangeResurce(List<object> input)
        {
            string NameResurce = (string)input[0];
            int ChangingValue =int.Parse((string)input[1]);

            int index = HeroTemp.Resurces.FindIndex(x => x.Name == NameResurce);
            if(index == -1)
            {
                HeroTemp.Resurces.Add(new Resurce { Name = NameResurce, Value = 0 });
                index = HeroTemp.Resurces.Count - 1;
            }
            HeroTemp.Resurces[index].Value += ChangingValue;

        }
    }
}