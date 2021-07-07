#pragma once

inline char* assessOperatingSystem(int windowsVersion) {

	// 20162RTM: Quick-fix to generate a missing default case in a switch statement
	switch (windowsVersion) {
	case 10:
		return "Excellent!";
	case 8:
		return "Meh but works";
	case 7:
		return "Try again, Hadi!"; // 20162RTM: Caret at return keyword will auto-highlight all function exits
	}

	return nullptr;
}
