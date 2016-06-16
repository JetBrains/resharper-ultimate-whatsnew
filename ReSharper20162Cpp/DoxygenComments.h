#pragma once

// Check for find usages and rename on parameter names
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
