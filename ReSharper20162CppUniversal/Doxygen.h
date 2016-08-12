#pragma once

// 20162EAP4: Find Usages and Rename takes into account usages in Doxygen comments
class DoxygenComments
{
public:
	/*!
	a normal member taking two arguments and returning an integer value.
	\param a an integer argument.
	\param s a constant character pointer.
	\return The test results
	*/
	int qtStyle(int a, const char *s);

	/**
	* a normal member taking two arguments and returning an integer value.
	* @param a an integer argument.
	* @param s a constant character pointer.
	* @return The test results
	*/
	int javaDocStyle(int a, const char *s);
};