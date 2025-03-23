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
            comboBoxCategory = new ComboBox();
            checkBoxGeneric = new CheckBox();
            labelPer = new Label();
            comboBoxUnit = new ComboBox();
            textBoxCost = new TextBox();
            labelCost = new Label();
            textBoxName = new TextBox();
            labelName = new Label();
            buttonAdd = new Button();
            buttonCancel = new Button();
            groupBoxResourceData.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxResourceData
            // 
            groupBoxResourceData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxResourceData.Controls.Add(comboBoxCategory);
            groupBoxResourceData.Controls.Add(checkBoxGeneric);
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
            // comboBoxCategory
            // 
            comboBoxCategory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(143, 84);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(233, 23);
            comboBoxCategory.TabIndex = 6;
            // 
            // checkBoxGeneric
            // 
            checkBoxGeneric.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            checkBoxGeneric.CheckAlign = ContentAlignment.MiddleRight;
            checkBoxGeneric.Location = new Point(16, 86);
            checkBoxGeneric.Name = "checkBoxGeneric";
            checkBoxGeneric.Size = new Size(104, 19);
            checkBoxGeneric.TabIndex = 4;
            checkBoxGeneric.Text = "Generic Role";
            checkBoxGeneric.UseVisualStyleBackColor = true;
            checkBoxGeneric.CheckedChanged += checkBoxGeneric_CheckedChanged;
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
            comboBoxUnit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxUnit.FormattingEnabled = true;
            comboBoxUnit.Location = new Point(270, 55);
            comboBoxUnit.Name = "comboBoxUnit";
            comboBoxUnit.Size = new Size(106, 23);
            comboBoxUnit.TabIndex = 3;
            // 
            // textBoxCost
            // 
            textBoxCost.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCost.Location = new Point(105, 55);
            textBoxCost.Name = "textBoxCost";
            textBoxCost.Size = new Size(130, 23);
            textBoxCost.TabIndex = 2;
            textBoxCost.TextAlign = HorizontalAlignment.Right;
            textBoxCost.KeyUp += textBoxCost_KeyUp;
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
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxName.Location = new Point(105, 26);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(271, 23);
            textBoxName.TabIndex = 1;
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
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAdd.Location = new Point(251, 152);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "OK";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Location = new Point(332, 152);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
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
        private CheckBox checkBoxGeneric;
        private ComboBox comboBoxCategory;
    }
}