using MoneyBurned.Dotnet.Lib;
using MoneyBurned.Dotnet.Lib.Data;

namespace MoneyBurned.Dotnet.Gui
{
    public partial class FormMain : Form
    {
        private Font mbBaseFont = new Font("Segoe UI Black", 26F, FontStyle.Bold, GraphicsUnit.Point);
        private Font mbBigFont = new Font("Segoe UI Black", 42F, FontStyle.Bold, GraphicsUnit.Point);

        private RecordingJob currentJob;


        public FormMain()
        {
            InitializeComponent();
            
        }

        private void openJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialogJob.ShowDialog();
        }

        private void saveJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialogJob.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonJobStart_Click(object sender, EventArgs e)
        {
            Resource[] resources = new Resource[listViewResources.Items.Count];
            for(int i = 0; i < resources.Length; i++)
            {
                resources[i] = (Resource)listViewResources.Items[i].Tag;
            }
            currentJob = new RecordingJob(resources);
            currentJob.StartRecording();
            progressBarJobRunning.Style = ProgressBarStyle.Marquee;
            buttonJobStop.Enabled = true;
        }

        private void buttonJobStop_Click(object sender, EventArgs e)
        {
            currentJob.EndRecording();
            labelJobTimeElapsed.Text = $"{currentJob.ElapsedTime}";
            labelJobMoneyBurned.Text = $"{currentJob.ElapsedCost}";
            progressBarJobRunning.Style = ProgressBarStyle.Blocks;
            buttonJobStop.Enabled = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddResource addResourceForm = new FormAddResource();
            addResourceForm.FormClosing += addResourceForm_FormClosing;
            addResourceForm.ShowDialog();
        }

        private void addResourceForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            FormAddResource addResourceForm = sender as FormAddResource;
            if (addResourceForm != null && addResourceForm.NewResource != null)
            {
                ListViewItem resourceItem = new ListViewItem(addResourceForm.NewResource.Name);
                resourceItem.Tag = addResourceForm.NewResource;
                resourceItem.SubItems.Add($"{addResourceForm.NewResource.CostPerWorkHour} /h");
                listViewResources.Items.Add(resourceItem);
            }
        }

        private void listViewResources_itemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            buttonJobStart.Enabled = listViewResources.Items.Count > 0;
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