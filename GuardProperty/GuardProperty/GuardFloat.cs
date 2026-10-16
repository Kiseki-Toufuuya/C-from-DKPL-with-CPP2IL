namespace GuardProperty;

[GuardTarget(typeof(float))]
[IsReadOnly]
public struct GuardFloat : IComparable<GuardFloat>
{
	public static int Mask; //Field offset: 0x0
	private readonly int hash; //Field offset: 0x0
	private readonly int value; //Field offset: 0x4

	public float Value
	{
		 get { } //Length: 555
	}

	private static GuardFloat() { }

	public GuardFloat(float v) { }

	public override int CompareTo(GuardFloat other) { }

	public bool Equals(GuardFloat other) { }

	public virtual bool Equals(object obj) { }

	public float get_Value() { }

	public virtual int GetHashCode() { }

	public static int Hash(int key) { }

	public static float op_Implicit(GuardFloat guard) { }

	public static GuardFloat op_Implicit(float raw) { }

	public virtual string ToString() { }

}

