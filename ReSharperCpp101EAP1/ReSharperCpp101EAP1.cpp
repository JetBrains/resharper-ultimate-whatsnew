#include "ReSharperCpp101EAP1.h"



ReSharperCpp101EAP1::ReSharperCpp101EAP1()
{
}


ReSharperCpp101EAP1::~ReSharperCpp101EAP1()
{
	// UPDATE: QF "Remove empty declaration"
}


int ReSharperCpp101EAP1::changeReturnType()
{
	const char* wrongType = "asdf";

	// UPDATE: QF "Change return type of function"
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

	// UPDATE: QF "Make data member mutable"
	constStruct.n1 = 2;
	constStruct.n2 = 4;
}

