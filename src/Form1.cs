using MoneyBurned.Dotnet.Lib.Data;

namespace MoneyBurned.Dotnet.Gui;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void textBoxTest_DoubleClick(object sender, EventArgs e)
    {
        Resource resource = new Resource("Jim", new Cost("75000/wy"));
        textBoxTest.Text = resource.ToString();
    }
}
