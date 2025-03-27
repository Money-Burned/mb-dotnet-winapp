using MoneyBurned.Dotnet.Lib;
using MoneyBurned.Dotnet.Lib.Data;
using System.Text.Json;

namespace MoneyBurned.Dotnet.Gui
{
    public partial class FormMain : Form
    {
        private readonly Font mbBaseFont = new Font("Segoe UI Black", 26F, FontStyle.Bold, GraphicsUnit.Point);
        private readonly Font mbBigFont = new Font("Segoe UI Black", 42F, FontStyle.Bold, GraphicsUnit.Point);
        private readonly string defaultResourceFilePath = ".\\mb-resourcePool.json";

        private System.Windows.Forms.Timer? currentJobTimer;
        private Job? currentJob;


        public FormMain()
        {
            InitializeComponent();
            LoadResourcePool(String.Empty);
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
            if (currentJob != null && currentJob.Resources.Count > 0)
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
                flowLayoutPanelJobResources.Enabled = false;

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
            flowLayoutPanelJobResources.Enabled = true;
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
            AddResourceToPool(resource);
        }

        /// <summary>
        /// Resource management: Edit the selected resource
        /// </summary>
        /// <param name="sender">Not relevant here</param>
        /// <param name="e">Not relevant here</param>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewResources.SelectedItems.Count == 1)
            {
                Resource? resource = (Resource?)listViewResources.SelectedItems[0].Tag;
                RemoveResourceFromPool(resource);
                FormAddResource addResourceForm = new FormAddResource(resource);
                addResourceForm.FormClosing += addResourceForm_FormClosing;
                addResourceForm.ShowDialog();
            }
        }

