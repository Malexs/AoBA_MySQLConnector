namespace Bank_Assistant
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.infoGBox = new System.Windows.Forms.GroupBox();
            this.fatNameBox = new System.Windows.Forms.TextBox();
            this.sNameBox = new System.Windows.Forms.TextBox();
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.fatNameLabel = new System.Windows.Forms.Label();
            this.sNameLabel = new System.Windows.Forms.Label();
            this.fNameLabel = new System.Windows.Forms.Label();
            this.nextPageBtn = new System.Windows.Forms.Button();
            this.birthGBox = new System.Windows.Forms.GroupBox();
            this.isFemaleRBtn = new System.Windows.Forms.RadioButton();
            this.isMaleRBtn = new System.Windows.Forms.RadioButton();
            this.bplaceBox = new System.Windows.Forms.TextBox();
            this.bdayBox = new System.Windows.Forms.TextBox();
            this.bplaceLabel = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.bdayLabel = new System.Windows.Forms.Label();
            this.passportGBox = new System.Windows.Forms.GroupBox();
            this.issueTBox = new System.Windows.Forms.TextBox();
            this.issueLabel = new System.Windows.Forms.Label();
            this.authorityTBox = new System.Windows.Forms.TextBox();
            this.authLabel = new System.Windows.Forms.Label();
            this.idTBox = new System.Windows.Forms.TextBox();
            this.numberTBox = new System.Windows.Forms.TextBox();
            this.serieTBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.nmbLabel = new System.Windows.Forms.Label();
            this.serieLabel = new System.Windows.Forms.Label();
            this.addrGBox = new System.Windows.Forms.GroupBox();
            this.offTownComBox = new System.Windows.Forms.ComboBox();
            this.curTownComBox = new System.Windows.Forms.ComboBox();
            this.offAddrTBox = new System.Windows.Forms.TextBox();
            this.offAddrLabel = new System.Windows.Forms.Label();
            this.curAddrTBox = new System.Windows.Forms.TextBox();
            this.offTownLabel = new System.Windows.Forms.Label();
            this.curAddrLabel = new System.Windows.Forms.Label();
            this.curTownLabel = new System.Windows.Forms.Label();
            this.contactsGBox = new System.Windows.Forms.GroupBox();
            this.mailTBox = new System.Windows.Forms.TextBox();
            this.mPhoneTBox = new System.Windows.Forms.TextBox();
            this.hPhoneTBox = new System.Windows.Forms.TextBox();
            this.mailLabel = new System.Windows.Forms.Label();
            this.mPhoneLabel = new System.Windows.Forms.Label();
            this.hPhoneLabel = new System.Windows.Forms.Label();
            this.workGBox = new System.Windows.Forms.GroupBox();
            this.salaryTBox = new System.Windows.Forms.TextBox();
            this.posTBox = new System.Windows.Forms.TextBox();
            this.wplaceTBox = new System.Windows.Forms.TextBox();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.posLabel = new System.Windows.Forms.Label();
            this.wplaceLabel = new System.Windows.Forms.Label();
            this.socialGBox = new System.Windows.Forms.GroupBox();
            this.invalidComBox = new System.Windows.Forms.ComboBox();
            this.citizenComBox = new System.Windows.Forms.ComboBox();
            this.familyComBox = new System.Windows.Forms.ComboBox();
            this.isArmyCBox = new System.Windows.Forms.CheckBox();
            this.isOldmanCBox = new System.Windows.Forms.CheckBox();
            this.armyLabel = new System.Windows.Forms.Label();
            this.oldieLabel = new System.Windows.Forms.Label();
            this.invalidLabel = new System.Windows.Forms.Label();
            this.citLabel = new System.Windows.Forms.Label();
            this.familyLabel = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.updBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.infoGBox.SuspendLayout();
            this.birthGBox.SuspendLayout();
            this.passportGBox.SuspendLayout();
            this.addrGBox.SuspendLayout();
            this.contactsGBox.SuspendLayout();
            this.workGBox.SuspendLayout();
            this.socialGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoGBox
            // 
            this.infoGBox.Controls.Add(this.fatNameBox);
            this.infoGBox.Controls.Add(this.sNameBox);
            this.infoGBox.Controls.Add(this.fnameBox);
            this.infoGBox.Controls.Add(this.fatNameLabel);
            this.infoGBox.Controls.Add(this.sNameLabel);
            this.infoGBox.Controls.Add(this.fNameLabel);
            this.infoGBox.Location = new System.Drawing.Point(19, 26);
            this.infoGBox.Name = "infoGBox";
            this.infoGBox.Size = new System.Drawing.Size(311, 164);
            this.infoGBox.TabIndex = 1;
            this.infoGBox.TabStop = false;
            this.infoGBox.Text = "Info";
            // 
            // fatNameBox
            // 
            this.fatNameBox.Location = new System.Drawing.Point(100, 98);
            this.fatNameBox.MaxLength = 16;
            this.fatNameBox.Name = "fatNameBox";
            this.fatNameBox.Size = new System.Drawing.Size(205, 20);
            this.fatNameBox.TabIndex = 5;
            this.fatNameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noDigits_KeyPress);
            // 
            // sNameBox
            // 
            this.sNameBox.Location = new System.Drawing.Point(100, 64);
            this.sNameBox.MaxLength = 32;
            this.sNameBox.Name = "sNameBox";
            this.sNameBox.Size = new System.Drawing.Size(205, 20);
            this.sNameBox.TabIndex = 4;
            this.sNameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noDigits_KeyPress);
            // 
            // fnameBox
            // 
            this.fnameBox.Location = new System.Drawing.Point(100, 29);
            this.fnameBox.MaxLength = 16;
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(205, 20);
            this.fnameBox.TabIndex = 3;
            this.fnameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noDigits_KeyPress);
            // 
            // fatNameLabel
            // 
            this.fatNameLabel.AutoSize = true;
            this.fatNameLabel.Location = new System.Drawing.Point(6, 105);
            this.fatNameLabel.Name = "fatNameLabel";
            this.fatNameLabel.Size = new System.Drawing.Size(73, 13);
            this.fatNameLabel.TabIndex = 2;
            this.fatNameLabel.Text = "Father\'s name";
            // 
            // sNameLabel
            // 
            this.sNameLabel.AutoSize = true;
            this.sNameLabel.Location = new System.Drawing.Point(6, 67);
            this.sNameLabel.Name = "sNameLabel";
            this.sNameLabel.Size = new System.Drawing.Size(73, 13);
            this.sNameLabel.TabIndex = 1;
            this.sNameLabel.Text = "Second name";
            // 
            // fNameLabel
            // 
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.Location = new System.Drawing.Point(6, 32);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(55, 13);
            this.fNameLabel.TabIndex = 0;
            this.fNameLabel.Text = "First name";
            // 
            // nextPageBtn
            // 
            this.nextPageBtn.Location = new System.Drawing.Point(19, 247);
            this.nextPageBtn.Name = "nextPageBtn";
            this.nextPageBtn.Size = new System.Drawing.Size(75, 23);
            this.nextPageBtn.TabIndex = 10;
            this.nextPageBtn.Text = "Next";
            this.nextPageBtn.UseVisualStyleBackColor = true;
            this.nextPageBtn.Click += new System.EventHandler(this.nextPageBtn_Click);
            // 
            // birthGBox
            // 
            this.birthGBox.Controls.Add(this.isFemaleRBtn);
            this.birthGBox.Controls.Add(this.isMaleRBtn);
            this.birthGBox.Controls.Add(this.bplaceBox);
            this.birthGBox.Controls.Add(this.bdayBox);
            this.birthGBox.Controls.Add(this.bplaceLabel);
            this.birthGBox.Controls.Add(this.sexLabel);
            this.birthGBox.Controls.Add(this.bdayLabel);
            this.birthGBox.Location = new System.Drawing.Point(19, 26);
            this.birthGBox.Name = "birthGBox";
            this.birthGBox.Size = new System.Drawing.Size(311, 164);
            this.birthGBox.TabIndex = 2;
            this.birthGBox.TabStop = false;
            this.birthGBox.Text = "Birth";
            this.birthGBox.Visible = false;
            // 
            // isFemaleRBtn
            // 
            this.isFemaleRBtn.AutoSize = true;
            this.isFemaleRBtn.Location = new System.Drawing.Point(100, 75);
            this.isFemaleRBtn.Name = "isFemaleRBtn";
            this.isFemaleRBtn.Size = new System.Drawing.Size(59, 17);
            this.isFemaleRBtn.TabIndex = 2;
            this.isFemaleRBtn.Text = "Female";
            this.isFemaleRBtn.UseVisualStyleBackColor = true;
            // 
            // isMaleRBtn
            // 
            this.isMaleRBtn.AutoSize = true;
            this.isMaleRBtn.Checked = true;
            this.isMaleRBtn.Location = new System.Drawing.Point(100, 55);
            this.isMaleRBtn.Name = "isMaleRBtn";
            this.isMaleRBtn.Size = new System.Drawing.Size(48, 17);
            this.isMaleRBtn.TabIndex = 1;
            this.isMaleRBtn.TabStop = true;
            this.isMaleRBtn.Text = "Male";
            this.isMaleRBtn.UseVisualStyleBackColor = true;
            // 
            // bplaceBox
            // 
            this.bplaceBox.Location = new System.Drawing.Point(100, 29);
            this.bplaceBox.MaxLength = 16;
            this.bplaceBox.Name = "bplaceBox";
            this.bplaceBox.Size = new System.Drawing.Size(205, 20);
            this.bplaceBox.TabIndex = 0;
            this.bplaceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noDigits_KeyPress);
            // 
            // bdayBox
            // 
            this.bdayBox.ForeColor = System.Drawing.Color.Gray;
            this.bdayBox.Location = new System.Drawing.Point(100, 102);
            this.bdayBox.MaxLength = 10;
            this.bdayBox.Name = "bdayBox";
            this.bdayBox.Size = new System.Drawing.Size(205, 20);
            this.bdayBox.TabIndex = 3;
            this.bdayBox.Text = "yyyy-MM-dd";
            this.bdayBox.Enter += new System.EventHandler(this.dateBox_Enter);
            this.bdayBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dates_KeyPress);
            this.bdayBox.Leave += new System.EventHandler(this.dateBox_Leave);
            // 
            // bplaceLabel
            // 
            this.bplaceLabel.AutoSize = true;
            this.bplaceLabel.Location = new System.Drawing.Point(6, 32);
            this.bplaceLabel.Name = "bplaceLabel";
            this.bplaceLabel.Size = new System.Drawing.Size(54, 13);
            this.bplaceLabel.TabIndex = 2;
            this.bplaceLabel.Text = "Birthplace";
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Location = new System.Drawing.Point(6, 67);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(25, 13);
            this.sexLabel.TabIndex = 1;
            this.sexLabel.Text = "Sex";
            // 
            // bdayLabel
            // 
            this.bdayLabel.AutoSize = true;
            this.bdayLabel.Location = new System.Drawing.Point(6, 105);
            this.bdayLabel.Name = "bdayLabel";
            this.bdayLabel.Size = new System.Drawing.Size(45, 13);
            this.bdayLabel.TabIndex = 0;
            this.bdayLabel.Text = "Birthday";
            // 
            // passportGBox
            // 
            this.passportGBox.Controls.Add(this.issueTBox);
            this.passportGBox.Controls.Add(this.issueLabel);
            this.passportGBox.Controls.Add(this.authorityTBox);
            this.passportGBox.Controls.Add(this.authLabel);
            this.passportGBox.Controls.Add(this.idTBox);
            this.passportGBox.Controls.Add(this.numberTBox);
            this.passportGBox.Controls.Add(this.serieTBox);
            this.passportGBox.Controls.Add(this.idLabel);
            this.passportGBox.Controls.Add(this.nmbLabel);
            this.passportGBox.Controls.Add(this.serieLabel);
            this.passportGBox.Location = new System.Drawing.Point(19, 26);
            this.passportGBox.Name = "passportGBox";
            this.passportGBox.Size = new System.Drawing.Size(311, 190);
            this.passportGBox.TabIndex = 3;
            this.passportGBox.TabStop = false;
            this.passportGBox.Text = "Passport Info";
            this.passportGBox.Visible = false;
            // 
            // issueTBox
            // 
            this.issueTBox.ForeColor = System.Drawing.Color.Gray;
            this.issueTBox.Location = new System.Drawing.Point(100, 164);
            this.issueTBox.MaxLength = 10;
            this.issueTBox.Name = "issueTBox";
            this.issueTBox.Size = new System.Drawing.Size(205, 20);
            this.issueTBox.TabIndex = 9;
            this.issueTBox.Text = "yyyy-MM-dd";
            this.issueTBox.Enter += new System.EventHandler(this.dateBox_Enter);
            this.issueTBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dates_KeyPress);
            this.issueTBox.Leave += new System.EventHandler(this.dateBox_Leave);
            // 
            // issueLabel
            // 
            this.issueLabel.AutoSize = true;
            this.issueLabel.Location = new System.Drawing.Point(6, 167);
            this.issueLabel.Name = "issueLabel";
            this.issueLabel.Size = new System.Drawing.Size(69, 13);
            this.issueLabel.TabIndex = 8;
            this.issueLabel.Text = "Date of issue";
            // 
            // authorityTBox
            // 
            this.authorityTBox.Location = new System.Drawing.Point(100, 131);
            this.authorityTBox.MaxLength = 45;
            this.authorityTBox.Name = "authorityTBox";
            this.authorityTBox.Size = new System.Drawing.Size(205, 20);
            this.authorityTBox.TabIndex = 7;
            this.authorityTBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noDigits_KeyPress);
            // 
            // authLabel
            // 
            this.authLabel.AutoSize = true;
            this.authLabel.Location = new System.Drawing.Point(6, 134);
            this.authLabel.Name = "authLabel";
            this.authLabel.Size = new System.Drawing.Size(48, 13);
            this.authLabel.TabIndex = 6;
            this.authLabel.Text = "Authority";
            // 
            // idTBox
            // 
            this.idTBox.Location = new System.Drawing.Point(100, 98);
            this.idTBox.MaxLength = 14;
            this.idTBox.Name = "idTBox";
            this.idTBox.Size = new System.Drawing.Size(205, 20);
            this.idTBox.TabIndex = 5;
            // 
            // numberTBox
            // 
            this.numberTBox.Location = new System.Drawing.Point(100, 64);
            this.numberTBox.MaxLength = 7;
            this.numberTBox.Name = "numberTBox";
            this.numberTBox.Size = new System.Drawing.Size(205, 20);
            this.numberTBox.TabIndex = 4;
            this.numberTBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noLetters_KeyPress);
            // 
            // serieTBox
            // 
            this.serieTBox.Location = new System.Drawing.Point(100, 29);
            this.serieTBox.MaxLength = 2;
            this.serieTBox.Name = "serieTBox";
            this.serieTBox.Size = new System.Drawing.Size(205, 20);
            this.serieTBox.TabIndex = 3;
            this.serieTBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noDigits_KeyPress);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(6, 105);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "ID";
            // 
            // nmbLabel
            // 
            this.nmbLabel.AutoSize = true;
            this.nmbLabel.Location = new System.Drawing.Point(6, 67);
            this.nmbLabel.Name = "nmbLabel";
            this.nmbLabel.Size = new System.Drawing.Size(44, 13);
            this.nmbLabel.TabIndex = 1;
            this.nmbLabel.Text = "Number";
            // 
            // serieLabel
            // 
            this.serieLabel.AutoSize = true;
            this.serieLabel.Location = new System.Drawing.Point(6, 32);
            this.serieLabel.Name = "serieLabel";
            this.serieLabel.Size = new System.Drawing.Size(31, 13);
            this.serieLabel.TabIndex = 0;
            this.serieLabel.Text = "Serie";
            // 
            // addrGBox
            // 
            this.addrGBox.Controls.Add(this.offTownComBox);
            this.addrGBox.Controls.Add(this.curTownComBox);
            this.addrGBox.Controls.Add(this.offAddrTBox);
            this.addrGBox.Controls.Add(this.offAddrLabel);
            this.addrGBox.Controls.Add(this.curAddrTBox);
            this.addrGBox.Controls.Add(this.offTownLabel);
            this.addrGBox.Controls.Add(this.curAddrLabel);
            this.addrGBox.Controls.Add(this.curTownLabel);
            this.addrGBox.Location = new System.Drawing.Point(19, 26);
            this.addrGBox.Name = "addrGBox";
            this.addrGBox.Size = new System.Drawing.Size(311, 164);
            this.addrGBox.TabIndex = 4;
            this.addrGBox.TabStop = false;
            this.addrGBox.Text = "Addresses";
            this.addrGBox.Visible = false;
            // 
            // offTownComBox
            // 
            this.offTownComBox.FormattingEnabled = true;
            this.offTownComBox.Location = new System.Drawing.Point(100, 98);
            this.offTownComBox.Name = "offTownComBox";
            this.offTownComBox.Size = new System.Drawing.Size(205, 21);
            this.offTownComBox.TabIndex = 9;
            this.offTownComBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noDigits_KeyPress);
            // 
            // curTownComBox
            // 
            this.curTownComBox.Location = new System.Drawing.Point(100, 29);
            this.curTownComBox.MaxLength = 16;
            this.curTownComBox.Name = "curTownComBox";
            this.curTownComBox.Size = new System.Drawing.Size(205, 21);
            this.curTownComBox.TabIndex = 8;
            this.curTownComBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noDigits_KeyPress);
            // 
            // offAddrTBox
            // 
            this.offAddrTBox.Location = new System.Drawing.Point(100, 131);
            this.offAddrTBox.MaxLength = 32;
            this.offAddrTBox.Name = "offAddrTBox";
            this.offAddrTBox.Size = new System.Drawing.Size(205, 20);
            this.offAddrTBox.TabIndex = 7;
            // 
            // offAddrLabel
            // 
            this.offAddrLabel.AutoSize = true;
            this.offAddrLabel.Location = new System.Drawing.Point(6, 138);
            this.offAddrLabel.Name = "offAddrLabel";
            this.offAddrLabel.Size = new System.Drawing.Size(63, 13);
            this.offAddrLabel.TabIndex = 6;
            this.offAddrLabel.Text = "Official addr";
            // 
            // curAddrTBox
            // 
            this.curAddrTBox.Location = new System.Drawing.Point(100, 64);
            this.curAddrTBox.MaxLength = 32;
            this.curAddrTBox.Name = "curAddrTBox";
            this.curAddrTBox.Size = new System.Drawing.Size(205, 20);
            this.curAddrTBox.TabIndex = 4;
            // 
            // offTownLabel
            // 
            this.offTownLabel.AutoSize = true;
            this.offTownLabel.Location = new System.Drawing.Point(6, 105);
            this.offTownLabel.Name = "offTownLabel";
            this.offTownLabel.Size = new System.Drawing.Size(65, 13);
            this.offTownLabel.TabIndex = 2;
            this.offTownLabel.Text = "Official town";
            // 
            // curAddrLabel
            // 
            this.curAddrLabel.AutoSize = true;
            this.curAddrLabel.Location = new System.Drawing.Point(6, 67);
            this.curAddrLabel.Name = "curAddrLabel";
            this.curAddrLabel.Size = new System.Drawing.Size(65, 13);
            this.curAddrLabel.TabIndex = 1;
            this.curAddrLabel.Text = "Current addr";
            // 
            // curTownLabel
            // 
            this.curTownLabel.AutoSize = true;
            this.curTownLabel.Location = new System.Drawing.Point(6, 32);
            this.curTownLabel.Name = "curTownLabel";
            this.curTownLabel.Size = new System.Drawing.Size(71, 13);
            this.curTownLabel.TabIndex = 0;
            this.curTownLabel.Text = "Current Town";
            // 
            // contactsGBox
            // 
            this.contactsGBox.Controls.Add(this.mailTBox);
            this.contactsGBox.Controls.Add(this.mPhoneTBox);
            this.contactsGBox.Controls.Add(this.hPhoneTBox);
            this.contactsGBox.Controls.Add(this.mailLabel);
            this.contactsGBox.Controls.Add(this.mPhoneLabel);
            this.contactsGBox.Controls.Add(this.hPhoneLabel);
            this.contactsGBox.Location = new System.Drawing.Point(19, 26);
            this.contactsGBox.Name = "contactsGBox";
            this.contactsGBox.Size = new System.Drawing.Size(311, 164);
            this.contactsGBox.TabIndex = 5;
            this.contactsGBox.TabStop = false;
            this.contactsGBox.Text = "Contacts";
            this.contactsGBox.Visible = false;
            // 
            // mailTBox
            // 
            this.mailTBox.Location = new System.Drawing.Point(100, 98);
            this.mailTBox.MaxLength = 40;
            this.mailTBox.Name = "mailTBox";
            this.mailTBox.Size = new System.Drawing.Size(205, 20);
            this.mailTBox.TabIndex = 5;
            // 
            // mPhoneTBox
            // 
            this.mPhoneTBox.Location = new System.Drawing.Point(100, 64);
            this.mPhoneTBox.MaxLength = 15;
            this.mPhoneTBox.Name = "mPhoneTBox";
            this.mPhoneTBox.Size = new System.Drawing.Size(205, 20);
            this.mPhoneTBox.TabIndex = 4;
            this.mPhoneTBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noLetters_KeyPress);
            // 
            // hPhoneTBox
            // 
            this.hPhoneTBox.Location = new System.Drawing.Point(100, 29);
            this.hPhoneTBox.MaxLength = 15;
            this.hPhoneTBox.Name = "hPhoneTBox";
            this.hPhoneTBox.Size = new System.Drawing.Size(205, 20);
            this.hPhoneTBox.TabIndex = 3;
            this.hPhoneTBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noLetters_KeyPress);
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Location = new System.Drawing.Point(6, 105);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(61, 13);
            this.mailLabel.TabIndex = 2;
            this.mailLabel.Text = "E-mail (n/q)";
            // 
            // mPhoneLabel
            // 
            this.mPhoneLabel.AutoSize = true;
            this.mPhoneLabel.Location = new System.Drawing.Point(6, 67);
            this.mPhoneLabel.Name = "mPhoneLabel";
            this.mPhoneLabel.Size = new System.Drawing.Size(97, 13);
            this.mPhoneLabel.TabIndex = 1;
            this.mPhoneLabel.Text = "Mobile phone (n/q)";
            // 
            // hPhoneLabel
            // 
            this.hPhoneLabel.AutoSize = true;
            this.hPhoneLabel.Location = new System.Drawing.Point(6, 32);
            this.hPhoneLabel.Name = "hPhoneLabel";
            this.hPhoneLabel.Size = new System.Drawing.Size(94, 13);
            this.hPhoneLabel.TabIndex = 0;
            this.hPhoneLabel.Text = "Home phone (n/q)";
            // 
            // workGBox
            // 
            this.workGBox.Controls.Add(this.salaryTBox);
            this.workGBox.Controls.Add(this.posTBox);
            this.workGBox.Controls.Add(this.wplaceTBox);
            this.workGBox.Controls.Add(this.salaryLabel);
            this.workGBox.Controls.Add(this.posLabel);
            this.workGBox.Controls.Add(this.wplaceLabel);
            this.workGBox.Location = new System.Drawing.Point(19, 26);
            this.workGBox.Name = "workGBox";
            this.workGBox.Size = new System.Drawing.Size(311, 164);
            this.workGBox.TabIndex = 6;
            this.workGBox.TabStop = false;
            this.workGBox.Text = "Work";
            this.workGBox.Visible = false;
            // 
            // salaryTBox
            // 
            this.salaryTBox.Location = new System.Drawing.Point(100, 98);
            this.salaryTBox.MaxLength = 20;
            this.salaryTBox.Name = "salaryTBox";
            this.salaryTBox.Size = new System.Drawing.Size(205, 20);
            this.salaryTBox.TabIndex = 5;
            this.salaryTBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noLetters_KeyPress);
            // 
            // posTBox
            // 
            this.posTBox.Location = new System.Drawing.Point(100, 64);
            this.posTBox.MaxLength = 32;
            this.posTBox.Name = "posTBox";
            this.posTBox.Size = new System.Drawing.Size(205, 20);
            this.posTBox.TabIndex = 4;
            this.posTBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noDigits_KeyPress);
            // 
            // wplaceTBox
            // 
            this.wplaceTBox.Location = new System.Drawing.Point(100, 29);
            this.wplaceTBox.MaxLength = 16;
            this.wplaceTBox.Name = "wplaceTBox";
            this.wplaceTBox.Size = new System.Drawing.Size(205, 20);
            this.wplaceTBox.TabIndex = 3;
            this.wplaceTBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noDigits_KeyPress);
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(6, 105);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(62, 13);
            this.salaryLabel.TabIndex = 2;
            this.salaryLabel.Text = "Salary (n/q)";
            // 
            // posLabel
            // 
            this.posLabel.AutoSize = true;
            this.posLabel.Location = new System.Drawing.Point(6, 67);
            this.posLabel.Name = "posLabel";
            this.posLabel.Size = new System.Drawing.Size(70, 13);
            this.posLabel.TabIndex = 1;
            this.posLabel.Text = "Position (n/q)";
            // 
            // wplaceLabel
            // 
            this.wplaceLabel.AutoSize = true;
            this.wplaceLabel.Location = new System.Drawing.Point(6, 32);
            this.wplaceLabel.Name = "wplaceLabel";
            this.wplaceLabel.Size = new System.Drawing.Size(85, 13);
            this.wplaceLabel.TabIndex = 0;
            this.wplaceLabel.Text = "Workplace (n/q)";
            // 
            // socialGBox
            // 
            this.socialGBox.Controls.Add(this.invalidComBox);
            this.socialGBox.Controls.Add(this.citizenComBox);
            this.socialGBox.Controls.Add(this.familyComBox);
            this.socialGBox.Controls.Add(this.isArmyCBox);
            this.socialGBox.Controls.Add(this.isOldmanCBox);
            this.socialGBox.Controls.Add(this.armyLabel);
            this.socialGBox.Controls.Add(this.oldieLabel);
            this.socialGBox.Controls.Add(this.invalidLabel);
            this.socialGBox.Controls.Add(this.citLabel);
            this.socialGBox.Controls.Add(this.familyLabel);
            this.socialGBox.Location = new System.Drawing.Point(19, 26);
            this.socialGBox.Name = "socialGBox";
            this.socialGBox.Size = new System.Drawing.Size(311, 197);
            this.socialGBox.TabIndex = 7;
            this.socialGBox.TabStop = false;
            this.socialGBox.Text = "Social";
            this.socialGBox.Visible = false;
            // 
            // invalidComBox
            // 
            this.invalidComBox.FormattingEnabled = true;
            this.invalidComBox.Location = new System.Drawing.Point(100, 98);
            this.invalidComBox.Name = "invalidComBox";
            this.invalidComBox.Size = new System.Drawing.Size(195, 21);
            this.invalidComBox.TabIndex = 13;
            // 
            // citizenComBox
            // 
            this.citizenComBox.FormattingEnabled = true;
            this.citizenComBox.Location = new System.Drawing.Point(100, 64);
            this.citizenComBox.Name = "citizenComBox";
            this.citizenComBox.Size = new System.Drawing.Size(195, 21);
            this.citizenComBox.TabIndex = 12;
            this.citizenComBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noDigits_KeyPress);
            // 
            // familyComBox
            // 
            this.familyComBox.FormattingEnabled = true;
            this.familyComBox.Location = new System.Drawing.Point(100, 29);
            this.familyComBox.Name = "familyComBox";
            this.familyComBox.Size = new System.Drawing.Size(195, 21);
            this.familyComBox.TabIndex = 11;
            this.familyComBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noDigits_KeyPress);
            // 
            // isArmyCBox
            // 
            this.isArmyCBox.AutoSize = true;
            this.isArmyCBox.Location = new System.Drawing.Point(100, 166);
            this.isArmyCBox.Name = "isArmyCBox";
            this.isArmyCBox.Size = new System.Drawing.Size(48, 17);
            this.isArmyCBox.TabIndex = 10;
            this.isArmyCBox.Text = "True";
            this.isArmyCBox.UseVisualStyleBackColor = true;
            // 
            // isOldmanCBox
            // 
            this.isOldmanCBox.AutoSize = true;
            this.isOldmanCBox.Location = new System.Drawing.Point(100, 137);
            this.isOldmanCBox.Name = "isOldmanCBox";
            this.isOldmanCBox.Size = new System.Drawing.Size(48, 17);
            this.isOldmanCBox.TabIndex = 9;
            this.isOldmanCBox.Text = "True";
            this.isOldmanCBox.UseVisualStyleBackColor = true;
            // 
            // armyLabel
            // 
            this.armyLabel.AutoSize = true;
            this.armyLabel.Location = new System.Drawing.Point(6, 167);
            this.armyLabel.Name = "armyLabel";
            this.armyLabel.Size = new System.Drawing.Size(30, 13);
            this.armyLabel.TabIndex = 8;
            this.armyLabel.Text = "Army";
            // 
            // oldieLabel
            // 
            this.oldieLabel.AutoSize = true;
            this.oldieLabel.Location = new System.Drawing.Point(4, 134);
            this.oldieLabel.Name = "oldieLabel";
            this.oldieLabel.Size = new System.Drawing.Size(43, 13);
            this.oldieLabel.TabIndex = 6;
            this.oldieLabel.Text = "Oldman";
            // 
            // invalidLabel
            // 
            this.invalidLabel.AutoSize = true;
            this.invalidLabel.Location = new System.Drawing.Point(6, 101);
            this.invalidLabel.Name = "invalidLabel";
            this.invalidLabel.Size = new System.Drawing.Size(38, 13);
            this.invalidLabel.TabIndex = 2;
            this.invalidLabel.Text = "Invalid";
            // 
            // citLabel
            // 
            this.citLabel.AutoSize = true;
            this.citLabel.Location = new System.Drawing.Point(6, 67);
            this.citLabel.Name = "citLabel";
            this.citLabel.Size = new System.Drawing.Size(38, 13);
            this.citLabel.TabIndex = 1;
            this.citLabel.Text = "Citizen";
            // 
            // familyLabel
            // 
            this.familyLabel.AutoSize = true;
            this.familyLabel.Location = new System.Drawing.Point(6, 32);
            this.familyLabel.Name = "familyLabel";
            this.familyLabel.Size = new System.Drawing.Size(36, 13);
            this.familyLabel.TabIndex = 0;
            this.familyLabel.Text = "Family";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(130, 247);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 100;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(238, 247);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 101;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // updBtn
            // 
            this.updBtn.Location = new System.Drawing.Point(20, 218);
            this.updBtn.Name = "updBtn";
            this.updBtn.Size = new System.Drawing.Size(75, 23);
            this.updBtn.TabIndex = 102;
            this.updBtn.Text = "Update";
            this.updBtn.UseVisualStyleBackColor = true;
            this.updBtn.Click += new System.EventHandler(this.updBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(130, 218);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 103;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 292);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.updBtn);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.passportGBox);
            this.Controls.Add(this.contactsGBox);
            this.Controls.Add(this.workGBox);
            this.Controls.Add(this.addrGBox);
            this.Controls.Add(this.socialGBox);
            this.Controls.Add(this.birthGBox);
            this.Controls.Add(this.nextPageBtn);
            this.Controls.Add(this.infoGBox);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.Shown += new System.EventHandler(this.AddForm_Shown);
            this.infoGBox.ResumeLayout(false);
            this.infoGBox.PerformLayout();
            this.birthGBox.ResumeLayout(false);
            this.birthGBox.PerformLayout();
            this.passportGBox.ResumeLayout(false);
            this.passportGBox.PerformLayout();
            this.addrGBox.ResumeLayout(false);
            this.addrGBox.PerformLayout();
            this.contactsGBox.ResumeLayout(false);
            this.contactsGBox.PerformLayout();
            this.workGBox.ResumeLayout(false);
            this.workGBox.PerformLayout();
            this.socialGBox.ResumeLayout(false);
            this.socialGBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox infoGBox;
        private System.Windows.Forms.TextBox fatNameBox;
        private System.Windows.Forms.TextBox sNameBox;
        private System.Windows.Forms.TextBox fnameBox;
        private System.Windows.Forms.Label fatNameLabel;
        private System.Windows.Forms.Label sNameLabel;
        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.Button nextPageBtn;
        private System.Windows.Forms.GroupBox birthGBox;
        private System.Windows.Forms.TextBox bplaceBox;
        private System.Windows.Forms.TextBox bdayBox;
        private System.Windows.Forms.Label bplaceLabel;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Label bdayLabel;
        private System.Windows.Forms.GroupBox passportGBox;
        private System.Windows.Forms.TextBox idTBox;
        private System.Windows.Forms.TextBox numberTBox;
        private System.Windows.Forms.TextBox serieTBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nmbLabel;
        private System.Windows.Forms.Label serieLabel;
        private System.Windows.Forms.GroupBox addrGBox;
        private System.Windows.Forms.TextBox curAddrTBox;
        private System.Windows.Forms.Label offTownLabel;
        private System.Windows.Forms.Label curAddrLabel;
        private System.Windows.Forms.Label curTownLabel;
        private System.Windows.Forms.GroupBox contactsGBox;
        private System.Windows.Forms.TextBox mailTBox;
        private System.Windows.Forms.TextBox mPhoneTBox;
        private System.Windows.Forms.TextBox hPhoneTBox;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.Label mPhoneLabel;
        private System.Windows.Forms.Label hPhoneLabel;
        private System.Windows.Forms.TextBox offAddrTBox;
        private System.Windows.Forms.Label offAddrLabel;
        private System.Windows.Forms.GroupBox workGBox;
        private System.Windows.Forms.TextBox salaryTBox;
        private System.Windows.Forms.TextBox posTBox;
        private System.Windows.Forms.TextBox wplaceTBox;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.Label posLabel;
        private System.Windows.Forms.Label wplaceLabel;
        private System.Windows.Forms.GroupBox socialGBox;
        private System.Windows.Forms.Label invalidLabel;
        private System.Windows.Forms.Label citLabel;
        private System.Windows.Forms.Label familyLabel;
        private System.Windows.Forms.Label armyLabel;
        private System.Windows.Forms.Label oldieLabel;
        private System.Windows.Forms.CheckBox isArmyCBox;
        private System.Windows.Forms.CheckBox isOldmanCBox;
        private System.Windows.Forms.RadioButton isFemaleRBtn;
        private System.Windows.Forms.RadioButton isMaleRBtn;
        private System.Windows.Forms.TextBox issueTBox;
        private System.Windows.Forms.Label issueLabel;
        private System.Windows.Forms.TextBox authorityTBox;
        private System.Windows.Forms.Label authLabel;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ComboBox curTownComBox;
        private System.Windows.Forms.ComboBox offTownComBox;
        private System.Windows.Forms.ComboBox invalidComBox;
        private System.Windows.Forms.ComboBox citizenComBox;
        private System.Windows.Forms.ComboBox familyComBox;
        private System.Windows.Forms.Button updBtn;
        private System.Windows.Forms.Button SaveBtn;
    }
}