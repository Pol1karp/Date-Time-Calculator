namespace Date_Time_Calculator
{
    partial class DateComparer
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
            this.OutputTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SecondDateLab = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.FirstDateLab = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.StartButton = new Guna.UI2.WinForms.Guna2Button();
            this.SecondDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.FirstDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.TitelLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
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
            this.OutputTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OutputTextBox.Location = new System.Drawing.Point(42, 430);
            this.OutputTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.PlaceholderText = "";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.SelectedText = "";
            this.OutputTextBox.Size = new System.Drawing.Size(528, 125);
            this.OutputTextBox.TabIndex = 14;
            // 
            // SecondDateLab
            // 
            this.SecondDateLab.BackColor = System.Drawing.Color.Transparent;
            this.SecondDateLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondDateLab.Location = new System.Drawing.Point(370, 97);
            this.SecondDateLab.Name = "SecondDateLab";
            this.SecondDateLab.Size = new System.Drawing.Size(105, 22);
            this.SecondDateLab.TabIndex = 13;
            this.SecondDateLab.Text = "Вторая дата:";
            // 
            // FirstDateLab
            // 
            this.FirstDateLab.BackColor = System.Drawing.Color.Transparent;
            this.FirstDateLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstDateLab.Location = new System.Drawing.Point(42, 97);
            this.FirstDateLab.Name = "FirstDateLab";
            this.FirstDateLab.Size = new System.Drawing.Size(106, 22);
            this.FirstDateLab.TabIndex = 12;
            this.FirstDateLab.Text = "Первая дата:";
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
            this.StartButton.Location = new System.Drawing.Point(182, 378);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(200, 45);
            this.StartButton.TabIndex = 11;
            this.StartButton.Text = "Измерить";
            this.StartButton.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // SecondDate
            // 
            this.SecondDate.Checked = true;
            this.SecondDate.FillColor = System.Drawing.SystemColors.ButtonShadow;
            this.SecondDate.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.SecondDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SecondDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.SecondDate.Location = new System.Drawing.Point(370, 125);
            this.SecondDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.SecondDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.SecondDate.Name = "SecondDate";
            this.SecondDate.Size = new System.Drawing.Size(200, 36);
            this.SecondDate.TabIndex = 10;
            this.SecondDate.Value = new System.DateTime(2025, 7, 20, 0, 1, 0, 0);
            // 
            // FirstDate
            // 
            this.FirstDate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.FirstDate.Checked = true;
            this.FirstDate.FillColor = System.Drawing.SystemColors.ButtonShadow;
            this.FirstDate.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.FirstDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FirstDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.FirstDate.Location = new System.Drawing.Point(42, 125);
            this.FirstDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.FirstDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.FirstDate.Name = "FirstDate";
            this.FirstDate.Size = new System.Drawing.Size(200, 36);
            this.FirstDate.TabIndex = 9;
            this.FirstDate.Value = new System.DateTime(2025, 7, 20, 0, 1, 0, 0);
            // 
            // TitelLabel
            // 
            this.TitelLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitelLabel.Location = new System.Drawing.Point(219, 23);
            this.TitelLabel.Name = "TitelLabel";
            this.TitelLabel.Size = new System.Drawing.Size(121, 22);
            this.TitelLabel.TabIndex = 15;
            this.TitelLabel.Text = "2Date Соmparer";
            this.TitelLabel.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // DateComparer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TitelLabel);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.SecondDateLab);
            this.Controls.Add(this.FirstDateLab);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.SecondDate);
            this.Controls.Add(this.FirstDate);
            this.Name = "DateComparer";
            this.Size = new System.Drawing.Size(606, 583);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox OutputTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel SecondDateLab;
        private Guna.UI2.WinForms.Guna2HtmlLabel FirstDateLab;
        private Guna.UI2.WinForms.Guna2Button StartButton;
        private Guna.UI2.WinForms.Guna2DateTimePicker SecondDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker FirstDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel TitelLabel;
    }
}
