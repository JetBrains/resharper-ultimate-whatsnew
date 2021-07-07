using System;

namespace ReSharper101CSharp
{
  class BracesForSingleLinersStyle
  {

    //20161RTM: Code style for braces around single-line statements

    void Test(object arg)
    {

         if (arg == null)  throw new ArgumentNullException(nameof(arg));








    }
  }
}
