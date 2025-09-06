using Guna.UI2.WinForms;
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
            timer1.Enabled = false;
            InputBirthDate.Value = DateTime.Now;
            InputBirthDate.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            InputBirthDate.ShowUpDown = true;
            InputBirthDate.MaxDate = DateTime.Now;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime birthDate = InputBirthDate.Value;
            DateTime now = DateTime.Now;

            if (birthDate > now)
            {
                MessageBox.Show("Дата рождения не может быть в будущем!");
                return;
            }

            int years = now.Year - birthDate.Year;
            int months = now.Month - birthDate.Month;
            int days = now.Day - birthDate.Day;

            if (days < 0)
            {
                months--;

                int prevMonth = now.Month - 1;
                int prevYear = now.Year;

                if (prevMonth == 0)
                {
                    prevMonth = 12;
                    prevYear--;
                }

                days += DateTime.DaysInMonth(prevYear, prevMonth);
            }

            if (months < 0)
            {
                years--;
                months += 12;
            }

            int weeks = days / 7;
            days = days % 7;

            DateTime nextBirthday = new DateTime(now.Year, birthDate.Month, birthDate.Day);
            if (nextBirthday < now)
                nextBirthday = nextBirthday.AddYears(1);

            TimeSpan untilNextBirthday = nextBirthday - now;
            DateTime eighteenth = birthDate.AddYears(18);
            TimeSpan until18 = eighteenth - now;
            DateTime thirtyThree = birthDate.AddYears(33);
            TimeSpan until33 = thirtyThree - now;

            string info18;
            if (until18.TotalSeconds < 0)
            {
                TimeSpan since18 = now - eighteenth;
                info18 = $"18 было: {since18.Days} дн., {since18.Hours} ч., {since18.Minutes} м., {since18.Seconds} с. назад.";
            }
            else
            {
                info18 = $"До 18: {until18.Days} дн., {until18.Hours} ч., {until18.Minutes} м., {until18.Seconds} с.";
            }

            int targetAge = (int)InputAge.Value; 

            DateTime targetDate = birthDate.AddYears(targetAge);
            TimeSpan untilTarget = targetDate - now;

            string infoTarget;
            if (untilTarget.TotalSeconds < 0)
            {
                TimeSpan sinceTarget = now - targetDate;
                infoTarget = $"{targetAge} было: {sinceTarget.Days} дн., {sinceTarget.Hours} ч., {sinceTarget.Minutes} м., {sinceTarget.Seconds} с. назад.";
            }
            else
            {
                infoTarget = $"До {targetAge}: {untilTarget.Days} дн., {untilTarget.Hours} ч., {untilTarget.Minutes} м., {untilTarget.Seconds} с.";
            }

            TimeSpan lived = now - birthDate;
            TimeSpan age = now - birthDate;

            OutputTextBox.Text =
            $"Живёт:\r\n" +
            $"- Лет: {years}\r\n" +
            $"- Месяцев: {months}\r\n" +
            $"- Недель: {weeks}\r\n" +
            $"- Дней: {days}\r\n" +
            $"- Часов: {age.Hours}\r\n" +
            $"- Минут: {age.Minutes}\r\n" +
            $"- Секунд: {age.Seconds}\r\n" +
            $"До следующего дня рождения: {untilNextBirthday.Days} дн., {untilNextBirthday.Hours} ч., {untilNextBirthday.Minutes} м., {untilNextBirthday.Seconds} с.\r\n" +
            $"{info18}\r\n" +
            $"{infoTarget}";


        }


        private void OutputTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
