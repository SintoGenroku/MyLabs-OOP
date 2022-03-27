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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolsAboutButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Search = new System.Windows.Forms.ToolStripDropDownButton();
            this.SearchByFullname = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.FullnameToSearch = new System.Windows.Forms.ToolStripTextBox();
            this.нАЙТИToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchByCash = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.CashSize = new System.Windows.Forms.ToolStripTextBox();
            this.SearchByContribution = new System.Windows.Forms.ToolStripMenuItem();
            this.ContributionType = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SortTypeButton = new System.Windows.Forms.ToolStripSplitButton();
            this.поДатеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поТипуВкладаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveSearchResults = new System.Windows.Forms.ToolStripButton();
            this.CloneButton = new System.Windows.Forms.Button();
            this.BuilderUpdate = new System.Windows.Forms.Button();
            this.ListOfUsers = new System.Windows.Forms.ListBox();
            this.ChangeMemento = new System.Windows.Forms.Button();
            this.BackToMemento = new System.Windows.Forms.Button();
            this.NewCash = new System.Windows.Forms.MaskedTextBox();
            this.MakeVip = new System.Windows.Forms.Button();
            this.CommunicationServices.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CashTrackBar)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FullName
            // 
            this.FullName.Location = new System.Drawing.Point(13, 150);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(300, 20);
            this.FullName.TabIndex = 0;
            // 
            // AccCreationDate
            // 
            this.AccCreationDate.Location = new System.Drawing.Point(355, 122);
            this.AccCreationDate.Name = "AccCreationDate";
            this.AccCreationDate.Size = new System.Drawing.Size(200, 20);
            this.AccCreationDate.TabIndex = 2;
            // 
            // CommunicationServices
            // 
            this.CommunicationServices.Controls.Add(this.NetBankingCheckBox);
            this.CommunicationServices.Controls.Add(this.SMSCheckBox);
            this.CommunicationServices.Location = new System.Drawing.Point(375, 260);
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
            this.BirthDate.Location = new System.Drawing.Point(13, 199);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(200, 20);
            this.BirthDate.TabIndex = 9;
            this.BirthDate.Value = new System.DateTime(2004, 1, 1, 10, 0, 0, 0);
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RegistrationButton.Location = new System.Drawing.Point(638, 294);
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
            this.panel1.Location = new System.Drawing.Point(612, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 81);
            this.panel1.TabIndex = 11;
            // 
            // ShortTermType
            // 
            this.ShortTermType.AutoSize = true;
            this.ShortTermType.Location = new System.Drawing.Point(3, 54);
            this.ShortTermType.Name = "ShortTermType";
            this.ShortTermType.Size = new System.Drawing.Size(104, 17);
            this.ShortTermType.TabIndex = 2;
            this.ShortTermType.Text = "Краткосрочный";
            this.ShortTermType.UseVisualStyleBackColor = true;
            this.ShortTermType.CheckedChanged += new System.EventHandler(this.ContributionChanged);
            // 
            // LongTermType
            // 
            this.LongTermType.AutoSize = true;
            this.LongTermType.Location = new System.Drawing.Point(3, 31);
            this.LongTermType.Name = "LongTermType";
            this.LongTermType.Size = new System.Drawing.Size(100, 17);
            this.LongTermType.TabIndex = 1;
            this.LongTermType.Text = "Долгосрочный";
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
            this.PerpetualType.Text = "Бессрочный";
            this.PerpetualType.UseVisualStyleBackColor = true;
            this.PerpetualType.CheckedChanged += new System.EventHandler(this.ContributionChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton8);
            this.panel2.Controls.Add(this.radioButton9);
            this.panel2.Location = new System.Drawing.Point(612, 205);
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
            this.ContributionTypes.Location = new System.Drawing.Point(611, 103);
            this.ContributionTypes.Name = "ContributionTypes";
            this.ContributionTypes.Size = new System.Drawing.Size(98, 20);
            this.ContributionTypes.TabIndex = 20;
            this.ContributionTypes.Text = "Тип Вклада";
            // 
            // LabelFullname
            // 
            this.LabelFullname.AutoSize = true;
            this.LabelFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LabelFullname.Location = new System.Drawing.Point(12, 130);
            this.LabelFullname.Name = "LabelFullname";
            this.LabelFullname.Size = new System.Drawing.Size(47, 20);
            this.LabelFullname.TabIndex = 21;
            this.LabelFullname.Text = "ФИО";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(298, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "Добро пожаловать!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(270, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Введите данные для регистрации";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Дата рождения";
            // 
            // PassportInfo
            // 
            this.PassportInfo.Location = new System.Drawing.Point(12, 266);
            this.PassportInfo.Margin = new System.Windows.Forms.Padding(2);
            this.PassportInfo.Name = "PassportInfo";
            this.PassportInfo.Size = new System.Drawing.Size(300, 20);
            this.PassportInfo.TabIndex = 25;
            // 
            // Pasport
            // 
            this.Pasport.AutoSize = true;
            this.Pasport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Pasport.Location = new System.Drawing.Point(64, 220);
            this.Pasport.Name = "Pasport";
            this.Pasport.Size = new System.Drawing.Size(194, 24);
            this.Pasport.TabIndex = 26;
            this.Pasport.Text = "Паспортные данные";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(726, 34);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(126, 23);
            this.SaveButton.TabIndex = 27;
            this.SaveButton.Text = "Сохранить в файл";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveToJson_Click);
            // 
            // DownloadButton
            // 
            this.DownloadButton.Location = new System.Drawing.Point(726, 63);
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
            this.label4.Location = new System.Drawing.Point(11, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Номер паспорта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(11, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Гражданство";
            // 
            // Citizenship
            // 
            this.Citizenship.Location = new System.Drawing.Point(12, 313);
            this.Citizenship.Margin = new System.Windows.Forms.Padding(2);
            this.Citizenship.Name = "Citizenship";
            this.Citizenship.Size = new System.Drawing.Size(300, 20);
            this.Citizenship.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(371, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Сумма вклада, USD";
            // 
            // Cash
            // 
            this.Cash.Enabled = false;
            this.Cash.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Cash.Location = new System.Drawing.Point(375, 180);
            this.Cash.Margin = new System.Windows.Forms.Padding(2);
            this.Cash.Name = "Cash";
            this.Cash.Size = new System.Drawing.Size(70, 20);
            this.Cash.TabIndex = 34;
            this.Cash.Text = "1000";
            // 
            // CashTrackBar
            // 
            this.CashTrackBar.Location = new System.Drawing.Point(355, 204);
            this.CashTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.CashTrackBar.Maximum = 10000;
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
            this.label7.Location = new System.Drawing.Point(450, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = " USD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(355, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Дата регистрации";
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(12, 344);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(708, 125);
            this.OutputBox.TabIndex = 38;
            this.OutputBox.Text = "";
            // 
            // ClearOutputBox
            // 
            this.ClearOutputBox.BackColor = System.Drawing.Color.Salmon;
            this.ClearOutputBox.Location = new System.Drawing.Point(726, 446);
            this.ClearOutputBox.Name = "ClearOutputBox";
            this.ClearOutputBox.Size = new System.Drawing.Size(75, 23);
            this.ClearOutputBox.TabIndex = 39;
            this.ClearOutputBox.Text = "Очистить";
            this.ClearOutputBox.UseVisualStyleBackColor = false;
            this.ClearOutputBox.Click += new System.EventHandler(this.ClearOutputBox_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolsAboutButton,
            this.toolStripSeparator1,
            this.Search,
            this.toolStripSeparator2,
            this.SortTypeButton,
            this.toolStripSeparator3,
            this.toolStripButton4,
            this.toolStripSeparator4,
            this.toolStripButton5,
            this.toolStripSeparator5,
            this.SaveSearchResults});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(864, 25);
            this.toolStrip1.TabIndex = 40;
            this.toolStrip1.Text = "6";
            // 
            // ToolsAboutButton
            // 
            this.ToolsAboutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ToolsAboutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolsAboutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolsAboutButton.Name = "ToolsAboutButton";
            this.ToolsAboutButton.Size = new System.Drawing.Size(86, 22);
            this.ToolsAboutButton.Text = "О программе";
            this.ToolsAboutButton.Click += new System.EventHandler(this.ToolsAboutButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Search
            // 
            this.Search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Search.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchByFullname,
            this.SearchByCash,
            this.SearchByContribution});
            this.Search.Image = ((System.Drawing.Image)(resources.GetObject("Search.Image")));
            this.Search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(55, 22);
            this.Search.Text = "Поиск";
            // 
            // SearchByFullname
            // 
            this.SearchByFullname.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.FullnameToSearch,
            this.нАЙТИToolStripMenuItem});
            this.SearchByFullname.Name = "SearchByFullname";
            this.SearchByFullname.Size = new System.Drawing.Size(140, 22);
            this.SearchByFullname.Text = "по ФИО";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "Введите ФИО";
            // 
            // FullnameToSearch
            // 
            this.FullnameToSearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.FullnameToSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FullnameToSearch.Name = "FullnameToSearch";
            this.FullnameToSearch.Size = new System.Drawing.Size(200, 23);
            this.FullnameToSearch.TextChanged += new System.EventHandler(this.FullNameSearch);
            // 
            // нАЙТИToolStripMenuItem
            // 
            this.нАЙТИToolStripMenuItem.Name = "нАЙТИToolStripMenuItem";
            this.нАЙТИToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.нАЙТИToolStripMenuItem.Text = "НАЙТИ";
            // 
            // SearchByCash
            // 
            this.SearchByCash.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox2,
            this.CashSize});
            this.SearchByCash.Name = "SearchByCash";
            this.SearchByCash.Size = new System.Drawing.Size(140, 22);
            this.SearchByCash.Text = "по Балансу";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.ReadOnly = true;
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox2.Text = "Введите сумму";
            // 
            // CashSize
            // 
            this.CashSize.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CashSize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CashSize.Name = "CashSize";
            this.CashSize.Size = new System.Drawing.Size(140, 23);
            this.CashSize.TextChanged += new System.EventHandler(this.CashSearchChanged);
            // 
            // SearchByContribution
            // 
            this.SearchByContribution.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContributionType});
            this.SearchByContribution.Name = "SearchByContribution";
            this.SearchByContribution.Size = new System.Drawing.Size(140, 22);
            this.SearchByContribution.Text = "Типу вклада";
            // 
            // ContributionType
            // 
            this.ContributionType.Items.AddRange(new object[] {
            "Бессрочный",
            "Долгосрочный",
            "Краткосрочный"});
            this.ContributionType.Name = "ContributionType";
            this.ContributionType.Size = new System.Drawing.Size(121, 23);
            this.ContributionType.Text = "Выберите тип";
            this.ContributionType.TextChanged += new System.EventHandler(this.ContributionToSerachChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // SortTypeButton
            // 
            this.SortTypeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SortTypeButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поДатеToolStripMenuItem,
            this.поТипуВкладаToolStripMenuItem});
            this.SortTypeButton.Image = ((System.Drawing.Image)(resources.GetObject("SortTypeButton.Image")));
            this.SortTypeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SortTypeButton.Name = "SortTypeButton";
            this.SortTypeButton.Size = new System.Drawing.Size(89, 22);
            this.SortTypeButton.Text = "Сортировка";
            // 
            // поДатеToolStripMenuItem
            // 
            this.поДатеToolStripMenuItem.Name = "поДатеToolStripMenuItem";
            this.поДатеToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.поДатеToolStripMenuItem.Text = "по дате";
            this.поДатеToolStripMenuItem.Click += new System.EventHandler(this.SortByDate);
            // 
            // поТипуВкладаToolStripMenuItem
            // 
            this.поТипуВкладаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.поТипуВкладаToolStripMenuItem.Name = "поТипуВкладаToolStripMenuItem";
            this.поТипуВкладаToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.поТипуВкладаToolStripMenuItem.Text = "по типу вклада";
            this.поТипуВкладаToolStripMenuItem.Click += new System.EventHandler(this.ContributionToSerachChanged);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Бессрочный",
            "Долгосрочный",
            "Краткосрочный"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(63, 22);
            this.toolStripButton4.Text = "Очистить";
            this.toolStripButton4.Click += new System.EventHandler(this.ClearOutputBox_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(55, 22);
            this.toolStripButton5.Text = "Удалить";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // SaveSearchResults
            // 
            this.SaveSearchResults.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SaveSearchResults.Image = ((System.Drawing.Image)(resources.GetObject("SaveSearchResults.Image")));
            this.SaveSearchResults.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveSearchResults.Name = "SaveSearchResults";
            this.SaveSearchResults.Size = new System.Drawing.Size(70, 22);
            this.SaveSearchResults.Text = "Сохранить";
            this.SaveSearchResults.Click += new System.EventHandler(this.SaveSorted);
            // 
            // CloneButton
            // 
            this.CloneButton.Location = new System.Drawing.Point(726, 344);
            this.CloneButton.Name = "CloneButton";
            this.CloneButton.Size = new System.Drawing.Size(44, 29);
            this.CloneButton.TabIndex = 41;
            this.CloneButton.Text = "Клон";
            this.CloneButton.UseVisualStyleBackColor = true;
            this.CloneButton.Click += new System.EventHandler(this.CloneButton_Click);
            // 
            // BuilderUpdate
            // 
            this.BuilderUpdate.Location = new System.Drawing.Point(728, 381);
            this.BuilderUpdate.Name = "BuilderUpdate";
            this.BuilderUpdate.Size = new System.Drawing.Size(95, 48);
            this.BuilderUpdate.TabIndex = 42;
            this.BuilderUpdate.Text = "Изменить последнего пользователя";
            this.BuilderUpdate.UseVisualStyleBackColor = true;
            this.BuilderUpdate.Click += new System.EventHandler(this.BuilderUpdate_Click);
            // 
            // ListOfUsers
            // 
            this.ListOfUsers.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ListOfUsers.FormattingEnabled = true;
            this.ListOfUsers.Location = new System.Drawing.Point(12, 34);
            this.ListOfUsers.Name = "ListOfUsers";
            this.ListOfUsers.Size = new System.Drawing.Size(120, 82);
            this.ListOfUsers.TabIndex = 43;
            // 
            // ChangeMemento
            // 
            this.ChangeMemento.Location = new System.Drawing.Point(138, 60);
            this.ChangeMemento.Name = "ChangeMemento";
            this.ChangeMemento.Size = new System.Drawing.Size(89, 24);
            this.ChangeMemento.TabIndex = 44;
            this.ChangeMemento.Text = "изменить счет";
            this.ChangeMemento.UseVisualStyleBackColor = true;
            this.ChangeMemento.Click += new System.EventHandler(this.ChangeMemento_Click);
            // 
            // BackToMemento
            // 
            this.BackToMemento.Location = new System.Drawing.Point(138, 82);
            this.BackToMemento.Name = "BackToMemento";
            this.BackToMemento.Size = new System.Drawing.Size(89, 24);
            this.BackToMemento.TabIndex = 45;
            this.BackToMemento.Text = "вернуть счет";
            this.BackToMemento.UseVisualStyleBackColor = true;
            this.BackToMemento.Click += new System.EventHandler(this.BackToMemento_Click);
            // 
            // NewCash
            // 
            this.NewCash.Location = new System.Drawing.Point(138, 34);
            this.NewCash.Mask = "00000";
            this.NewCash.Name = "NewCash";
            this.NewCash.Size = new System.Drawing.Size(100, 20);
            this.NewCash.TabIndex = 47;
            this.NewCash.Text = "0";
            this.NewCash.ValidatingType = typeof(int);
            // 
            // MakeVip
            // 
            this.MakeVip.Location = new System.Drawing.Point(138, 105);
            this.MakeVip.Name = "MakeVip";
            this.MakeVip.Size = new System.Drawing.Size(89, 23);
            this.MakeVip.TabIndex = 49;
            this.MakeVip.Text = "рыцарь";
            this.MakeVip.UseVisualStyleBackColor = true;
            this.MakeVip.Click += new System.EventHandler(this.MakeVip_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(864, 481);
            this.Controls.Add(this.MakeVip);
            this.Controls.Add(this.NewCash);
            this.Controls.Add(this.BackToMemento);
            this.Controls.Add(this.ChangeMemento);
            this.Controls.Add(this.ListOfUsers);
            this.Controls.Add(this.BuilderUpdate);
            this.Controls.Add(this.CloneButton);
            this.Controls.Add(this.toolStrip1);
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
            this.Text = "Банк Dai Deneg";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CommunicationServices.ResumeLayout(false);
            this.CommunicationServices.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CashTrackBar)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ToolsAboutButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton SaveSearchResults;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSplitButton SortTypeButton;
        private System.Windows.Forms.ToolStripMenuItem поДатеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поТипуВкладаToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton Search;
        private System.Windows.Forms.ToolStripMenuItem SearchByFullname;
        private System.Windows.Forms.ToolStripMenuItem SearchByCash;
        private System.Windows.Forms.ToolStripMenuItem SearchByContribution;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox FullnameToSearch;
        private System.Windows.Forms.ToolStripMenuItem нАЙТИToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox ContributionType;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripTextBox CashSize;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.Button CloneButton;
        private System.Windows.Forms.Button BuilderUpdate;
        private System.Windows.Forms.ListBox ListOfUsers;
        private System.Windows.Forms.Button ChangeMemento;
        private System.Windows.Forms.Button BackToMemento;
        private System.Windows.Forms.MaskedTextBox NewCash;
        private System.Windows.Forms.Button MakeVip;
    }
}

