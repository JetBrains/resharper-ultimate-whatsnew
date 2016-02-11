class BaseClass final
{
public:
	BaseClass(void);

	BaseClass(
		const double glitchDistance,
		const int glitchPosition);

	virtual const double GetDistance(void) final;

	~BaseClass(void);

private:
	double m_distance;
	int m_position;
};

// UPDATE: QF "Make base class non-final"
class glitch_element : public BaseClass
{
public:
	// UPDATE: QF "Make base function non-final"
	const double GetDistance() override;
};