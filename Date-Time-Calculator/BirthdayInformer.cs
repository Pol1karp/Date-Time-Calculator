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
            DateTime birthdate = InputBirthDate.Value.Date;
            DateTime now = DateTime.Now;
            int targetAge = (int)InputAge.Value;


            int years = now.Year - birthdate.Year;
            if (now < birthdate.AddYears(years)) years--;

            DateTime afterYears = birthdate.AddYears(years);
            int months = now.Month - afterYears.Month;
            if (now.Day < afterYears.Day) months--;
            if (months < 0) months += 12;

            DateTime afterMonths = afterYears.AddMonths(months);
            int totalDays = (now - afterMonths).Days;
            int weeks = totalDays / 7;
            int days = totalDays % 7;


            DateTime nextBirthday = new DateTime(now.Year, birthdate.Month, birthdate.Day);
            if (nextBirthday < now)
                nextBirthday = nextBirthday.AddYears(1);

            int nbYears = nextBirthday.Year - now.Year;
            int nbMonths = nextBirthday.Month - now.Month;
            int nbDays = nextBirthday.Day - now.Day;

            if (nbDays < 0)
            {
                nbMonths--;
                DateTime prevMonth = nextBirthday.AddMonths(-1);
                nbDays += DateTime.DaysInMonth(prevMonth.Year, prevMonth.Month);
            }

            if (nbMonths < 0)
            {
                nbYears--;
                nbMonths += 12;
            }

            int nbWeeks = nbDays / 7;
            nbDays = nbDays % 7;
            string nextBirthdayInfo = $"До следующего дня рождения: {nbYears} лет, {nbMonths} мес., {nbWeeks} нед., {nbDays} дн.";

            DateTime birthday18 = birthdate.AddYears(18);
            string eighteenInfo;
            if (now < birthday18)
            {
                int y = birthday18.Year - now.Year;
                int m = birthday18.Month - now.Month;
                int d = birthday18.Day - now.Day;

                if (d < 0)
                {
                    m--;
                    DateTime prevMonth = birthday18.AddMonths(-1);
                    d += DateTime.DaysInMonth(prevMonth.Year, prevMonth.Month);
                }
                if (m < 0)
                {
                    y--;
                    m += 12;
                }

                int w = d / 7;
                d = d % 7;

                eighteenInfo = $"До 18 лет: {y} лет, {m} мес., {w} нед., {d} дн.";
            }
            else
            {
                eighteenInfo = "Уже исполнилось 18";
            }

            DateTime birthdayN = birthdate.AddYears(targetAge);
            string targetInfo;
            if (now < birthdayN)
            {
                int y = birthdayN.Year - now.Year;
                int m = birthdayN.Month - now.Month;
                int d = birthdayN.Day - now.Day;

                if (d < 0)
                {
                    m--;
                    DateTime prevMonth = birthdayN.AddMonths(-1);
                    d += DateTime.DaysInMonth(prevMonth.Year, prevMonth.Month);
                }
                if (m < 0)
                {
                    y--;
                    m += 12;
                }

                int w = d / 7;
                d = d % 7;

                targetInfo = $"До {targetAge}-летия: {y} лет, {m} мес., {w} нед., {d} дн.";
            }
            else
            {
                targetInfo = $"{targetAge}-летие уже наступило";
            }

            string result = $"Живёт:\r\n" +
                            $"- Лет: {years}\r\n" +
                            $"- Месяцев: {months}\r\n" +
                            $"- Недель: {weeks}\r\n" +
                            $"- Дней: {days}\r\n\r\n" +
                            $"{nextBirthdayInfo}\r\n" +
                            $"{eighteenInfo}\r\n" +
                            $"{targetInfo}";

            OutputTextBox.Text = result;


        }
    }
}
