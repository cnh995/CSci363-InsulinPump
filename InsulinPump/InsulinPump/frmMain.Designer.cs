namespace InsulinPump
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.secenariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowBatteryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowInsulinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceNeedleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highBloodSugarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowBloodSugarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valueEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insulinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloodSugarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batteryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLatestReading = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNextReadingTime = new System.Windows.Forms.Label();
            this.btnScheduleDose = new System.Windows.Forms.Button();
            this.btnReadingHistory = new System.Windows.Forms.Button();
            this.btnUserSettings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.secenariosToolStripMenuItem,
            this.valueEntryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(295, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "mnuMainMenu";
            // 
            // secenariosToolStripMenuItem
            // 
            this.secenariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lowBatteryToolStripMenuItem,
            this.lowInsulinToolStripMenuItem,
            this.replaceNeedleToolStripMenuItem,
            this.highBloodSugarToolStripMenuItem,
            this.lowBloodSugarToolStripMenuItem,
            this.disconnectedToolStripMenuItem});
            this.secenariosToolStripMenuItem.Name = "secenariosToolStripMenuItem";
            this.secenariosToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.secenariosToolStripMenuItem.Text = "Secenarios";
            // 
            // lowBatteryToolStripMenuItem
            // 
            this.lowBatteryToolStripMenuItem.Name = "lowBatteryToolStripMenuItem";
            this.lowBatteryToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.lowBatteryToolStripMenuItem.Text = "Low Battery";
            this.lowBatteryToolStripMenuItem.Click += new System.EventHandler(this.lowBatteryToolStripMenuItem_Click);
            // 
            // lowInsulinToolStripMenuItem
            // 
            this.lowInsulinToolStripMenuItem.Name = "lowInsulinToolStripMenuItem";
            this.lowInsulinToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.lowInsulinToolStripMenuItem.Text = "Low Insulin";
            this.lowInsulinToolStripMenuItem.Click += new System.EventHandler(this.lowInsulinToolStripMenuItem_Click);
            // 
            // replaceNeedleToolStripMenuItem
            // 
            this.replaceNeedleToolStripMenuItem.Name = "replaceNeedleToolStripMenuItem";
            this.replaceNeedleToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.replaceNeedleToolStripMenuItem.Text = "Replace Needle";
            this.replaceNeedleToolStripMenuItem.Click += new System.EventHandler(this.replaceNeedleToolStripMenuItem_Click);
            // 
            // highBloodSugarToolStripMenuItem
            // 
            this.highBloodSugarToolStripMenuItem.Name = "highBloodSugarToolStripMenuItem";
            this.highBloodSugarToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.highBloodSugarToolStripMenuItem.Text = "High Blood Sugar";
            this.highBloodSugarToolStripMenuItem.Click += new System.EventHandler(this.highBloodSugarToolStripMenuItem_Click);
            // 
            // lowBloodSugarToolStripMenuItem
            // 
            this.lowBloodSugarToolStripMenuItem.Name = "lowBloodSugarToolStripMenuItem";
            this.lowBloodSugarToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.lowBloodSugarToolStripMenuItem.Text = "Low Blood Sugar";
            this.lowBloodSugarToolStripMenuItem.Click += new System.EventHandler(this.lowBloodSugarToolStripMenuItem_Click);
            // 
            // disconnectedToolStripMenuItem
            // 
            this.disconnectedToolStripMenuItem.Name = "disconnectedToolStripMenuItem";
            this.disconnectedToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.disconnectedToolStripMenuItem.Text = "Disconnected";
            this.disconnectedToolStripMenuItem.Click += new System.EventHandler(this.disconnectedToolStripMenuItem_Click);
            // 
            // valueEntryToolStripMenuItem
            // 
            this.valueEntryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insulinToolStripMenuItem,
            this.bloodSugarToolStripMenuItem,
            this.batteryToolStripMenuItem});
            this.valueEntryToolStripMenuItem.Name = "valueEntryToolStripMenuItem";
            this.valueEntryToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.valueEntryToolStripMenuItem.Text = "Value Entry";
            // 
            // insulinToolStripMenuItem
            // 
            this.insulinToolStripMenuItem.Name = "insulinToolStripMenuItem";
            this.insulinToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.insulinToolStripMenuItem.Text = "Insulin";
            this.insulinToolStripMenuItem.Click += new System.EventHandler(this.insulinToolStripMenuItem_Click);
            // 
            // bloodSugarToolStripMenuItem
            // 
            this.bloodSugarToolStripMenuItem.Name = "bloodSugarToolStripMenuItem";
            this.bloodSugarToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.bloodSugarToolStripMenuItem.Text = "Blood Sugar";
            // 
            // batteryToolStripMenuItem
            // 
            this.batteryToolStripMenuItem.Name = "batteryToolStripMenuItem";
            this.batteryToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.batteryToolStripMenuItem.Text = "Battery";
            // 
            // lblLatestReading
            // 
            this.lblLatestReading.AutoSize = true;
            this.lblLatestReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatestReading.Location = new System.Drawing.Point(26, 56);
            this.lblLatestReading.Name = "lblLatestReading";
            this.lblLatestReading.Size = new System.Drawing.Size(81, 42);
            this.lblLatestReading.TabIndex = 1;
            this.lblLatestReading.Text = "120";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Next Reading Time";
            // 
            // lblNextReadingTime
            // 
            this.lblNextReadingTime.AutoSize = true;
            this.lblNextReadingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextReadingTime.Location = new System.Drawing.Point(166, 56);
            this.lblNextReadingTime.Name = "lblNextReadingTime";
            this.lblNextReadingTime.Size = new System.Drawing.Size(91, 42);
            this.lblNextReadingTime.TabIndex = 4;
            this.lblNextReadingTime.Text = "3:30";
            // 
            // btnScheduleDose
            // 
            this.btnScheduleDose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScheduleDose.Location = new System.Drawing.Point(33, 178);
            this.btnScheduleDose.Name = "btnScheduleDose";
            this.btnScheduleDose.Size = new System.Drawing.Size(226, 68);
            this.btnScheduleDose.TabIndex = 5;
            this.btnScheduleDose.Text = "Schedule Next Dose";
            this.btnScheduleDose.UseVisualStyleBackColor = true;
            this.btnScheduleDose.Click += new System.EventHandler(this.btnScheduleDose_Click);
            // 
            // btnReadingHistory
            // 
            this.btnReadingHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadingHistory.Location = new System.Drawing.Point(33, 270);
            this.btnReadingHistory.Name = "btnReadingHistory";
            this.btnReadingHistory.Size = new System.Drawing.Size(226, 68);
            this.btnReadingHistory.TabIndex = 6;
            this.btnReadingHistory.Text = "Reading History";
            this.btnReadingHistory.UseVisualStyleBackColor = true;
            this.btnReadingHistory.Click += new System.EventHandler(this.btnReadingHistory_Click);
            // 
            // btnUserSettings
            // 
            this.btnUserSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserSettings.Location = new System.Drawing.Point(33, 362);
            this.btnUserSettings.Name = "btnUserSettings";
            this.btnUserSettings.Size = new System.Drawing.Size(226, 68);
            this.btnUserSettings.TabIndex = 7;
            this.btnUserSettings.Text = "User Settings";
            this.btnUserSettings.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Latest Reading";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "mg/dl";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 463);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUserSettings);
            this.Controls.Add(this.btnReadingHistory);
            this.Controls.Add(this.btnScheduleDose);
            this.Controls.Add(this.lblNextReadingTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLatestReading);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Insulin Pump";
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem secenariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowBatteryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowInsulinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceNeedleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highBloodSugarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowBloodSugarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valueEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insulinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloodSugarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batteryToolStripMenuItem;
        private System.Windows.Forms.Label lblLatestReading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNextReadingTime;
        private System.Windows.Forms.Button btnScheduleDose;
        private System.Windows.Forms.Button btnReadingHistory;
        private System.Windows.Forms.Button btnUserSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

