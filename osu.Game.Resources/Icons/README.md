# How to generate `Icons.res`

1. Open `Developer PowerShell for VS 2022`
2. `cd` into this directory
3. Run `RC.exe /v Icons.rc`

# Adding new icons

1. Put the `.ico` file with a reasonable name into this folder
2. Open `Icons.rc` as a text file and add the relevant lines
3. Add the C# definition to `Icons.cs`
4. Regenerate `Icons.res`
