using System;

namespace ReSharper20173CSharp.Deconstructors.Formatter
{
    // Control formatter using comments
    // 
    // 1. Remove any last } here, then type it again. Note R# reformats the entire thing to:
    // {
    // }
    //
    // Ideally we want to keep the one-liners in this class!
    //
    // 2. Add // @formatter:off at the start of class or method, and // @formatter:on at the end.
    //    If we now do the } thing, no reformatting is done.

    // [AT]formatter:off
    public class BlogPostException : Exception
    {
        public BlogPostException() { }

        public BlogPostException(string message) : base(message) { }

        public BlogPostException(string message, Exception innerException) : base(message, innerException) { } // 
    }
    // [AT]formatter:on
}