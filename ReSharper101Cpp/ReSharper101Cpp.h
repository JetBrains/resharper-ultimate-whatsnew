#pragma once
#include <iostream>

class ReSharper101Cpp
{
	// 20161RTM: QF "Create and initialize field from constructor parameter
	ReSharper101Cpp(int x, char lalala)
	{
	}

	ReSharper101Cpp();
	~ReSharper101Cpp();

	static int changeReturnType();
	static void makeMemberMutable();
};