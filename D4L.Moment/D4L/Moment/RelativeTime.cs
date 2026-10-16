namespace D4L.Moment;

[IsReadOnly]
public struct RelativeTime : IComparable<RelativeTime>, IComparable
{
	private static Stopwatch stopwatch; //Field offset: 0x0
	private readonly long MilliSeconds; //Field offset: 0x0

	private static RelativeTime() { }

	public RelativeTime(long milliSeconds) { }

	public override int CompareTo(RelativeTime other) { }

	public override int CompareTo(object obj) { }

	public TimeSpan DiffFrom(RelativeTime other) { }

	public double DiffSecondsFrom(RelativeTime other) { }

	public bool Equals(RelativeTime other) { }

	public virtual bool Equals(object obj) { }

	public static RelativeTime GetDeviceUptime() { }

	public virtual int GetHashCode() { }

	public virtual string ToString() { }

}

