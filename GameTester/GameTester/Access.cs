using System;
namespace GameTester
{
    [Serializable]
    public class Access
    {
        public static Access Instance = new Access();
        public bool CheckAge(int ageCondition)
        {
            return true;
        }
    }
}