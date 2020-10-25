namespace RFID_v2
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
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.cbCom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.btOpenFIle = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btRead = new System.Windows.Forms.Button();
            this.btShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLog
            // 
            this.dgvLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.Location = new System.Drawing.Point(204, 12);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.Size = new System.Drawing.Size(596, 410);
            this.dgvLog.TabIndex = 1;
            // 
            // cbCom
            // 
            this.cbCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCom.FormattingEnabled = true;
            this.cbCom.Location = new System.Drawing.Point(76, 142);
            this.cbCom.Name = "cbCom";
            this.cbCom.Size = new System.Drawing.Size(121, 21);
            this.cbCom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(17, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM";
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(43, 218);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(122, 28);
            this.btStart.TabIndex = 4;
            this.btStart.Text = "START";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btOpenFIle
            // 
            this.btOpenFIle.Location = new System.Drawing.Point(13, 183);
            this.btOpenFIle.Name = "btOpenFIle";
            this.btOpenFIle.Size = new System.Drawing.Size(49, 24);
            this.btOpenFIle.TabIndex = 5;
            this.btOpenFIle.Text = "File";
            this.btOpenFIle.UseVisualStyleBackColor = true;
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(76, 183);
            this.tbPath.Multiline = true;
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(121, 24);
            this.tbPath.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btShow);
            this.panel1.Controls.Add(this.btRead);
            this.panel1.Controls.Add(this.tbPath);
            this.panel1.Controls.Add(this.btOpenFIle);
            this.panel1.Controls.Add(this.btStart);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbCom);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 410);
            this.panel1.TabIndex = 0;
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(43, 258);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(121, 25);
            this.btRead.TabIndex = 7;
            this.btRead.Text = "READ";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // btShow
            // 
            this.btShow.Location = new System.Drawing.Point(43, 303);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(121, 25);
            this.btShow.TabIndex = 8;
            this.btShow.Text = "SHOW";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 414);
            this.Controls.Add(this.dgvLog);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvLog;
        private System.Windows.Forms.ComboBox cbCom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btOpenFIle;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Button btShow;
    }
}

