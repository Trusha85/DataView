namespace DataView
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnViewReport = new Button();
            btnSaveToDb = new Button();
            btnLoadData = new Button();
            dgvContacts = new DataGridView();
            tabPage2 = new TabPage();
            dgvSms = new DataGridView();
            tabPage3 = new TabPage();
            dgvCalls = new DataGridView();
            tabPage4 = new TabPage();
            dgvDeviceInfo = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContacts).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSms).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCalls).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDeviceInfo).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(793, 444);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnViewReport);
            tabPage1.Controls.Add(btnSaveToDb);
            tabPage1.Controls.Add(btnLoadData);
            tabPage1.Controls.Add(dgvContacts);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(785, 416);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "ContactsTab";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnViewReport
            // 
            btnViewReport.Location = new Point(467, 16);
            btnViewReport.Name = "btnViewReport";
            btnViewReport.Size = new Size(90, 23);
            btnViewReport.TabIndex = 3;
            btnViewReport.Text = "View Report";
            btnViewReport.UseVisualStyleBackColor = true;
            btnViewReport.Click += btnViewReport_Click;
            // 
            // btnSaveToDb
            // 
            btnSaveToDb.Location = new Point(313, 16);
            btnSaveToDb.Name = "btnSaveToDb";
            btnSaveToDb.Size = new Size(115, 23);
            btnSaveToDb.TabIndex = 2;
            btnSaveToDb.Text = "Save to Database";
            btnSaveToDb.UseVisualStyleBackColor = true;
            btnSaveToDb.Click += btnSaveToDb_Click;
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(199, 16);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(75, 23);
            btnLoadData.TabIndex = 1;
            btnLoadData.Text = "Load Data";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // dgvContacts
            // 
            dgvContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContacts.Location = new Point(199, 51);
            dgvContacts.Name = "dgvContacts";
            dgvContacts.Size = new Size(358, 346);
            dgvContacts.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvSms);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(785, 416);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "SmsTab";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvSms
            // 
            dgvSms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSms.Location = new Point(180, 36);
            dgvSms.Name = "dgvSms";
            dgvSms.Size = new Size(444, 348);
            dgvSms.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvCalls);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(785, 416);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "CallLogsTab";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvCalls
            // 
            dgvCalls.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCalls.Location = new Point(161, 36);
            dgvCalls.Name = "dgvCalls";
            dgvCalls.Size = new Size(448, 349);
            dgvCalls.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dgvDeviceInfo);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(785, 416);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "DeviceInfoTab";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvDeviceInfo
            // 
            dgvDeviceInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeviceInfo.Location = new Point(164, 36);
            dgvDeviceInfo.Name = "dgvDeviceInfo";
            dgvDeviceInfo.Size = new Size(466, 337);
            dgvDeviceInfo.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvContacts).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSms).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCalls).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDeviceInfo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgvContacts;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button btnViewReport;
        private Button btnSaveToDb;
        private Button btnLoadData;
        private DataGridView dgvSms;
        private DataGridView dgvCalls;
        private DataGridView dgvDeviceInfo;
    }
}
