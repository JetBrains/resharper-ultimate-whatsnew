using System;

namespace ReSharper20173CSharp.Refactoring.ExtractMethod
{
    class ExtractLocalFunction
    {
        public Uri CreateUrl(string url = "https://www.jetbrains.com/")
        {
            // Select this statement and extract a locatl function (Ctrl+R, M)
            if (!url.EndsWith("/"))
            {
                url = url + "/";
            }

            return new Uri(url);
        }
    }
}