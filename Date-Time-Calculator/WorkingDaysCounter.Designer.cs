namespace Date_Time_Calculator
{
    partial class WorkingDaysCounter
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
            this.TitelLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.OutputTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SecondDateLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.FirstDateLab = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.StartButton = new Guna.UI2.WinForms.Guna2Button();
            this.SecondDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.FirstDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DayChoLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.IfMonday = new Guna.UI2.WinForms.Guna2CheckBox();
            this.IfTuesday = new Guna.UI2.WinForms.Guna2CheckBox();
            this.IfWensday = new Guna.UI2.WinForms.Guna2CheckBox();
            this.IfThursday = new Guna.UI2.WinForms.Guna2CheckBox();
            this.IfFriday = new Guna.UI2.WinForms.Guna2CheckBox();
            this.IfSutarday = new Guna.UI2.WinForms.Guna2CheckBox();
            this.IfSunday = new Guna.UI2.WinForms.Guna2CheckBox();
            this.SuspendLayout();
            // 
            // TitelLabel
            // 
            this.TitelLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitelLabel.Location = new System.Drawing.Point(219, 23);
            this.TitelLabel.Name = "TitelLabel";
            this.TitelLabel.Size = new System.Drawing.Size(154, 22);
            this.TitelLabel.TabIndex = 22;
            this.TitelLabel.Text = "WorkingDaysCounter";
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
            this.OutputTextBox.Location = new System.Drawing.Point(39, 454);
            this.OutputTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.PlaceholderText = "";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.SelectedText = "";
            this.OutputTextBox.Size = new System.Drawing.Size(528, 125);
            this.OutputTextBox.TabIndex = 21;
            // 
            // SecondDateLabel
            // 
            this.SecondDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.SecondDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondDateLabel.Location = new System.Drawing.Point(367, 102);
            this.SecondDateLabel.Name = "SecondDateLabel";
            this.SecondDateLabel.Size = new System.Drawing.Size(105, 22);
            this.SecondDateLabel.TabIndex = 20;
            this.SecondDateLabel.Text = "Вторая дата:";
            // 
            // FirstDateLab
            // 
            this.FirstDateLab.BackColor = System.Drawing.Color.Transparent;
            this.FirstDateLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstDateLab.Location = new System.Drawing.Point(39, 102);
            this.FirstDateLab.Name = "FirstDateLab";
            this.FirstDateLab.Size = new System.Drawing.Size(106, 22);
            this.FirstDateLab.TabIndex = 19;
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
            this.StartButton.Location = new System.Drawing.Point(179, 402);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(200, 45);
            this.StartButton.TabIndex = 18;
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
            this.SecondDate.Location = new System.Drawing.Point(367, 130);
            this.SecondDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.SecondDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.SecondDate.Name = "SecondDate";
            this.SecondDate.Size = new System.Drawing.Size(200, 36);
            this.SecondDate.TabIndex = 17;
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
            this.FirstDate.Location = new System.Drawing.Point(39, 130);
            this.FirstDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.FirstDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.FirstDate.Name = "FirstDate";
            this.FirstDate.Size = new System.Drawing.Size(200, 36);
            this.FirstDate.TabIndex = 16;
            this.FirstDate.Value = new System.DateTime(2025, 7, 20, 0, 1, 0, 0);
            // 
            // DayChoLabel
            // 
            this.DayChoLabel.BackColor = System.Drawing.Color.Transparent;
            this.DayChoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DayChoLabel.Location = new System.Drawing.Point(216, 172);
            this.DayChoLabel.Name = "DayChoLabel";
            this.DayChoLabel.Size = new System.Drawing.Size(163, 22);
            this.DayChoLabel.TabIndex = 23;
            this.DayChoLabel.Text = "Выбор робочих дней:";
            // 
            // IfMonday
            // 
            this.IfMonday.AutoSize = true;
            this.IfMonday.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IfMonday.CheckedState.BorderRadius = 0;
            this.IfMonday.CheckedState.BorderThickness = 0;
            this.IfMonday.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IfMonday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IfMonday.Location = new System.Drawing.Point(107, 200);
            this.IfMonday.Name = "IfMonday";
            this.IfMonday.Size = new System.Drawing.Size(132, 24);
            this.IfMonday.TabIndex = 24;
            this.IfMonday.Text = "Понедельник";
            this.IfMonday.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.IfMonday.UncheckedState.BorderRadius = 0;
            this.IfMonday.UncheckedState.BorderThickness = 0;
            this.IfMonday.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // IfTuesday
            // 
            this.IfTuesday.AutoSize = true;
            this.IfTuesday.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IfTuesday.CheckedState.BorderRadius = 0;
            this.IfTuesday.CheckedState.BorderThickness = 0;
            this.IfTuesday.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IfTuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IfTuesday.Location = new System.Drawing.Point(147, 230);
            this.IfTuesday.Name = "IfTuesday";
            this.IfTuesday.Size = new System.Drawing.Size(92, 24);
            this.IfTuesday.TabIndex = 25;
            this.IfTuesday.Text = "Вторник";
            this.IfTuesday.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.IfTuesday.UncheckedState.BorderRadius = 0;
            this.IfTuesday.UncheckedState.BorderThickness = 0;
            this.IfTuesday.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // IfWensday
            // 
            this.IfWensday.AutoSize = true;
            this.IfWensday.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IfWensday.CheckedState.BorderRadius = 0;
            this.IfWensday.CheckedState.BorderThickness = 0;
            this.IfWensday.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IfWensday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IfWensday.Location = new System.Drawing.Point(162, 260);
            this.IfWensday.Name = "IfWensday";
            this.IfWensday.Size = new System.Drawing.Size(77, 24);
            this.IfWensday.TabIndex = 26;
            this.IfWensday.Text = "Среда";
            this.IfWensday.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.IfWensday.UncheckedState.BorderRadius = 0;
            this.IfWensday.UncheckedState.BorderThickness = 0;
            this.IfWensday.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // IfThursday
            // 
            this.IfThursday.AutoSize = true;
            this.IfThursday.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IfThursday.CheckedState.BorderRadius = 0;
            this.IfThursday.CheckedState.BorderThickness = 0;
            this.IfThursday.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IfThursday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IfThursday.Location = new System.Drawing.Point(367, 200);
            this.IfThursday.Name = "IfThursday";
            this.IfThursday.Size = new System.Drawing.Size(92, 24);
            this.IfThursday.TabIndex = 27;
            this.IfThursday.Text = "Четверг";
            this.IfThursday.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.IfThursday.UncheckedState.BorderRadius = 0;
            this.IfThursday.UncheckedState.BorderThickness = 0;
            this.IfThursday.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // IfFriday
            // 
            this.IfFriday.AutoSize = true;
            this.IfFriday.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IfFriday.CheckedState.BorderRadius = 0;
            this.IfFriday.CheckedState.BorderThickness = 0;
            this.IfFriday.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IfFriday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IfFriday.Location = new System.Drawing.Point(367, 230);
            this.IfFriday.Name = "IfFriday";
            this.IfFriday.Size = new System.Drawing.Size(94, 24);
            this.IfFriday.TabIndex = 28;
            this.IfFriday.Text = "Пятница";
            this.IfFriday.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.IfFriday.UncheckedState.BorderRadius = 0;
            this.IfFriday.UncheckedState.BorderThickness = 0;
            this.IfFriday.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // IfSutarday
            // 
            this.IfSutarday.AutoSize = true;
            this.IfSutarday.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IfSutarday.CheckedState.BorderRadius = 0;
            this.IfSutarday.CheckedState.BorderThickness = 0;
            this.IfSutarday.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IfSutarday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IfSutarday.Location = new System.Drawing.Point(367, 260);
            this.IfSutarday.Name = "IfSutarday";
            this.IfSutarday.Size = new System.Drawing.Size(91, 24);
            this.IfSutarday.TabIndex = 29;
            this.IfSutarday.Text = "Суббота";
            this.IfSutarday.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.IfSutarday.UncheckedState.BorderRadius = 0;
            this.IfSutarday.UncheckedState.BorderThickness = 0;
            this.IfSutarday.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // IfSunday
            // 
            this.IfSunday.AutoSize = true;
            this.IfSunday.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IfSunday.CheckedState.BorderRadius = 0;
            this.IfSunday.CheckedState.BorderThickness = 0;
            this.IfSunday.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IfSunday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IfSunday.Location = new System.Drawing.Point(237, 290);
            this.IfSunday.Name = "IfSunday";
            this.IfSunday.Size = new System.Drawing.Size(126, 24);
            this.IfSunday.TabIndex = 30;
            this.IfSunday.Text = "Воскресенье";
            this.IfSunday.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.IfSunday.UncheckedState.BorderRadius = 0;
            this.IfSunday.UncheckedState.BorderThickness = 0;
            this.IfSunday.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // WorkingDaysCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IfSunday);
            this.Controls.Add(this.IfSutarday);
            this.Controls.Add(this.IfFriday);
            this.Controls.Add(this.IfThursday);
            this.Controls.Add(this.IfWensday);
            this.Controls.Add(this.IfTuesday);
            this.Controls.Add(this.IfMonday);
            this.Controls.Add(this.DayChoLabel);
            this.Controls.Add(this.TitelLabel);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.SecondDateLabel);
            this.Controls.Add(this.FirstDateLab);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.SecondDate);
            this.Controls.Add(this.FirstDate);
            this.Name = "WorkingDaysCounter";
            this.Size = new System.Drawing.Size(606, 583);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel TitelLabel;
        private Guna.UI2.WinForms.Guna2TextBox OutputTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel SecondDateLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel FirstDateLab;
        private Guna.UI2.WinForms.Guna2Button StartButton;
        private Guna.UI2.WinForms.Guna2DateTimePicker SecondDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker FirstDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel DayChoLabel;
        private Guna.UI2.WinForms.Guna2CheckBox IfMonday;
        private Guna.UI2.WinForms.Guna2CheckBox IfTuesday;
        private Guna.UI2.WinForms.Guna2CheckBox IfWensday;
        private Guna.UI2.WinForms.Guna2CheckBox IfThursday;
        private Guna.UI2.WinForms.Guna2CheckBox IfFriday;
        private Guna.UI2.WinForms.Guna2CheckBox IfSutarday;
        private Guna.UI2.WinForms.Guna2CheckBox IfSunday;
    }
}
