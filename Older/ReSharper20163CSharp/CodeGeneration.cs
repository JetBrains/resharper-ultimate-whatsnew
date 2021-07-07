using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace ReSharper20163CSharp
{
  public class CodeGeneration
  {
    // 20163 Implement IComparable<T> (used for sorting)
    // cursor on a free line inside class => AltIns => Relational members => select _sizeCm field

    // Implement Comparer<T> (base class to provide custom implementation of IComparer<T>)
    // cursor on a free line inside class => AltIns => Relational comparer => select _sizeCm field
    class ShoeSize
    {
      private int _sizeCm;

      public int SizeCm => _sizeCm;

      public int SizeEu
      {
        get { return (int) (1.5 * _sizeCm); }
        set { _sizeCm = (int) (value / 1.5); }
      }
    }


    // 20163 Generate relational members
    // cursor on a free line inside class => AltIns => Relational members => select _name field => note that you can choose different string comparison options
    class Account
    {
      private string _name;
      private string _email;

      public string Name => _name;
      public string EMail => _email;
    }

    // 20163 Dispose pattern generator
    // AltEnter on IDisposable => Generate dispose pattern (or AltIns => Dispose pattern) => select _handle as a resource that must be disposed
    class HandleWrapper : IDisposable
    {
      readonly SafeHandle _handle = new SafeFileHandle(IntPtr.Zero, true);
    }
  }
}