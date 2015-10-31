namespace Bank_Assistant
{
    partial class UserForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddInfoBtn = new System.Windows.Forms.Button();
            this.GetInfoBtn = new System.Windows.Forms.Button();
            this.InfoDataGrid = new System.Windows.Forms.DataGridView();
            this.UpdBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.SelectBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InfoDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AddInfoBtn
            // 
            this.AddInfoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddInfoBtn.Location = new System.Drawing.Point(9, 195);
            this.AddInfoBtn.Name = "AddInfoBtn";
            this.AddInfoBtn.Size = new System.Drawing.Size(88, 30);
            this.AddInfoBtn.TabIndex = 1;
            this.AddInfoBtn.Text = "Add new";
            this.AddInfoBtn.UseVisualStyleBackColor = true;
            this.AddInfoBtn.Click += new System.EventHandler(this.AddInfoBtn_Click);
            // 
            // GetInfoBtn
            // 
            this.GetInfoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GetInfoBtn.Location = new System.Drawing.Point(103, 195);
            this.GetInfoBtn.Name = "GetInfoBtn";
            this.GetInfoBtn.Size = new System.Drawing.Size(88, 30);
            this.GetInfoBtn.TabIndex = 2;
            this.GetInfoBtn.Text = "Show all";
            this.GetInfoBtn.UseVisualStyleBackColor = true;
            this.GetInfoBtn.Click += new System.EventHandler(this.ShowInfoBtn_Click);
            // 
            // InfoDataGrid
            // 
            this.InfoDataGrid.AllowUserToAddRows = false;
            this.InfoDataGrid.AllowUserToDeleteRows = false;
            this.InfoDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InfoDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.InfoDataGrid.Location = new System.Drawing.Point(9, 7);
            this.InfoDataGrid.Name = "InfoDataGrid";
            this.InfoDataGrid.RowHeadersVisible = false;
            this.InfoDataGrid.Size = new System.Drawing.Size(652, 182);
            this.InfoDataGrid.TabIndex = 3;
            // 
            // UpdBtn
            // 
            this.UpdBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdBtn.Location = new System.Drawing.Point(197, 195);
            this.UpdBtn.Name = "UpdBtn";
            this.UpdBtn.Size = new System.Drawing.Size(88, 30);
            this.UpdBtn.TabIndex = 4;
            this.UpdBtn.Text = "Update";
            this.UpdBtn.UseVisualStyleBackColor = true;
            this.UpdBtn.Click += new System.EventHandler(this.UpdBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DelBtn.Location = new System.Drawing.Point(291, 195);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(88, 30);
            this.DelBtn.TabIndex = 5;
            this.DelBtn.Text = "Delete";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.Location = new System.Drawing.Point(385, 195);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(88, 30);
            this.searchBtn.TabIndex = 6;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // SelectBtn
            // 
            this.SelectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectBtn.Location = new System.Drawing.Point(479, 195);
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.Size = new System.Drawing.Size(88, 30);
            this.SelectBtn.TabIndex = 7;
            this.SelectBtn.Text = "Select";
            this.SelectBtn.UseVisualStyleBackColor = true;
            this.SelectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.Location = new System.Drawing.Point(573, 195);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(88, 30);
            this.CancelBtn.TabIndex = 8;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 240);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SelectBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.UpdBtn);
            this.Controls.Add(this.InfoDataGrid);
            this.Controls.Add(this.GetInfoBtn);
            this.Controls.Add(this.AddInfoBtn);
            this.Name = "UserForm";
            this.Text = "Bank Assistant";
            ((System.ComponentModel.ISupportInitialize)(this.InfoDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddInfoBtn;
        private System.Windows.Forms.Button GetInfoBtn;
        private System.Windows.Forms.DataGridView InfoDataGrid;
        private System.Windows.Forms.Button UpdBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button SelectBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}

