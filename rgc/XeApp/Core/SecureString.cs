namespace XeApp.Core;

public struct SecureString : ISecureValue<String>, IComparable<SecureString>, IEquatable<SecureString>
{
	private const int coef = 11; //Field offset: 0x0
	private const int offset = 3; //Field offset: 0x0
	private const int start = 1; //Field offset: 0x0
	private Byte[] _bytes; //Field offset: 0x0
	private Byte[] _swizzle; //Field offset: 0x4

	public override bool IsFalsifed
	{
		 get { } //Length: 3
	}

	public override string Value
	{
		 get { } //Length: 253
		 set { } //Length: 154
	}

	public SecureString(string v, Byte[] swizzle) { }

	public override int CompareTo(SecureString t) { }

	public override bool Equals(SecureString v) { }

	public override bool get_IsFalsifed() { }

	public override string get_Value() { }

	public override void set_Value(string value) { }

}

