namespace GuardProperty;

[GuardTarget(typeof(int))]
[IsReadOnly]
public struct GuardInt : IComparable<GuardInt>
{
	public static int Mask; //Field offset: 0x0
	private readonly int hash; //Field offset: 0x0
	private readonly int value; //Field offset: 0x4

	public int Value
	{
		 get { } //Length: 444
	}

	private static GuardInt() { }

	public GuardInt(int v) { }

	public override int CompareTo(GuardInt other) { }

	public bool Equals(GuardInt other) { }

	public virtual bool Equals(object obj) { }

	public int get_Value() { }

	public virtual int GetHashCode() { }

	public static int Hash(int key) { }

	public static int op_Implicit(GuardInt guard) { }

	public static GuardInt op_Implicit(int raw) { }

	public virtual string ToString() { }

}

