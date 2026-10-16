namespace System.Security.Cryptography;

[IsReadOnly]
public struct HashAlgorithmName : IEquatable<HashAlgorithmName>
{
	private readonly string _name; //Field offset: 0x0

	public static HashAlgorithmName MD5
	{
		 get { } //Length: 61
	}

	public string Name
	{
		 get { } //Length: 10
	}

	public static HashAlgorithmName SHA1
	{
		 get { } //Length: 61
	}

	public static HashAlgorithmName SHA256
	{
		 get { } //Length: 61
	}

	public static HashAlgorithmName SHA384
	{
		 get { } //Length: 61
	}

	public static HashAlgorithmName SHA512
	{
		 get { } //Length: 61
	}

	public HashAlgorithmName(string name) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(HashAlgorithmName other) { }

	public static HashAlgorithmName get_MD5() { }

	public string get_Name() { }

	public static HashAlgorithmName get_SHA1() { }

	public static HashAlgorithmName get_SHA256() { }

	public static HashAlgorithmName get_SHA384() { }

	public static HashAlgorithmName get_SHA512() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(HashAlgorithmName left, HashAlgorithmName right) { }

	public static bool op_Inequality(HashAlgorithmName left, HashAlgorithmName right) { }

	public virtual string ToString() { }

}

