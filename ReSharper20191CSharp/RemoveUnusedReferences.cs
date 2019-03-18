namespace ReSharper20191CSharp
{
    public class BackspaceTypingAssist
    {
        public void Run()
        {
            // 1. Add a newline: (place caret here and enter)

            // 2. Press backspace, note we are unindenting code.
        }
    }
    public class RemoveUnusedReferences
    {
        // 1. Make sure the project file contains a couple of NuGet references, e.g.:
        /*
            <ItemGroup>
                <PackageReference Include="CsvHelper" Version="12.1.2" />
                <PackageReference Include = "Microsoft.EntityFrameworkCore" Version="3.0.0-preview.19074.3" />
                <PackageReference Include = "Newtonsoft.Json" Version="12.0.1" />
            </ItemGroup>
        */

        // 2. Build the project (to ensure packages are all restored)

        // 3. Use the context menu on ReSharper20191CSharp, Optimize References... (Ctrl+Alt+Y)

        // 4. See there are three unused NuGet references (CsvHelper, Microsoft.EntityFrameworkCore and Newtonsoft.Json)

        // 5. Remove one of them, verify the package is uninstalled.
    }
}