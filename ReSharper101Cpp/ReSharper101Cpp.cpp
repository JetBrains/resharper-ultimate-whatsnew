#include "ReSharper101Cpp.h"



ReSharper101Cpp::ReSharper101Cpp()
{
}


ReSharper101Cpp::~ReSharper101Cpp()
{
	// 20161RTM: QF "Remove empty declaration"
}


int ReSharper101Cpp::changeReturnType()
{
	const char* wrongType = "asdf";

	// 20161RTM: QF "Change return type of function"
	return wrongType;

};

void ReSharper101Cpp::makeMemberMutable()
{
	const struct
	{
		int n1;
		int n2;
	} 
	
	constStruct = { 0, 0 };

	// 20161RTM: QF "Make data member mutable"
	constStruct.n1 = 2;
	constStruct.n2 = 4;
}

