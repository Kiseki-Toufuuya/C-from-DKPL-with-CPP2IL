namespace System;

[IsReadOnly]
public struct DateTimeOffset : IComparable, IFormattable, IComparable<DateTimeOffset>, IEquatable<DateTimeOffset>, ISerializable, IDeserializationCallback, ISpanFormattable
{
	public static readonly DateTimeOffset MinValue; //Field offset: 0x0
	public static readonly DateTimeOffset MaxValue; //Field offset: 0x10
	public static readonly DateTimeOffset UnixEpoch; //Field offset: 0x20
	private readonly DateTime _dateTime; //Field offset: 0x0
	private readonly short _offsetMinutes; //Field offset: 0x8

	private DateTime ClockDateTime
	{
		private get { } //Length: 243
	}

	public DateTime DateTime
	{
		 get { } //Length: 65
	}

	public int Day
	{
		 get { } //Length: 173
	}

	public int Hour
	{
		 get { } //Length: 186
	}

	public DateTime LocalDateTime
	{
		 get { } //Length: 173
	}

	public int Millisecond
	{
		 get { } //Length: 122
	}

	public int Minute
	{
		 get { } //Length: 122
	}

	public int Month
	{
		 get { } //Length: 173
	}

	public static DateTimeOffset Now
	{
		 get { } //Length: 87
	}

	public TimeSpan Offset
	{
		 get { } //Length: 50
	}

	public int Second
	{
		 get { } //Length: 122
	}

	public long Ticks
	{
		 get { } //Length: 165
	}

	public TimeSpan TimeOfDay
	{
		 get { } //Length: 178
	}

	public DateTime UtcDateTime
	{
		 get { } //Length: 158
	}

	public static DateTimeOffset UtcNow
	{
		 get { } //Length: 151
	}

	public int Year
	{
		 get { } //Length: 173
	}

	private static DateTimeOffset() { }

	private DateTimeOffset(SerializationInfo info, StreamingContext context) { }

	public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar, TimeSpan offset) { }

	public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, TimeSpan offset) { }

	public DateTimeOffset(long ticks, TimeSpan offset) { }

	public DateTimeOffset(DateTime dateTime, TimeSpan offset) { }

	public DateTimeOffset(DateTime dateTime) { }

	public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, TimeSpan offset) { }

	public static int Compare(DateTimeOffset first, DateTimeOffset second) { }

	public override int CompareTo(DateTimeOffset other) { }

	public override bool Equals(DateTimeOffset other) { }

	public virtual bool Equals(object obj) { }

	public static DateTimeOffset FromFileTime(long fileTime) { }

	private DateTime get_ClockDateTime() { }

	public DateTime get_DateTime() { }

	public int get_Day() { }

	public int get_Hour() { }

	public DateTime get_LocalDateTime() { }

	public int get_Millisecond() { }

	public int get_Minute() { }

	public int get_Month() { }

	public static DateTimeOffset get_Now() { }

	public TimeSpan get_Offset() { }

	public int get_Second() { }

	public long get_Ticks() { }

	public TimeSpan get_TimeOfDay() { }

	public DateTime get_UtcDateTime() { }

	public static DateTimeOffset get_UtcNow() { }

	public int get_Year() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(DateTimeOffset left, DateTimeOffset right) { }

	public static DateTimeOffset op_Implicit(DateTime dateTime) { }

	public static bool op_Inequality(DateTimeOffset left, DateTimeOffset right) { }

	public static TimeSpan op_Subtraction(DateTimeOffset left, DateTimeOffset right) { }

	public static DateTimeOffset Parse(string input, IFormatProvider formatProvider, DateTimeStyles styles) { }

	public static DateTimeOffset Parse(string input, IFormatProvider formatProvider) { }

	public static DateTimeOffset ParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles) { }

	private override int System.IComparable.CompareTo(object obj) { }

	private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	public DateTimeOffset ToOffset(TimeSpan offset) { }

	public string ToString(IFormatProvider formatProvider) { }

	public virtual string ToString() { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

	public DateTimeOffset ToUniversalTime() { }

	public long ToUnixTimeMilliseconds() { }

	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider formatProvider = null) { }

	public static bool TryParse(string input, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result) { }

	public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result) { }

	private static DateTime ValidateDate(DateTime dateTime, TimeSpan offset) { }

	private static short ValidateOffset(TimeSpan offset) { }

	private static DateTimeStyles ValidateStyles(DateTimeStyles style, string parameterName) { }

}

