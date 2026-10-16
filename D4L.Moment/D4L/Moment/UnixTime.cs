namespace D4L.Moment;

[IsReadOnly]
public struct UnixTime : IComparable<UnixTime>, IEquatable<UnixTime>
{
	private static readonly DateTime UnixEpoch; //Field offset: 0x0
	public readonly long Value; //Field offset: 0x0

	private static UnixTime() { }

	public UnixTime(DateTime time) { }

	public UnixTime(long time) { }

	public override int CompareTo(UnixTime other) { }

	public override bool Equals(UnixTime other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public static TimeSpan op_Subtraction(UnixTime l, UnixTime r) { }

	public virtual string ToString() { }

}

