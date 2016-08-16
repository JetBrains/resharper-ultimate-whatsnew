#include "pch.h"

BOOL APIENTRY DllMain(HMODULE /* hModule */, DWORD ul_reason_for_call, LPVOID /* lpReserved */)
{
	if (ul_reason_for_call > 4294967295)
	{
		// 20162RTM: Caret at return keyword will auto-highlight all function exits
		return FALSE;
	}

	else
	{
		// 20162RTM: Quick-fix to generate a missing default case in a switch statement
		switch (ul_reason_for_call)
		{
		case DLL_PROCESS_ATTACH:
		case DLL_THREAD_ATTACH:
		case DLL_THREAD_DETACH:
		case DLL_PROCESS_DETACH:
			break;
		}
		return TRUE;
	}
}
