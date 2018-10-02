using System;
using System.Collections.Generic;
using System.Collections;
using System.Reflection;
using System.Xml;
using GraphEditor;
namespace GameTester
{
    [Serializable]
    public class Effect
    {
        public static Effect Instance = new Effect();

        public void ToConsole(string Text)
        {
            Console.WriteLine(Text);
        }
        [ParametersExternalNames("Минуты")]
        public void ChangeTime(int Minutes)
        {
            HeroTemp.Instance.time.AddTime(Minutes);
        }
        /// <summary>
        /// Изменяет именованый ресурс на значение . Если его нет то предварительно, он будет создан с нулевым значением
        /// </summary>
        /// <param name="input"> Сначала имя ресурса, потом значние со знаком</param>
        [ParametersExternalNames("Название ресурса","Изменить на")]
        public void ChangeResurce(Resurces NameResurce, int ChangingValue)
        {
            int index = HeroTemp.Instance.Resurces.FindIndex(x => x.Name == NameResurce);
            if(index == -1)
            {
                HeroTemp.Instance.Resurces.Add(new Resurce { Name = NameResurce, Value = 0 });
                index = HeroTemp.Instance.Resurces.Count - 1;
            }
            HeroTemp.Instance.Resurces[index].Value += ChangingValue;
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