using System;
using System.Collections.Generic;

namespace ConsoleApplication2
{
    public class ShortTimeToLongTime
    {
        public void Calculate()
        {
            var time = "01:29:45AM";
            var shortTime = ShortTime.GetFrom(time);
            var longTime = LongTime.GetFrom(shortTime);

            var Longtime2 = DateTime.Parse(time);

            Console.WriteLine(Longtime2);
            Console.ReadKey();
        }

        
    }

     
    
    public class LongTime
    {
        public LongTime(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        //var time = "07:05:45PM";
        //00:05:45 AM
        public static LongTime GetFrom(ShortTime shortTime)
        {
            if (shortTime.PartOfTime == ShortTime.Part.AM)
            {
                return new LongTime(shortTime.Hour, shortTime.Minutes, shortTime.Seconds);
            }
            if (shortTime.PartOfTime == ShortTime.Part.PM)
            {
                if (shortTime.Hour == 12)
                    return new LongTime(shortTime.Hour - 12, shortTime.Minutes, shortTime.Seconds);
                if (shortTime.IsHourBetween1To11)
                    return new LongTime(shortTime.Hour + 12, shortTime.Minutes, shortTime.Seconds);
            }
            throw new ArgumentOutOfRangeException("Part of time out of specified scope");
        }

        public override string ToString()
        {
            return $"{this.Hours.ToString("00")}:{this.Minutes.ToString("00")}:{this.Seconds.ToString("00")}";
        }
    }

    public class ShortTime
    {
        public ShortTime(string hour, string minutes, string seconds, string partOfTime)
        {
            Hour = int.Parse(hour);
            Minutes = int.Parse(minutes);
            Seconds = int.Parse(seconds);
            PartOfTime = (Part)Enum.Parse(typeof(Part), partOfTime);
        }


        public bool IsMidnight => PartOfTime == Part.PM && Hour == 12;

        public bool IsHourBetween1To11 => Hour >= 1 && Hour <= 11;

        public int Hour { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public Part PartOfTime { get; set; }

        public enum Part
        {
            AM,
            PM
        }

        public static ShortTime GetFrom(string time)
        {
            var splitted = time.Split(':');
            var amPm = splitted[2].Substring(splitted[2].Length - 2, 2);
            var seconds = splitted[2].Substring(0, splitted[2].Length - 2);
            return new ShortTime(splitted[0], splitted[1], seconds, amPm);
        }
    }
}
