namespace SeparateFiles
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnSelectFrom = new System.Windows.Forms.Button();
            this.InputFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InputTo = new System.Windows.Forms.TextBox();
            this.BtnSelectTo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnExec = new System.Windows.Forms.Button();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TextLog = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CheckCreateYearFolder = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InputTargetFiles = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSelectFrom
            // 
            this.BtnSelectFrom.Location = new System.Drawing.Point(537, 13);
            this.BtnSelectFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSelectFrom.Name = "BtnSelectFrom";
            this.BtnSelectFrom.Size = new System.Drawing.Size(75, 26);
            this.BtnSelectFrom.TabIndex = 1;
            this.BtnSelectFrom.Text = "選択";
            this.BtnSelectFrom.UseVisualStyleBackColor = true;
            this.BtnSelectFrom.Click += new System.EventHandler(this.BtnSelectFrom_Click);
            // 
            // InputFrom
            // 
            this.InputFrom.Location = new System.Drawing.Point(98, 13);
            this.InputFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputFrom.Name = "InputFrom";
            this.InputFrom.Size = new System.Drawing.Size(433, 26);
            this.InputFrom.TabIndex = 0;
            this.InputFrom.TextChanged += new System.EventHandler(this.Reset);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "対象フォルダ";
            // 
            // InputTo
            // 
            this.InputTo.Location = new System.Drawing.Point(98, 47);
            this.InputTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputTo.Name = "InputTo";
            this.InputTo.Size = new System.Drawing.Size(433, 26);
            this.InputTo.TabIndex = 2;
            this.InputTo.TextChanged += new System.EventHandler(this.Reset);
            // 
            // BtnSelectTo
            // 
            this.BtnSelectTo.Location = new System.Drawing.Point(537, 47);
            this.BtnSelectTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSelectTo.Name = "BtnSelectTo";
            this.BtnSelectTo.Size = new System.Drawing.Size(75, 26);
            this.BtnSelectTo.TabIndex = 3;
            this.BtnSelectTo.Text = "選択";
            this.BtnSelectTo.UseVisualStyleBackColor = true;
            this.BtnSelectTo.Click += new System.EventHandler(this.BtnSelectTo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "出力フォルダ";
            // 
            // BtnExec
            // 
            this.BtnExec.Enabled = false;
            this.BtnExec.Location = new System.Drawing.Point(537, 87);
            this.BtnExec.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.BtnExec.Name = "BtnExec";
            this.BtnExec.Size = new System.Drawing.Size(75, 26);
            this.BtnExec.TabIndex = 6;
            this.BtnExec.Text = "実行";
            this.BtnExec.UseVisualStyleBackColor = true;
            this.BtnExec.Click += new System.EventHandler(this.BtnExec_Click);
            // 
            // BtnCheck
            // 
            this.BtnCheck.Location = new System.Drawing.Point(456, 87);
            this.BtnCheck.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(75, 26);
            this.BtnCheck.TabIndex = 5;
            this.BtnCheck.Text = "確認";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 119);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 190);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TextLog);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(592, 158);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "出力ログ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TextLog
            // 
            this.TextLog.BackColor = System.Drawing.SystemColors.Window;
            this.TextLog.Location = new System.Drawing.Point(0, 0);
            this.TextLog.Multiline = true;
            this.TextLog.Name = "TextLog";
            this.TextLog.ReadOnly = true;
            this.TextLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextLog.Size = new System.Drawing.Size(592, 158);
            this.TextLog.TabIndex = 0;
            this.TextLog.TabStop = false;
            this.TextLog.Text = "Welcome!!";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CheckCreateYearFolder);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.InputTargetFiles);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(592, 162);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "設定";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CheckCreateYearFolder
            // 
            this.CheckCreateYearFolder.AutoSize = true;
            this.CheckCreateYearFolder.Location = new System.Drawing.Point(6, 38);
            this.CheckCreateYearFolder.Name = "CheckCreateYearFolder";
            this.CheckCreateYearFolder.Size = new System.Drawing.Size(138, 23);
            this.CheckCreateYearFolder.TabIndex = 1;
            this.CheckCreateYearFolder.Text = "西暦フォルダを作成";
            this.CheckCreateYearFolder.UseVisualStyleBackColor = true;
            this.CheckCreateYearFolder.CheckStateChanged += new System.EventHandler(this.Reset);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "対象ファイル";
            // 
            // InputTargetFiles
            // 
            this.InputTargetFiles.Location = new System.Drawing.Point(90, 6);
            this.InputTargetFiles.Name = "InputTargetFiles";
            this.InputTargetFiles.Size = new System.Drawing.Size(496, 26);
            this.InputTargetFiles.TabIndex = 0;
            this.InputTargetFiles.Text = "*.jpg;*.png;*.dng";
            this.InputTargetFiles.TextChanged += new System.EventHandler(this.Reset);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.BtnExec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSelectTo);
            this.Controls.Add(this.InputTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputFrom);
            this.Controls.Add(this.BtnSelectFrom);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(640, 360);
            this.MinimumSize = new System.Drawing.Size(640, 360);
            this.Name = "Form1";
            this.Text = "SeparateFiles";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnSelectFrom;
        private TextBox InputFrom;
        private Label label1;
        private TextBox InputTo;
        private Button BtnSelectTo;
        private Label label2;
        private Button BtnExec;
        private Button BtnCheck;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox TextLog;
        private TabPage tabPage2;
        private CheckBox CheckCreateYearFolder;
        private Label label3;
        private TextBox InputTargetFiles;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}