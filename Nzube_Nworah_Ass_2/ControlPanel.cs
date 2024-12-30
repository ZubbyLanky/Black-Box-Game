namespace Nzube_Nworah_Ass_2
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
        }

        private void btnDesgin_Click(object sender, EventArgs e)
        {
            DesignForm designForm = new DesignForm();
            designForm.Show();
           
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            
        }
    }
}
