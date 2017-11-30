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
            this.menuStrip1.Size = new System.Drawing.Size(304, 24);
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
            // 
            // lowInsulinToolStripMenuItem
            // 
            this.lowInsulinToolStripMenuItem.Name = "lowInsulinToolStripMenuItem";
            this.lowInsulinToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.lowInsulinToolStripMenuItem.Text = "Low Insulin";
            // 
            // replaceNeedleToolStripMenuItem
            // 
            this.replaceNeedleToolStripMenuItem.Name = "replaceNeedleToolStripMenuItem";
            this.replaceNeedleToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.replaceNeedleToolStripMenuItem.Text = "Replace Needle";
            // 
            // highBloodSugarToolStripMenuItem
            // 
            this.highBloodSugarToolStripMenuItem.Name = "highBloodSugarToolStripMenuItem";
            this.highBloodSugarToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.highBloodSugarToolStripMenuItem.Text = "High Blood Sugar";
            // 
            // lowBloodSugarToolStripMenuItem
            // 
            this.lowBloodSugarToolStripMenuItem.Name = "lowBloodSugarToolStripMenuItem";
            this.lowBloodSugarToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.lowBloodSugarToolStripMenuItem.Text = "Low Blood Sugar";
            // 
            // disconnectedToolStripMenuItem
            // 
            this.disconnectedToolStripMenuItem.Name = "disconnectedToolStripMenuItem";
            this.disconnectedToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.disconnectedToolStripMenuItem.Text = "Disconnected";
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
            this.insulinToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.insulinToolStripMenuItem.Text = "Insulin";
            // 
            // bloodSugarToolStripMenuItem
            // 
            this.bloodSugarToolStripMenuItem.Name = "bloodSugarToolStripMenuItem";
            this.bloodSugarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bloodSugarToolStripMenuItem.Text = "Blood Sugar";
            // 
            // batteryToolStripMenuItem
            // 
            this.batteryToolStripMenuItem.Name = "batteryToolStripMenuItem";
            this.batteryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.batteryToolStripMenuItem.Text = "Battery";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 521);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Insulin Pump";
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
    }
}

