using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharp20212.SourceGenerators
{
    public static partial class SharedUtil
    {
        private static Document OpenFile(string path)
        {
            throw new NotImplementedException();
        }
    }

    public class Document
    {
        public string[] Rows
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public string this[int row]
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class Range : IEnumerable<int>
    {
        public Range(int start, int end)
        {
            Start = start;
            End = end;
        }

        public int Start { get; set; }
        public int End { get; set; }

        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Table
    {
        public void Import(string row)
        {
            throw new NotImplementedException();
        }
    }


    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    class ImportAttribute : System.Attribute
    {
        public ImportAttribute(string member, string implPath)
        {

        }
    }
}