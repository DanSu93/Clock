namespace Часы_C
{
    partial class Часы
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Часы));
            this.Panel = new System.Windows.Forms.Panel();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnPause = new System.Windows.Forms.Button();
            this.TmrDisplay = new System.Windows.Forms.Panel();
            this.BtnGo = new System.Windows.Forms.Button();
            this.imgSec2 = new System.Windows.Forms.PictureBox();
            this.imgSec1 = new System.Windows.Forms.PictureBox();
            this.imgHour1 = new System.Windows.Forms.PictureBox();
            this.imgHour2 = new System.Windows.Forms.PictureBox();
            this.imgDots1 = new System.Windows.Forms.PictureBox();
            this.imgMin1 = new System.Windows.Forms.PictureBox();
            this.imgMin2 = new System.Windows.Forms.PictureBox();
            this.imgDots2 = new System.Windows.Forms.PictureBox();
            this.Display = new System.Windows.Forms.Panel();
            this.BtnChange = new System.Windows.Forms.Button();
            this.LAlarm = new System.Windows.Forms.Label();
            this.L2 = new System.Windows.Forms.Label();
            this.imgAlarm = new System.Windows.Forms.PictureBox();
            this.MaskDate = new System.Windows.Forms.MaskedTextBox();
            this.Timer1Sec = new System.Windows.Forms.Timer(this.components);
            this.BtnResAlarm = new System.Windows.Forms.Button();
            this.Wake = new System.Windows.Forms.RadioButton();
            this.Time = new System.Windows.Forms.RadioButton();
            this.LSpeed = new System.Windows.Forms.Label();
            this.Btn_ResSpeed = new System.Windows.Forms.Button();
            this.L1 = new System.Windows.Forms.Label();
            this.TimerWakeUp = new System.Windows.Forms.Timer(this.components);
            this.LOff = new System.Windows.Forms.Label();
            this.LOn = new System.Windows.Forms.Label();
            this.BarOnOff = new System.Windows.Forms.TrackBar();
            this.TimerAlarm = new System.Windows.Forms.Timer(this.components);
            this.BarSpeed = new System.Windows.Forms.TrackBar();
            this.TmrDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSec2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSec1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHour1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHour2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDots1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDots2)).BeginInit();
            this.Display.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAlarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarOnOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Location = new System.Drawing.Point(403, 66);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(88, 65);
            this.Panel.TabIndex = 57;
            this.Panel.Visible = false;
            // 
            // BtnStart
            // 
            this.BtnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnStart.ForeColor = System.Drawing.Color.LimeGreen;
            this.BtnStart.Location = new System.Drawing.Point(7, 12);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(116, 35);
            this.BtnStart.TabIndex = 34;
            this.BtnStart.Text = "Старт";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnPause
            // 
            this.BtnPause.Enabled = false;
            this.BtnPause.Location = new System.Drawing.Point(131, 12);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(92, 35);
            this.BtnPause.TabIndex = 33;
            this.BtnPause.Text = "Пауза";
            this.BtnPause.UseVisualStyleBackColor = true;
            this.BtnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // TmrDisplay
            // 
            this.TmrDisplay.Controls.Add(this.BtnStart);
            this.TmrDisplay.Controls.Add(this.BtnPause);
            this.TmrDisplay.Location = new System.Drawing.Point(248, 131);
            this.TmrDisplay.Name = "TmrDisplay";
            this.TmrDisplay.Size = new System.Drawing.Size(232, 77);
            this.TmrDisplay.TabIndex = 55;
            this.TmrDisplay.Visible = false;
            // 
            // BtnGo
            // 
            this.BtnGo.AutoSize = true;
            this.BtnGo.Location = new System.Drawing.Point(111, 143);
            this.BtnGo.Name = "BtnGo";
            this.BtnGo.Size = new System.Drawing.Size(136, 35);
            this.BtnGo.TabIndex = 54;
            this.BtnGo.Text = "Установить время";
            this.BtnGo.UseVisualStyleBackColor = true;
            this.BtnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // imgSec2
            // 
            this.imgSec2.Image = ((System.Drawing.Image)(resources.GetObject("imgSec2.Image")));
            this.imgSec2.Location = new System.Drawing.Point(323, 6);
            this.imgSec2.Name = "imgSec2";
            this.imgSec2.Size = new System.Drawing.Size(56, 100);
            this.imgSec2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgSec2.TabIndex = 18;
            this.imgSec2.TabStop = false;
            // 
            // imgSec1
            // 
            this.imgSec1.Image = ((System.Drawing.Image)(resources.GetObject("imgSec1.Image")));
            this.imgSec1.Location = new System.Drawing.Point(267, 6);
            this.imgSec1.Name = "imgSec1";
            this.imgSec1.Size = new System.Drawing.Size(56, 100);
            this.imgSec1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgSec1.TabIndex = 11;
            this.imgSec1.TabStop = false;
            // 
            // imgHour1
            // 
            this.imgHour1.Image = ((System.Drawing.Image)(resources.GetObject("imgHour1.Image")));
            this.imgHour1.Location = new System.Drawing.Point(7, 6);
            this.imgHour1.Name = "imgHour1";
            this.imgHour1.Size = new System.Drawing.Size(56, 100);
            this.imgHour1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgHour1.TabIndex = 12;
            this.imgHour1.TabStop = false;
            // 
            // imgHour2
            // 
            this.imgHour2.Image = ((System.Drawing.Image)(resources.GetObject("imgHour2.Image")));
            this.imgHour2.Location = new System.Drawing.Point(63, 6);
            this.imgHour2.Name = "imgHour2";
            this.imgHour2.Size = new System.Drawing.Size(56, 100);
            this.imgHour2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgHour2.TabIndex = 13;
            this.imgHour2.TabStop = false;
            // 
            // imgDots1
            // 
            this.imgDots1.Image = ((System.Drawing.Image)(resources.GetObject("imgDots1.Image")));
            this.imgDots1.Location = new System.Drawing.Point(118, 6);
            this.imgDots1.Name = "imgDots1";
            this.imgDots1.Size = new System.Drawing.Size(20, 100);
            this.imgDots1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgDots1.TabIndex = 14;
            this.imgDots1.TabStop = false;
            // 
            // imgMin1
            // 
            this.imgMin1.Image = ((System.Drawing.Image)(resources.GetObject("imgMin1.Image")));
            this.imgMin1.Location = new System.Drawing.Point(136, 6);
            this.imgMin1.Name = "imgMin1";
            this.imgMin1.Size = new System.Drawing.Size(56, 100);
            this.imgMin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgMin1.TabIndex = 15;
            this.imgMin1.TabStop = false;
            // 
            // imgMin2
            // 
            this.imgMin2.Image = ((System.Drawing.Image)(resources.GetObject("imgMin2.Image")));
            this.imgMin2.Location = new System.Drawing.Point(192, 6);
            this.imgMin2.Name = "imgMin2";
            this.imgMin2.Size = new System.Drawing.Size(56, 100);
            this.imgMin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgMin2.TabIndex = 16;
            this.imgMin2.TabStop = false;
            // 
            // imgDots2
            // 
            this.imgDots2.Image = ((System.Drawing.Image)(resources.GetObject("imgDots2.Image")));
            this.imgDots2.Location = new System.Drawing.Point(248, 6);
            this.imgDots2.Name = "imgDots2";
            this.imgDots2.Size = new System.Drawing.Size(20, 100);
            this.imgDots2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgDots2.TabIndex = 17;
            this.imgDots2.TabStop = false;
            // 
            // Display
            // 
            this.Display.Controls.Add(this.imgSec2);
            this.Display.Controls.Add(this.imgSec1);
            this.Display.Controls.Add(this.imgHour1);
            this.Display.Controls.Add(this.imgHour2);
            this.Display.Controls.Add(this.imgDots1);
            this.Display.Controls.Add(this.imgMin1);
            this.Display.Controls.Add(this.imgMin2);
            this.Display.Controls.Add(this.imgDots2);
            this.Display.Location = new System.Drawing.Point(15, 17);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(386, 112);
            this.Display.TabIndex = 53;
            // 
            // BtnChange
            // 
            this.BtnChange.Location = new System.Drawing.Point(344, 214);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(131, 35);
            this.BtnChange.TabIndex = 52;
            this.BtnChange.Text = "Таймер";
            this.BtnChange.UseVisualStyleBackColor = true;
            this.BtnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // LAlarm
            // 
            this.LAlarm.AutoSize = true;
            this.LAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LAlarm.Location = new System.Drawing.Point(350, 188);
            this.LAlarm.Name = "LAlarm";
            this.LAlarm.Size = new System.Drawing.Size(0, 13);
            this.LAlarm.TabIndex = 50;
            this.LAlarm.Visible = false;
            // 
            // L2
            // 
            this.L2.AutoSize = true;
            this.L2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L2.Location = new System.Drawing.Point(255, 187);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(164, 13);
            this.L2.TabIndex = 49;
            this.L2.Text = "Будильник установлен на:";
            this.L2.Visible = false;
            // 
            // imgAlarm
            // 
            this.imgAlarm.Image = global::Часы_C.Properties.Resources.Alarm;
            this.imgAlarm.Location = new System.Drawing.Point(408, 69);
            this.imgAlarm.Name = "imgAlarm";
            this.imgAlarm.Size = new System.Drawing.Size(60, 60);
            this.imgAlarm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgAlarm.TabIndex = 48;
            this.imgAlarm.TabStop = false;
            this.imgAlarm.Visible = false;
            // 
            // MaskDate
            // 
            this.MaskDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaskDate.Location = new System.Drawing.Point(22, 148);
            this.MaskDate.Mask = "00:00:00";
            this.MaskDate.Name = "MaskDate";
            this.MaskDate.Size = new System.Drawing.Size(80, 29);
            this.MaskDate.TabIndex = 56;
            // 
            // Timer1Sec
            // 
            this.Timer1Sec.Enabled = true;
            this.Timer1Sec.Interval = 1000;
            this.Timer1Sec.Tick += new System.EventHandler(this.Timer1Sec_Tick);
            // 
            // BtnResAlarm
            // 
            this.BtnResAlarm.Location = new System.Drawing.Point(344, 138);
            this.BtnResAlarm.Name = "BtnResAlarm";
            this.BtnResAlarm.Size = new System.Drawing.Size(131, 39);
            this.BtnResAlarm.TabIndex = 51;
            this.BtnResAlarm.Text = "Сброс будильника";
            this.BtnResAlarm.UseVisualStyleBackColor = true;
            this.BtnResAlarm.Visible = false;
            this.BtnResAlarm.Click += new System.EventHandler(this.BtnResAlarm_Click);
            // 
            // Wake
            // 
            this.Wake.AutoSize = true;
            this.Wake.Location = new System.Drawing.Point(259, 161);
            this.Wake.Name = "Wake";
            this.Wake.Size = new System.Drawing.Size(79, 17);
            this.Wake.TabIndex = 47;
            this.Wake.Text = "Будильник";
            this.Wake.UseVisualStyleBackColor = true;
            this.Wake.CheckedChanged += new System.EventHandler(this.Wake_CheckedChanged);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Checked = true;
            this.Time.Location = new System.Drawing.Point(259, 138);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(58, 17);
            this.Time.TabIndex = 46;
            this.Time.TabStop = true;
            this.Time.Text = "Время";
            this.Time.UseVisualStyleBackColor = true;
            this.Time.CheckedChanged += new System.EventHandler(this.Time_CheckedChanged);
            // 
            // LSpeed
            // 
            this.LSpeed.AutoSize = true;
            this.LSpeed.Location = new System.Drawing.Point(139, 198);
            this.LSpeed.Name = "LSpeed";
            this.LSpeed.Size = new System.Drawing.Size(18, 13);
            this.LSpeed.TabIndex = 45;
            this.LSpeed.Text = "1x";
            // 
            // Btn_ResSpeed
            // 
            this.Btn_ResSpeed.Location = new System.Drawing.Point(248, 214);
            this.Btn_ResSpeed.Name = "Btn_ResSpeed";
            this.Btn_ResSpeed.Size = new System.Drawing.Size(90, 35);
            this.Btn_ResSpeed.TabIndex = 44;
            this.Btn_ResSpeed.Text = "Сброс";
            this.Btn_ResSpeed.UseVisualStyleBackColor = true;
            this.Btn_ResSpeed.Click += new System.EventHandler(this.Btn_ResSpeed_Click_1);
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Location = new System.Drawing.Point(83, 198);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(55, 13);
            this.L1.TabIndex = 43;
            this.L1.Text = "Скорость";
            // 
            // TimerWakeUp
            // 
            this.TimerWakeUp.Interval = 1;
            this.TimerWakeUp.Tick += new System.EventHandler(this.TimerWakeUp_Tick);
            // 
            // LOff
            // 
            this.LOff.AutoSize = true;
            this.LOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LOff.ForeColor = System.Drawing.Color.Red;
            this.LOff.Location = new System.Drawing.Point(435, 42);
            this.LOff.Name = "LOff";
            this.LOff.Size = new System.Drawing.Size(27, 13);
            this.LOff.TabIndex = 42;
            this.LOff.Text = "OFF";
            // 
            // LOn
            // 
            this.LOn.AutoSize = true;
            this.LOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LOn.ForeColor = System.Drawing.Color.LimeGreen;
            this.LOn.Location = new System.Drawing.Point(437, 24);
            this.LOn.Name = "LOn";
            this.LOn.Size = new System.Drawing.Size(25, 13);
            this.LOn.TabIndex = 41;
            this.LOn.Text = "ON";
            // 
            // BarOnOff
            // 
            this.BarOnOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BarOnOff.Location = new System.Drawing.Point(408, 17);
            this.BarOnOff.Maximum = 1;
            this.BarOnOff.Name = "BarOnOff";
            this.BarOnOff.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.BarOnOff.Size = new System.Drawing.Size(45, 45);
            this.BarOnOff.TabIndex = 39;
            this.BarOnOff.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BarOnOff.Value = 1;
            this.BarOnOff.Scroll += new System.EventHandler(this.BarOnOff_Scroll);
            // 
            // TimerAlarm
            // 
            this.TimerAlarm.Interval = 1000;
            this.TimerAlarm.Tick += new System.EventHandler(this.TimerAlarm_Tick);
            // 
            // BarSpeed
            // 
            this.BarSpeed.Location = new System.Drawing.Point(15, 214);
            this.BarSpeed.Maximum = 100;
            this.BarSpeed.Name = "BarSpeed";
            this.BarSpeed.Size = new System.Drawing.Size(227, 45);
            this.BarSpeed.TabIndex = 40;
            this.BarSpeed.Value = 50;
            this.BarSpeed.Scroll += new System.EventHandler(this.BarSpeed_Scroll_1);
            // 
            // Часы
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 277);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.TmrDisplay);
            this.Controls.Add(this.BtnGo);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.BtnChange);
            this.Controls.Add(this.LAlarm);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.imgAlarm);
            this.Controls.Add(this.MaskDate);
            this.Controls.Add(this.BtnResAlarm);
            this.Controls.Add(this.Wake);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.LSpeed);
            this.Controls.Add(this.Btn_ResSpeed);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.LOff);
            this.Controls.Add(this.LOn);
            this.Controls.Add(this.BarOnOff);
            this.Controls.Add(this.BarSpeed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Часы";
            this.Text = "Часы";
            this.Load += new System.EventHandler(this.Clock_Load);
            this.TmrDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgSec2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSec1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHour1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHour2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDots1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDots2)).EndInit();
            this.Display.ResumeLayout(false);
            this.Display.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAlarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarOnOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel Panel;
        internal System.Windows.Forms.Button BtnStart;
        internal System.Windows.Forms.Button BtnPause;
        internal System.Windows.Forms.Panel TmrDisplay;
        internal System.Windows.Forms.Button BtnGo;
        internal System.Windows.Forms.PictureBox imgSec2;
        internal System.Windows.Forms.PictureBox imgSec1;
        internal System.Windows.Forms.PictureBox imgHour1;
        internal System.Windows.Forms.PictureBox imgHour2;
        internal System.Windows.Forms.PictureBox imgDots1;
        internal System.Windows.Forms.PictureBox imgMin1;
        internal System.Windows.Forms.PictureBox imgMin2;
        internal System.Windows.Forms.PictureBox imgDots2;
        internal System.Windows.Forms.Panel Display;
        internal System.Windows.Forms.Button BtnChange;
        internal System.Windows.Forms.Label LAlarm;
        internal System.Windows.Forms.Label L2;
        internal System.Windows.Forms.PictureBox imgAlarm;
        internal System.Windows.Forms.MaskedTextBox MaskDate;
        internal System.Windows.Forms.Timer Timer1Sec;
        internal System.Windows.Forms.Button BtnResAlarm;
        internal System.Windows.Forms.RadioButton Wake;
        internal System.Windows.Forms.RadioButton Time;
        internal System.Windows.Forms.Label LSpeed;
        internal System.Windows.Forms.Button Btn_ResSpeed;
        internal System.Windows.Forms.Label L1;
        internal System.Windows.Forms.Timer TimerWakeUp;
        internal System.Windows.Forms.Label LOff;
        internal System.Windows.Forms.Label LOn;
        internal System.Windows.Forms.TrackBar BarOnOff;
        internal System.Windows.Forms.Timer TimerAlarm;
        internal System.Windows.Forms.TrackBar BarSpeed;



    }
}

