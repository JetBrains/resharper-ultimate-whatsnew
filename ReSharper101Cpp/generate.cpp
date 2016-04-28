struct X {};
struct Y {};

// 20161RTM: "Generate stream operators" supports Boost.Serialization
// 20161RTM: "Generate relational operators" supports std::tie
struct Z : X, Y
{
	int a, b;
};
