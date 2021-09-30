using System.Diagnostics.CodeAnalysis;

// ReSharper disable UnusedMember.Local
// ReSharper disable UnusedType.Global
// ReSharper disable UnusedVariable

namespace CSCodeAnalysis;
#nullable disable
[SuppressMessage("ReSharper", "UnusedMember.Global")]

public class RemoveNRTSyntaxForNonNRTContext
{
    //Paste here the method from the CodeForCSharpDemo class
    //Nullable is disabled for the file
    //ReSharper will suggest removing redundant NRT syntax or replace it with JetBrains.Annotations attributes 
}

class WithStaticLocalFunctionWithClosure
{

    void DemoMethod(int closure)
    {
        Console.WriteLine(LocalFunction());

        static int LocalFunction()
        {
            //Alt+Enter on "closure"
            return closure;
        }
    }
}

class WithNonStaticLocalFunctionWithClosure
{

    void DemoMethod(int closure)
    {
        Console.WriteLine(LocalFunction());

        int LocalFunction()
        {
            //Alt+Enter on "closure" | Select the context action
            return closure;
        }
    }
}

class ReplacePadLeftPadRightWithStrInterpolationPlaceholders
{
    private void DemoMethod(int i)
    {
        //Alt+Enter on the squiggle below
        var s = $"... { i.ToString("bar").PadLeft(3) } ...";
    }
}