#pragma once
#include <iostream>

class ReSharper101Cpp
{
	// 101EAP1: QF "Create and initialize field from constructor parameter
	ReSharper101Cpp(int x, char lalala)
	{
	}

	ReSharper101Cpp();
	~ReSharper101Cpp();

	static int changeReturnType();
	static void makeMemberMutable();
};