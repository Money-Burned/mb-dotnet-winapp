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
