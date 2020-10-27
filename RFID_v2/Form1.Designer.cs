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
            this.btShow = new System.Windows.Forms.Button();
            this.btRead = new System.Windows.Forms.Button();
            this.btExport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFolder = new System.Windows.Forms.TextBox();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLog
            // 
            this.dgvLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.Location = new System.Drawing.Point(204, 3);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.Size = new System.Drawing.Size(596, 410);
            this.dgvLog.TabIndex = 1;
            // 
            // cbCom
            // 
            this.cbCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCom.FormattingEnabled = true;
            this.cbCom.Location = new System.Drawing.Point(76, 93);
            this.cbCom.Name = "cbCom";
            this.cbCom.Size = new System.Drawing.Size(121, 21);
            this.cbCom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(17, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM";
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(44, 164);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(122, 28);
            this.btStart.TabIndex = 4;
            this.btStart.Text = "START";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btOpenFIle
            // 
            this.btOpenFIle.Location = new System.Drawing.Point(13, 134);
            this.btOpenFIle.Name = "btOpenFIle";
            this.btOpenFIle.Size = new System.Drawing.Size(49, 24);
            this.btOpenFIle.TabIndex = 5;
            this.btOpenFIle.Text = "File";
            this.btOpenFIle.UseVisualStyleBackColor = true;
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(76, 134);
            this.tbPath.Multiline = true;
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(121, 24);
            this.tbPath.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbFileName);
            this.panel1.Controls.Add(this.tbFolder);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btExport);
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
            // btShow
            // 
            this.btShow.Location = new System.Drawing.Point(118, 215);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(65, 25);
            this.btShow.TabIndex = 8;
            this.btShow.Text = "SHOW";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(13, 215);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(69, 25);
            this.btRead.TabIndex = 7;
            this.btRead.Text = "READ";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // btExport
            // 
            this.btExport.Location = new System.Drawing.Point(62, 361);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(121, 25);
            this.btExport.TabIndex = 9;
            this.btExport.Text = "EXPORT";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 8);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 8);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(11, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Path";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "File name";
            // 
            // tbFolder
            // 
            this.tbFolder.Location = new System.Drawing.Point(62, 272);
            this.tbFolder.Multiline = true;
            this.tbFolder.Name = "tbFolder";
            this.tbFolder.Size = new System.Drawing.Size(121, 24);
            this.tbFolder.TabIndex = 14;
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(62, 316);
            this.tbFileName.Multiline = true;
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(121, 24);
            this.tbFileName.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 47);
            this.label4.TabIndex = 16;
            this.label4.Text = "Châm công di động";
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
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.TextBox tbFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

