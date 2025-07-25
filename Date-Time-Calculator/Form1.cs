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

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
