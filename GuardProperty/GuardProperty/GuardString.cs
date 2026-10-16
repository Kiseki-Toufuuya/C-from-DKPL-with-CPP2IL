namespace GuardProperty;

[GuardTarget(typeof(string))]
[IsReadOnly]
public struct GuardString : IComparable<GuardString>
{
	private readonly int hash; //Field offset: 0x0
	private readonly string value; //Field offset: 0x4

	public string Value
	{
		 get { } //Length: 297
	}

	public GuardString(string v) { }

	public override int CompareTo(GuardString other) { }

	public bool Equals(GuardString other) { }

	public virtual bool Equals(object obj) { }

	public string get_Value() { }

	public virtual int GetHashCode() { }

	public static int Hash(string key) { }

	public static bool op_Equality(GuardString leftHand, GuardString rightHand) { }

	public static string op_Implicit(GuardString guard) { }

	public static GuardString op_Implicit(string raw) { }

	public virtual string ToString() { }

}

