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
    public partial class WorkingDaysCounter : UserControl
    {
        public WorkingDaysCounter()
        {
            InitializeComponent();
            FirstDate.Value=DateTime.Now;
            SecondDate.Value=DateTime.Now;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DateTime start = FirstDate.Value.Date;
            DateTime end = SecondDate.Value.Date;

            if (start > end)
            {
                DateTime temp = start;
                start = end;
                end = temp;
            }

            HashSet<DayOfWeek> selectedDays = new HashSet<DayOfWeek>();

            if (IfMonday.Checked) selectedDays.Add(DayOfWeek.Monday);
            if (IfTuesday.Checked) selectedDays.Add(DayOfWeek.Tuesday);
            if (IfWensday.Checked) selectedDays.Add(DayOfWeek.Wednesday);
            if (IfThursday.Checked) selectedDays.Add(DayOfWeek.Thursday);
            if (IfFriday.Checked) selectedDays.Add(DayOfWeek.Friday);
            if (IfSutarday.Checked) selectedDays.Add(DayOfWeek.Saturday);
            if (IfSunday.Checked) selectedDays.Add(DayOfWeek.Sunday);

            int workDays = 0;

            for (DateTime date = start; date <= end; date = date.AddDays(1))
            {
                if (selectedDays.Contains(date.DayOfWeek))
                {
                    workDays++;
                }
            }

            OutputTextBox.Text = $"Рабочих дней: {workDays}";
        }

        private void OutputTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

