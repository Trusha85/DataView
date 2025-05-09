namespace DataView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            dgvContacts.DataSource = DataLoader.LoadContacts(@"C:\Users\avi\contacts.txt");
            dgvSms.DataSource = DataLoader.LoadSMS(@"C:\Users\avi\sms.txt");
            dgvCalls.DataSource = DataLoader.LoadCalls(@"C:\Users\avi\call_logs.txt");
            dgvDeviceInfo.DataSource = DataLoader.LoadDeviceInfo(@"C:\Users\avi\cpuinfo.txt", @"C:\Users\avi\meminfo.txt");
        }

        private void btnSaveToDb_Click(object sender, EventArgs e)
        {

        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {

        }
    }
}
