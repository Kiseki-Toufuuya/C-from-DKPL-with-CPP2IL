namespace UnityEngine.Timeline;

internal struct DiscreteTime : IComparable
{
	private const double k_Tick = 1E-12; //Field offset: 0x0
	public static readonly DiscreteTime kMaxTime; //Field offset: 0x0
	private readonly long m_DiscreteTime; //Field offset: 0x0

	public static double tickValue
	{
		 get { } //Length: 7
	}

	private static DiscreteTime() { }

	public DiscreteTime(DiscreteTime time) { }

	private DiscreteTime(long time) { }

	public DiscreteTime(double time) { }

	public DiscreteTime(float time) { }

	public DiscreteTime(int time) { }

	public DiscreteTime(int frame, double fps) { }

	public override int CompareTo(object obj) { }

	private static long DoubleToDiscreteTime(double time) { }

	public virtual bool Equals(object obj) { }

	public bool Equals(DiscreteTime other) { }

	private static long FloatToDiscreteTime(float time) { }

	public static DiscreteTime FromTicks(long ticks) { }

	public static double get_tickValue() { }

	public virtual int GetHashCode() { }

	public static long GetNearestTick(double time) { }

	public long GetTick() { }

	private static long IntToDiscreteTime(int time) { }

	public static DiscreteTime Max(DiscreteTime lhs, DiscreteTime rhs) { }

	public static DiscreteTime Min(DiscreteTime lhs, DiscreteTime rhs) { }

	public DiscreteTime OneTickAfter() { }

	public DiscreteTime OneTickBefore() { }

	public static DiscreteTime op_Addition(DiscreteTime lhs, DiscreteTime rhs) { }

	public static bool op_Equality(DiscreteTime lhs, DiscreteTime rhs) { }

	public static DiscreteTime op_Explicit(long time) { }

	public static float op_Explicit(DiscreteTime b) { }

	public static DiscreteTime op_Explicit(float time) { }

	public static DiscreteTime op_Explicit(double time) { }

	public static long op_Explicit(DiscreteTime b) { }

	public static double op_Explicit(DiscreteTime b) { }

	public static bool op_GreaterThan(DiscreteTime lhs, DiscreteTime rhs) { }

	public static bool op_GreaterThanOrEqual(DiscreteTime lhs, DiscreteTime rhs) { }

	public static DiscreteTime op_Implicit(int time) { }

	public static bool op_Inequality(DiscreteTime lhs, DiscreteTime rhs) { }

	public static bool op_LessThan(DiscreteTime lhs, DiscreteTime rhs) { }

	public static bool op_LessThanOrEqual(DiscreteTime lhs, DiscreteTime rhs) { }

	public static DiscreteTime op_Subtraction(DiscreteTime lhs, DiscreteTime rhs) { }

	public static double SnapToNearestTick(double time) { }

	public static float SnapToNearestTick(float time) { }

	private static double ToDouble(long time) { }

	private static float ToFloat(long time) { }

	public virtual string ToString() { }

}

