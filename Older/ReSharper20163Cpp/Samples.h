#pragma once

#include <filesystem>

class Samples
{
public:
  Samples();
  ~Samples();
};


/*
 *20163 Postfix completion and postfix templates in C++
 * to type 'if (is_directory(path))'  in the 'read' method below,
 * type 'path.idir' and choose is_directory in the completion list, 
 * then type '.if' to wrap the expression with 'if(..)'
 */

/*
 * 20163 Introduce Typedef/Inline Typedef refactorings
 * 1. select std::experimental::filesystem::path below, press Ctrl+Shift+R
 * and choose Introduce Typedef
 * 2. invoke Refactor This on the newly created typedef and choose Inline Typedef
 */

void doSomething();

inline void read(std::experimental::filesystem::path path)
{
  std::vector<int> nums{ 3, 4, 2, 8, 15, 267 };
  for (int value_ : nums) 

}

inline void write(std::experimental::filesystem::path path)
{  
}