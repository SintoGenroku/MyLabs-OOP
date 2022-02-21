namespace lab2
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
            this.FullName = new System.Windows.Forms.TextBox();
            this.AccCreationDate = new System.Windows.Forms.DateTimePicker();
            this.CommunicationServices = new System.Windows.Forms.GroupBox();
            this.NetBankingCheckBox = new System.Windows.Forms.CheckBox();
            this.SMSCheckBox = new System.Windows.Forms.CheckBox();
            this.BirthDate = new System.Windows.Forms.DateTimePicker();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ShortTermType = new System.Windows.Forms.RadioButton();
            this.LongTermType = new System.Windows.Forms.RadioButton();
            this.PerpetualType = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.ContributionTypes = new System.Windows.Forms.Label();
            this.LabelFullname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PassportInfo = new System.Windows.Forms.TextBox();
            this.Pasport = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Citizenship = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Cash = new System.Windows.Forms.TextBox();
            this.CashTrackBar = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.ClearOutputBox = new System.Windows.Forms.Button();
            this.CommunicationServices.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CashTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // FullName
            // 
            this.FullName.Location = new System.Drawing.Point(15, 97);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(300, 20);
            this.FullName.TabIndex = 0;
            // 
            // AccCreationDate
            // 
            this.AccCreationDate.Location = new System.Drawing.Point(331, 97);
            this.AccCreationDate.Name = "AccCreationDate";
            this.AccCreationDate.Size = new System.Drawing.Size(200, 20);
            this.AccCreationDate.TabIndex = 2;
            // 
            // CommunicationServices
            // 
            this.CommunicationServices.Controls.Add(this.NetBankingCheckBox);
            this.CommunicationServices.Controls.Add(this.SMSCheckBox);
            this.CommunicationServices.Location = new System.Drawing.Point(351, 235);
            this.CommunicationServices.Name = "CommunicationServices";
            this.CommunicationServices.Size = new System.Drawing.Size(200, 73);
            this.CommunicationServices.TabIndex = 8;
            this.CommunicationServices.TabStop = false;
            this.CommunicationServices.Text = "Информационные услуги";
            // 
            // NetBankingCheckBox
            // 
            this.NetBankingCheckBox.AutoSize = true;
            this.NetBankingCheckBox.Location = new System.Drawing.Point(6, 43);
            this.NetBankingCheckBox.Name = "NetBankingCheckBox";
            this.NetBankingCheckBox.Size = new System.Drawing.Size(194, 17);
            this.NetBankingCheckBox.TabIndex = 1;
            this.NetBankingCheckBox.Text = "Подключение интернет-банкинга";
            this.NetBankingCheckBox.UseVisualStyleBackColor = true;
            // 
            // SMSCheckBox
            // 
            this.SMSCheckBox.AutoSize = true;
            this.SMSCheckBox.Location = new System.Drawing.Point(7, 20);
            this.SMSCheckBox.Name = "SMSCheckBox";
            this.SMSCheckBox.Size = new System.Drawing.Size(184, 17);
            this.SMSCheckBox.TabIndex = 0;
            this.SMSCheckBox.Text = "Подключение смс-оповещения";
            this.SMSCheckBox.UseVisualStyleBackColor = true;
            // 
            // BirthDate
            // 
            this.BirthDate.Location = new System.Drawing.Point(15, 146);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(200, 20);
            this.BirthDate.TabIndex = 9;
            this.BirthDate.Value = new System.DateTime(2004, 1, 1, 10, 0, 0, 0);
            this.BirthDate.ValueChanged += new System.EventHandler(this.BirthDate_ValueChanged);
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RegistrationButton.Location = new System.Drawing.Point(591, 269);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(186, 30);
            this.RegistrationButton.TabIndex = 10;
            this.RegistrationButton.Text = "Зарегистрироваться";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ShortTermType);
            this.panel1.Controls.Add(this.LongTermType);
            this.panel1.Controls.Add(this.PerpetualType);
            this.panel1.Location = new System.Drawing.Point(588, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 81);
            this.panel1.TabIndex = 11;
            // 
            // ShortTermType
            // 
            this.ShortTermType.AutoSize = true;
            this.ShortTermType.Location = new System.Drawing.Point(3, 54);
            this.ShortTermType.Name = "ShortTermType";
            this.ShortTermType.Size = new System.Drawing.Size(109, 17);
            this.ShortTermType.TabIndex = 2;
            this.ShortTermType.Text = "Краткострочный";
            this.ShortTermType.UseVisualStyleBackColor = true;
            this.ShortTermType.CheckedChanged += new System.EventHandler(this.ContributionChanged);
            // 
            // LongTermType
            // 
            this.LongTermType.AutoSize = true;
            this.LongTermType.Location = new System.Drawing.Point(3, 31);
            this.LongTermType.Name = "LongTermType";
            this.LongTermType.Size = new System.Drawing.Size(105, 17);
            this.LongTermType.TabIndex = 1;
            this.LongTermType.Text = "Долгострочный";
            this.LongTermType.UseVisualStyleBackColor = true;
            this.LongTermType.CheckedChanged += new System.EventHandler(this.ContributionChanged);
            // 
            // PerpetualType
            // 
            this.PerpetualType.AutoSize = true;
            this.PerpetualType.Location = new System.Drawing.Point(3, 8);
            this.PerpetualType.Name = "PerpetualType";
            this.PerpetualType.Size = new System.Drawing.Size(87, 17);
            this.PerpetualType.TabIndex = 0;
            this.PerpetualType.TabStop = true;
            this.PerpetualType.Text = "Бессрочный";
            this.PerpetualType.UseVisualStyleBackColor = true;
            this.PerpetualType.CheckedChanged += new System.EventHandler(this.ContributionChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton8);
            this.panel2.Controls.Add(this.radioButton9);
            this.panel2.Location = new System.Drawing.Point(588, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 56);
            this.panel2.TabIndex = 12;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(3, 8);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(208, 17);
            this.radioButton8.TabIndex = 2;
            this.radioButton8.Text = "Фиксированная процентная ставка";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.InterestChanged);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(3, 31);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(186, 17);
            this.radioButton9.TabIndex = 1;
            this.radioButton9.Text = "Плавающая процентная ставка";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.InterestChanged);
            // 
            // ContributionTypes
            // 
            this.ContributionTypes.AutoSize = true;
            this.ContributionTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ContributionTypes.Location = new System.Drawing.Point(587, 78);
            this.ContributionTypes.Name = "ContributionTypes";
            this.ContributionTypes.Size = new System.Drawing.Size(98, 20);
            this.ContributionTypes.TabIndex = 20;
            this.ContributionTypes.Text = "Тип Вклада";
            // 
            // LabelFullname
            // 
            this.LabelFullname.AutoSize = true;
            this.LabelFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LabelFullname.Location = new System.Drawing.Point(14, 77);
            this.LabelFullname.Name = "LabelFullname";
            this.LabelFullname.Size = new System.Drawing.Size(47, 20);
            this.LabelFullname.TabIndex = 21;
            this.LabelFullname.Text = "ФИО";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(288, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "Добро пожаловать!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(260, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Введите данные для регистрации";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(14, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Дата рождения";
            // 
            // PassportInfo
            // 
            this.PassportInfo.Location = new System.Drawing.Point(15, 241);
            this.PassportInfo.Margin = new System.Windows.Forms.Padding(2);
            this.PassportInfo.Name = "PassportInfo";
            this.PassportInfo.Size = new System.Drawing.Size(300, 20);
            this.PassportInfo.TabIndex = 25;
            // 
            // Pasport
            // 
            this.Pasport.AutoSize = true;
            this.Pasport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Pasport.Location = new System.Drawing.Point(98, 192);
            this.Pasport.Name = "Pasport";
            this.Pasport.Size = new System.Drawing.Size(194, 24);
            this.Pasport.TabIndex = 26;
            this.Pasport.Text = "Паспортные данные";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(651, 392);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(126, 23);
            this.SaveButton.TabIndex = 27;
            this.SaveButton.Text = "Сохранить в файл";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveToJson_Click);
            // 
            // DownloadButton
            // 
            this.DownloadButton.Location = new System.Drawing.Point(651, 421);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(126, 23);
            this.DownloadButton.TabIndex = 28;
            this.DownloadButton.Text = "Загрузить из файла";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadFromJson_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(14, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Номер паспорта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(14, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Гражданство";
            // 
            // Citizenship
            // 
            this.Citizenship.Location = new System.Drawing.Point(15, 288);
            this.Citizenship.Margin = new System.Windows.Forms.Padding(2);
            this.Citizenship.Name = "Citizenship";
            this.Citizenship.Size = new System.Drawing.Size(300, 20);
            this.Citizenship.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(347, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Сумма вклада, USD";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Cash
            // 
            this.Cash.Enabled = false;
            this.Cash.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Cash.Location = new System.Drawing.Point(351, 155);
            this.Cash.Margin = new System.Windows.Forms.Padding(2);
            this.Cash.Name = "Cash";
            this.Cash.Size = new System.Drawing.Size(70, 20);
            this.Cash.TabIndex = 34;
            this.Cash.Text = "1000";
            // 
            // CashTrackBar
            // 
            this.CashTrackBar.Location = new System.Drawing.Point(331, 179);
            this.CashTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.CashTrackBar.Maximum = 1000000;
            this.CashTrackBar.Minimum = 1000;
            this.CashTrackBar.Name = "CashTrackBar";
            this.CashTrackBar.Size = new System.Drawing.Size(200, 45);
            this.CashTrackBar.TabIndex = 35;
            this.CashTrackBar.Value = 1000;
            this.CashTrackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label7.Location = new System.Drawing.Point(426, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = " USD";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(331, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Дата регистрации";
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(15, 319);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(630, 125);
            this.OutputBox.TabIndex = 38;
            this.OutputBox.Text = "";
            // 
            // ClearOutputBox
            // 
            this.ClearOutputBox.BackColor = System.Drawing.Color.Salmon;
            this.ClearOutputBox.Location = new System.Drawing.Point(651, 319);
            this.ClearOutputBox.Name = "ClearOutputBox";
            this.ClearOutputBox.Size = new System.Drawing.Size(75, 23);
            this.ClearOutputBox.TabIndex = 39;
            this.ClearOutputBox.Text = "Очистить";
            this.ClearOutputBox.UseVisualStyleBackColor = false;
            this.ClearOutputBox.Click += new System.EventHandler(this.ClearOutputBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClearOutputBox);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CashTrackBar);
            this.Controls.Add(this.Cash);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Citizenship);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.Pasport);
            this.Controls.Add(this.PassportInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelFullname);
            this.Controls.Add(this.ContributionTypes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.BirthDate);
            this.Controls.Add(this.CommunicationServices);
            this.Controls.Add(this.AccCreationDate);
            this.Controls.Add(this.FullName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CommunicationServices.ResumeLayout(false);
            this.CommunicationServices.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CashTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox FullName;
        public System.Windows.Forms.DateTimePicker AccCreationDate;
        public System.Windows.Forms.GroupBox CommunicationServices;
        public System.Windows.Forms.CheckBox NetBankingCheckBox;
        public System.Windows.Forms.CheckBox SMSCheckBox;
        public System.Windows.Forms.DateTimePicker BirthDate;
        public System.Windows.Forms.Button RegistrationButton;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.RadioButton ShortTermType;
        public System.Windows.Forms.RadioButton LongTermType;
        public System.Windows.Forms.RadioButton PerpetualType;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.RadioButton radioButton8;
        public System.Windows.Forms.RadioButton radioButton9;
        public System.Windows.Forms.Label ContributionTypes;
        public System.Windows.Forms.Label LabelFullname;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox PassportInfo;
        public System.Windows.Forms.Label Pasport;
        public System.Windows.Forms.Button SaveButton;
        public System.Windows.Forms.Button DownloadButton;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox Citizenship;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox Cash;
        public System.Windows.Forms.TrackBar CashTrackBar;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox OutputBox;
        private System.Windows.Forms.Button ClearOutputBox;
    }
}

