using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ReSharper20183CSharp
{
    [SuppressMessage("ReSharper", "ArgumentsStyleLiteral")]
    public class ParameterHints
    {
        public IEnumerable<string> SplitWords(string sentence)
        {
            if (string.IsNullOrEmpty(sentence)) return Enumerable.Empty<string>();

            return Regex.Split(sentence, "\\s");
        }

        public void NullAndBoolean()
        {
            var peopleService = new PeopleService();
            var people = peopleService.Find("Maarten", null, false);
        }

        public void NoParameterHintsForThese()
        {
            var range = Enumerable.Range(10, 20);
            var minimum = Math.Min(1, 2);
            
            var person1 = new Person();
            var person2 = new Person();
            var areEqual = person1.Equals(person2);

            var stringBuilder = new StringBuilder();
            stringBuilder.Append("Hello, ");
            stringBuilder.Append("World!");
        }

        #region Clutter

        public class Person
        {
            
        }

        public class PeopleService
        {
            public IEnumerable<Person> Find(string firstName, string lastName, bool caseSensitive)
            {
                return null;
            }
        }

        #endregion
    }
}