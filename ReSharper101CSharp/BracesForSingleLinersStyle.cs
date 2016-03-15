using System;

namespace ReSharper101CSharp
{
  class BracesForSingleLinersStyle
  {

    //TODO: 101EAP6 Code style for braces around single-line statements

    void Test(object arg)
    {

         if (arg == null)  throw new ArgumentNullException(nameof(arg));








    }
  }
}
