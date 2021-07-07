using System;

namespace ReSharper20162CSharp
{
    public class SuppressSsrHighlight
    {
        public void SuppressHighlightOfLocalisedDateTimeNow()
        {
            // 20162RTM: SSR pattern from solution will flag DateTime.Now as a suggestion
            // Alt+Enter to allow "Disable once with comment"
            var dateTime = DateTime.Now;
            Console.WriteLine(dateTime);
        }
    }
}