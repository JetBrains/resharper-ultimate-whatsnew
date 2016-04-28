struct A {};

struct B
{
	A a;
	void foo() const;
};

void B::foo() const
{
	// 20161RTM: QF "Make member function non-const"
	a = A();
}