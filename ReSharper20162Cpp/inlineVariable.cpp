#include "stdafx.h"

class InlineVariable
{
	// 20162RTM: Inline Variable in C++
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
