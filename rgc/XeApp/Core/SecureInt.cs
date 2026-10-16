namespace XeApp.Core;

public struct SecureInt : ISecureValue<Int32>, IComparable<SecureInt>, IEquatable<SecureInt>
{
	private const int MIRROR_XOR = 932683275; //Field offset: 0x0
	private int _mirror; //Field offset: 0x0
	private int _xor; //Field offset: 0x4
	private int _val; //Field offset: 0x8

	public override bool IsFalsifed
	{
		 get { } //Length: 26
	}

	public override int Value
	{
		 get { } //Length: 14
		 set { } //Length: 27
	}

	public SecureInt(int v, int xor) { }

	public override int CompareTo(SecureInt t) { }

	public override bool Equals(SecureInt v) { }

	public override bool get_IsFalsifed() { }

	public override int get_Value() { }

	public override void set_Value(int value) { }

}

