using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Часы_C
{

    public class ClockClass
    {
        public delegate void TimeContainer(byte value);
        public event TimeContainer SecChanged;
        public event TimeContainer MinChanged;
        public event TimeContainer HourChanged;
        public delegate void AlarmContainer(bool value);
        public event AlarmContainer AlarmChanged;
        public byte sc;
        public byte sec
        {
            get { return sc;}
            set { sc = value; }
        }
        public byte mn;
        public byte min
        {
            get { return mn; }
            set { mn = value; }
        }
        public byte hr;
        public byte hour
        {
            get { return hr; }
            set { hr = value; }
        }
        public bool alrm;
        public bool Alarm
        {
            get { return alrm; }
            set { alrm = value; AlarmChanged(alrm);}

        }
        virtual public void AddSec()
        {

            if (sc < 59) 
            {
            sc += 1;
            }
            else
            {                
                sc = 0;
                AddMin();
            }
            SecChanged(sc);
        }
        virtual public void AddMin()
        {

            if (mn < 59)
            {
                mn += 1;
            }
            else
            {
                mn = 0;
                AddHour();
            }
            MinChanged(mn);
        }
        virtual public void AddHour()
        {

            if (hr < 23)
            {
                hr += 1;
            }
            else
            {
                hr = 0;
            }
            HourChanged(hr);
        }
    }
}
