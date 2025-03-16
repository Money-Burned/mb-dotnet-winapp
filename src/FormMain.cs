namespace MoneyBurned.Dotnet.Gui
{
    public partial class FormMain : Form
    {
        private Font mbBaseFont = new Font("Segoe UI Black", 26F, FontStyle.Bold, GraphicsUnit.Point);
        private Font mbBigFont = new Font("Segoe UI Black", 42F, FontStyle.Bold, GraphicsUnit.Point);


        public FormMain()
        {
            InitializeComponent();
            buttonAdd.Focus();
        }

        private void openJobToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveJobToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonJobStart_Click(object sender, EventArgs e)
        {

        }

        private void buttonJobStop_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void buttonDuplicate_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {

        }

        private void buttonCollapse_Click(object sender, EventArgs e)
        {
            splitContainerMain.Panel2Collapsed = true;
            buttonExpand.Visible = true;
        }

        private void buttonExpand_Click(object sender, EventArgs e)
        {
            splitContainerMain.Panel2Collapsed = false;
            buttonExpand.Visible = false;
        }

        private void labelJobMoneyBurned_SizeChanged(object sender, EventArgs e)
        {
            // Select font style based on UI size
            labelJobMoneyBurned.Font = ((Label)sender).Width > Convert.ToInt32(this.Width / 2) ? mbBigFont : mbBaseFont;
        }
    }
}