﻿#include "stdafx.h"

class __declspec(deprecated) DeprecatedClass
{
public:
	__declspec(deprecated)
		static int deprecatedFunction()
	{
		return 42;
	}
};

// 20162RTM: Inspection: usage of deprecated symbols
static void globalFunction()
{
	auto p = DeprecatedClass::deprecatedFunction();
}