using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphEditor
{
    class TestClass
    {
        string s = string.Empty;
        public TestClass() { }

        public TestClass(string TestString)
        {
            s = TestString;
        }
        public string Method1 (int NamParam1, string NameParam2, bool Bool1)
        {
            return "out";
        }
        public string Method2()
        {
            return "out";
        }
        public void Method3()
        {

        }
        public void Method4(Weekly enumTest)
        {

        }
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