        /// <summary>
        /// Resource management: Remove the selected resources
        /// </summary>
        /// <param name="sender">Not relevant here</param>
        /// <param name="e">Not relevant here</param>
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listViewResources.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listViewResources.SelectedItems)
                {
                    RemoveResourceFromPool((Resource?)item.Tag);
                }
            }
        }

        /// <summary>
        /// Resource management: Adds the selected resources to the current Job
        /// </summary>
        /// <param name="sender">Not relevant here</param>
        /// <param name="e">Not relevant here</param>
        private void buttonAddToJob_Click(object sender, EventArgs e)
        {
            if (listViewResources.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listViewResources.SelectedItems)
                {
                    Resource? resource = (Resource?)item.Tag;
                    AddResourceToJob(resource);
                }
            }
        }

        #endregion

        #region UI Menu Handler

        private void openJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialogJob.ShowDialog();
        }

        private void openFileDialogJob_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (e.Cancel) return;
            MessageBox.Show("Feature is not implemented by now...", "Loading job unavailable", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void saveJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialogJob.ShowDialog();
        }

        private void saveFileDialogJob_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (e.Cancel) return;
            MessageBox.Show("Feature is not implemented by now...", "Saving job unavailable", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void AddResourceToJob(Resource? resource)
        {
            if (resource != null)
            {
                resource.Amount = resource.Amount == 0 ? resource.Amount = 1 : resource.Amount = resource.Amount;

                foreach (UserControlResourceInstance resourceControl in flowLayoutPanelJobResources.Controls)
                {
                    if (resourceControl.Resource?.Id == resource.Id)
                    {
                        if (resourceControl.Resource.IsGenericRole)
                        {
                            resourceControl.AddGenericResource();
                        }
                        else
                        {
                            MessageBox.Show($"The resource {resource.Name} is already assigned to the job. Please choose another!", "Resource exisiting!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        return;
                    }
                }

                UserControlResourceInstance resourceInstance = new UserControlResourceInstance(resource);
                resourceInstance.OnResourceChanged += ResourceInstance_OnResourceChanged;
                flowLayoutPanelJobResources.Controls.Add(resourceInstance);
            }
        }

        private void AddResourceToPool(Resource? resource)
        {
            if (resource != null)
            {
                resource.Amount = 1;
                ListViewItem resourceItem = new ListViewItem(resource.Name);
                resourceItem.SubItems.Add($"{resource.CostPerWorkHour:C2}");
                resourceItem.ImageIndex = (int)resource.Category;
                resourceItem.Tag = resource;
                listViewResources.Items.Add(resourceItem);
            }
        }

        private void RemoveResourceFromPool(Resource? resource)
        {
            if (resource != null)
            {
                foreach (ListViewItem resourceItem in listViewResources.Items)
                {
                    Resource? resourceItemResource = (Resource?)resourceItem.Tag;
                    if (resourceItemResource != null && resource.Id == resourceItemResource.Id)
                    {
                        resourceItem.Remove();
                    }
                }
            }
        }

        private void listViewResources_DoubleClick(object sender, EventArgs e)
        {
            if (listViewResources.SelectedItems.Count == 1)
            {
                AddResourceToJob((Resource?)listViewResources.SelectedItems[0].Tag);
            }
        }

        private void listViewResources_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewResources.SelectedItems.Count == 1)
            {
                buttonEdit.Enabled = true;
                buttonRemove.Enabled = true;
                buttonAddToJob.Enabled = true;
            }
            else if (listViewResources.SelectedItems.Count > 0)
            {
                buttonEdit.Enabled = false;
                buttonRemove.Enabled = true;
                buttonAddToJob.Enabled = true;
            }
            else
            {
                buttonEdit.Enabled = false;
                buttonRemove.Enabled = false;
                buttonAddToJob.Enabled = false;
            }
        }

        private void flowLayoutPanelJobResources_ControlsChanged(object sender, ControlEventArgs e)
        {
            List<Resource> currentlyAssignedResources = [];
            foreach (UserControlResourceInstance resourceControl in flowLayoutPanelJobResources.Controls)
            {
                if (resourceControl.Resource != null)
                {
                    currentlyAssignedResources.Add(resourceControl.Resource);
                }
            }
            currentJob?.ClearResources();
            currentJob?.AddResources(currentlyAssignedResources.ToArray());
            buttonJobStart.Enabled = flowLayoutPanelJobResources.Controls.Count > 0;
            DrawJobUi();
        }

        private void ResourceInstance_OnResourceChanged(object? sender, EventArgs e)
        {
            DrawJobUi();
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

        #region General Helper

        private void LoadResourcePool(string filePath)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(filePath))
                {
                    filePath = defaultResourceFilePath;
                    if (!File.Exists(filePath)) return;
                }

                List<Guid> resourcePoolItemIds = [];
                foreach (ListViewItem resourceItem in listViewResources.Items)
                {
                    Resource? resourceItemResource = (Resource?)resourceItem.Tag;
                    if (resourceItemResource != null)
                    {
                        resourcePoolItemIds.Add(resourceItemResource.Id);
                    }
                }

                string resourcePoolItemsAsJson = File.ReadAllText(filePath);
                List<Resource>? loadedResourcePoolItems = JsonSerializer.Deserialize<List<Resource>>(resourcePoolItemsAsJson);
                if (loadedResourcePoolItems != null)
                {
                    foreach (Resource resource in loadedResourcePoolItems)
                    {
                        if (!resourcePoolItemIds.Contains(resource.Id))
                        {
                            AddResourceToPool(resource);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading resources", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveResourcePool(string filePath)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(filePath))
                {
                    filePath = defaultResourceFilePath;
                }

                List<Resource> resourcePoolItems = [];
                foreach (ListViewItem resourceItem in listViewResources.Items)
                {
                    Resource? resourceItemResource = (Resource?)resourceItem.Tag;
                    if (resourceItemResource != null)
                    {
                        resourceItemResource.Amount = 1;
                        resourcePoolItems.Add(resourceItemResource);
                    }
                }
                JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
                string resourcePoolItemsAsJson = JsonSerializer.Serialize(resourcePoolItems, options);
                File.WriteAllText(filePath, resourcePoolItemsAsJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error saving resources", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveResourcePool(String.Empty);
        }

        #endregion
    }
}