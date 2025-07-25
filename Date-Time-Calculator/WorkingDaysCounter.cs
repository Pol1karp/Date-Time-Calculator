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
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DateTime start = guna2DateTimePicker1.Value.Date;
            DateTime end = guna2DateTimePicker2.Value.Date;

            if (start > end)
            {
                DateTime temp = start;
                start = end;
                end = temp;
            }

            HashSet<DayOfWeek> selectedDays = new HashSet<DayOfWeek>();

            if (guna2CheckBox1.Checked) selectedDays.Add(DayOfWeek.Monday);
            if (guna2CheckBox2.Checked) selectedDays.Add(DayOfWeek.Tuesday);
            if (guna2CheckBox3.Checked) selectedDays.Add(DayOfWeek.Wednesday);
            if (guna2CheckBox4.Checked) selectedDays.Add(DayOfWeek.Thursday);
            if (guna2CheckBox5.Checked) selectedDays.Add(DayOfWeek.Friday);
            if (guna2CheckBox6.Checked) selectedDays.Add(DayOfWeek.Saturday);
            if (guna2CheckBox7.Checked) selectedDays.Add(DayOfWeek.Sunday);

            int workDays = 0;

            for (DateTime date = start; date <= end; date = date.AddDays(1))
            {
                if (selectedDays.Contains(date.DayOfWeek))
                {
                    workDays++;
                }
            }

            guna2TextBox1.Text = $"Рабочих дней: {workDays}";
        }


    }
}

