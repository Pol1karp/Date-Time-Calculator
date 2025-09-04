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
            int inputValue = (int)AmoundOfTime.Value;

            string from = SecondChoice.SelectedItem.ToString();
            string to = FirstChoice.SelectedItem.ToString();

            long seconds = 0;
            if (from == "Лет") seconds = inputValue * 365L * 24 * 60 * 60;
            if (from == "Месяцев") seconds = inputValue * 30L * 24 * 60 * 60;
            if (from == "Дней") seconds = inputValue * 24L * 60 * 60;
            if (from == "Часов") seconds = inputValue * 60L * 60;
            if (from == "Минут") seconds = inputValue * 60L;
            if (from == "Секунд") seconds = inputValue;


            long result = 0;
            if (to == "Лет") result = seconds / (365L * 24 * 60 * 60);
            if (to == "Месяцев") result = seconds / (30L * 24 * 60 * 60);
            if (to == "Дней") result = seconds / (24L * 60 * 60);
            if (to == "Часов") result = seconds / (60L * 60);
            if (to == "Минут") result = seconds / 60L;
            if (to == "Секунд") result = seconds;

            OutputTextBox.Text = $"{result} {to}";
        }

    }
}
