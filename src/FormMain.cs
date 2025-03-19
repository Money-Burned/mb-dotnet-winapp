using MoneyBurned.Dotnet.Lib;
using MoneyBurned.Dotnet.Lib.Data;

namespace MoneyBurned.Dotnet.Gui
{
    public partial class FormMain : Form
    {
        private Font mbBaseFont = new Font("Segoe UI Black", 26F, FontStyle.Bold, GraphicsUnit.Point);
        private Font mbBigFont = new Font("Segoe UI Black", 42F, FontStyle.Bold, GraphicsUnit.Point);
        
        private System.Windows.Forms.Timer? currentJobTimer;
        private Job? currentJob;


        public FormMain()
        {
            InitializeComponent();
            currentJob = new Job("A new MB job...");
            DrawJobUi();
            ActiveControl = buttonAdd;
        }

        #region UI Logic Handler

        /// <summary>
        /// The start button: this is where most of the magic happens: the recording job is put together. We do 
        /// this here as all the resources used are required first. Then the timer is set up and launched.
        /// </summary>
        /// <param name="sender">Not relevant here</param>
        /// <param name="e">Not relevant here</param>
        private void buttonJobStart_Click(object sender, EventArgs e)
        {
            if(currentJob != null && currentJob.Resources.Count > 0)
            {
                if (currentJob.StartTime != DateTime.MinValue)
                {
                    Resource[] recentResources = [.. currentJob.Resources];
                    currentJob = new Job("Another job...", recentResources);
                }

                currentJob.StartRecording();
                progressBarJobRunning.Style = ProgressBarStyle.Marquee;
                buttonJobStop.Enabled = true;
                buttonJobStart.Enabled = false;
                buttonJobStop.Focus();

                currentJobTimer = new System.Windows.Forms.Timer();
                currentJobTimer.Interval = 500;
                currentJobTimer.Tick += currentJobTimer_Tick;
                currentJobTimer.Start();
            }
            else
            {
                MessageBox.Show("The job wasn't initialized or there are no resources defined!", "Wait! Job not ready...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// The only purpos of this event handler is to redraw the UI as long as the stop watch is running.
        /// </summary>
        /// <param name="sender">Not relevant here</param>
        /// <param name="e">Not relevant here</param>
        private void currentJobTimer_Tick(object? sender, EventArgs e)
        {
            DrawJobUi();
        }

        /// <summary>
        /// The stop button: when done with the current money recording job, the stop watch needs to be 
        /// stopped. Then the timer is disposed and the user interface is brought backt to the state it was before.
        /// </summary>
        /// <param name="sender">Not relevant here</param>
        /// <param name="e">Not relevant here</param>
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

        /// <summary>
        /// Resource management: Open the dialog for adding a new resource
        /// </summary>
        /// <param name="sender">Not relevant here</param>
        /// <param name="e">Not relevant here</param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddResource addResourceForm = new FormAddResource();
            addResourceForm.FormClosing += addResourceForm_FormClosing;
            addResourceForm.ShowDialog();
        }

        /// <summary>
        /// Resource management: Adding the new resource, if it was created in the dialog that is to be closed
        /// </summary>
        /// <param name="sender">Needed to recover the created resource from the closing form</param>
        /// <param name="e">Not relevant here</param>
        private void addResourceForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            FormAddResource? addResourceForm = sender as FormAddResource;
            Resource? resource = addResourceForm?.Tag as Resource;
            AddResource(resource);
        }

        /// <summary>
        /// Resource management: Duplicate the selected resource
        /// </summary>
        /// <param name="sender">Not relevant here</param>
        /// <param name="e">Not relevant here</param>
        private void buttonDuplicate_Click(object sender, EventArgs e)
        {
            if(listViewResources.SelectedItems.Count == 1)
            {
                AddResource((Resource?)listViewResources.SelectedItems[0].Tag);
            }
        }

        /// <summary>
        /// Resource management: Remove the selected resources
        /// </summary>
        /// <param name="sender">Not relevant here</param>
        /// <param name="e">Not relevant here</param>
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if(listViewResources.SelectedItems.Count > 0)
            {
                foreach(ListViewItem item in listViewResources.SelectedItems)
                {
                    RemoveResource((Resource?)item.Tag);
                    listViewResources.Items.Remove(item);
                }
            }
        }

        #endregion

        #region UI Menu Handler

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
            textBoxJobName.Text = currentJob != null ? currentJob.Name : "";
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
                resourceItem.SubItems.Add($"{resource.CostPerWorkHour:C2}");
                listViewResources.Items.Add(resourceItem);
                currentJob?.AddResource(resource);
            }
            buttonJobStart.Enabled = listViewResources.Items.Count > 0;
            DrawJobUi();
        }

        private void RemoveResource(Resource? resource)
        {
            if (resource != null)
            {
                currentJob?.RemoveResource(resource);
            }
            buttonJobStart.Enabled = listViewResources.Items.Count > 0;
            DrawJobUi();
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