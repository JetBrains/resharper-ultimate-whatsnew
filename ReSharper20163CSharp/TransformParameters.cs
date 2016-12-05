// ReSharper disable UnusedMember.Global
namespace ReSharper20163CSharp
{
  public class TransformParameters
  {
    // 20163 Transform Parameters refactoring
    //
    // Converts incoming parameters to new class or tuple. Converts out parameters and return value to
    // new class or tuple
    // Invoke Refactor This on method signature (method name or parameters) and select Transform Parameters
    public bool DoSomething(int param1, string param2, int param3, out bool param4)
    {
      param4 = true;

      return false;
    }
  }
}