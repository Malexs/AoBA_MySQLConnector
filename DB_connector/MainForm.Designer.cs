namespace Bank_Assistant
{
    partial class MainForm
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
            ((System.ComponentModel.ISupportInitialize)(this.InfoDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AddInfoBtn
            // 
            this.AddInfoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddInfoBtn.Location = new System.Drawing.Point(12, 311);
            this.AddInfoBtn.Name = "AddInfoBtn";
            this.AddInfoBtn.Size = new System.Drawing.Size(88, 30);
            this.AddInfoBtn.TabIndex = 1;
            this.AddInfoBtn.Text = "add";
            this.AddInfoBtn.UseVisualStyleBackColor = true;
            this.AddInfoBtn.Click += new System.EventHandler(this.AddInfoBtn_Click);
            // 
            // GetInfoBtn
            // 
            this.GetInfoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GetInfoBtn.Location = new System.Drawing.Point(125, 313);
            this.GetInfoBtn.Name = "GetInfoBtn";
            this.GetInfoBtn.Size = new System.Drawing.Size(78, 27);
            this.GetInfoBtn.TabIndex = 2;
            this.GetInfoBtn.Text = "select";
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
            this.InfoDataGrid.Size = new System.Drawing.Size(423, 258);
            this.InfoDataGrid.TabIndex = 3;
            // 
            // UpdBtn
            // 
            this.UpdBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UpdBtn.Location = new System.Drawing.Point(228, 313);
            this.UpdBtn.Name = "UpdBtn";
            this.UpdBtn.Size = new System.Drawing.Size(64, 26);
            this.UpdBtn.TabIndex = 4;
            this.UpdBtn.Text = "update";
            this.UpdBtn.UseVisualStyleBackColor = true;
            this.UpdBtn.Click += new System.EventHandler(this.UpdBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DelBtn.Location = new System.Drawing.Point(315, 315);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(75, 23);
            this.DelBtn.TabIndex = 5;
            this.DelBtn.Text = "delete";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 353);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.UpdBtn);
            this.Controls.Add(this.InfoDataGrid);
            this.Controls.Add(this.GetInfoBtn);
            this.Controls.Add(this.AddInfoBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.InfoDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddInfoBtn;
        private System.Windows.Forms.Button GetInfoBtn;
        private System.Windows.Forms.DataGridView InfoDataGrid;
        private System.Windows.Forms.Button UpdBtn;
        private System.Windows.Forms.Button DelBtn;
    }
}

