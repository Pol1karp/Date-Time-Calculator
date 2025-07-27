namespace Date_Time_Calculator
{
    partial class BirthdayInformer
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TitelLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.OutputTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.BDateLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.StartButton = new Guna.UI2.WinForms.Guna2Button();
            this.InputBirthDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.AgeLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.InputAge = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.InputAge)).BeginInit();
            this.SuspendLayout();
            // 
            // TitelLabel
            // 
            this.TitelLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitelLabel.Location = new System.Drawing.Point(219, 23);
            this.TitelLabel.Name = "TitelLabel";
            this.TitelLabel.Size = new System.Drawing.Size(121, 22);
            this.TitelLabel.TabIndex = 29;
            this.TitelLabel.Text = "BirthdayInformer";
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.OutputTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OutputTextBox.DefaultText = "";
            this.OutputTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.OutputTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.OutputTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OutputTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OutputTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OutputTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.OutputTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OutputTextBox.Location = new System.Drawing.Point(39, 309);
            this.OutputTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.PlaceholderText = "";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.SelectedText = "";
            this.OutputTextBox.Size = new System.Drawing.Size(528, 270);
            this.OutputTextBox.TabIndex = 28;
            // 
            // BDateLabel
            // 
            this.BDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.BDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BDateLabel.Location = new System.Drawing.Point(39, 102);
            this.BDateLabel.Name = "BDateLabel";
            this.BDateLabel.Size = new System.Drawing.Size(236, 22);
            this.BDateLabel.TabIndex = 26;
            this.BDateLabel.Text = "Введите свою дату рождения:";
            // 
            // StartButton
            // 
            this.StartButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StartButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StartButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StartButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StartButton.FillColor = System.Drawing.Color.Gray;
            this.StartButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.StartButton.ForeColor = System.Drawing.Color.White;
            this.StartButton.Location = new System.Drawing.Point(191, 257);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(200, 45);
            this.StartButton.TabIndex = 25;
            this.StartButton.Text = "Ок";
            this.StartButton.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // InputBirthDate
            // 
            this.InputBirthDate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.InputBirthDate.Checked = true;
            this.InputBirthDate.FillColor = System.Drawing.SystemColors.ButtonShadow;
            this.InputBirthDate.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.InputBirthDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.InputBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.InputBirthDate.Location = new System.Drawing.Point(39, 130);
            this.InputBirthDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.InputBirthDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.InputBirthDate.Name = "InputBirthDate";
            this.InputBirthDate.Size = new System.Drawing.Size(200, 36);
            this.InputBirthDate.TabIndex = 23;
            this.InputBirthDate.Value = new System.DateTime(2025, 7, 20, 0, 1, 0, 0);
            // 
            // AgeLabel
            // 
            this.AgeLabel.BackColor = System.Drawing.Color.Transparent;
            this.AgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgeLabel.Location = new System.Drawing.Point(39, 187);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(154, 22);
            this.AgeLabel.TabIndex = 30;
            this.AgeLabel.Text = "Введите возрост N:";
            // 
            // InputAge
            // 
            this.InputAge.BackColor = System.Drawing.Color.Transparent;
            this.InputAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputAge.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.InputAge.Location = new System.Drawing.Point(39, 215);
            this.InputAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.InputAge.Name = "InputAge";
            this.InputAge.Size = new System.Drawing.Size(230, 36);
            this.InputAge.TabIndex = 31;
            this.InputAge.Value = new decimal(new int[] {
            33,
            0,
            0,
            0});
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BirthdayInformer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InputAge);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.TitelLabel);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.BDateLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.InputBirthDate);
            this.Name = "BirthdayInformer";
            this.Size = new System.Drawing.Size(606, 583);
            ((System.ComponentModel.ISupportInitialize)(this.InputAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel TitelLabel;
        private Guna.UI2.WinForms.Guna2TextBox OutputTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel BDateLabel;
        private Guna.UI2.WinForms.Guna2Button StartButton;
        private Guna.UI2.WinForms.Guna2DateTimePicker InputBirthDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel AgeLabel;
        private Guna.UI2.WinForms.Guna2NumericUpDown InputAge;
        private System.Windows.Forms.Timer timer1;
    }
}
