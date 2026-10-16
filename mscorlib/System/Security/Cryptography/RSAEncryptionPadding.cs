namespace System.Security.Cryptography;

public sealed class RSAEncryptionPadding : IEquatable<RSAEncryptionPadding>
{
	private static readonly RSAEncryptionPadding s_pkcs1; //Field offset: 0x0
	private static readonly RSAEncryptionPadding s_oaepSHA1; //Field offset: 0x4
	private static readonly RSAEncryptionPadding s_oaepSHA256; //Field offset: 0x8
	private static readonly RSAEncryptionPadding s_oaepSHA384; //Field offset: 0xC
	private static readonly RSAEncryptionPadding s_oaepSHA512; //Field offset: 0x10
	private RSAEncryptionPaddingMode _mode; //Field offset: 0x8
	private HashAlgorithmName _oaepHashAlgorithm; //Field offset: 0xC

	public RSAEncryptionPaddingMode Mode
	{
		 get { } //Length: 11
	}

	public HashAlgorithmName OaepHashAlgorithm
	{
		 get { } //Length: 11
	}

	public static RSAEncryptionPadding OaepSHA1
	{
		 get { } //Length: 61
	}

	public static RSAEncryptionPadding OaepSHA256
	{
		 get { } //Length: 61
	}

	public static RSAEncryptionPadding OaepSHA384
	{
		 get { } //Length: 61
	}

	public static RSAEncryptionPadding OaepSHA512
	{
		 get { } //Length: 61
	}

	public static RSAEncryptionPadding Pkcs1
	{
		 get { } //Length: 60
	}

	private static RSAEncryptionPadding() { }

	internal RSAEncryptionPadding() { }

	private RSAEncryptionPadding(RSAEncryptionPaddingMode mode, HashAlgorithmName oaepHashAlgorithm) { }

	private static int CombineHashCodes(int h1, int h2) { }

	public static RSAEncryptionPadding CreateOaep(HashAlgorithmName hashAlgorithm) { }

	public override bool Equals(RSAEncryptionPadding other) { }

	public virtual bool Equals(object obj) { }

	public RSAEncryptionPaddingMode get_Mode() { }

	public HashAlgorithmName get_OaepHashAlgorithm() { }

	public static RSAEncryptionPadding get_OaepSHA1() { }

	public static RSAEncryptionPadding get_OaepSHA256() { }

	public static RSAEncryptionPadding get_OaepSHA384() { }

	public static RSAEncryptionPadding get_OaepSHA512() { }

	public static RSAEncryptionPadding get_Pkcs1() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(RSAEncryptionPadding left, RSAEncryptionPadding right) { }

	public static bool op_Inequality(RSAEncryptionPadding left, RSAEncryptionPadding right) { }

	public virtual string ToString() { }

}

