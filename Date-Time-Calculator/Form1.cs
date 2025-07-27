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
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
        private void LoadControl(UserControl uc)
        {
            guna2Panel3.Controls.Clear();
            uc.Dock = DockStyle.Fill;           
            guna2Panel3.Controls.Add(uc);         
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            long unixTimestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            guna2HtmlLabel3.Text = $"Unix Timestamp: {unixTimestamp}";
        }
        private void guna2Button7_Click(object sender, EventArgs e)
        {
            guna2Panel3.Controls.Clear();
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            LoadControl(new DateComparer());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            LoadControl(new WorkingDaysCounter());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            LoadControl(new LeepCounter());
        }
        
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            LoadControl(new TimeConverter());
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            LoadControl(new BirthdayInformer());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
        private bool isDarkTheme = false;
        private void ApplyThemeToAllControls()
        {
            Color backColor;
            Color foreColor;
            Color panelColor;

            if (isDarkTheme)
            {
                backColor = Color.FromArgb(30, 30, 30);
                foreColor = Color.White;
                panelColor = Color.FromArgb(45, 45, 45);
            }
            else
            {
                backColor = Color.WhiteSmoke;
                foreColor = Color.Black;
                panelColor = Color.Gainsboro;
            }

            this.BackColor = backColor;

            guna2Panel1.BackColor = panelColor;
            guna2Panel2.BackColor = panelColor;

            guna2Button1.FillColor = panelColor;
            guna2Button1.ForeColor = foreColor;

            guna2Button2.FillColor = panelColor;
            guna2Button2.ForeColor = foreColor;

            guna2Button3.FillColor = panelColor;
            guna2Button3.ForeColor = foreColor;

            guna2Button4.FillColor = panelColor;
            guna2Button4.ForeColor = foreColor;

            guna2Button5.FillColor = panelColor;
            guna2Button5.ForeColor = foreColor;

            guna2Button6.FillColor = panelColor;
            guna2Button6.ForeColor = foreColor;

            guna2Button7.FillColor = panelColor;
            guna2Button7.ForeColor = foreColor;

            guna2HtmlLabel3.ForeColor = foreColor;
            guna2HtmlLabel3.ForeColor = foreColor;

            // Смена темы для UserControls
            DateComparer.ApplyTheme(isDarkTheme);
            userControl2_WorkingCounter.ApplyTheme(isDarkTheme);
            userControl3_LeapCounter.ApplyTheme(isDarkTheme);
            userControl4_TimeConverter.ApplyTheme(isDarkTheme);
            userControl5_BirthdayInformer.ApplyTheme(isDarkTheme);
        }


    }
}
