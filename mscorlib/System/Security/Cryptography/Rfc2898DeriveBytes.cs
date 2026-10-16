namespace System.Security.Cryptography;

public class Rfc2898DeriveBytes : DeriveBytes
{
	private const int MinimumSaltSize = 8; //Field offset: 0x0
	private readonly Byte[] _password; //Field offset: 0x8
	private Byte[] _salt; //Field offset: 0xC
	private uint _iterations; //Field offset: 0x10
	private HMAC _hmac; //Field offset: 0x14
	private int _blockSize; //Field offset: 0x18
	private Byte[] _buffer; //Field offset: 0x1C
	private uint _block; //Field offset: 0x20
	private int _startIndex; //Field offset: 0x24
	private int _endIndex; //Field offset: 0x28
	[CompilerGenerated]
	private readonly HashAlgorithmName <HashAlgorithm>k__BackingField; //Field offset: 0x2C

	public HashAlgorithmName HashAlgorithm
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public int IterationCount
	{
		 get { } //Length: 11
		 set { } //Length: 103
	}

	public Byte[] Salt
	{
		 get { } //Length: 21
		 set { } //Length: 181
	}

	public Rfc2898DeriveBytes(Byte[] password, Byte[] salt, int iterations) { }

	public Rfc2898DeriveBytes(Byte[] password, Byte[] salt, int iterations, HashAlgorithmName hashAlgorithm) { }

	public Rfc2898DeriveBytes(string password, Byte[] salt) { }

	public Rfc2898DeriveBytes(string password, Byte[] salt, int iterations) { }

	public Rfc2898DeriveBytes(string password, Byte[] salt, int iterations, HashAlgorithmName hashAlgorithm) { }

	public Rfc2898DeriveBytes(string password, int saltSize) { }

	public Rfc2898DeriveBytes(string password, int saltSize, int iterations) { }

	public Rfc2898DeriveBytes(string password, int saltSize, int iterations, HashAlgorithmName hashAlgorithm) { }

	public Byte[] CryptDeriveKey(string algname, string alghashname, int keySize, Byte[] rgbIV) { }

	protected virtual void Dispose(bool disposing) { }

	private Byte[] Func() { }

	[CompilerGenerated]
	public HashAlgorithmName get_HashAlgorithm() { }

	public int get_IterationCount() { }

	public Byte[] get_Salt() { }

	public virtual Byte[] GetBytes(int cb) { }

	private void Initialize() { }

	private HMAC OpenHmac() { }

	public virtual void Reset() { }

	public void set_IterationCount(int value) { }

	public void set_Salt(Byte[] value) { }

}

