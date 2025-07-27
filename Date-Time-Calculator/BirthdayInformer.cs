using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Date_Time_Calculator
{
    public partial class BirthdayInformer : UserControl
    {
        public BirthdayInformer()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime birthdate = guna2DateTimePicker1.Value.Date;
            DateTime now = DateTime.Now;
            int targetAge = (int)guna2NumericUpDown2.Value;

            TimeSpan life = now - birthdate;
            int years = (int)(life.TotalDays / 365.25);
            int days = life.Days;
            int hours = (int)life.TotalHours;
            int minutes = (int)life.TotalMinutes;
            int seconds = (int)life.TotalSeconds;
            long milliseconds = (long)(life.TotalMilliseconds);


            DateTime nextBirthday = new DateTime(now.Year, birthdate.Month, birthdate.Day);
            if (nextBirthday < now)
                nextBirthday = nextBirthday.AddYears(1);
            TimeSpan untilNextBirthday = nextBirthday - now;

            DateTime birthday18 = birthdate.AddYears(18);
            string eighteenInfo;

            if (now < birthday18)
            {
                TimeSpan until18 = birthday18 - now;
                eighteenInfo = $"До 18 лет: {until18.Days} дн., {until18.Hours} ч.";
            }
            else
            {
                eighteenInfo = "Уже исполнилось 18";
            }

            DateTime birthdayN = birthdate.AddYears(targetAge);
            TimeSpan untilTarget = birthdayN - now;

            string result = $"Живёт:\r\n" +
                    $"- Лет: {years}\r\n" +
                    $"- Дней: {days}\r\n" +
                    $"- Часов: {hours}\r\n" +
                    $"- Минут: {minutes}\r\n" +
                    $"- Секунд: {seconds}\r\n" +
                    $"- Миллисекунд: {milliseconds}\r\n\r\n" +
                    $"До следующего дня рождения: {untilNextBirthday.Days} дн., {untilNextBirthday.Hours} ч.\r\n" +
                    $"{eighteenInfo}\r\n" +
                    $"До N  возроста {targetAge} лет: {untilTarget.Days} дн., {untilTarget.Hours} ч.";

            guna2TextBox1.Text = result;
        }
    }
}
