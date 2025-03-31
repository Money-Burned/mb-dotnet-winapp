namespace MoneyBurned.Dotnet.Gui
{
    partial class UserControlResourceInstance
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelName = new Label();
            numericUpDownCount = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCount).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoEllipsis = true;
            labelName.Location = new Point(1, 4);
            labelName.Name = "labelName";
            labelName.Size = new Size(55, 23);
            labelName.TabIndex = 0;
            labelName.Text = "...";
            labelName.TextAlign = ContentAlignment.MiddleLeft;
            labelName.DoubleClick += UserControlResourceInstance_DoubleClick;
            // 
            // numericUpDownCount
            // 
            numericUpDownCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDownCount.Location = new Point(58, 3);
            numericUpDownCount.Name = "numericUpDownCount";
            numericUpDownCount.Size = new Size(37, 23);
            numericUpDownCount.TabIndex = 1;
            numericUpDownCount.TextAlign = HorizontalAlignment.Right;
            numericUpDownCount.ValueChanged += numericUpDownCount_ValueChanged;
            // 
            // UserControlResourceInstance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(numericUpDownCount);
            Controls.Add(labelName);
            Name = "UserControlResourceInstance";
            Size = new Size(98, 30);
            DoubleClick += UserControlResourceInstance_DoubleClick;
            ((System.ComponentModel.ISupportInitialize)numericUpDownCount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelName;
        private NumericUpDown numericUpDownCount;
    }
}
