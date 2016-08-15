using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace ReSharper20162CSharp
{
  class Templates
  {
  }

  [SuppressMessage("ReSharper", "UnusedMember.Local")]
  [SuppressMessage("ReSharper", "ArrangeTypeMemberModifiers")]
  [SuppressMessage("ReSharper", "InvertIf")]
  [SuppressMessage("ReSharper", "UseObjectOrCollectionInitializer")]
  public class Class1
  {

    //20162RTM: Surrond templates in completion suggestions. Select the statement and type 'if', then press Enter

    void Foo(string fileName, byte[] buffer)
    {
        var fileStream = new FileStream(fileName, FileMode.Open);
    }

  }
}