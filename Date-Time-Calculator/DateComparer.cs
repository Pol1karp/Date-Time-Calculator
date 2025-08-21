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
    public partial class DateComparer : UserControl
    {
        public DateComparer()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DateTime start = FirstDate.Value;
            DateTime end = SecondDate.Value;

            if (end < start)
            {
                MessageBox.Show("Конечная дата должна быть позже начальной.");
                return;
            }
            int years = end.Year - start.Year;
            int months = end.Month - start.Month;
            int days = end.Day - start.Day;
            if (days < 0)
            {
                months--;
                days += DateTime.DaysInMonth(start.Year, start.Month);
            }
            if (months < 0)
            {
                years--;
                months += 12;
            }
            int weeks = days / 7;
            days = days % 7;
            TimeSpan timeDiff = end - start;
            int hours = timeDiff.Hours;
            int minutes = timeDiff.Minutes;
            int seconds = timeDiff.Seconds;
            int milliseconds = timeDiff.Milliseconds;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Прошло:");
            sb.AppendLine($"- Лет: {years}");
            sb.AppendLine($"- Месяцев: {months}");
            sb.AppendLine($"- Недель: {weeks}");
            sb.AppendLine($"- Дней: {days}");
            OutputTextBox.Text = sb.ToString();
        }
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
       


    }
}
