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
            FirstDate.Value = DateTime.Now;
            SecondDate.Value = DateTime.Now;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DateTime start = FirstDate.Value;
            DateTime end = SecondDate.Value;
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

            OutputTextBox.Text = "Високосных лет между датами: " + leapYears;
        }
    }
}
