namespace JE.TestHub.UI
{
    public partial class TestHub : Form
    {
        public TestHub()
        {
            InitializeComponent();
        }
        private void TestHub_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(10, 10);
        }
        private void btnDrawCircle_Click(object sender, EventArgs e)
        {
            BasicCircle bc = new BasicCircle();
            bc.Show();
        }
    }
}
