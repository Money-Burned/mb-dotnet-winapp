using MoneyBurned.Dotnet.Lib.Data;

namespace MoneyBurned.Dotnet.Gui
{
    public partial class FormAddResource : Form
    {
        private readonly CostIntervalType[] costIntervalTypes = [CostIntervalType.WorkDay, CostIntervalType.WorkWeek, CostIntervalType.WorkMonth, CostIntervalType.WorkYear, CostIntervalType.Minute, CostIntervalType.Hour, CostIntervalType.Day, CostIntervalType.Week, CostIntervalType.Month, CostIntervalType.Year];
        private readonly CostIntervalType costIntervalTypeDefault = CostIntervalType.Hour;
        private readonly ResourceCategory[] resourceCategories = [ResourceCategory.Person, ResourceCategory.GroupOfPersons, ResourceCategory.Asset, ResourceCategory.GroupOfAssets, ResourceCategory.Location, ResourceCategory.Rental];
        private readonly ResourceCategory resourceCategoryDefault = ResourceCategory.Person;
        private Resource? resource;

        public FormAddResource()
        {
            InitializeComponent();
            PopulateComboBoxes();
            comboBoxUnit.SelectedItem = costIntervalTypeDefault;
            comboBoxCategory.SelectedItem = resourceCategoryDefault;
        }

        public FormAddResource(Resource? resource)
        {
            InitializeComponent();
            PopulateComboBoxes();
            comboBoxUnit.SelectedItem = costIntervalTypeDefault;
            if (resource != null)
            {
                this.resource = resource;
                textBoxName.Text = resource.Name;
                this.Text = $"Edit {resource}...";
                textBoxCost.Text = $"{resource.CostPerWorkHour}";
                checkBoxGeneric.Checked = resource.IsGenericRole;
                comboBoxCategory.SelectedItem = resource.Category;
            }
            else
            {
                comboBoxCategory.SelectedItem = resourceCategoryDefault;
            }
        }

        private void PopulateComboBoxes()
        {
            foreach (CostIntervalType costType in costIntervalTypes)
            {
                comboBoxUnit.Items.Add(costType);
            }
            foreach (ResourceCategory resourceCategory in resourceCategories)
            {
                comboBoxCategory.Items.Add(resourceCategory);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                CostIntervalType selectedCostType = costIntervalTypeDefault;
                if (comboBoxUnit.SelectedItem != null)
                {
                    selectedCostType = (CostIntervalType)comboBoxUnit.SelectedItem;
                }
                ResourceCategory selectedCategory = default;
                if (comboBoxCategory.SelectedItem != null)
                {
                    selectedCategory = (ResourceCategory)comboBoxCategory.SelectedItem;
                }

                if (resource != null)
                {
                    resource.UpdateCoreData(textBoxName.Text, new Cost(Convert.ToDecimal(textBoxCost.Text), selectedCostType), checkBoxGeneric.Checked);
                    resource.Category = selectedCategory;
                }
                else
                {
                    resource = new Resource(String.IsNullOrWhiteSpace(textBoxName.Text) ? "No name" : textBoxName.Text, new Cost(Convert.ToDecimal(textBoxCost.Text), selectedCostType), checkBoxGeneric.Checked, selectedCategory);
                }

                Tag = resource;
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

        private void textBoxCost_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonAdd_Click(sender, EventArgs.Empty);
            }
        }

        private void checkBoxGeneric_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGeneric.Checked && !((ResourceCategory?)comboBoxCategory.SelectedItem == ResourceCategory.GroupOfAssets || (ResourceCategory?)comboBoxCategory.SelectedItem == ResourceCategory.GroupOfPersons))
            {
                comboBoxCategory.SelectedItem = ResourceCategory.GroupOfPersons;
            }

            if (!checkBoxGeneric.Checked && ((ResourceCategory?)comboBoxCategory.SelectedItem == ResourceCategory.GroupOfAssets || (ResourceCategory?)comboBoxCategory.SelectedItem == ResourceCategory.GroupOfPersons))
            {
                comboBoxCategory.SelectedItem = ResourceCategory.Person;
            }
        }
    }
}
