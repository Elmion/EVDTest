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
        public void EnumTest(TestEnum testEnu, int trala)
        {
            Console.WriteLine(testEnu.ToString());
        }
    }
    public enum TestEnum
    {
        First,
        Second,
        Three
    }

}