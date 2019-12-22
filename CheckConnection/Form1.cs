namespace CheckConnection
{
    using System;
    using System.Windows.Forms;
    using iTuner;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReportAvailability();
            NetworkStatus.AvailabilityChanged += new NetworkStatusChangedHandler(DoAvailabilityChanged);
        }

        static void DoAvailabilityChanged(object sender, NetworkStatusChangedArgs e)
        {
            ReportAvailability();
        }

        private static void ReportAvailability()
        {
            if (NetworkStatus.IsAvailable)
            {
                label1.Text = "... Network is available";
            }
            else
            {
                label1.Text = "... Network is not available";
            }
        }
    }
}
