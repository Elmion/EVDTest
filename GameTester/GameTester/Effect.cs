using System;
using System.Collections.Generic;
using System.Collections;
using System.Reflection;
using System.Xml;
namespace GameTester
{
    [Serializable]
    public class Effect
    {
        public static Effect Instance = new Effect();

        public void Effect1(List<object> input)
        {
            Console.WriteLine(input[0]);
        }
        public void Effect2(string s1, int dsd, int dasd)
        {
        }
        /// <summary>
        /// Изменяет именованый ресурс на значение . Если его нет то предварительно, он будет создан с нулевым значением
        /// </summary>
        /// <param name="input"> Сначала имя ресурса, потом значние со знаком</param>
        public void ChangeResurce(string NameResurce, int ChangingValue)
        {
            int index = HeroTemp.Resurces.FindIndex(x => x.Name == NameResurce);
            if(index == -1)
            {
                HeroTemp.Resurces.Add(new Resurce { Name = NameResurce, Value = 0 });
                index = HeroTemp.Resurces.Count - 1;
            }
            HeroTemp.Resurces[index].Value += ChangingValue;

        }
    }
    public class ParametredAction
    {
        Type ActionType;
        public MethodInfo link;
        public List<object> Params;
        public string Name
        {
            get
            {
                return link.Name;
            }
        }
        public  ParametredAction(MethodInfo link, object[] Params,Type ActionType)
        {
            this.link = link;
            this.Params = new List<object>(Params);
            this.ActionType = ActionType;
        }
        public void Run(object target)
        {
            ParameterInfo[] info = link.GetParameters();
            ArrayList ReadyParams = new ArrayList();
            for (int i = 0; i < info.Length; i++)
            {
                 ReadyParams.Add(Convert.ChangeType(Params[i], info[i].ParameterType));
            }
            link.Invoke(target,ReadyParams.ToArray());
        }
    }
}