using MoneyBurned.Dotnet.Lib.Data;

namespace MoneyBurned.Dotnet.Gui
{
    public partial class UserControlResourceInstance : UserControl
    {
        public int ResourceAmount { get { return Convert.ToInt32(numericUpDownCount.Value); } }
        private EventHandler onResourceChanged;
        public event EventHandler OnResourceChanged { add { onResourceChanged += value; } remove { onResourceChanged -= value; } }
        private Resource? resource;
        public Resource? Resource { get { return resource; } }

        public UserControlResourceInstance(Resource? resource)
        {
            onResourceChanged = delegate { };

            InitializeComponent();
            if (resource == null)
            {
                this.Dispose();
                return;
            }

            this.resource = resource;

            if (!resource.IsGenericRole)
            {
                numericUpDownCount.Visible = false;
                labelName.Width = this.Width - 6;
            }

            numericUpDownCount.Value = resource.Amount;
            labelName.Text = resource.Name;
        }

        public void AddGenericResource()
        {
            if (resource != null)
            {
                numericUpDownCount.Value++;
            }
        }

        private void numericUpDownCount_ValueChanged(object sender, EventArgs e)
        {
            if (resource != null)
            {
                resource.Amount = Convert.ToInt32(numericUpDownCount.Value);
                onResourceChanged?.Invoke(resource, EventArgs.Empty);

                if (resource.Amount == 0)
                {
                    this.Dispose();
                }
            }
        }

        private void UserControlResourceInstance_DoubleClick(object sender, EventArgs e)
        {
            if (resource != null)
            {
                resource.Amount = 0;
                onResourceChanged?.Invoke(resource, EventArgs.Empty);
            }
            this.Dispose();
        }
    }
}
