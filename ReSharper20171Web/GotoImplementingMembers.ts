interface IMyInterface {
    interfaceMethod();
    interfaceProperty: string;
}

class MyBaseClass {
    baseMethod1(): string { throw new Error("Not implemented"); }
    baseProperty: string;
}

// Navigate To menu on IMyInterface and highlight Implementing Members
// Navigate To menu on MyBaseClass and highlight Overriding Members
class MyClass extends MyBaseClass implements IMyInterface {
    interfaceMethod() {
    }

    interfaceProperty: string;

    baseMethod1(): string { return "Hello world"; }

    baseProperty: string;
}