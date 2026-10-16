namespace GuardProperty;

[GuardTarget(typeof(long))]
[IsReadOnly]
public struct GuardLong : IComparable<GuardLong>
{
	public static long Mask; //Field offset: 0x0
	private readonly int hash; //Field offset: 0x0
	private readonly long value; //Field offset: 0x8

	public long Value
	{
		 get { } //Length: 467
	}

	private static GuardLong() { }

	public GuardLong(long v) { }

	public override int CompareTo(GuardLong other) { }

	public bool Equals(GuardLong other) { }

	public virtual bool Equals(object obj) { }

	public long get_Value() { }

	public virtual int GetHashCode() { }

	public static int Hash(long key) { }

	public static long op_Implicit(GuardLong guard) { }

	public static GuardLong op_Implicit(long raw) { }

	public virtual string ToString() { }

}

