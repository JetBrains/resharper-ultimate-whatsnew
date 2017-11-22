using System;

namespace ReSharper20173CSharp.Deconstructors.Formatter
{
    public class WrapChopLongLines
    {
        public void Demo()
        {
            // AltEnter on the following line, use wrap/chop and show the difference between both
            var reportHtml = CreateReport("359CD313-7C7E-49B2-A2AB-E12FDFD1319D", DateTimeOffset.UtcNow.AddMonths(-1), DateTimeOffset.UtcNow, useRichText: true);
        }

        public static string CreateReport(string customerId, DateTimeOffset from, DateTimeOffset to, bool useRichText)
        {
            return string.Empty;
        }
    }
}