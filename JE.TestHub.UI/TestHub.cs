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

        private void btnToggleCircle_Click(object sender, EventArgs e)
        {
            ToggleCircle tc = new ToggleCircle();
            tc.Show();
        }

        private void btnMoveCircle_Click(object sender, EventArgs e)
        {
            MoveCircle mc = new MoveCircle();
            mc.Show();
        }

        private void btnDragCircle_Click(object sender, EventArgs e)
        {
            DragCircle dc = new DragCircle();
            dc.Show();
        }
    }
}
