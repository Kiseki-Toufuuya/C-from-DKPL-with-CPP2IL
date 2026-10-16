namespace XeApp.Core;

public struct SecureLong : ISecureValue<Int64>, IComparable<SecureLong>, IEquatable<SecureLong>
{
	private const long MIRROR_XOR = 6929404086676223; //Field offset: 0x0
	private long _xor; //Field offset: 0x0
	private long _val; //Field offset: 0x8
	private long _mirror; //Field offset: 0x10

	public override bool IsFalsifed
	{
		 get { } //Length: 53
	}

	public override long Value
	{
		 get { } //Length: 19
		 set { } //Length: 51
	}

	public SecureLong(long v, long xor) { }

	public override int CompareTo(SecureLong t) { }

	public override bool Equals(SecureLong v) { }

	public override bool get_IsFalsifed() { }

	public override long get_Value() { }

	public override void set_Value(long value) { }

}

