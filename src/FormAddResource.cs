using MoneyBurned.Dotnet.Lib.Data;
using System.ComponentModel;

namespace MoneyBurned.Dotnet.Gui
{
    public partial class FormAddResource : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Resource NewResource { get; private set; }
        private CostIntervalType[] costIntervalTypes = new CostIntervalType[] { CostIntervalType.WorkDay, CostIntervalType.WorkWeek, CostIntervalType.WorkMonth, CostIntervalType.WorkYear, CostIntervalType.Minute, CostIntervalType.Hour, CostIntervalType.Day, CostIntervalType.Week, CostIntervalType.Month, CostIntervalType.Year };

        public FormAddResource()
        {
            InitializeComponent();
            comboBoxUnit.Items.Add(CostIntervalType.Hour);
            comboBoxUnit.Items.Add(CostIntervalType.WorkDay);
            comboBoxUnit.Items.Add(CostIntervalType.WorkYear);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                NewResource = new Resource(String.IsNullOrWhiteSpace(textBoxName.Text) ? "No name" : textBoxName.Text, new Cost(Convert.ToDecimal(textBoxCost.Text), (CostIntervalType)comboBoxUnit?.SelectedItem));
                Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid resource definition...", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
