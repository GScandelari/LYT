namespace LogYourTime
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblCaseID = new System.Windows.Forms.Label();
            this.txbCaseID = new System.Windows.Forms.TextBox();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.boxLogs = new System.Windows.Forms.GroupBox();
            this.txbLogs = new System.Windows.Forms.RichTextBox();
            this.boxField = new System.Windows.Forms.GroupBox();
            this.lblDateTime_Date = new System.Windows.Forms.Label();
            this.btnSaveLogs = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsddBtn_option = new System.Windows.Forms.ToolStripDropDownButton();
            this.disclaimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceCodeOnGitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tslblSaveStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.boxLogs.SuspendLayout();
            this.boxField.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCaseID
            // 
            this.lblCaseID.AutoSize = true;
            this.lblCaseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaseID.Location = new System.Drawing.Point(32, 22);
            this.lblCaseID.Name = "lblCaseID";
            this.lblCaseID.Size = new System.Drawing.Size(52, 13);
            this.lblCaseID.TabIndex = 0;
            this.lblCaseID.Text = "Case ID";
            // 
            // txbCaseID
            // 
            this.txbCaseID.Location = new System.Drawing.Point(93, 19);
            this.txbCaseID.Name = "txbCaseID";
            this.txbCaseID.Size = new System.Drawing.Size(191, 20);
            this.txbCaseID.TabIndex = 1;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(23, 48);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(61, 13);
            this.lblDateTime.TabIndex = 2;
            this.lblDateTime.Text = "DateTime";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(35, 71);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(60, 52);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(101, 71);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(60, 52);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(166, 71);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(60, 52);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // boxLogs
            // 
            this.boxLogs.Controls.Add(this.txbLogs);
            this.boxLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxLogs.Location = new System.Drawing.Point(13, 148);
            this.boxLogs.Name = "boxLogs";
            this.boxLogs.Size = new System.Drawing.Size(323, 176);
            this.boxLogs.TabIndex = 7;
            this.boxLogs.TabStop = false;
            this.boxLogs.Text = "Logs";
            // 
            // txbLogs
            // 
            this.txbLogs.DetectUrls = false;
            this.txbLogs.Location = new System.Drawing.Point(7, 20);
            this.txbLogs.Name = "txbLogs";
            this.txbLogs.ReadOnly = true;
            this.txbLogs.Size = new System.Drawing.Size(310, 150);
            this.txbLogs.TabIndex = 7;
            this.txbLogs.Text = "";
            this.txbLogs.WordWrap = false;
            this.txbLogs.TabStopChanged += new System.EventHandler(this.TxbLogs_TextChanged);
            this.txbLogs.TextChanged += new System.EventHandler(this.TxbLogs_TextChanged);
            // 
            // boxField
            // 
            this.boxField.Controls.Add(this.lblDateTime_Date);
            this.boxField.Controls.Add(this.btnSaveLogs);
            this.boxField.Controls.Add(this.btnStop);
            this.boxField.Controls.Add(this.lblCaseID);
            this.boxField.Controls.Add(this.btnPause);
            this.boxField.Controls.Add(this.lblDateTime);
            this.boxField.Controls.Add(this.txbCaseID);
            this.boxField.Controls.Add(this.btnStart);
            this.boxField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxField.Location = new System.Drawing.Point(13, 13);
            this.boxField.Name = "boxField";
            this.boxField.Size = new System.Drawing.Size(323, 129);
            this.boxField.TabIndex = 8;
            this.boxField.TabStop = false;
            this.boxField.Text = "Control";
            // 
            // lblDateTime_Date
            // 
            this.lblDateTime_Date.AutoSize = true;
            this.lblDateTime_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime_Date.Location = new System.Drawing.Point(90, 48);
            this.lblDateTime_Date.Name = "lblDateTime_Date";
            this.lblDateTime_Date.Size = new System.Drawing.Size(30, 13);
            this.lblDateTime_Date.TabIndex = 7;
            this.lblDateTime_Date.Text = "Date";
            // 
            // btnSaveLogs
            // 
            this.btnSaveLogs.Location = new System.Drawing.Point(232, 71);
            this.btnSaveLogs.Name = "btnSaveLogs";
            this.btnSaveLogs.Size = new System.Drawing.Size(60, 52);
            this.btnSaveLogs.TabIndex = 6;
            this.btnSaveLogs.Text = "Save Logs";
            this.btnSaveLogs.UseVisualStyleBackColor = true;
            this.btnSaveLogs.Click += new System.EventHandler(this.BtnSaveLogs_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddBtn_option,
            this.tslblSaveStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 330);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(348, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsddBtn_option
            // 
            this.tsddBtn_option.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddBtn_option.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disclaimerToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.sourceCodeOnGitHubToolStripMenuItem});
            this.tsddBtn_option.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddBtn_option.Name = "tsddBtn_option";
            this.tsddBtn_option.Size = new System.Drawing.Size(62, 20);
            this.tsddBtn_option.Text = "Options";
            // 
            // disclaimerToolStripMenuItem
            // 
            this.disclaimerToolStripMenuItem.Name = "disclaimerToolStripMenuItem";
            this.disclaimerToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.disclaimerToolStripMenuItem.Text = "Disclaimer";
            this.disclaimerToolStripMenuItem.Click += new System.EventHandler(this.DisclaimerToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // sourceCodeOnGitHubToolStripMenuItem
            // 
            this.sourceCodeOnGitHubToolStripMenuItem.Name = "sourceCodeOnGitHubToolStripMenuItem";
            this.sourceCodeOnGitHubToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.sourceCodeOnGitHubToolStripMenuItem.Text = "Source Code on GitHub";
            this.sourceCodeOnGitHubToolStripMenuItem.Click += new System.EventHandler(this.SourceCodeOnGitHubToolStripMenuItem_Click);
            // 
            // tslblSaveStatus
            // 
            this.tslblSaveStatus.Name = "tslblSaveStatus";
            this.tslblSaveStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 352);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.boxField);
            this.Controls.Add(this.boxLogs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log Your Time - LYT";
            this.Activated += new System.EventHandler(this.DateTimePicker_getDate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.boxLogs.ResumeLayout(false);
            this.boxField.ResumeLayout(false);
            this.boxField.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCaseID;
        private System.Windows.Forms.TextBox txbCaseID;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox boxLogs;
        private System.Windows.Forms.GroupBox boxField;
        private System.Windows.Forms.RichTextBox txbLogs;
        private System.Windows.Forms.Button btnSaveLogs;
        private System.Windows.Forms.Label lblDateTime_Date;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsddBtn_option;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourceCodeOnGitHubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disclaimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tslblSaveStatus;
    }
}

