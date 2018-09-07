using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTester
{
    /// <summary>
    /// Считает время мышки
    /// </summary>
    public class TimeLine
    {
        public TimeSpan CurrentDay;
        public int Days = 1;
        public TimeLine()
        {
            CurrentDay = new TimeSpan(0);
        }
        public DayPhase GetDayPhase()
        {
            if(5 <= CurrentDay.Hours && CurrentDay.Hours < 11)
            {
                return DayPhase.Morning;
            }
            else
            if (11 <= CurrentDay.Hours && CurrentDay.Hours < 17)
            {
                return DayPhase.Day;
            }
            else
            if (17 <= CurrentDay.Hours && CurrentDay.Hours < 23)
            {
                return DayPhase.Evening;
            }
            else
            {
                return DayPhase.Night;
            }
        }
        public int NewBornAge
        {
            get
            {
                return (int)Math.Ceiling(19f * (1 - Math.Exp(-Days / 200f)))-1;
            }
        }
        public void AddTime(int minutes)
        {
            CurrentDay = CurrentDay.Add(new TimeSpan(0, minutes, 0));
            if(CurrentDay.Days > 0) //прещелкиваем дату.
            {
                Days += CurrentDay.Days;
                CurrentDay = CurrentDay - new TimeSpan(CurrentDay.Days, 0, 0, 0);
            }
        }
        public string CurentTimeToString()
        {
            return CurrentDay.Hours + ":" + CurrentDay.Minutes;
        }
    }
    public enum DayPhase
    {
        Morning,
        Day,
        Evening,
        Night
    }
}
