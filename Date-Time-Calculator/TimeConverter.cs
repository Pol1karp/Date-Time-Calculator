using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
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
            double inputValue = (double)guna2NumericUpDown2.Value;

            string from = guna2ComboBox2.SelectedItem.ToString();
            string to = guna2ComboBox1.SelectedItem.ToString();

            double seconds = 0;
            if (from == "Лет") seconds = inputValue * 365.25 * 24 * 60 * 60;
            if (from == "Месяцев") seconds = inputValue * 30.44 * 24 * 60 * 60;
            if (from == "Дней") seconds = inputValue * 24 * 60 * 60;
            if (from == "Часов") seconds = inputValue * 60 * 60;
            if (from == "Минут") seconds = inputValue * 60;
            if (from == "Секунд") seconds = inputValue;
            double result = 0;
            if (to == "Лет") result = seconds / (365.25 * 24 * 60 * 60);
            if (to == "Месяцев") result = seconds / (30.44 * 24 * 60 * 60);
            if (to == "Дней") result = seconds / (24 * 60 * 60);
            if (to == "Часов") result = seconds / (60 * 60);
            if (to == "Минут") result = seconds / 60;
            if (to == "Секунд") result = seconds;
            guna2TextBox1.Text = $"{Math.Round(result, 4)} {to}";
        }
    }
}
