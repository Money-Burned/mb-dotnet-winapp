# Development approach of mb-dotnet-winapp

## Framework or development platform used

- Origin and some background on the chosen framework/platform
- Links to further literature (official documentation / Wikipedia)
- What knowledge one should already have when choosing this framework/platform?
- Cost and license considerations in the context of the framework/platform

### Method of approach

- Why that framework?
    - Common benefits and/or disadvantages
    - Limitations ("only works on before high noon and below 20 degrees")
- Are there any dependencies on the operating system and if not, what do you have to consider if you want to run it on different operating systems?
- Are there any dependencies on other software in your code, e.g. libraries that you use?
- How much time should a developer plan to use/reimplement your approach?

### Development environment

- How do you set up a modern development environment for optimal development processes?
- Tools of choice

## Planning and software design

### Requirements

- What did you do to map the requirements to specific tasks to implement?
- Did you use user stories or requirements or both?
- To what extent have you broken it down?
- What requirements did you end up implementing? 

| ReqID | Implemented? | Remarks (why not; challenges; how?) |
| :--- | :---: | :--- | 
| MF 01.1 | No | |
| MF 01.2 | No | |
| MF 02.1 | No | |
| MF 02.2 | No | |
| MF 03.1 | No | |
| MF 03.2 | No | |
| MF 03.3 | No | |
| MF 03.4 | No | |
| MB 01.1 | No | |
| MB 01.2 | No | |
| MB 02.1 | No | |
| OF 01.1 | No | |
| OF 01.2 | No | |
| OF 02.1 | No | |
| OF 02.2 | No | |
| OF 02.3 | No | |
| OF 02.4 | No | |
| OF 02.5 | No | |
| OF 03.1 | No | |
| OF 03.2 | No | |
| OB 01.1 | No | |
| OB 02.1 | No | |
| OB 03.1 | No | |
| OB 03.2 | No | |

- What special features that were not part of the requirements did you include and why?

### Modeling of data

- Outline the class model of the application if you use OOP; feel encouraged to use graphics like UML
- Outline the persistence of your application if it is implemented; feel encouraged to use graphics like ERM
    - Config data
    - Usage data

### Logic

- Outline how your internal processing is designed; feel encouraged to use graphics like flow charts or a state diagram!
- Did you externalize parts of your logic and why?

## Tutorial

### Creating a new WinForms Dotnet application

Because of the idea of making this an implementation variant for the "Money Burned" examples, I'm going to stick with the [default repository template hosted on GitHub](https://github.com/Money-Burned/.template-project). It's a little bit of an overkill in terms of folder structure, but that's not a big deal - if you're just doing this to reproduce the basic creation of the application, you're fine to skip this part...  
After creating the repository in GitHub and cloning it locally, we start in the root folder of our project - in this case, it's _mb-dotnet-winapp_.  

1. First of all we need to overwrite the gitignore placeholder file so all the binary artifacts from build and debugging are not tracked - we can use the Dotnet template by using the Dotnet CLI: `dotnet new gitignore --force`. The parameter _force_ will have you overwrite the existing template.  
2. After I have the local repo ready for the application code, I just need to push the initial Dotnet template code of a WinForms application into this source folder using the Dotnet CLI with a separate name and output target: `dotnet new winforms -o .\src\ -n mb-dotnet-winapp`.  
3. Let's try! Change to the source folder by typing `cd .\src\` and firing up the created WinForms template with `dotnet run`. If all went well, there should open a new blank window named _"Form 1"_ in the title.  

### Preparation of the created WinForms project for further development

Lets make some modifications to our project to get a clean start to the development of the application. It is recommended to open the project folder in the IDE of your choice (I suggest using [VSCode](https://code.visualstudio.com/), having the [C# Dev Kit extension](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit) installed or using a full [Visual Studio](https://visualstudio.microsoft.com/)).  

1. Add a reference to the _mb-dotnet-lib_ library (assuming we already cloned it to the same folder, where the project folder of _mb-dotnet-winapp_ is residing in). To do that, I make use of the Dotnet CLI from the source folder and type: `dotnet add reference ..\..\mb-dotnet-lib\src\mb-dotnet-lib.csproj`.  
2. Inside the project file, there are two things to change. First will be the default namespace of the app to be a bit more meaningful. To do so, open the file [_mb-dotnet-winapp.csproj_](../src/mb-dotnet-winapp.csproj) and edit the element _RootNamespace_ to `<RootNamespace>MoneyBurned.Dotnet.Gui</RootNamespace>`.  
To have a nicer looking name of the generated output assemby (the compiled .exe file, you can run and distribute), I will also add the element _AssemblyName_ like this: `<AssemblyName>MoneyBurned.Gui</AssemblyName>`. Otherwise the assembly would have the name of the project.  
3. To be consistent, you will have to change the namespaces in all your code files. Open all three existing *.cs files. Examine the content and edit all occurences of `namespace <old_name_space>;` to `namespace MoneyBurned.Dotnet.Gui;`.  
4. It's not necessary, but sometimes it's handy to treat a project as a Visual Studio solution. To do this, I need to create a .sln file. There are many ways to create one. Let VSCode (see SOLUTION EXPLORER in the navigation pane), Visual Studio or the [Dotnet CLI](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-sln) do it for you.  
For reasons of convenience, I have placed the [mb-dotnet-winapp.sln file](../src/mb-dotnet-winapp.sln) directly in the source folder but at project root level will be fine as well. Just be sure that paths are all correct.

5. Now we can try to use the library by adding just a single textbox:  

    **Edit the file "[Form1.Designer.cs](../src/Form1.Designer.cs)"**, looking for the region _"Windows Form Designer generated code"_ and modify like lined out below:  

    ```csharp
    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        textBoxTest = new TextBox();
        // 
        // textBoxTest
        // 
        textBoxTest.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        textBoxTest.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        textBoxTest.Location = new Point(20, 50);
        textBoxTest.Text = "Double-Click me to create a resource!";
        textBoxTest.DoubleClick += new System.EventHandler(this.textBoxTest_DoubleClick);

        this.Controls.Add(textBoxTest);
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Form1";
    }

    private TextBox textBoxTest;

    #endregion
    ```

    **Edit the file "[Form1.cs](../src/Form1.cs)"** to add the eventhandler for double-clicking the textbox just beneath the contructor; the file should look like that in the end:  

    ```csharp
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
    ```

    Be sure not to miss the new include aka using directive in the first line of the file, referencing the namespace of the library!  

5. Just to be sure, that everythink works as expected try again running the app by `dotnet run`. If all went well, there should open a window including the textbox. When double-clicking the textbox, the content should change to the name and costs of a resource.  
