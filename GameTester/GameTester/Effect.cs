using System;
using System.Collections.Generic;
using System.Reflection;

namespace GameTester
{
    public class Effect
    {
        
        
        public Effect()
        {
            List<Delegate> TagsEffect;
        }
        public void LoadEffect(string XML)
        {
            TagsEffect = new List<Delegate>();
            TagsEffect.Add(Delegate.CreateDelegate(typeof(Action<object>),this ,typeof(Effect).GetMethod("Effect1")));
            TagsEffect[0].DynamicInvoke(1);
        }
        public void DoEffect()
        {

        }
        public  void Effect1(object ddd)
        {
        
        }
    }
}