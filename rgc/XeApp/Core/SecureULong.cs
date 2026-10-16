namespace XeApp.Core;

public struct SecureULong : ISecureValue<UInt64>, IComparable<SecureULong>, IEquatable<SecureULong>
{
	private const ulong MIRROR_XOR = 6597229979551057; //Field offset: 0x0
	private ulong _xor; //Field offset: 0x0
	private ulong _val; //Field offset: 0x8
	private ulong _mirror; //Field offset: 0x10

	public override bool IsFalsifed
	{
		 get { } //Length: 53
	}

	public override ulong Value
	{
		 get { } //Length: 19
		 set { } //Length: 51
	}

	public SecureULong(ulong v, ulong xor) { }

	public override int CompareTo(SecureULong t) { }

	public override bool Equals(SecureULong v) { }

	public override bool get_IsFalsifed() { }

	public override ulong get_Value() { }

	public override void set_Value(ulong value) { }

}

