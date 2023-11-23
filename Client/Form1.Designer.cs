
namespace Client
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
            this.btnConnectServer = new System.Windows.Forms.Button();
            this.txtLogs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbChooseSubject = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnectServer
            // 
            this.btnConnectServer.Location = new System.Drawing.Point(77, 24);
            this.btnConnectServer.Name = "btnConnectServer";
            this.btnConnectServer.Size = new System.Drawing.Size(227, 41);
            this.btnConnectServer.TabIndex = 0;
            this.btnConnectServer.Text = "Connect to Server";
            this.btnConnectServer.UseVisualStyleBackColor = true;
            this.btnConnectServer.Click += new System.EventHandler(this.btnConnectServer_Click);
            // 
            // txtLogs
            // 
            this.txtLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLogs.Location = new System.Drawing.Point(503, 81);
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ReadOnly = true;
            this.txtLogs.Size = new System.Drawing.Size(447, 378);
            this.txtLogs.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(664, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Information";
            // 
            // lbChooseSubject
            // 
            this.lbChooseSubject.Enabled = false;
            this.lbChooseSubject.FormattingEnabled = true;
            this.lbChooseSubject.ItemHeight = 16;
            this.lbChooseSubject.Items.AddRange(new object[] {
            "History",
            "Math",
            "English",
            "Physics",
            "Biology"});
            this.lbChooseSubject.Location = new System.Drawing.Point(77, 223);
            this.lbChooseSubject.Name = "lbChooseSubject";
            this.lbChooseSubject.Size = new System.Drawing.Size(227, 84);
            this.lbChooseSubject.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(77, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Set higher grades";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Choose the subject";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(130, 459);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 36);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShow
            // 
            this.btnShow.Enabled = false;
            this.btnShow.Location = new System.Drawing.Point(77, 81);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(227, 45);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "Show grades";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(503, 49);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 26);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 521);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbChooseSubject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLogs);
            this.Controls.Add(this.btnConnectServer);
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnectServer;
        private System.Windows.Forms.TextBox txtLogs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbChooseSubject;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnClear;
    }
}

