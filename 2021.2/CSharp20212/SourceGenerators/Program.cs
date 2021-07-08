using System;

namespace CSharp20212.SourceGenerators
{
    static class Program
    {
        private static void Main(string[] args)
        {
            // change signature refactoring demo
            foreach (var project in args)
            {
                var rowSample = new Range(0, 100);
                var table = SharedUtil.ImportCsv(project);
                Console.WriteLine(table);
            }
        }

        // static void Main(string[] args)
        // {
        //   // debug demo
        //   var person = GeneratedFileDaemon.CreatePerson(null, 27);
        //   Console.WriteLine(person);
        // }
    }

    [Import("Table ImportCsv(string path)", @"..\SharedImpl\ImportTools.cs")]
    [Import("Table ImportCsvRow(string path, int row)", @"..\SharedImpl\ImportTools.cs")]
    public static partial class SharedUtil
    {
    }
}