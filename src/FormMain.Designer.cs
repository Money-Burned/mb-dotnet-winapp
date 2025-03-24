
namespace MoneyBurned.Dotnet.Gui
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            toolStripMain = new ToolStrip();
            toolStripDropDownFile = new ToolStripDropDownButton();
            toolStripSeparator1 = new ToolStripSeparator();
            openJobToolStripMenuItem = new ToolStripMenuItem();
            saveJobToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toolStripDropDownMisc = new ToolStripDropDownButton();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            statusStripMain = new StatusStrip();
            splitContainerMain = new SplitContainer();
            buttonExpand = new Button();
            textBoxJobName = new TextBox();
            progressBarJobRunning = new ProgressBar();
            buttonJobStop = new Button();
            buttonJobStart = new Button();
            labelJobDetails = new Label();
            labelJobTimeElapsed = new Label();
            labelJobMoneyBurned = new Label();
            splitContainerResources = new SplitContainer();
            groupBoxResourcePool = new GroupBox();
            buttonAddToJob = new Button();
            buttonEdit = new Button();
            buttonRemove = new Button();
            buttonAdd = new Button();
            listViewResources = new ListView();
            columnHeaderName = new ColumnHeader();
            columnHeaderCost = new ColumnHeader();
            imageListResources = new ImageList(components);
            groupBoxJobResources = new GroupBox();
            flowLayoutPanelJobResources = new FlowLayoutPanel();
            buttonCollapse = new Button();
            openFileDialogJob = new OpenFileDialog();
            saveFileDialogJob = new SaveFileDialog();
            toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).BeginInit();
            splitContainerMain.Panel1.SuspendLayout();
            splitContainerMain.Panel2.SuspendLayout();
            splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerResources).BeginInit();
            splitContainerResources.Panel1.SuspendLayout();
            splitContainerResources.Panel2.SuspendLayout();
            splitContainerResources.SuspendLayout();
            groupBoxResourcePool.SuspendLayout();
            groupBoxJobResources.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripMain
            // 
            toolStripMain.Items.AddRange(new ToolStripItem[] { toolStripDropDownFile, toolStripDropDownMisc });
            toolStripMain.Location = new Point(0, 0);
            toolStripMain.Name = "toolStripMain";
            toolStripMain.Size = new Size(624, 25);
            toolStripMain.TabIndex = 0;
            toolStripMain.Text = "toolStrip1";
            // 
            // toolStripDropDownFile
            // 
            toolStripDropDownFile.AutoToolTip = false;
            toolStripDropDownFile.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownFile.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator1, openJobToolStripMenuItem, saveJobToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem });
            toolStripDropDownFile.Image = (Image)resources.GetObject("toolStripDropDownFile.Image");
            toolStripDropDownFile.ImageTransparentColor = Color.Magenta;
            toolStripDropDownFile.Name = "toolStripDropDownFile";
            toolStripDropDownFile.Size = new Size(38, 22);
            toolStripDropDownFile.Text = "File";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(121, 6);
            // 
            // openJobToolStripMenuItem
            // 
            openJobToolStripMenuItem.Name = "openJobToolStripMenuItem";
            openJobToolStripMenuItem.Size = new Size(124, 22);
            openJobToolStripMenuItem.Text = "Open Job";
            openJobToolStripMenuItem.Click += openJobToolStripMenuItem_Click;
            // 
            // saveJobToolStripMenuItem
            // 
            saveJobToolStripMenuItem.Name = "saveJobToolStripMenuItem";
            saveJobToolStripMenuItem.Size = new Size(124, 22);
            saveJobToolStripMenuItem.Text = "Save Job";
            saveJobToolStripMenuItem.Click += saveJobToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(121, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(124, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // toolStripDropDownMisc
            // 
            toolStripDropDownMisc.AutoToolTip = false;
            toolStripDropDownMisc.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownMisc.DropDownItems.AddRange(new ToolStripItem[] { settingsToolStripMenuItem, aboutToolStripMenuItem });
            toolStripDropDownMisc.Image = (Image)resources.GetObject("toolStripDropDownMisc.Image");
            toolStripDropDownMisc.ImageTransparentColor = Color.Magenta;
            toolStripDropDownMisc.Name = "toolStripDropDownMisc";
            toolStripDropDownMisc.Size = new Size(45, 22);
            toolStripDropDownMisc.Text = "Misc";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(116, 22);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(116, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // statusStripMain
            // 
            statusStripMain.Location = new Point(0, 299);
            statusStripMain.Name = "statusStripMain";
            statusStripMain.Size = new Size(624, 22);
            statusStripMain.TabIndex = 1;
            statusStripMain.Text = "statusStrip1";
            // 
            // splitContainerMain
            // 
            splitContainerMain.Dock = DockStyle.Fill;
            splitContainerMain.Location = new Point(0, 25);
            splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            splitContainerMain.Panel1.Controls.Add(buttonExpand);
            splitContainerMain.Panel1.Controls.Add(textBoxJobName);
            splitContainerMain.Panel1.Controls.Add(progressBarJobRunning);
            splitContainerMain.Panel1.Controls.Add(buttonJobStop);
            splitContainerMain.Panel1.Controls.Add(buttonJobStart);
            splitContainerMain.Panel1.Controls.Add(labelJobDetails);
            splitContainerMain.Panel1.Controls.Add(labelJobTimeElapsed);
            splitContainerMain.Panel1.Controls.Add(labelJobMoneyBurned);
            splitContainerMain.Panel1MinSize = 240;
            // 
            // splitContainerMain.Panel2
            // 
            splitContainerMain.Panel2.Controls.Add(splitContainerResources);
            splitContainerMain.Size = new Size(624, 274);
            splitContainerMain.SplitterDistance = 240;
            splitContainerMain.TabIndex = 2;
            // 
            // buttonExpand
            // 
            buttonExpand.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonExpand.Location = new Point(215, 211);
            buttonExpand.Name = "buttonExpand";
            buttonExpand.Size = new Size(15, 50);
            buttonExpand.TabIndex = 3;
            buttonExpand.Text = "<";
            buttonExpand.UseVisualStyleBackColor = true;
            buttonExpand.Visible = false;
            buttonExpand.Click += buttonExpand_Click;
            // 
            // textBoxJobName
            // 
            textBoxJobName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxJobName.BackColor = SystemColors.Control;
            textBoxJobName.BorderStyle = BorderStyle.None;
            textBoxJobName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBoxJobName.Location = new Point(12, 10);
            textBoxJobName.Name = "textBoxJobName";
            textBoxJobName.Size = new Size(212, 22);
            textBoxJobName.TabIndex = 4;
            textBoxJobName.Text = "Job Name";
            textBoxJobName.TextAlign = HorizontalAlignment.Center;
            // 
            // progressBarJobRunning
            // 
            progressBarJobRunning.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progressBarJobRunning.Location = new Point(28, 191);
            progressBarJobRunning.Name = "progressBarJobRunning";
            progressBarJobRunning.Size = new Size(181, 12);
            progressBarJobRunning.TabIndex = 5;
            // 
            // buttonJobStop
            // 
            buttonJobStop.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonJobStop.Enabled = false;
            buttonJobStop.Location = new Point(120, 211);
            buttonJobStop.Name = "buttonJobStop";
            buttonJobStop.Size = new Size(90, 50);
            buttonJobStop.TabIndex = 7;
            buttonJobStop.Text = "Stop";
            buttonJobStop.UseVisualStyleBackColor = true;
            buttonJobStop.Click += buttonJobStop_Click;
            // 
            // buttonJobStart
            // 
            buttonJobStart.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonJobStart.Enabled = false;
            buttonJobStart.Location = new Point(28, 211);
            buttonJobStart.Name = "buttonJobStart";
            buttonJobStart.Size = new Size(90, 50);
            buttonJobStart.TabIndex = 6;
            buttonJobStart.Text = "Start";
            buttonJobStart.UseVisualStyleBackColor = true;
            buttonJobStart.Click += buttonJobStart_Click;
            // 
            // labelJobDetails
            // 
            labelJobDetails.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelJobDetails.Font = new Font("Segoe UI", 9.5F);
            labelJobDetails.ForeColor = SystemColors.InfoText;
            labelJobDetails.Location = new Point(12, 35);
            labelJobDetails.Name = "labelJobDetails";
            labelJobDetails.Size = new Size(212, 64);
            labelJobDetails.TabIndex = 8;
            labelJobDetails.Text = "<Details>";
            labelJobDetails.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelJobTimeElapsed
            // 
            labelJobTimeElapsed.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelJobTimeElapsed.Font = new Font("Segoe UI", 12F);
            labelJobTimeElapsed.Location = new Point(12, 154);
            labelJobTimeElapsed.Name = "labelJobTimeElapsed";
            labelJobTimeElapsed.Size = new Size(212, 29);
            labelJobTimeElapsed.TabIndex = 9;
            labelJobTimeElapsed.Text = "00:00:00";
            labelJobTimeElapsed.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelJobMoneyBurned
            // 
            labelJobMoneyBurned.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelJobMoneyBurned.AutoEllipsis = true;
            labelJobMoneyBurned.Font = new Font("Segoe UI Black", 28F, FontStyle.Bold);
            labelJobMoneyBurned.Location = new Point(12, 88);
            labelJobMoneyBurned.Name = "labelJobMoneyBurned";
            labelJobMoneyBurned.Size = new Size(218, 62);
            labelJobMoneyBurned.TabIndex = 10;
            labelJobMoneyBurned.Text = "$ 0.00";
            labelJobMoneyBurned.TextAlign = ContentAlignment.MiddleCenter;
            labelJobMoneyBurned.SizeChanged += labelJobMoneyBurned_SizeChanged;
            // 
            // splitContainerResources
            // 
            splitContainerResources.Dock = DockStyle.Fill;
            splitContainerResources.Location = new Point(0, 0);
            splitContainerResources.Name = "splitContainerResources";
            splitContainerResources.Orientation = Orientation.Horizontal;
            // 
            // splitContainerResources.Panel1
            // 
            splitContainerResources.Panel1.Controls.Add(groupBoxResourcePool);
            splitContainerResources.Panel1MinSize = 140;
            // 
            // splitContainerResources.Panel2
            // 
            splitContainerResources.Panel2.Controls.Add(groupBoxJobResources);
            splitContainerResources.Panel2.Controls.Add(buttonCollapse);
            splitContainerResources.Panel2MinSize = 100;
            splitContainerResources.Size = new Size(380, 274);
            splitContainerResources.SplitterDistance = 140;
            splitContainerResources.TabIndex = 1;
            // 
            // groupBoxResourcePool
            // 
            groupBoxResourcePool.Controls.Add(buttonAddToJob);
            groupBoxResourcePool.Controls.Add(buttonEdit);
            groupBoxResourcePool.Controls.Add(buttonRemove);
            groupBoxResourcePool.Controls.Add(buttonAdd);
            groupBoxResourcePool.Controls.Add(listViewResources);
            groupBoxResourcePool.Dock = DockStyle.Fill;
            groupBoxResourcePool.Location = new Point(0, 0);
            groupBoxResourcePool.Name = "groupBoxResourcePool";
            groupBoxResourcePool.Size = new Size(380, 140);
            groupBoxResourcePool.TabIndex = 0;
            groupBoxResourcePool.TabStop = false;
            groupBoxResourcePool.Text = "Resource Pool";
            // 
            // buttonAddToJob
            // 
            buttonAddToJob.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAddToJob.Enabled = false;
            buttonAddToJob.Location = new Point(299, 107);
            buttonAddToJob.Name = "buttonAddToJob";
            buttonAddToJob.Size = new Size(75, 23);
            buttonAddToJob.TabIndex = 16;
            buttonAddToJob.Text = "Add to Job";
            buttonAddToJob.UseVisualStyleBackColor = true;
            buttonAddToJob.Click += buttonAddToJob_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEdit.Enabled = false;
            buttonEdit.Location = new Point(299, 51);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(75, 23);
            buttonEdit.TabIndex = 13;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonRemove.Enabled = false;
            buttonRemove.Location = new Point(299, 80);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(75, 23);
            buttonRemove.TabIndex = 14;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAdd.Location = new Point(299, 22);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 12;
            buttonAdd.Text = "New...";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // listViewResources
            // 
            listViewResources.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewResources.Columns.AddRange(new ColumnHeader[] { columnHeaderName, columnHeaderCost });
            listViewResources.LargeImageList = imageListResources;
            listViewResources.Location = new Point(6, 22);
            listViewResources.Name = "listViewResources";
            listViewResources.Size = new Size(287, 108);
            listViewResources.SmallImageList = imageListResources;
            listViewResources.TabIndex = 15;
            listViewResources.UseCompatibleStateImageBehavior = false;
            listViewResources.View = View.Details;
            listViewResources.SelectedIndexChanged += listViewResources_SelectedIndexChanged;
            listViewResources.DoubleClick += listViewResources_DoubleClick;
            // 
            // columnHeaderName
            // 
            columnHeaderName.Tag = "Name";
            columnHeaderName.Text = "Name";
            columnHeaderName.Width = 140;
            // 
            // columnHeaderCost
            // 
            columnHeaderCost.Text = "Cost/h";
            columnHeaderCost.TextAlign = HorizontalAlignment.Right;
            columnHeaderCost.Width = 100;
            // 
            // imageListResources
            // 
            imageListResources.ColorDepth = ColorDepth.Depth24Bit;
            imageListResources.ImageStream = (ImageListStreamer)resources.GetObject("imageListResources.ImageStream");
            imageListResources.TransparentColor = Color.Transparent;
            imageListResources.Images.SetKeyName(0, "person.ico");
            imageListResources.Images.SetKeyName(1, "groupOfPersons.ico");
            imageListResources.Images.SetKeyName(2, "asset.ico");
            imageListResources.Images.SetKeyName(3, "groupOfAssets.ico");
            imageListResources.Images.SetKeyName(4, "location.ico");
            imageListResources.Images.SetKeyName(5, "rental.ico");
            // 
            // groupBoxJobResources
            // 
            groupBoxJobResources.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxJobResources.Controls.Add(flowLayoutPanelJobResources);
            groupBoxJobResources.Location = new Point(0, 2);
            groupBoxJobResources.Name = "groupBoxJobResources";
            groupBoxJobResources.Size = new Size(353, 125);
            groupBoxJobResources.TabIndex = 13;
            groupBoxJobResources.TabStop = false;
            groupBoxJobResources.Text = "Current Job Resources";
            // 
            // flowLayoutPanelJobResources
            // 
            flowLayoutPanelJobResources.Dock = DockStyle.Fill;
            flowLayoutPanelJobResources.Location = new Point(3, 19);
            flowLayoutPanelJobResources.Name = "flowLayoutPanelJobResources";
            flowLayoutPanelJobResources.Size = new Size(347, 103);
            flowLayoutPanelJobResources.TabIndex = 0;
            flowLayoutPanelJobResources.ControlAdded += flowLayoutPanelJobResources_ControlsChanged;
            // 
            // buttonCollapse
            // 
            buttonCollapse.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCollapse.Location = new Point(359, 67);
            buttonCollapse.Name = "buttonCollapse";
            buttonCollapse.Size = new Size(15, 50);
            buttonCollapse.TabIndex = 12;
            buttonCollapse.Text = ">";
            buttonCollapse.UseVisualStyleBackColor = true;
            buttonCollapse.Click += buttonCollapse_Click;
            // 
            // openFileDialogJob
            // 
            openFileDialogJob.Title = "Open Job...";
            // 
            // saveFileDialogJob
            // 
            saveFileDialogJob.Title = "Save Job...";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 321);
            Controls.Add(splitContainerMain);
            Controls.Add(statusStripMain);
            Controls.Add(toolStripMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(640, 320);
            Name = "FormMain";
            Text = "Money Burned";
            FormClosing += FormMain_FormClosing;
            toolStripMain.ResumeLayout(false);
            toolStripMain.PerformLayout();
            splitContainerMain.Panel1.ResumeLayout(false);
            splitContainerMain.Panel1.PerformLayout();
            splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).EndInit();
            splitContainerMain.ResumeLayout(false);
            splitContainerResources.Panel1.ResumeLayout(false);
            splitContainerResources.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerResources).EndInit();
            splitContainerResources.ResumeLayout(false);
            groupBoxResourcePool.ResumeLayout(false);
            groupBoxJobResources.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStripMain;
        private StatusStrip statusStripMain;
        private SplitContainer splitContainerMain;
        private Label labelJobDetails;
        private Label labelJobTimeElapsed;
        private Label labelJobMoneyBurned;
        private Button buttonJobStop;
        private Button buttonJobStart;
        private ProgressBar progressBarJobRunning;
        private ToolStripDropDownButton toolStripDropDownFile;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem openJobToolStripMenuItem;
        private ToolStripMenuItem saveJobToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownMisc;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private GroupBox groupBoxResourcePool;
        private Button buttonEdit;
        private Button buttonRemove;
        private Button buttonAdd;
        private ListView listViewResources;
        private TextBox textBoxJobName;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderCost;
        private OpenFileDialog openFileDialogJob;
        private SaveFileDialog saveFileDialogJob;
        private Button buttonExpand;
        private SplitContainer splitContainerResources;
        private GroupBox groupBoxJobResources;
        private FlowLayoutPanel flowLayoutPanelJobResources;
        private Button buttonCollapse;
        private Button buttonAddToJob;
        private ImageList imageListResources;
    }
}