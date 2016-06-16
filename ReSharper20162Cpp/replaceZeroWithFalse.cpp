#define MY_TRUE 1000

class ReplaceZeroWithBoolean
{
    static bool getFalseValue()
    {
        // Place caret on the 0 below, Alt+Enter → Replace expression with false
        return 0;
    }

    static bool getTrueValue()
    {
        // Place caret on the non-zero value below, Alt+Enter → Replace expression with true
        return 1;
    }

    static bool getTrueValueFromMacro()
    {
        // Place caret on the non-zero macro value below, Alt+Enter → Replace expression with true
        return MY_TRUE;
    }
};