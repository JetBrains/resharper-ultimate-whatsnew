// ReSharper20172Cpp.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"

// Expression result unused inspection
int SomeFunction(int x)
{
	if (x == 1)
		return 1;
	else if (x == 2)
		2; // Expression result unused / quickfix to return unused expression
	else
		return 3;
}