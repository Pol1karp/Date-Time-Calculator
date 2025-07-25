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
    public partial class LeepCounter : UserControl
    {
        public LeepCounter()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DateTime start = guna2DateTimePicker1.Value;
            DateTime end = guna2DateTimePicker2.Value;
            if (start > end)
            {
                DateTime temp = start;
                start = end;
                end = temp;
            }

            int leapYears = 0;

            for (int year = start.Year; year <= end.Year; year++)
            {
                if (DateTime.IsLeapYear(year))
                {
                    leapYears++;
                }
            }

            guna2TextBox1.Text = "Високосных лет между датами: " + leapYears;
        }
    }
}
