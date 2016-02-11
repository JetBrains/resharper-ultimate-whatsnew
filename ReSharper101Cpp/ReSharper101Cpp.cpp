#include "ReSharper101Cpp.h"



ReSharper101Cpp::ReSharper101Cpp()
{
}


ReSharper101Cpp::~ReSharper101Cpp()
{
	// 101EAP1: QF "Remove empty declaration"
}


int ReSharper101Cpp::changeReturnType()
{
	const char* wrongType = "asdf";

	// 101EAP1: QF "Change return type of function"
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

	// 101EAP1: QF "Make data member mutable"
	constStruct.n1 = 2;
	constStruct.n2 = 4;
}

