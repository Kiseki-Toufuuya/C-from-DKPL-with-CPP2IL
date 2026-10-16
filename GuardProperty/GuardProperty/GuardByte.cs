namespace GuardProperty;

[GuardTarget(typeof(byte))]
[IsReadOnly]
public struct GuardByte : IComparable<GuardByte>
{
	public static byte Mask; //Field offset: 0x0
	private readonly int hash; //Field offset: 0x0
	private readonly byte value; //Field offset: 0x4

	public byte Value
	{
		 get { } //Length: 407
	}

	private static GuardByte() { }

	public GuardByte(byte v) { }

	public override int CompareTo(GuardByte other) { }

	public bool Equals(GuardByte other) { }

	public virtual bool Equals(object obj) { }

	public byte get_Value() { }

	public virtual int GetHashCode() { }

	public static int Hash(byte key) { }

	public static byte op_Implicit(GuardByte guard) { }

	public virtual string ToString() { }

}

