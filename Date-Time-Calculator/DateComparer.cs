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
            DateTime start = guna2DateTimePicker1.Value;
            DateTime end = guna2DateTimePicker2.Value;

            if (end < start)
            {
                MessageBox.Show("Конечная дата должна быть позже начальной.");
                return;
            }
            if (start > end)
            {
                DateTime temp = start;
                start = end;
                end = temp;
            }

            TimeSpan diff = end - start;

            int totalDays = (int)diff.TotalDays;
            int totalHours = (int)diff.TotalHours;
            int totalMinutes = (int)diff.TotalMinutes;
            int totalSeconds = (int)diff.TotalSeconds;
            int totalMilliseconds = (int)diff.TotalMilliseconds;

            int years = end.Year - start.Year;
            int months = (end.Year - start.Year) * 12 + end.Month - start.Month;
            int weeks = totalDays / 7;

            string result = $"Прошло:\n" +
                            $"- Лет: {years}\n" +
                            $"- Месяцев: {months}\n" +
                            $"- Недель: {weeks}\n" +
                            $"- Дней: {totalDays}\n" +
                            $"- Часов: {totalHours}\n" +
                            $"- Минут: {totalMinutes}\n" +
                            $"- Секунд: {totalSeconds}\n" +
                            $"- Миллисекунд: {totalMilliseconds}";

            guna2TextBox1.Text = result;
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
        public void ApplyTheme(bool dark)
        {
            Color backColor;
            Color foreColor;
            Color buttonColor;

            if (dark)
            {
                backColor = Color.FromArgb(30, 30, 30);
                foreColor = Color.White;
                buttonColor = Color.DimGray;
            }
            else
            {
                backColor = Color.White;
                foreColor = Color.Black;
                buttonColor = Color.LightGray;
            }

            this.BackColor = backColor;

            guna2HtmlLabel1.ForeColor = foreColor;
            guna2HtmlLabel2.ForeColor = foreColor;
            guna2HtmlLabel3.ForeColor = foreColor;
            guna2Button1.FillColor = buttonColor;
            guna2Button1.ForeColor = foreColor;

            guna2Button1.FillColor = buttonColor;
            guna2Button1.ForeColor = foreColor;
        }

    }
}
