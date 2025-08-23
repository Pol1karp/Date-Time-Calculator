namespace Date_Time_Calculator
{
    partial class TimeConverter
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
            this.FirstChoice = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SecondChoice = new Guna.UI2.WinForms.Guna2ComboBox();
            this.HowMuchLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.HowMuchLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.AmoundOfTime = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.IntLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.OutputTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.StartButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.AmoundOfTime)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstChoice
            // 
            this.FirstChoice.BackColor = System.Drawing.Color.Transparent;
            this.FirstChoice.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FirstChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FirstChoice.FillColor = System.Drawing.Color.Gray;
            this.FirstChoice.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FirstChoice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FirstChoice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FirstChoice.ForeColor = System.Drawing.Color.White;
            this.FirstChoice.ItemHeight = 30;
            this.FirstChoice.Items.AddRange(new object[] {
            "Лет",
            "Месяцев",
            "Дней",
            "Часов",
            "Минут",
            "Секунд"});
            this.FirstChoice.Location = new System.Drawing.Point(39, 130);
            this.FirstChoice.Name = "FirstChoice";
            this.FirstChoice.Size = new System.Drawing.Size(230, 36);
            this.FirstChoice.StartIndex = 0;
            this.FirstChoice.TabIndex = 0;
            // 
            // SecondChoice
            // 
            this.SecondChoice.BackColor = System.Drawing.Color.Transparent;
            this.SecondChoice.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SecondChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SecondChoice.FillColor = System.Drawing.Color.Gray;
            this.SecondChoice.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SecondChoice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SecondChoice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SecondChoice.ForeColor = System.Drawing.Color.White;
            this.SecondChoice.ItemHeight = 30;
            this.SecondChoice.Items.AddRange(new object[] {
            "Лет",
            "Месяцев",
            "Дней",
            "Часов",
            "Минут",
            "Секунд"});
            this.SecondChoice.Location = new System.Drawing.Point(367, 130);
            this.SecondChoice.Name = "SecondChoice";
            this.SecondChoice.Size = new System.Drawing.Size(230, 36);
            this.SecondChoice.StartIndex = 0;
            this.SecondChoice.TabIndex = 1;
            // 
            // HowMuchLabel
            // 
            this.HowMuchLabel.BackColor = System.Drawing.Color.Transparent;
            this.HowMuchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HowMuchLabel.Location = new System.Drawing.Point(39, 102);
            this.HowMuchLabel.Name = "HowMuchLabel";
            this.HowMuchLabel.Size = new System.Drawing.Size(71, 22);
            this.HowMuchLabel.TabIndex = 20;
            this.HowMuchLabel.Text = "Сколько:";
            // 
            // HowMuchLabel2
            // 
            this.HowMuchLabel2.BackColor = System.Drawing.Color.Transparent;
            this.HowMuchLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HowMuchLabel2.Location = new System.Drawing.Point(367, 102);
            this.HowMuchLabel2.Name = "HowMuchLabel2";
            this.HowMuchLabel2.Size = new System.Drawing.Size(18, 22);
            this.HowMuchLabel2.TabIndex = 21;
            this.HowMuchLabel2.Text = "В:";
            // 
            // AmoundOfTime
            // 
            this.AmoundOfTime.BackColor = System.Drawing.Color.Transparent;
            this.AmoundOfTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AmoundOfTime.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AmoundOfTime.Location = new System.Drawing.Point(179, 249);
            this.AmoundOfTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AmoundOfTime.Name = "AmoundOfTime";
            this.AmoundOfTime.Size = new System.Drawing.Size(230, 36);
            this.AmoundOfTime.TabIndex = 23;
            this.AmoundOfTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // IntLabel
            // 
            this.IntLabel.BackColor = System.Drawing.Color.Transparent;
            this.IntLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IntLabel.Location = new System.Drawing.Point(179, 221);
            this.IntLabel.Name = "IntLabel";
            this.IntLabel.Size = new System.Drawing.Size(167, 22);
            this.IntLabel.TabIndex = 24;
            this.IntLabel.Text = "Количество времени:";
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
            this.OutputTextBox.TabIndex = 26;
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
            this.StartButton.Size = new System.Drawing.Size(206, 45);
            this.StartButton.TabIndex = 25;
            this.StartButton.Text = "Измерить";
            this.StartButton.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(219, 23);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(106, 22);
            this.guna2HtmlLabel4.TabIndex = 27;
            this.guna2HtmlLabel4.Text = "TimeConverter";
            // 
            // TimeConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.IntLabel);
            this.Controls.Add(this.AmoundOfTime);
            this.Controls.Add(this.HowMuchLabel2);
            this.Controls.Add(this.HowMuchLabel);
            this.Controls.Add(this.SecondChoice);
            this.Controls.Add(this.FirstChoice);
            this.Name = "TimeConverter";
            this.Size = new System.Drawing.Size(606, 583);
            ((System.ComponentModel.ISupportInitialize)(this.AmoundOfTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox FirstChoice;
        private Guna.UI2.WinForms.Guna2ComboBox SecondChoice;
        private Guna.UI2.WinForms.Guna2HtmlLabel HowMuchLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel HowMuchLabel2;
        private Guna.UI2.WinForms.Guna2NumericUpDown AmoundOfTime;
        private Guna.UI2.WinForms.Guna2HtmlLabel IntLabel;
        private Guna.UI2.WinForms.Guna2TextBox OutputTextBox;
        private Guna.UI2.WinForms.Guna2Button StartButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
    }
}
