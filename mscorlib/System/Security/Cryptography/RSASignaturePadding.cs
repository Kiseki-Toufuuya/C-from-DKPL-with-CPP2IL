namespace System.Security.Cryptography;

public sealed class RSASignaturePadding : IEquatable<RSASignaturePadding>
{
	private static readonly RSASignaturePadding s_pkcs1; //Field offset: 0x0
	private static readonly RSASignaturePadding s_pss; //Field offset: 0x4
	private readonly RSASignaturePaddingMode _mode; //Field offset: 0x8

	public RSASignaturePaddingMode Mode
	{
		 get { } //Length: 11
	}

	public static RSASignaturePadding Pkcs1
	{
		 get { } //Length: 60
	}

	public static RSASignaturePadding Pss
	{
		 get { } //Length: 61
	}

	private static RSASignaturePadding() { }

	private RSASignaturePadding(RSASignaturePaddingMode mode) { }

	internal RSASignaturePadding() { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(RSASignaturePadding other) { }

	public RSASignaturePaddingMode get_Mode() { }

	public static RSASignaturePadding get_Pkcs1() { }

	public static RSASignaturePadding get_Pss() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(RSASignaturePadding left, RSASignaturePadding right) { }

	public static bool op_Inequality(RSASignaturePadding left, RSASignaturePadding right) { }

	public virtual string ToString() { }

}

