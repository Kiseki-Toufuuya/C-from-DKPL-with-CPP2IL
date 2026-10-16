namespace GuardProperty;

[GuardTarget(typeof(bool))]
[IsReadOnly]
public struct GuardBool : IComparable<GuardBool>
{
	public static bool Mask; //Field offset: 0x0
	private static readonly uint TrueHash; //Field offset: 0x4
	private static readonly uint FalseHash; //Field offset: 0x8
	private readonly int hash; //Field offset: 0x0
	private readonly bool value; //Field offset: 0x4

	public bool Value
	{
		 get { } //Length: 347
	}

	private static GuardBool() { }

	public GuardBool(bool v) { }

	public override int CompareTo(GuardBool other) { }

	public bool Equals(GuardBool other) { }

	public virtual bool Equals(object obj) { }

	public bool get_Value() { }

	public virtual int GetHashCode() { }

	public static int Hash(bool key) { }

	public static bool op_Implicit(GuardBool guard) { }

	public virtual string ToString() { }

}

