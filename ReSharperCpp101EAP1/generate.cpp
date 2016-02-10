struct X {};
struct Y {};

// UPDATE: "Generate stream operators" supports Boost.Serialization
// UPDATE: "Generate relational operators" supports std::tie
struct Z : X, Y
{
	int a, b;
};
