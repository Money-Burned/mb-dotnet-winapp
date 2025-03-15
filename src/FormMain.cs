namespace MoneyBurned.Dotnet.Gui
{
    public partial class FormMain : Form
    {
        private Font mbBaseFont;
        private Font mbBigFont = new Font("Segoe UI Black", 42F, FontStyle.Bold, GraphicsUnit.Point);


        public FormMain()
        {
            InitializeComponent();
            mbBaseFont = labelJobMoneyBurned.Font;
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
            SuspendLayout();
            if (((Label)sender).Width > 350)
            {
                labelJobMoneyBurned.Font = mbBigFont;
            }
            else
            {
                labelJobMoneyBurned.Font = mbBaseFont;
            }
            labelJobMoneyBurned.Refresh();
            ResumeLayout();
        }
    }
}