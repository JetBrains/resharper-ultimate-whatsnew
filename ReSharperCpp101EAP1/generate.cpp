struct X {};
struct Y {};

// 101EAP1: "Generate stream operators" supports Boost.Serialization
// 101EAP1: "Generate relational operators" supports std::tie
struct Z : X, Y
{
	int a, b;
};
