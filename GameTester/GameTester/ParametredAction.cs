using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GameTester
{
    [Serializable]
    public class ParametredAction
    {
        Type ActionType;
        private string name = string.Empty;
        public MethodInfo link;
        public List<object> Params;
        public string Name
        {
            get
            {
                if (name == string.Empty)
                    return link.Name;
                else return name;
            }
            set
            {
                name = value;
            }
        }
        public ParametredAction(MethodInfo link, object[] Params, Type ActionType)
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
            link.Invoke(target, ReadyParams.ToArray());
        }
    }
}
