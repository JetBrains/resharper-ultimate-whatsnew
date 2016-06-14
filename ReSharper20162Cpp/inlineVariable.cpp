class InlineVariable
{
    static int getValue(int input1, int input2)
    {
        auto result = input1 + input2;
        // Place caret on `result` below, invoke Refactor This → Inline Variable
        return result;
    }

    static int getValueSquared(int input1, int input2)
    {
        auto result = input1 + input2;
        // Place caret on `result` below, invoke Refactor This → Inline Variable
        return result * result;
    }
};