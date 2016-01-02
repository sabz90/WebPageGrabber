namespace WebPageGrabber
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.tbProgress = new System.Windows.Forms.TextBox();
            this.btAbort = new System.Windows.Forms.Button();
            this.btGrab = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbStatusText = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSavePath = new System.Windows.Forms.TextBox();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDepth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(19, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(748, 600);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.tbProgress);
            this.tabPage1.Controls.Add(this.btAbort);
            this.tabPage1.Controls.Add(this.btGrab);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.lbStatusText);
            this.tabPage1.Controls.Add(this.lbStatus);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbSavePath);
            this.tabPage1.Controls.Add(this.tbURL);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(740, 574);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 515);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Enter a Valid URL";
            // 
            // tbProgress
            // 
            this.tbProgress.Location = new System.Drawing.Point(27, 160);
            this.tbProgress.Multiline = true;
            this.tbProgress.Name = "tbProgress";
            this.tbProgress.ReadOnly = true;
            this.tbProgress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbProgress.Size = new System.Drawing.Size(647, 339);
            this.tbProgress.TabIndex = 4;
            this.tbProgress.WordWrap = false;
            // 
            // btAbort
            // 
            this.btAbort.AllowDrop = true;
            this.btAbort.Enabled = false;
            this.btAbort.Location = new System.Drawing.Point(412, 119);
            this.btAbort.Name = "btAbort";
            this.btAbort.Size = new System.Drawing.Size(75, 23);
            this.btAbort.TabIndex = 3;
            this.btAbort.Text = "Abort";
            this.btAbort.UseVisualStyleBackColor = true;
            this.btAbort.Click += new System.EventHandler(this.btAbort_Click);
            // 
            // btGrab
            // 
            this.btGrab.Location = new System.Drawing.Point(521, 119);
            this.btGrab.Name = "btGrab";
            this.btGrab.Size = new System.Drawing.Size(153, 23);
            this.btGrab.TabIndex = 3;
            this.btGrab.Text = "Select Folder and Grab!";
            this.btGrab.UseVisualStyleBackColor = true;
            this.btGrab.Click += new System.EventHandler(this.btGrab_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(27, 533);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(647, 23);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // lbStatusText
            // 
            this.lbStatusText.AutoSize = true;
            this.lbStatusText.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatusText.Location = new System.Drawing.Point(117, 293);
            this.lbStatusText.Name = "lbStatusText";
            this.lbStatusText.Size = new System.Drawing.Size(11, 18);
            this.lbStatusText.TabIndex = 1;
            this.lbStatusText.Text = ".";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(24, 512);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(59, 18);
            this.lbStatus.TabIndex = 1;
            this.lbStatus.Text = "STATUS:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Progress:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Save Path:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL:";
            // 
            // tbSavePath
            // 
            this.tbSavePath.Location = new System.Drawing.Point(104, 84);
            this.tbSavePath.Name = "tbSavePath";
            this.tbSavePath.ReadOnly = true;
            this.tbSavePath.Size = new System.Drawing.Size(570, 20);
            this.tbSavePath.TabIndex = 0;
            this.tbSavePath.Text = "      You can select folder when you click grab";
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(104, 46);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(570, 20);
            this.tbURL.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tbDepth);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(740, 574);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(524, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "This tab is for future settings like downloading images, css, js, flash,etc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 515);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Developed by Sabarish";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 4;
            // 
            // tbDepth
            // 
            this.tbDepth.Location = new System.Drawing.Point(174, 39);
            this.tbDepth.Name = "tbDepth";
            this.tbDepth.Size = new System.Drawing.Size(100, 20);
            this.tbDepth.TabIndex = 1;
            this.tbDepth.TabStop = false;
            this.tbDepth.Text = "2";
            this.tbDepth.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Depth:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 623);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "WebPageGrabber by Sabarish (sabarish90@outlook.com)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btGrab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSavePath;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbDepth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbStatusText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbProgress;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btAbort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
    }
}

