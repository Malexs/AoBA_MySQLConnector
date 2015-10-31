namespace Bank_Assistant
{
    partial class SearchForm
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
            this.fnameLabel = new System.Windows.Forms.Label();
            this.fnameTBox = new System.Windows.Forms.TextBox();
            this.snameLabel = new System.Windows.Forms.Label();
            this.snameTBox = new System.Windows.Forms.TextBox();
            this.fatNameTBox = new System.Windows.Forms.TextBox();
            this.fathNameLabel = new System.Windows.Forms.Label();
            this.srchBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fnameLabel
            // 
            this.fnameLabel.AutoSize = true;
            this.fnameLabel.Location = new System.Drawing.Point(77, 7);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(55, 13);
            this.fnameLabel.TabIndex = 0;
            this.fnameLabel.Text = "First name";
            // 
            // fnameTBox
            // 
            this.fnameTBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.fnameTBox.Location = new System.Drawing.Point(48, 23);
            this.fnameTBox.MaxLength = 16;
            this.fnameTBox.Name = "fnameTBox";
            this.fnameTBox.Size = new System.Drawing.Size(122, 20);
            this.fnameTBox.TabIndex = 1;
            // 
            // snameLabel
            // 
            this.snameLabel.AutoSize = true;
            this.snameLabel.Location = new System.Drawing.Point(69, 46);
            this.snameLabel.Name = "snameLabel";
            this.snameLabel.Size = new System.Drawing.Size(73, 13);
            this.snameLabel.TabIndex = 2;
            this.snameLabel.Text = "Second name";
            // 
            // snameTBox
            // 
            this.snameTBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.snameTBox.Location = new System.Drawing.Point(48, 65);
            this.snameTBox.MaxLength = 32;
            this.snameTBox.Name = "snameTBox";
            this.snameTBox.Size = new System.Drawing.Size(122, 20);
            this.snameTBox.TabIndex = 3;
            // 
            // fatNameTBox
            // 
            this.fatNameTBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.fatNameTBox.Location = new System.Drawing.Point(48, 104);
            this.fatNameTBox.MaxLength = 16;
            this.fatNameTBox.Name = "fatNameTBox";
            this.fatNameTBox.Size = new System.Drawing.Size(122, 20);
            this.fatNameTBox.TabIndex = 5;
            // 
            // fathNameLabel
            // 
            this.fathNameLabel.AutoSize = true;
            this.fathNameLabel.Location = new System.Drawing.Point(69, 88);
            this.fathNameLabel.Name = "fathNameLabel";
            this.fathNameLabel.Size = new System.Drawing.Size(71, 13);
            this.fathNameLabel.TabIndex = 4;
            this.fathNameLabel.Text = "Fathers name";
            // 
            // srchBtn
            // 
            this.srchBtn.Location = new System.Drawing.Point(67, 130);
            this.srchBtn.Name = "srchBtn";
            this.srchBtn.Size = new System.Drawing.Size(75, 23);
            this.srchBtn.TabIndex = 6;
            this.srchBtn.Text = "Search";
            this.srchBtn.UseVisualStyleBackColor = true;
            this.srchBtn.Click += new System.EventHandler(this.srchBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(67, 159);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 200);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.srchBtn);
            this.Controls.Add(this.fatNameTBox);
            this.Controls.Add(this.fathNameLabel);
            this.Controls.Add(this.snameTBox);
            this.Controls.Add(this.snameLabel);
            this.Controls.Add(this.fnameTBox);
            this.Controls.Add(this.fnameLabel);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fnameLabel;
        private System.Windows.Forms.TextBox fnameTBox;
        private System.Windows.Forms.Label snameLabel;
        private System.Windows.Forms.TextBox snameTBox;
        private System.Windows.Forms.TextBox fatNameTBox;
        private System.Windows.Forms.Label fathNameLabel;
        private System.Windows.Forms.Button srchBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}