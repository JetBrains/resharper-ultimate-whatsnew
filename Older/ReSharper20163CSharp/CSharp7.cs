using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReSharper20163CSharp
{
  class CSharp7
  {
    // 20163 Context actions for binary literals, digit separators, etc.
    // AltEnter, play with 'Convert to hex', 'Separate thousands'
    private const int Billion = 1000000000;
  }


  // 20163 Support for out variables, local functions, etc.
  // VS2017 is required

  //class CSharp7Patterns
  //{
  //public void UseIsPattern(object o)
  //{
  //    if (o is int i)
  //        {

  //    }
  //}
  //}



  //static class MyOutClass
  //{
  //    public static void SetRandomXyValues(out int x, out int y)
  //    {
  //        var rnd = new Random();
  //        x = rnd.Next();
  //        y = rnd.Next();
  //    }

  //    private static void TestOut()
  //    {            
  //        SetRandomXyValues(out int x, out int y);
  //        Debug.Print($"{x}, {y}");
  //    }

  //}
}
