#include "ReSharperCpp101EAP1.h"



ReSharperCpp101EAP1::ReSharperCpp101EAP1()
{
}


ReSharperCpp101EAP1::~ReSharperCpp101EAP1()
{
	// UPDATE: QF "Remove empty declaration"
}


int ReSharperCpp101EAP1::returnNumber()
{
	const char* wrongType = "asdf";

	// UPDATE: QF "Change return type of function"
	return wrongType;

};
