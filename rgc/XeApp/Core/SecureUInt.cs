namespace XeApp.Core;

public struct SecureUInt : ISecureValue<UInt32>, IComparable<SecureUInt>, IEquatable<SecureUInt>
{
	private const uint MIRROR_XOR = 2962578227; //Field offset: 0x0
	private uint _xor; //Field offset: 0x0
	private uint _val; //Field offset: 0x4
	private uint _mirror; //Field offset: 0x8

	public override bool IsFalsifed
	{
		 get { } //Length: 26
	}

	public override uint Value
	{
		 get { } //Length: 13
		 set { } //Length: 27
	}

	public SecureUInt(uint v, uint xor) { }

	public override int CompareTo(SecureUInt t) { }

	public override bool Equals(SecureUInt v) { }

	public override bool get_IsFalsifed() { }

	public override uint get_Value() { }

	public override void set_Value(uint value) { }

}

