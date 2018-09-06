using System;
namespace GameTester
{
    [Serializable]
    public class Access
    {
        public static Access Instance = new Access();
        public bool AgeGreaterOrEqual(int ageCondition)
        {
           if(HeroTemp.Instance.time.NewBornAge >= ageCondition)
             return true;
           else
             return false;
        }
        public bool AgeSmaller(int ageCondition)
        {
            if (HeroTemp.Instance.time.NewBornAge < ageCondition)
                return true;
            else
                return false;
        }
    }
}