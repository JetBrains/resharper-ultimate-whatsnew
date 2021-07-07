using System;
using System.Diagnostics.CodeAnalysis;

namespace ReSharper20162CSharp
{
  [SuppressMessage("ReSharper", "ConvertToConstant.Local")]
  class InjectedHtml
  {

    // 20162RTM: 'Mark as HTML' context action
    public InjectedHtml()
    {
      var myHtml = @"<p>Lorem ipsum dolor sit amet, 
      <i>consectetur adipiscing elit</i>, sed do eiusmod dolore magna aliqua. 
      Ut enim ad <i>minim veniam</b>, quis nostrud exercitation 
      ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>";



      //language=html
      var myHtm =  @"<p>Lorem ipsum dolor sit amet, 
      <i>consectetur adipiscing elit</i>, sed do eiusmod dolore magna aliqua. 
      Ut enim ad <i>minim veniam</b>, quis nostrud exercitation 
      ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>";

      //language=regexp
      var myRegex =  @"(?<word>[A-Za-z]+)(?<";






      Console.WriteLine(myHtml);
      Console.WriteLine(myHtm);
      Console.WriteLine(myRegex);
    }
  }
}
