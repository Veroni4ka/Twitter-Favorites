namespace TwitterFavorites
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ddlTwitterAuthAccount = new System.Windows.Forms.ComboBox();
            this.cboxSaveToFile = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(436, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get Likes Info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(794, 469);
            this.dataGridView1.TabIndex = 1;
            // 
            // ddlTwitterAuthAccount
            // 
            this.ddlTwitterAuthAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTwitterAuthAccount.FormattingEnabled = true;
            this.ddlTwitterAuthAccount.Location = new System.Drawing.Point(12, 67);
            this.ddlTwitterAuthAccount.Name = "ddlTwitterAuthAccount";
            this.ddlTwitterAuthAccount.Size = new System.Drawing.Size(403, 21);
            this.ddlTwitterAuthAccount.TabIndex = 2;
            // 
            // cboxSaveToFile
            // 
            this.cboxSaveToFile.AutoSize = true;
            this.cboxSaveToFile.Location = new System.Drawing.Point(545, 67);
            this.cboxSaveToFile.Name = "cboxSaveToFile";
            this.cboxSaveToFile.Size = new System.Drawing.Size(82, 17);
            this.cboxSaveToFile.TabIndex = 3;
            this.cboxSaveToFile.Text = "Save to File";
            this.cboxSaveToFile.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Twitter Authentication Account";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 578);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxSaveToFile);
            this.Controls.Add(this.ddlTwitterAuthAccount);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Likes Info";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox ddlTwitterAuthAccount;
        private System.Windows.Forms.CheckBox cboxSaveToFile;
        private System.Windows.Forms.Label label1;
    }
}

