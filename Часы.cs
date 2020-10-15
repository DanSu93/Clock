using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Часы_C
{
    public partial class Часы : Form
    {
        public Часы()
        {
            InitializeComponent();
        }
        Byte min, sec, hour,Tmin, Tsec, Thour, w = 0;  DateTime alarm, dates;
        Boolean al = false;
        int ed,des,lft;
        ClockClass Clock = new ClockClass();
        TimerClass Tmr = new TimerClass();
        private void Clock_Load(object sender, EventArgs e)
        {
            Clock.SecChanged += this.SomeSecChanged;
            Clock.MinChanged += this.SomeMinChanged;
            Clock.HourChanged += this.SomeHourChanged;
            Clock.AlarmChanged += this.SomeAlarmChanged;
            Clock.sec = Convert.ToByte(DateTime.Now.Second);
            SomeSecChanged(sec);
            Clock.min = Convert.ToByte(DateTime.Now.Minute);
            SomeMinChanged(min);
            Clock.hour = Convert.ToByte(DateTime.Now.Hour);
            SomeHourChanged(hour);
            lft = imgAlarm.Left;
            Tmr.SecChanged1 += this.SomeSecChanged;
            Tmr.MinChanged1 += this.SomeMinChanged;
            Tmr.HourChanged1 += this.SomeHourChanged;
            Tmr.ChangedStp += this.SomeStopChanged;
            Tmin = 10;
        }
        public void SomeSecChanged(byte sec)
        {
            
            if (TmrDisplay.Visible == false)
            {
                sec = Clock.sec;
                ed = sec % 10;
                des = sec / 10;
            }
            else
            {
                Tsec = Tmr.sec;
                ed = Tsec % 10;
                des = Tsec / 10;
            }
            switch (ed)
            {
                case 0:
                    {
                        this.imgSec2.Image = Часы_C.Properties.Resources.Clock_0;
                        break;
                    }
                case 1:
                    {
                        this.imgSec2.Image = Часы_C.Properties.Resources.Clock_1;
                        break;
                    }
                case 2:
                    {
                        this.imgSec2.Image = Часы_C.Properties.Resources.Clock_2;
                        break;
                    }
                case 3:
                    {
                        this.imgSec2.Image = Часы_C.Properties.Resources.Clock_3;
                        break;
                    }
                case 4:
                    {
                        this.imgSec2.Image = Часы_C.Properties.Resources.Clock_4;
                        break;
                    }
                case 5:
                    {
                        this.imgSec2.Image = Часы_C.Properties.Resources.Clock_5;
                        break;
                    }
                case 6:
                    {
                        this.imgSec2.Image = Часы_C.Properties.Resources.Clock_6;
                        break;
                    }
                case 7:
                    {
                        this.imgSec2.Image = Часы_C.Properties.Resources.Clock_7;
                        break;
                    }
                case 8:
                    {
                        this.imgSec2.Image = Часы_C.Properties.Resources.Clock_8;
                        break;
                    }
                case 9:
                    {
                        this.imgSec2.Image = Часы_C.Properties.Resources.Clock_9;
                        break;
                    }
            }
            switch (des)
            {
                case 0:
                    {
                        this.imgSec1.Image = Часы_C.Properties.Resources.Clock_0;
                        break;
                    }
                case 1:
                    {
                        this.imgSec1.Image = Часы_C.Properties.Resources.Clock_1;
                        break;
                    }
                case 2:
                    {
                        this.imgSec1.Image = Часы_C.Properties.Resources.Clock_2;
                        break;
                    }
                case 3:
                    {
                        this.imgSec1.Image = Часы_C.Properties.Resources.Clock_3;
                        break;
                    }
                case 4:
                    {
                        this.imgSec1.Image = Часы_C.Properties.Resources.Clock_4;
                        break;
                    }
                case 5:
                    {
                        this.imgSec1.Image = Часы_C.Properties.Resources.Clock_5;
                        break;
                    }
            }
        }
       public void SomeMinChanged(byte min)
       {
            if (TmrDisplay.Visible == false)
            {
                min = Clock.min;
                ed = min % 10;
                des = min / 10;
            }
            else
            {
                Tmin = Tmr.min;
                ed = Tmin % 10;
                des = Tmin / 10;
            }
            switch (ed)
                {
                    case 0:
                        {
                            this.imgMin2.Image = Часы_C.Properties.Resources.Clock_0;
                            break;
                        }
                    case 1:
                        {
                            this.imgMin2.Image = Часы_C.Properties.Resources.Clock_1;
                            break;
                        }
                    case 2:
                        {
                            this.imgMin2.Image = Часы_C.Properties.Resources.Clock_2;
                            break;
                        }
                    case 3:
                        {
                            this.imgMin2.Image = Часы_C.Properties.Resources.Clock_3;
                            break;
                        }
                    case 4:
                        {
                            this.imgMin2.Image = Часы_C.Properties.Resources.Clock_4;
                            break;
                        }
                    case 5:
                        {
                            this.imgMin2.Image = Часы_C.Properties.Resources.Clock_5;
                            break;
                        }
                    case 6:
                        {
                            this.imgMin2.Image = Часы_C.Properties.Resources.Clock_6;
                            break;
                        }
                    case 7:
                        {
                            this.imgMin2.Image = Часы_C.Properties.Resources.Clock_7;
                            break;
                        }
                    case 8:
                        {
                            this.imgMin2.Image = Часы_C.Properties.Resources.Clock_8;
                            break;
                        }
                    case 9:
                        {
                            this.imgMin2.Image = Часы_C.Properties.Resources.Clock_9;
                            break;
                        }
            }
            switch (des)
            {
                case 0:
                    {
                        this.imgMin1.Image = Часы_C.Properties.Resources.Clock_0;
                        break;
                    }
                case 1:
                    {
                        this.imgMin1.Image = Часы_C.Properties.Resources.Clock_1;
                        break;
                    }
                case 2:
                    {
                        this.imgMin1.Image = Часы_C.Properties.Resources.Clock_2;
                        break;
                    }
                case 3:
                    {
                        this.imgMin1.Image = Часы_C.Properties.Resources.Clock_3;
                        break;
                    }
                case 4:
                    {
                        this.imgMin1.Image = Часы_C.Properties.Resources.Clock_4;
                        break;
                    }
                case 5:
                    {
                        this.imgMin1.Image = Часы_C.Properties.Resources.Clock_5;
                        break;
                    }
            }
        }
       public void SomeHourChanged(byte min)
       {
           
           if (TmrDisplay.Visible == false)
           {
               hour = Clock.hour;
               ed = hour % 10;
               des = hour / 10;
           }
           else
           {
               Thour = Tmr.hour;
               ed = Thour % 10;
               des = Thour / 10;
           }
           switch (ed)
           {
               case 0:
                   {
                       this.imgHour2.Image = Часы_C.Properties.Resources.Clock_0;
                       break;
                   }
               case 1:
                   {
                       this.imgHour2.Image = Часы_C.Properties.Resources.Clock_1;
                       break;
                   }
               case 2:
                   {
                       this.imgHour2.Image = Часы_C.Properties.Resources.Clock_2;
                       break;
                   }
               case 3:
                   {
                       this.imgHour2.Image = Часы_C.Properties.Resources.Clock_3;
                       break;
                   }
               case 4:
                   {
                       this.imgHour2.Image = Часы_C.Properties.Resources.Clock_4;
                       break;
                   }
               case 5:
                   {
                       this.imgHour2.Image = Часы_C.Properties.Resources.Clock_5;
                       break;
                   }
               case 6:
                   {
                       this.imgHour2.Image = Часы_C.Properties.Resources.Clock_6;
                       break;
                   }
               case 7:
                   {
                       this.imgHour2.Image = Часы_C.Properties.Resources.Clock_7;
                       break;
                   }
               case 8:
                   {
                       this.imgHour2.Image = Часы_C.Properties.Resources.Clock_8;
                       break;
                   }
               case 9:
                   {
                       this.imgHour2.Image = Часы_C.Properties.Resources.Clock_9;
                       break;
                   }
           }
           switch (des)
           {
               case 0:
                   {
                       this.imgHour1.Image = Часы_C.Properties.Resources.Clock_0;
                       break;
                   }
               case 1:
                   {
                       this.imgHour1.Image = Часы_C.Properties.Resources.Clock_1;
                       break;
                   }
               case 2:
                   {
                       this.imgHour1.Image = Часы_C.Properties.Resources.Clock_2;
                       break;
                   }
           }
       }
       public void SomeAlarmChanged(bool NewAlarm)
       {
           if (Clock.Alarm == true)
           {
               al = Clock.Alarm;
               imgAlarm.Visible = true;
               TimerAlarm.Start();
               TimerWakeUp.Stop();
               L2.Visible = true;
               LAlarm.Text = Convert.ToString(alarm);
               LAlarm.Visible = true;
               BtnResAlarm.Visible = true;
           }
           else
           {
               al = Clock.Alarm;
               imgAlarm.Visible = false;
               TimerAlarm.Stop();
               TimerWakeUp.Stop();
               imgAlarm.Left = lft;
               L2.Visible = false;
               LAlarm.Visible = false;
               BtnResAlarm.Visible = false;
               BtnResAlarm.Text = "Сброс будильника";
           }
       }
       public void SomeStopChanged(bool stp)
       {
           Timer1Sec.Stop();
           MessageBox.Show("Время истекло!");
           BtnStart.Text = "Старт";
           BtnStart.ForeColor = Color.LimeGreen;
           Tmr.min = 10;
           SomeMinChanged(1);
       }

       private void BarSpeed_Scroll_1(object sender, EventArgs e)
       {
           Double Speed;
           if (BarSpeed.Value > 99)
           {
               Timer1Sec.Interval = 1;
               TimerAlarm.Interval = 1;
               LSpeed.Text = "MAX";
           }
           else
           {
               Timer1Sec.Interval = 1000 - (20 * (BarSpeed.Value - 50));
               TimerAlarm.Interval = 1000 - (20 * (BarSpeed.Value - 50));
               Speed = 1 / (Convert.ToDouble(Timer1Sec.Interval) / 1000);
               Speed *= 100;
               Speed = Convert.ToInt32(Speed);
               Speed /= 100;
               LSpeed.Text = Convert.ToString(Speed) + "x";
               if (BarSpeed.Value < 1)
               {
                   LSpeed.Text = "MIN";
               }
           }
       }

       private void Btn_ResSpeed_Click_1(object sender, EventArgs e)
       {
           LSpeed.Text = "1x";
           BarSpeed.Value = 50;
           Timer1Sec.Interval = 1000;
           TimerAlarm.Interval = 1000;
       }

       private void BarOnOff_Scroll(object sender, EventArgs e)
       {
           Font bold = new Font(LOff.Font, FontStyle.Bold);
           Font normal = new Font(LOff.Font, FontStyle.Regular);
           if (BarOnOff.Value == 0)
           {
               LOn.Font = normal;
               LOff.Font = bold;
               Timer1Sec.Stop();
               TimerAlarm.Stop();
               TimerWakeUp.Stop();
               imgAlarm.Left = lft;
               Display.Visible = false;
               BtnStart.Enabled = false;
               BtnPause.Enabled = false;
               BtnGo.Enabled = false;
           }
           else
           {
               Display.Visible = true;
               LOff.Font = normal;
               LOn.Font = bold;
               if (TmrDisplay.Visible == false | (BtnStart.Text == "Сброс" & BtnPause.Text == "Пауза"))
               {
                   Timer1Sec.Start();
               }
               else
                   TimerAlarm.Start();
               BtnStart.Enabled = true;
               if (BtnPause.Text == "Продолжить" | BtnStart.Text == "Сброс")
               {
                   BtnPause.Enabled = true;
               }
               BtnGo.Enabled = true;
           }
           BtnResAlarm.Text = "Остановить будильник";
       }

       private void TimerWakeUp_Tick(object sender, EventArgs e)
       {
           switch (w)
           {
               case 0:
                   
                       lft = imgAlarm.Left;
                       imgAlarm.Left += 7;
                       w=1;
                       break;
               case 1:
                       lft = imgAlarm.Left;
                       imgAlarm.Left -= 7;
                       w=2;
                       break;
               case 2:
                   
                       lft = imgAlarm.Left;
                       imgAlarm.Left -= 7;
                       w=3;
                       break;
               case 3:
                   
                       lft = imgAlarm.Left;
                       imgAlarm.Left += 7;
                       w=0;
                       break;
           }
       }

       private void Time_CheckedChanged(object sender, EventArgs e)
       {
           BtnGo.Text = "Установить время";
       }

       private void Wake_CheckedChanged(object sender, EventArgs e)
       {
           BtnGo.Text = "Установить будильник";
       }

       private void BtnPause_Click(object sender, EventArgs e)
       {
           if (BtnPause.Text == "Пауза")
           {
               Timer1Sec.Stop();
               BtnPause.Text = "Продолжить";
           }
           else
           {
               BtnPause.Text = "Пауза";
               Timer1Sec.Start();
           }
       }

       private void Timer1Sec_Tick(object sender, EventArgs e)
       {
           if (TmrDisplay.Visible == false)
           {
               Clock.AddSec();
           }
           else Tmr.AddSec();
       }

       private void BtnGo_Click(object sender, EventArgs e)
       {
           if (TmrDisplay.Visible == false)
           {
               if (Time.Checked)
               {
                   try
                   {
                       dates = Convert.ToDateTime(MaskDate.Text);
                       Clock.sec = Convert.ToByte(dates.Second);
                       SomeSecChanged(sec);
                       Clock.min = Convert.ToByte(dates.Minute);
                       SomeMinChanged(min);
                       Clock.hour = Convert.ToByte(dates.Hour);
                       SomeHourChanged(hour);
                   }
                   catch
                   {
                       MessageBox.Show("Неправильно введены данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   }
               }
               else
               {
                   try
                   {
                       alarm = Convert.ToDateTime(MaskDate.Text);
                       Clock.Alarm = true;
                   }
                   catch
                   {
                       MessageBox.Show("Неправильно введены данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   }
               }
           }
           else
           {
               try
               {
                   dates = Convert.ToDateTime(MaskDate.Text);
                   Tmr.sec = Convert.ToByte(dates.Second);
                   SomeSecChanged(Tsec);
                   Tmr.min = Convert.ToByte(dates.Minute);
                   SomeMinChanged(Tmin);
                   Tmr.hour = Convert.ToByte(dates.Hour);
                   SomeHourChanged(Thour);
               }
               catch
               {
                   MessageBox.Show("Неправильно введены данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
           }
       }

       private void TimerAlarm_Tick(object sender, EventArgs e)
       {
           if (alarm.Hour == Clock.hour & alarm.Minute == Clock.min & alarm.Second == Clock.sec)
           {
               TimerWakeUp.Start();
               TimerAlarm.Stop();
               BtnResAlarm.Text = "ВЫКЛЮЧИТЬ";
           }
       }

       private void BtnResAlarm_Click(object sender, EventArgs e)
       {
           Clock.Alarm = false;
       }

       private void BtnChange_Click(object sender, EventArgs e)
       {
           if (BtnChange.Text == "Таймер")
           {
               TmrDisplay.Visible = true;
               Panel.Visible = true;
               Tmr.sec = Tsec;
               Tmr.min = Tmin;
               Tmr.hour = Thour;
               SomeSecChanged(Tsec);
               SomeMinChanged(Tmin);
               SomeHourChanged(Thour);
               BtnGo.BringToFront();
               MaskDate.BringToFront();
               BtnChange.Text = "Часы";
               Timer1Sec.Stop();
               TimerWakeUp.Stop();
               BtnResAlarm.Text = "Сброс будильника";
               imgAlarm.Left = lft;
               TimerAlarm.Stop();
               BtnGo.Text = "Установить";
           }
           else
           {
               TmrDisplay.Visible = false;
               Panel.Visible = false;
               SomeSecChanged(sec);
               SomeMinChanged(min);
               SomeHourChanged(hour);
               BtnChange.Text = "Таймер";
               Timer1Sec.Start();
               if (imgAlarm.Visible == true)
               {
                   TimerAlarm.Start();
               }
               BtnGo.SendToBack();
               MaskDate.SendToBack();
               if (Time.Checked)
               {
                   BtnGo.Text = "Установить время";
               }
               else
                   BtnGo.Text = "Установить будильник";
           }
       }

       private void BtnStart_Click(object sender, EventArgs e)
       {
           if (Thour == 0 & Tmin == 0 & Tsec == 0)
           {
               MessageBox.Show("Время истекло!");
               return;
           }
           if (BtnStart.Text == "Старт")
           {
               Timer1Sec.Start();
               BtnStart.Text = "Сброс";
               BtnStart.ForeColor = Color.Red;
               BtnPause.Enabled = true;
           }
           else
           {
               Timer1Sec.Stop();
               Tmr.hour = 0;
               SomeHourChanged(Tmr.hour);
               Tmr.min = 10;
               SomeMinChanged(Tmr.min);
               Tmr.sec = 0;
               SomeSecChanged(Tmr.sec);
               BtnPause.Text = "Пауза";
               BtnStart.Text = "Старт";
               BtnStart.ForeColor = Color.LimeGreen;
               BtnPause.Enabled = false;
           }
       }
    }
}
