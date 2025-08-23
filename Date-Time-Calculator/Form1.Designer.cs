namespace Date_Time_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.HomeButton = new Guna.UI2.WinForms.Guna2Button();
            this.UnixTimestampLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TitelLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.BirthdayInfoButton = new Guna.UI2.WinForms.Guna2Button();
            this.TConverterButton = new Guna.UI2.WinForms.Guna2Button();
            this.LeepButton = new Guna.UI2.WinForms.Guna2Button();
            this.WCounterButton = new Guna.UI2.WinForms.Guna2Button();
            this.MenuLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DComparerButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Panel1.Controls.Add(this.HomeButton);
            this.guna2Panel1.Controls.Add(this.UnixTimestampLabel);
            this.guna2Panel1.Controls.Add(this.TitelLabel);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(834, 78);
            this.guna2Panel1.TabIndex = 6;
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.Transparent;
            this.HomeButton.DefaultAutoSize = true;
            this.HomeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HomeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HomeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HomeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.HomeButton.FillColor = System.Drawing.SystemColors.Control;
            this.HomeButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.HomeButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.Location = new System.Drawing.Point(12, 12);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(95, 33);
            this.HomeButton.TabIndex = 16;
            this.HomeButton.Text = "Home";
            this.HomeButton.Click += new System.EventHandler(this.guna2Button7_Click);
            // 
            // UnixTimestampLabel
            // 
            this.UnixTimestampLabel.BackColor = System.Drawing.Color.Transparent;
            this.UnixTimestampLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UnixTimestampLabel.ForeColor = System.Drawing.SystemColors.MenuText;
            this.UnixTimestampLabel.Location = new System.Drawing.Point(567, 3);
            this.UnixTimestampLabel.Name = "UnixTimestampLabel";
            this.UnixTimestampLabel.Size = new System.Drawing.Size(120, 22);
            this.UnixTimestampLabel.TabIndex = 10;
            this.UnixTimestampLabel.Text = "Unix Timestamp:";
            // 
            // TitelLabel
            // 
            this.TitelLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitelLabel.Location = new System.Drawing.Point(337, 27);
            this.TitelLabel.Name = "TitelLabel";
            this.TitelLabel.Size = new System.Drawing.Size(166, 22);
            this.TitelLabel.TabIndex = 0;
            this.TitelLabel.Text = "Date & Time Calculator";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.guna2Panel2.Controls.Add(this.BirthdayInfoButton);
            this.guna2Panel2.Controls.Add(this.TConverterButton);
            this.guna2Panel2.Controls.Add(this.LeepButton);
            this.guna2Panel2.Controls.Add(this.WCounterButton);
            this.guna2Panel2.Controls.Add(this.MenuLabel);
            this.guna2Panel2.Controls.Add(this.DComparerButton);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 78);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(228, 583);
            this.guna2Panel2.TabIndex = 7;
            // 
            // BirthdayInfoButton
            // 
            this.BirthdayInfoButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BirthdayInfoButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BirthdayInfoButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BirthdayInfoButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BirthdayInfoButton.FillColor = System.Drawing.SystemColors.ControlLight;
            this.BirthdayInfoButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BirthdayInfoButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.BirthdayInfoButton.Location = new System.Drawing.Point(3, 262);
            this.BirthdayInfoButton.Name = "BirthdayInfoButton";
            this.BirthdayInfoButton.Size = new System.Drawing.Size(222, 51);
            this.BirthdayInfoButton.TabIndex = 13;
            this.BirthdayInfoButton.Text = "Birthday Informer";
            this.BirthdayInfoButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BirthdayInfoButton.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // TConverterButton
            // 
            this.TConverterButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.TConverterButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.TConverterButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.TConverterButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.TConverterButton.FillColor = System.Drawing.SystemColors.ControlLight;
            this.TConverterButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TConverterButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.TConverterButton.Location = new System.Drawing.Point(3, 205);
            this.TConverterButton.Name = "TConverterButton";
            this.TConverterButton.Size = new System.Drawing.Size(222, 51);
            this.TConverterButton.TabIndex = 12;
            this.TConverterButton.Text = "Time Converter";
            this.TConverterButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TConverterButton.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // LeepButton
            // 
            this.LeepButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LeepButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LeepButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LeepButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LeepButton.FillColor = System.Drawing.SystemColors.ControlLight;
            this.LeepButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LeepButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.LeepButton.Location = new System.Drawing.Point(3, 148);
            this.LeepButton.Name = "LeepButton";
            this.LeepButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LeepButton.Size = new System.Drawing.Size(222, 51);
            this.LeepButton.TabIndex = 11;
            this.LeepButton.Text = "Leap Counter";
            this.LeepButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LeepButton.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // WCounterButton
            // 
            this.WCounterButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.WCounterButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.WCounterButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WCounterButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.WCounterButton.FillColor = System.Drawing.SystemColors.ControlLight;
            this.WCounterButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.WCounterButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.WCounterButton.Location = new System.Drawing.Point(3, 91);
            this.WCounterButton.Name = "WCounterButton";
            this.WCounterButton.Size = new System.Drawing.Size(222, 51);
            this.WCounterButton.TabIndex = 10;
            this.WCounterButton.Text = "2Date Working Counter";
            this.WCounterButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.WCounterButton.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // MenuLabel
            // 
            this.MenuLabel.BackColor = System.Drawing.Color.Transparent;
            this.MenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuLabel.ForeColor = System.Drawing.SystemColors.MenuText;
            this.MenuLabel.Location = new System.Drawing.Point(88, 6);
            this.MenuLabel.Name = "MenuLabel";
            this.MenuLabel.Size = new System.Drawing.Size(43, 22);
            this.MenuLabel.TabIndex = 9;
            this.MenuLabel.Text = "Menu";
            // 
            // DComparerButton
            // 
            this.DComparerButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DComparerButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DComparerButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DComparerButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DComparerButton.FillColor = System.Drawing.SystemColors.ControlLight;
            this.DComparerButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DComparerButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.DComparerButton.Location = new System.Drawing.Point(3, 34);
            this.DComparerButton.Name = "DComparerButton";
            this.DComparerButton.Size = new System.Drawing.Size(222, 51);
            this.DComparerButton.TabIndex = 9;
            this.DComparerButton.Text = "2Date Соmparer";
            this.DComparerButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DComparerButton.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.guna2TextBox2);
            this.guna2Panel3.Controls.Add(this.guna2TextBox3);
            this.guna2Panel3.Controls.Add(this.guna2TextBox1);
            this.guna2Panel3.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.Location = new System.Drawing.Point(228, 78);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(606, 583);
            this.guna2Panel3.TabIndex = 8;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Animated = true;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.guna2TextBox1.DefaultText = resources.GetString("guna2TextBox1.DefaultText");
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(58, 91);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox1.Multiline = true;
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(510, 253);
            this.guna2TextBox1.TabIndex = 1;
            this.guna2TextBox1.UseWaitCursor = true;
            this.guna2TextBox1.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(109, 22);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = null;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.Animated = true;
            this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.guna2TextBox3.DefaultText = "Главная страница программы, это краткий гайд и путеводитель по программе.";
            this.guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Location = new System.Drawing.Point(58, 7);
            this.guna2TextBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox3.Multiline = true;
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PlaceholderText = "";
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.Size = new System.Drawing.Size(510, 48);
            this.guna2TextBox3.TabIndex = 3;
            this.guna2TextBox3.UseWaitCursor = true;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Animated = true;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.guna2TextBox2.DefaultText = "<=Используйте панель слева для навигации.";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(7, 504);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox2.Multiline = true;
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(331, 48);
            this.guna2TextBox2.TabIndex = 4;
            this.guna2TextBox2.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(834, 661);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Date & Time Calculator";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel TitelLabel;
        private Guna.UI2.WinForms.Guna2Button DComparerButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel MenuLabel;
        private Guna.UI2.WinForms.Guna2Button BirthdayInfoButton;
        private Guna.UI2.WinForms.Guna2Button TConverterButton;
        private Guna.UI2.WinForms.Guna2Button LeepButton;
        private Guna.UI2.WinForms.Guna2Button WCounterButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2HtmlLabel UnixTimestampLabel;
        private Guna.UI2.WinForms.Guna2Button HomeButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
    }
}

