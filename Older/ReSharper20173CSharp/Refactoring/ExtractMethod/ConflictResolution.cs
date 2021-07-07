using System.IO;

namespace ReSharper20173CSharp.Refactoring.ExtractMethod
{
    class ConflictResolution
    {
        private static string GetText1(string path, string filename)
        {
            // Let's extract this line:
            var reader = File.OpenText(AppendPathSeparator(path) + filename);
            var text = reader.ReadToEnd();
            return text;

            // Which would need this function as well...
            string AppendPathSeparator(string filepath)
            {
                if (!filepath.EndsWith(@"\"))
                    filepath += @"\";

                return filepath;
            }
        }

        private static string GetText2(string path, string sourceFileName, string targetFileName)
        {
            // Let's extract this line which uses a local function:
            var reader = File.OpenText(AppendPathSeparator(path) + sourceFileName);
            var text = reader.ReadToEnd();

            // But be warned! This line also uses the same local function:
            File.WriteAllText(AppendPathSeparator(path) + targetFileName, text);
            return text;

            string AppendPathSeparator(string filepath)
            {
                if (!filepath.EndsWith(@"\"))
                    filepath += @"\";

                return filepath;
            }
        }
    }
}