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
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}
