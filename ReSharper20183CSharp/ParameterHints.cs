using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
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