using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Часы_C
{
    public class TimerClass:ClockClass
    {
        public event TimeContainer SecChanged1;
        public event TimeContainer MinChanged1;
        public event TimeContainer HourChanged1;
        public event AlarmContainer ChangedStp;
        override public void AddSec()
        {

            if (sc > 0)
            {
                sc -= 1;
            }
            else
            {
                if (sc==0 & mn==0 & hr==0)
                {
                    ChangedStp(true);
                    return;
                }
                sc = 59;
                AddMin();
            }
            SecChanged1(sc);
        }
        override public void AddMin()
        {
            if (mn > 0)
            {
                mn -= 1;
            }
            else if (hr!=0)
            {
                mn =59;
                AddHour();
            }
            MinChanged1(mn);
        }
        override public void AddHour()
        {

            if (hr > 0)
            {
                hr -= 1;
            }
            HourChanged1(hr);
        }
    }

}
