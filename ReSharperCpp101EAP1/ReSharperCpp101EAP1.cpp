#include "ReSharperCpp101EAP1.h"



ReSharperCpp101EAP1::ReSharperCpp101EAP1()
{
}


ReSharperCpp101EAP1::~ReSharperCpp101EAP1()
{
	// 101EAP1: QF "Remove empty declaration"
}


int ReSharperCpp101EAP1::changeReturnType()
{
	const char* wrongType = "asdf";

	// 101EAP1: QF "Change return type of function"
	return wrongType;

};

void ReSharperCpp101EAP1::makeMemberMutable()
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

