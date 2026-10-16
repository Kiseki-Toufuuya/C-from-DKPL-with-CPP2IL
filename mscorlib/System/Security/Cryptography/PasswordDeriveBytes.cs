namespace System.Security.Cryptography;

[ComVisible(True)]
public class PasswordDeriveBytes : DeriveBytes
{
	private int _extraCount; //Field offset: 0x8
	private int _prefix; //Field offset: 0xC
	private int _iterations; //Field offset: 0x10
	private Byte[] _baseValue; //Field offset: 0x14
	private Byte[] _extra; //Field offset: 0x18
	private Byte[] _salt; //Field offset: 0x1C
	private string _hashName; //Field offset: 0x20
	private Byte[] _password; //Field offset: 0x24
	private HashAlgorithm _hash; //Field offset: 0x28

	public string HashName
	{
		 get { } //Length: 11
		 set { } //Length: 397
	}

	public int IterationCount
	{
		 get { } //Length: 11
		 set { } //Length: 255
	}

	public Byte[] Salt
	{
		 get { } //Length: 101
		 set { } //Length: 334
	}

	public PasswordDeriveBytes(string strPassword, Byte[] rgbSalt) { }

	public PasswordDeriveBytes(Byte[] password, Byte[] salt) { }

	public PasswordDeriveBytes(string strPassword, Byte[] rgbSalt, string strHashName, int iterations) { }

	public PasswordDeriveBytes(Byte[] password, Byte[] salt, string hashName, int iterations) { }

	public PasswordDeriveBytes(string strPassword, Byte[] rgbSalt, CspParameters cspParams) { }

	public PasswordDeriveBytes(Byte[] password, Byte[] salt, CspParameters cspParams) { }

	public PasswordDeriveBytes(string strPassword, Byte[] rgbSalt, string strHashName, int iterations, CspParameters cspParams) { }

	public PasswordDeriveBytes(Byte[] password, Byte[] salt, string hashName, int iterations, CspParameters cspParams) { }

	private Byte[] ComputeBaseValue() { }

	private Byte[] ComputeBytes(int cb) { }

	public Byte[] CryptDeriveKey(string algname, string alghashname, int keySize, Byte[] rgbIV) { }

	protected virtual void Dispose(bool disposing) { }

	public string get_HashName() { }

	public int get_IterationCount() { }

	public Byte[] get_Salt() { }

	[Obsolete("Rfc2898DeriveBytes replaces PasswordDeriveBytes for deriving key material from a password and is preferred in new applications.")]
	public virtual Byte[] GetBytes(int cb) { }

	private void HashPrefix(CryptoStream cs) { }

	public virtual void Reset() { }

	public void set_HashName(string value) { }

	public void set_IterationCount(int value) { }

	public void set_Salt(Byte[] value) { }

}

