namespace MoneyBurned.Dotnet.Gui
{
    partial class FormAddResource
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxResourceData = new GroupBox();
            buttonAdd = new Button();
            buttonCancel = new Button();
            labelName = new Label();
            textBoxName = new TextBox();
            textBoxCost = new TextBox();
            labelCost = new Label();
            comboBoxUnit = new ComboBox();
            labelPer = new Label();
            groupBoxResourceData.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxResourceData
            // 
            groupBoxResourceData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxResourceData.Controls.Add(labelPer);
            groupBoxResourceData.Controls.Add(comboBoxUnit);
            groupBoxResourceData.Controls.Add(textBoxCost);
            groupBoxResourceData.Controls.Add(labelCost);
            groupBoxResourceData.Controls.Add(textBoxName);
            groupBoxResourceData.Controls.Add(labelName);
            groupBoxResourceData.Location = new Point(12, 12);
            groupBoxResourceData.Name = "groupBoxResourceData";
            groupBoxResourceData.Size = new Size(395, 134);
            groupBoxResourceData.TabIndex = 0;
            groupBoxResourceData.TabStop = false;
            groupBoxResourceData.Text = "Resource data";
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAdd.Location = new Point(251, 152);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Location = new Point(332, 152);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(16, 29);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Name";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(88, 26);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(288, 23);
            textBoxName.TabIndex = 1;
            // 
            // labelCost
            // 
            labelCost.AutoSize = true;
            labelCost.Location = new Point(16, 58);
            labelCost.Name = "labelCost";
            labelCost.Size = new Size(31, 15);
            labelCost.TabIndex = 2;
            labelCost.Text = "Cost";
            // 
            // textBoxCost
            // 
            textBoxCost.Location = new Point(88, 55);
            textBoxCost.Name = "textBoxCost";
            textBoxCost.Size = new Size(147, 23);
            textBoxCost.TabIndex = 3;
            textBoxCost.TextAlign = HorizontalAlignment.Right;
            // 
            // labelPer
            // 
            labelPer.AutoSize = true;
            labelPer.Location = new Point(240, 58);
            labelPer.Name = "labelPer";
            labelPer.Size = new Size(24, 15);
            labelPer.TabIndex = 5;
            labelPer.Text = "per";
            // 
            // comboBoxUnit
            // 
            comboBoxUnit.FormattingEnabled = true;
            comboBoxUnit.Location = new Point(270, 55);
            comboBoxUnit.Name = "comboBoxUnit";
            comboBoxUnit.Size = new Size(106, 23);
            comboBoxUnit.TabIndex = 4;
            // 
            // FormAddResource
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 185);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAdd);
            Controls.Add(groupBoxResourceData);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormAddResource";
            Text = "Add a resource";
            groupBoxResourceData.ResumeLayout(false);
            groupBoxResourceData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxResourceData;
        private Label labelName;
        private Button buttonAdd;
        private Button buttonCancel;
        private ComboBox comboBoxUnit;
        private TextBox textBoxCost;
        private Label labelCost;
        private TextBox textBoxName;
        private Label labelPer;
    }
}