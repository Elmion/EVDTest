using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphEditor
{
    public class ParametersExternalNamesAttribute : Attribute
    {
        private string[] Names;
        public ParametersExternalNamesAttribute(params string[] Names)
        {
            this.Names = Names;
        }
        public string[] GetNames()
        {
            return Names;
        }

    }
    public class MethodDescriptionAttribute : Attribute
    {
        public string MethodName;
        public string MethodDescription;
        public MethodDescriptionAttribute(string ShortName,string Description)
        {
            MethodName = ShortName;
            MethodDescription = Description;
        }
    }
    
}
