using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphEditor
{
    public class TestClass
    {
        string s = string.Empty;
        public TestClass() { }

        public TestClass(string TestString)
        {
            s = TestString;
        }
        [MethodDescription("Полный метод","тестовый метод 1 тралалалаа")]
        [ParametersExternalNames("Парам1", "Типо","Галочка")]
        public string Method1 (int NamParam1, string NameParam2, bool Bool1)
        {
            return "out";
        }
        [MethodDescription("Возвратный метод", "тестовый метод 2 e[f[[f[f")]
        public string Method2()
        {
            return "out";
        }
        [MethodDescription("пустой метод", "тестовый метод 2 e[f[[f[f")]
        public void Method3()
        {

        }
        [MethodDescription("Метод с переч", "Перечисление")]
        [ParametersExternalNames("Заклинание")]
        public void Method4(Weekly enumTest)
        {

        }
        [MethodDescription("Метод с переч2", "Перечисление")]
        [ParametersExternalNames("Заклинание", "asdasd")]
        public String Method4(Weekly enumTest, out string Outreparam)
        {
            Outreparam = "jjjj";
            return "out";
        }
    }
    public enum Weekly
    {
       Klin,Fin,Pin
    }

}
