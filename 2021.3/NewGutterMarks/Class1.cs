// ReSharper disable All




namespace NewGutterMarks;

internal interface ITopInterface {
    public void Foo() {}
}
internal class TopClass : ITopInterface {
    void ITopInterface.Foo() { }
    protected virtual void Goo() { }
}
internal class ClassImpl : TopClass, ITopInterface {
    protected override void Goo() { }
}




internal struct MyStruct : ITopInterfaceImpl {
    public void Foo() { }
}

internal class ClassOneMoreImpl : TopClass {
    protected override void Goo() { }
}

internal interface ITopInterfaceImpl : ITopInterface {
    void ITopInterface.Foo() { }
}
