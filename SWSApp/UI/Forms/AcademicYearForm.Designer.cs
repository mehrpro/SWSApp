namespace SWSApp.UI.Forms
{
    partial class AcademicYearForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAcademicYear = new System.Windows.Forms.DataGridView();
            this.cbxYear2 = new System.Windows.Forms.ComboBox();
            this.cbxYear1 = new System.Windows.Forms.ComboBox();
            this.cbxMonth2 = new System.Windows.Forms.ComboBox();
            this.cbxMonth1 = new System.Windows.Forms.ComboBox();
            this.cbxDay2 = new System.Windows.Forms.ComboBox();
            this.cbxDay1 = new System.Windows.Forms.ComboBox();
            this.txtYearTitle = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcademicYear)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.dgvAcademicYear);
            this.groupBox1.Controls.Add(this.cbxYear2);
            this.groupBox1.Controls.Add(this.cbxYear1);
            this.groupBox1.Controls.Add(this.cbxMonth2);
            this.groupBox1.Controls.Add(this.cbxMonth1);
            this.groupBox1.Controls.Add(this.cbxDay2);
            this.groupBox1.Controls.Add(this.cbxDay1);
            this.groupBox1.Controls.Add(this.txtYearTitle);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(829, 498);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "سال تحصیلی";
            // 
            // dgvAcademicYear
            // 
            this.dgvAcademicYear.AllowUserToAddRows = false;
            this.dgvAcademicYear.AllowUserToDeleteRows = false;
            this.dgvAcademicYear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAcademicYear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcademicYear.Location = new System.Drawing.Point(12, 168);
            this.dgvAcademicYear.Name = "dgvAcademicYear";
            this.dgvAcademicYear.ReadOnly = true;
            this.dgvAcademicYear.RowTemplate.Height = 25;
            this.dgvAcademicYear.Size = new System.Drawing.Size(805, 318);
            this.dgvAcademicYear.TabIndex = 14;
            // 
            // cbxYear2
            // 
            this.cbxYear2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxYear2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxYear2.FormattingEnabled = true;
            this.cbxYear2.Items.AddRange(new object[] {
            "1400",
            "1401",
            "1402",
            "1403",
            "1404",
            "1405",
            "1406",
            "1407",
            "1408",
            "1409",
            "1410",
            "1411",
            "1412",
            "1413",
            "1414",
            "1415",
            "1416",
            "1417",
            "1418",
            "1419",
            "1420"});
            this.cbxYear2.Location = new System.Drawing.Point(446, 130);
            this.cbxYear2.Name = "cbxYear2";
            this.cbxYear2.Size = new System.Drawing.Size(75, 23);
            this.cbxYear2.TabIndex = 11;
            // 
            // cbxYear1
            // 
            this.cbxYear1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxYear1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxYear1.FormattingEnabled = true;
            this.cbxYear1.Items.AddRange(new object[] {
            "1400",
            "1401",
            "1402",
            "1403",
            "1404",
            "1405",
            "1406",
            "1407",
            "1408",
            "1409",
            "1410",
            "1411",
            "1412",
            "1413",
            "1414",
            "1415",
            "1416",
            "1417",
            "1418",
            "1419",
            "1420"});
            this.cbxYear1.Location = new System.Drawing.Point(446, 99);
            this.cbxYear1.Name = "cbxYear1";
            this.cbxYear1.Size = new System.Drawing.Size(75, 23);
            this.cbxYear1.TabIndex = 7;
            // 
            // cbxMonth2
            // 
            this.cbxMonth2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMonth2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMonth2.FormattingEnabled = true;
            this.cbxMonth2.Items.AddRange(new object[] {
            "فروردین",
            "اردیبهشت",
            "خرداد",
            "تیر",
            "مرداد",
            "شهریور",
            "مهر",
            "آبان",
            "آذر",
            "دی",
            "بهمن",
            "اسفند"});
            this.cbxMonth2.Location = new System.Drawing.Point(527, 130);
            this.cbxMonth2.Name = "cbxMonth2";
            this.cbxMonth2.Size = new System.Drawing.Size(103, 23);
            this.cbxMonth2.TabIndex = 10;
            // 
            // cbxMonth1
            // 
            this.cbxMonth1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMonth1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMonth1.FormattingEnabled = true;
            this.cbxMonth1.Items.AddRange(new object[] {
            "فروردین",
            "اردیبهشت",
            "خرداد",
            "تیر",
            "مرداد",
            "شهریور",
            "مهر",
            "آبان",
            "آذر",
            "دی",
            "بهمن",
            "اسفند"});
            this.cbxMonth1.Location = new System.Drawing.Point(527, 99);
            this.cbxMonth1.Name = "cbxMonth1";
            this.cbxMonth1.Size = new System.Drawing.Size(103, 23);
            this.cbxMonth1.TabIndex = 6;
            // 
            // cbxDay2
            // 
            this.cbxDay2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxDay2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDay2.FormattingEnabled = true;
            this.cbxDay2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbxDay2.Location = new System.Drawing.Point(636, 130);
            this.cbxDay2.Name = "cbxDay2";
            this.cbxDay2.Size = new System.Drawing.Size(40, 23);
            this.cbxDay2.TabIndex = 9;
            // 
            // cbxDay1
            // 
            this.cbxDay1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxDay1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDay1.FormattingEnabled = true;
            this.cbxDay1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbxDay1.Location = new System.Drawing.Point(636, 99);
            this.cbxDay1.Name = "cbxDay1";
            this.cbxDay1.Size = new System.Drawing.Size(40, 23);
            this.cbxDay1.TabIndex = 5;
            // 
            // txtYearTitle
            // 
            this.txtYearTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYearTitle.Location = new System.Drawing.Point(446, 68);
            this.txtYearTitle.MaxLength = 50;
            this.txtYearTitle.Name = "txtYearTitle";
            this.txtYearTitle.Size = new System.Drawing.Size(230, 23);
            this.txtYearTitle.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.Location = new System.Drawing.Point(446, 37);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(230, 23);
            this.txtID.TabIndex = 1;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(682, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "آخرین روز سال تحصیلی";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(682, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "اولین روز سال تحصیلی";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(682, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "عنوان سال تحصیلی";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(682, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "شناسه";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(347, 122);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 31);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(260, 122);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(81, 31);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "بستن";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // AcademicYearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 498);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AcademicYearForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "سال تحصیلی";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcademicYear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYearTitle;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxYear1;
        private System.Windows.Forms.ComboBox cbxMonth1;
        private System.Windows.Forms.ComboBox cbxDay1;
        private System.Windows.Forms.ComboBox cbxYear2;
        private System.Windows.Forms.ComboBox cbxMonth2;
        private System.Windows.Forms.ComboBox cbxDay2;
        private System.Windows.Forms.DataGridView dgvAcademicYear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}