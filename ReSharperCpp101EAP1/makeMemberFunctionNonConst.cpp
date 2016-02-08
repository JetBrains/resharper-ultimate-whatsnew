struct A {};

struct B
{
	A a;
	void foo() const;
};

void B::foo() const
{
	// UPDATE: QF "Make member function non-const"
	a = A();
}