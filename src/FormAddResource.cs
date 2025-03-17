using MoneyBurned.Dotnet.Lib.Data;
using System.ComponentModel;

namespace MoneyBurned.Dotnet.Gui
{
    public partial class FormAddResource : Form
    {
        private readonly CostIntervalType[] costIntervalTypes = [CostIntervalType.WorkDay, CostIntervalType.WorkWeek, CostIntervalType.WorkMonth, CostIntervalType.WorkYear, CostIntervalType.Minute, CostIntervalType.Hour, CostIntervalType.Day, CostIntervalType.Week, CostIntervalType.Month, CostIntervalType.Year];
        private readonly CostIntervalType costIntervalTypeDefault = CostIntervalType.Hour;

        public FormAddResource()
        {
            InitializeComponent();
            foreach(CostIntervalType costType in costIntervalTypes)
            {
                comboBoxUnit.Items.Add(costType);
            }
            comboBoxUnit.SelectedItem = costIntervalTypeDefault;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                CostIntervalType selectedCostType = costIntervalTypeDefault;
                if(comboBoxUnit.SelectedItem != null) 
                {
                    selectedCostType = (CostIntervalType)comboBoxUnit.SelectedItem;
                }
                Tag = new Resource(String.IsNullOrWhiteSpace(textBoxName.Text) ? "No name" : textBoxName.Text, new Cost(Convert.ToDecimal(textBoxCost.Text), selectedCostType));
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
