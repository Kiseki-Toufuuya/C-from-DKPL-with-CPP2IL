namespace System;

[IsReadOnly]
public struct TimeSpan : IComparable, IComparable<TimeSpan>, IEquatable<TimeSpan>, IFormattable, ISpanFormattable
{
	public static readonly TimeSpan Zero; //Field offset: 0x0
	public static readonly TimeSpan MaxValue; //Field offset: 0x8
	public static readonly TimeSpan MinValue; //Field offset: 0x10
	internal readonly long _ticks; //Field offset: 0x0

	public int Days
	{
		 get { } //Length: 28
	}

	public int Hours
	{
		 get { } //Length: 36
	}

	public int Minutes
	{
		 get { } //Length: 36
	}

	public long Ticks
	{
		 get { } //Length: 13
	}

	public double TotalDays
	{
		 get { } //Length: 39
	}

	public double TotalHours
	{
		 get { } //Length: 39
	}

	public double TotalMilliseconds
	{
		 get { } //Length: 83
	}

	public double TotalMinutes
	{
		 get { } //Length: 39
	}

	public double TotalSeconds
	{
		 get { } //Length: 39
	}

	private static TimeSpan() { }

	public TimeSpan(int days, int hours, int minutes, int seconds, int milliseconds) { }

	public TimeSpan(long ticks) { }

	public TimeSpan(int hours, int minutes, int seconds) { }

	public TimeSpan Add(TimeSpan ts) { }

	public static int Compare(TimeSpan t1, TimeSpan t2) { }

	public override int CompareTo(object value) { }

	public override int CompareTo(TimeSpan value) { }

	public virtual bool Equals(object value) { }

	public override bool Equals(TimeSpan obj) { }

	public static TimeSpan FromDays(double value) { }

	public static TimeSpan FromHours(double value) { }

	public static TimeSpan FromMilliseconds(double value) { }

	public static TimeSpan FromMinutes(double value) { }

	public static TimeSpan FromSeconds(double value) { }

	public static TimeSpan FromTicks(long value) { }

	public int get_Days() { }

	public int get_Hours() { }

	public int get_Minutes() { }

	public long get_Ticks() { }

	public double get_TotalDays() { }

	public double get_TotalHours() { }

	public double get_TotalMilliseconds() { }

	public double get_TotalMinutes() { }

	public double get_TotalSeconds() { }

	public virtual int GetHashCode() { }

	private static TimeSpan Interval(double value, int scale) { }

	public TimeSpan Negate() { }

	public static TimeSpan op_Addition(TimeSpan t1, TimeSpan t2) { }

	public static bool op_Equality(TimeSpan t1, TimeSpan t2) { }

	public static bool op_GreaterThan(TimeSpan t1, TimeSpan t2) { }

	public static bool op_GreaterThanOrEqual(TimeSpan t1, TimeSpan t2) { }

	public static bool op_Inequality(TimeSpan t1, TimeSpan t2) { }

	public static bool op_LessThan(TimeSpan t1, TimeSpan t2) { }

	public static bool op_LessThanOrEqual(TimeSpan t1, TimeSpan t2) { }

	public static TimeSpan op_Subtraction(TimeSpan t1, TimeSpan t2) { }

	public static TimeSpan op_UnaryNegation(TimeSpan t) { }

	public static TimeSpan Parse(string input, IFormatProvider formatProvider) { }

	public static TimeSpan Parse(string s) { }

	public TimeSpan Subtract(TimeSpan ts) { }

	internal static long TimeToTicks(int hour, int minute, int second) { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

	public virtual string ToString() { }

	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider formatProvider = null) { }

}

