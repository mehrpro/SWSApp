namespace SWSApp.UI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcademicYear = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSchools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTagCart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSMS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaradod = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReceiver = new System.Windows.Forms.ToolStripMenuItem();
            this.راهنماToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.دربارهنرمافزارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuInformation,
            this.mnuTaradod,
            this.راهنماToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuInformation
            // 
            this.mnuInformation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAcademicYear,
            this.mnuSchools,
            this.mnuStudents,
            this.mnuTagCart,
            this.mnuSMS});
            this.mnuInformation.Name = "mnuInformation";
            this.mnuInformation.Size = new System.Drawing.Size(80, 20);
            this.mnuInformation.Text = "اطلاعات پایه";
            // 
            // mnuAcademicYear
            // 
            this.mnuAcademicYear.Name = "mnuAcademicYear";
            this.mnuAcademicYear.Size = new System.Drawing.Size(180, 22);
            this.mnuAcademicYear.Text = "سال تحصیلی";
            this.mnuAcademicYear.Click += new System.EventHandler(this.mnuAcademicYear_Click);
            // 
            // mnuSchools
            // 
            this.mnuSchools.Name = "mnuSchools";
            this.mnuSchools.Size = new System.Drawing.Size(180, 22);
            this.mnuSchools.Text = "مدارس";
            // 
            // mnuStudents
            // 
            this.mnuStudents.Name = "mnuStudents";
            this.mnuStudents.Size = new System.Drawing.Size(180, 22);
            this.mnuStudents.Text = "دانش آموزان";
            // 
            // mnuTagCart
            // 
            this.mnuTagCart.Name = "mnuTagCart";
            this.mnuTagCart.Size = new System.Drawing.Size(180, 22);
            this.mnuTagCart.Text = "تگ کارت";
            // 
            // mnuSMS
            // 
            this.mnuSMS.Name = "mnuSMS";
            this.mnuSMS.Size = new System.Drawing.Size(180, 22);
            this.mnuSMS.Text = "سامانه پیام کوتاه";
            // 
            // mnuTaradod
            // 
            this.mnuTaradod.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReceiver});
            this.mnuTaradod.Name = "mnuTaradod";
            this.mnuTaradod.Size = new System.Drawing.Size(39, 20);
            this.mnuTaradod.Text = "تردد";
            // 
            // mnuReceiver
            // 
            this.mnuReceiver.Name = "mnuReceiver";
            this.mnuReceiver.Size = new System.Drawing.Size(144, 22);
            this.mnuReceiver.Text = "تخصیص کارت";
            // 
            // راهنماToolStripMenuItem
            // 
            this.راهنماToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.دربارهنرمافزارToolStripMenuItem});
            this.راهنماToolStripMenuItem.Name = "راهنماToolStripMenuItem";
            this.راهنماToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.راهنماToolStripMenuItem.Text = "راهنما";
            // 
            // دربارهنرمافزارToolStripMenuItem
            // 
            this.دربارهنرمافزارToolStripMenuItem.Name = "دربارهنرمافزارToolStripMenuItem";
            this.دربارهنرمافزارToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.دربارهنرمافزارToolStripMenuItem.Text = "درباره نرم افزار";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ترددبان";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuInformation;
        private System.Windows.Forms.ToolStripMenuItem mnuAcademicYear;
        private System.Windows.Forms.ToolStripMenuItem mnuSchools;
        private System.Windows.Forms.ToolStripMenuItem mnuStudents;
        private System.Windows.Forms.ToolStripMenuItem mnuTagCart;
        private System.Windows.Forms.ToolStripMenuItem mnuSMS;
        private System.Windows.Forms.ToolStripMenuItem mnuTaradod;
        private System.Windows.Forms.ToolStripMenuItem mnuReceiver;
        private System.Windows.Forms.ToolStripMenuItem راهنماToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem دربارهنرمافزارToolStripMenuItem;
    }
}