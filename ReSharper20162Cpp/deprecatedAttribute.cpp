class __declspec(deprecated) DeprecatedClass
{
public:
    __declspec(deprecated)
    static int deprecatedFunction()
    {
        return 42;
    }
};

static void globalFunction()
{
    auto p = DeprecatedClass::deprecatedFunction();
}