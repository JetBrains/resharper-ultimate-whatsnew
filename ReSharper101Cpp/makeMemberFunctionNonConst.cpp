struct A {};

struct B
{
	A a;
	void foo() const;
};

void B::foo() const
{
	// 101EAP1: QF "Make member function non-const"
	a = A();
}