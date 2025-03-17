using MoneyBurned.Dotnet.Lib;
using MoneyBurned.Dotnet.Lib.Data;

namespace MoneyBurned.Dotnet.Gui
{
    public partial class FormMain : Form
    {
        private Font mbBaseFont = new Font("Segoe UI Black", 26F, FontStyle.Bold, GraphicsUnit.Point);
        private Font mbBigFont = new Font("Segoe UI Black", 42F, FontStyle.Bold, GraphicsUnit.Point);
        
        private System.Windows.Forms.Timer? currentJobTimer;
        private RecordingJob? currentJob;


        public FormMain()
        {
            InitializeComponent();
            DrawJobUi();
        }

        #region UI Logic Handler

        private void buttonJobStart_Click(object sender, EventArgs e)
        {
            Resource[]? resources = new Resource[listViewResources.Items.Count];
            for(int i = 0; i < resources.Length; i++)
            {
                Resource? res = listViewResources?.Items?[i]?.Tag as Resource;
                if(res != null)
                {
                    resources[i] = res;
                }
            }
            currentJob = new RecordingJob(resources);
            currentJob.StartRecording();
            progressBarJobRunning.Style = ProgressBarStyle.Marquee;
            buttonJobStop.Enabled = true;
            buttonJobStart.Enabled = false;

            currentJobTimer = new System.Windows.Forms.Timer();
            currentJobTimer.Interval = 1000;
            currentJobTimer.Tick += currentJobTimer_Tick;
            currentJobTimer.Start();
        }

        private void currentJobTimer_Tick(object? sender, EventArgs e)
        {
            DrawJobUi();
        }

        private void buttonJobStop_Click(object sender, EventArgs e)
        {
            currentJobTimer?.Stop();
            currentJobTimer?.Dispose();
            currentJob?.EndRecording();
            DrawJobUi();
            progressBarJobRunning.Style = ProgressBarStyle.Blocks;
            buttonJobStop.Enabled = false;
            buttonJobStart.Enabled = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddResource addResourceForm = new FormAddResource();
            addResourceForm.FormClosing += addResourceForm_FormClosing;
            addResourceForm.ShowDialog();
        }

        private void addResourceForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            FormAddResource? addResourceForm = sender as FormAddResource;
            Resource? resource = addResourceForm?.Tag as Resource;
            AddResource(resource);
            buttonJobStart.Enabled = listViewResources.Items.Count > 0;
        }

        private void buttonDuplicate_Click(object sender, EventArgs e)
        {
            if(listViewResources.SelectedItems.Count == 1)
            {
                AddResource((Resource?)listViewResources.SelectedItems[0].Tag);
            }

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if(listViewResources.SelectedItems.Count > 0)
            {
                foreach(ListViewItem item in listViewResources.SelectedItems)
                {
                    listViewResources.Items.Remove(item);
                }
            }
        }

        private void listViewResources_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewResources.SelectedItems.Count == 1) 
            {
                buttonDuplicate.Enabled = true;
                buttonRemove.Enabled = true;
            }
            else if(listViewResources.SelectedItems.Count > 0)
            {
                buttonDuplicate.Enabled = false;
                buttonRemove.Enabled = true;
            }
            else
            {
                buttonDuplicate.Enabled = false;
                buttonRemove.Enabled = false;
            }
        }

        #endregion

        #region UI Menue Handler

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

        #endregion

        #region UI Helper

        private void DrawJobUi()
        {
            labelJobDetails.Text = currentJob != null ? currentJob.ToString() : "";
            labelJobTimeElapsed.Text = currentJob != null ? $"{currentJob.ElapsedTime:hh\\:mm\\:ss}" : $"{TimeSpan.Zero:hh\\:mm\\:ss}";
            labelJobMoneyBurned.Text = currentJob != null ? $"{currentJob.ElapsedCost:C2}" : $"{Decimal.Zero:C2}";
        }

        private void AddResource(Resource? resource)
        {
            if (resource != null)
            {
                ListViewItem resourceItem = new ListViewItem(resource.Name);
                resourceItem.Tag = resource;
                resourceItem.SubItems.Add($"{resource.CostPerWorkHour:C2} /h");
                listViewResources.Items.Add(resourceItem);
            }
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

        #endregion
    }
}