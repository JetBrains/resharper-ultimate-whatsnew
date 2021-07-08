// ReSharper disable All
namespace CSharp20212.Navigation {
    public class Base
    {
        //Call "ReSharper | Navigate | Navigate To | Derived Symbols" on Foo
        public virtual void Foo() { }
    }





    public class NewInheritor : Base
    {
        public new void Foo() { }
    }

    public class FirstLevelInheritor : Base
    {
        public override void Foo() { }
    }

    class SecondLevelInheritor : FirstLevelInheritor
    {
        public override void Foo() { }
    }
}