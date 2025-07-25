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
    public partial class TimeConverter : UserControl
    {
        public TimeConverter()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
        private double ConvertToSeconds(double value, string unit)
        {
            if (unit == "Лет") return value * 365.25 * 24 * 60 * 60;
            if (unit == "Месяцев") return value * 30.44 * 24 * 60 * 60;
            if (unit == "Дней") return value * 24 * 60 * 60;
            if (unit == "Часов") return value * 60 * 60;
            if (unit == "Минут") return value * 60;
            if (unit == "Секунд") return value;
            return 0;
        }

        private double ConvertFromSeconds(double seconds, string unit)
        {
            if (unit == "Лет") return seconds / (365.25 * 24 * 60 * 60);
            if (unit == "Месяцев") return seconds / (30.44 * 24 * 60 * 60);
            if (unit == "Дней") return seconds / (24 * 60 * 60);
            if (unit == "Часов") return seconds / (60 * 60);
            if (unit == "Минут") return seconds / 60;
            if (unit == "Секунд") return seconds;
            return 0;
        }

    }
}
