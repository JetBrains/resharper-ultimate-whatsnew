using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReSharper20163CSharp
{
  class Other
  {
    // 20163 Interpolated strings typing assist improved
    // place cursor after = and type $ => R# will generate $"" and put cursor inside the parentheses
    private string interpolatedString = $""

    //20163 Join Lines action
    // select both lines inside the JoinTwoLines() method => AltEnter => type 'join' => select 'Join Lines'
    // If you are using the IntelliJ IDEA/ReSharper 2.x keymap, press Ctrl+Shift+J
    private void JoinTwoLines()
    {
      var s1 = "This story will ";
      var s2 = "never end";
    }
  }

  //20163 User-defined language injections: marked as a range
  // cursor inside string; AltEnter -> Mark as CSS
  // AltEnter on color -> Convert color to rgb()
  public class LanguageInjections
  {
    private const string Style = @".title
            {
                color: red;
                font-size: 12pt;
                font-weight: bold;                            
            }";

    // place cursor inside string => AltEnter => Mark as => JavaScript
    private string _script = "alert('Hello World!');";

    // 20163 User-defined language injections: comment with prefix and postfix
    // store only css parameter value. To treat it like css, simply add prefix and postfix
    // cursor after css (in comment) => type prefix=.myClass{color: postfix=}
    //language=css
    private string toolBarColor = "gree";
  }

  // 20163 C# SSR improvements: string and integer numeric literals now match by value 
  // (literals representing the same integers written with different suffixes, in different radixes, with digit separators or not are now considered 'similar')
  // select 2 * Second => AltEnter => type "search" => select 'Search with Pattern' => 'Match similar constructs' must be checked => navigate to the construct in the Third property 
  class MatchSimilarConstructs
  {
    public int First => 42 * Second;
    public int Second => 42 * Third;
    public int Third => 0x2A * First;
  }


  // 20163 Indenting of nested for, foreach, while, lock statements without braces is now disabled by default
  // with options to restore the old behavior
  class FormattingNestedStatements
  {
    public FormattingNestedStatements(int[] array1, int[] array2)
    {
      for (int i = 0; i < array1.Length; i++)
      for (int j = 0; j < array2.Length; j++)
          Console.WriteLine($"i={i}; j={j}");
    }
  }

}