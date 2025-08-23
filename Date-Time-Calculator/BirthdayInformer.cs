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
                days += DateTime.DaysInMonth(now.Year, (now.Month - 1 <= 0 ? 12 : now.Month - 1));
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

            OutputTextBox.Text =
                $"Живёт:\r\n" +
                $"- Лет: {years}\r\n" +
                $"- Месяцев: {months}\r\n" +
                $"- Недель: {weeks}\r\n" +
                $"- Дней: {days}\r\n\r\n" +
                $"До следующего дня рождения: {untilNextBirthday.Days} дн., {untilNextBirthday.Hours} ч.\r\n" +
                $"До 18 лет: {until18.Days} дн., {until18.Hours} ч.\r\n" +
                $"До 33-летия: {until33.Days} дн., {until33.Hours} ч.";
        }
    }
}
