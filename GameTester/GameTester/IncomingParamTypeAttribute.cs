using System;

namespace GameTester
{
    internal class IncomingTypesAttribute : Attribute
    {
        public Type[] types;
        public IncomingTypesAttribute(params Type[] types)
        {
            this.types = types;
        }
    }
}