// ReSharper disable UnusedMember.Global
// ReSharper disable NotAccessedField.Local
namespace ReSharper20163CSharp
{
  public class IntroduceFromUnusedParameters
  {
    private readonly int _used;

    // 20163 Introduce From Unused Parameters quick-fix
    //
    // Quick Fix - hit Alt+Enter on any unused parameter to introduce a single field or property
    // Expand menu to introduce from all unused parameters
    // Expand Introduce Property menu item to change what kind of property is generated
    // Expand Introduce Property → Configure default to choose the default property kind suggested by the Quick Fix
    public IntroduceFromUnusedParameters(int unused1, int unused2, int used, int unused3)
    {
      _used = used;
    }
  }
}