#pragma once
#include <iostream>

class ReSharperCpp101EAP1
{
	// 101EAP1: QF "Create and initialize field from constructor parameter
	ReSharperCpp101EAP1(int x, char lalala)
	{
	}

	ReSharperCpp101EAP1();
	~ReSharperCpp101EAP1();

	static int changeReturnType();
	static void makeMemberMutable();
};