namespace Mono.Security.Cryptography;

internal class DSAManaged : DSA
{
	internal sealed class KeyGeneratedEventHandler : MulticastDelegate
	{

		public KeyGeneratedEventHandler(object object, IntPtr method) { }

		public override void Invoke(object sender, EventArgs e) { }

	}

	private bool keypairGenerated; //Field offset: 0x10
	private bool m_disposed; //Field offset: 0x11
	private BigInteger p; //Field offset: 0x14
	private BigInteger q; //Field offset: 0x18
	private BigInteger g; //Field offset: 0x1C
	private BigInteger x; //Field offset: 0x20
	private BigInteger y; //Field offset: 0x24
	private BigInteger j; //Field offset: 0x28
	private BigInteger seed; //Field offset: 0x2C
	private int counter; //Field offset: 0x30
	private bool j_missing; //Field offset: 0x34
	private RandomNumberGenerator rng; //Field offset: 0x38
	[CompilerGenerated]
	private KeyGeneratedEventHandler KeyGenerated; //Field offset: 0x3C

	public event KeyGeneratedEventHandler KeyGenerated
	{
		[CompilerGenerated]
		 add { } //Length: 116
		[CompilerGenerated]
		 remove { } //Length: 116
	}

	public virtual string KeyExchangeAlgorithm
	{
		 get { } //Length: 3
	}

	public virtual int KeySize
	{
		 get { } //Length: 45
	}

	public bool PublicOnly
	{
		 get { } //Length: 85
	}

	private RandomNumberGenerator Random
	{
		private get { } //Length: 42
	}

	public virtual string SignatureAlgorithm
	{
		 get { } //Length: 35
	}

	public DSAManaged(int dwKeySize) { }

	private void add(Byte[] a, Byte[] b, int value) { }

	[CompilerGenerated]
	public void add_KeyGenerated(KeyGeneratedEventHandler value) { }

	public virtual Byte[] CreateSignature(Byte[] rgbHash) { }

	protected virtual void Dispose(bool disposing) { }

	public virtual DSAParameters ExportParameters(bool includePrivateParameters) { }

	protected virtual void Finalize() { }

	private void Generate() { }

	private void GenerateKeyPair() { }

	private void GenerateParams(int keyLength) { }

	public virtual string get_KeyExchangeAlgorithm() { }

	public virtual int get_KeySize() { }

	public bool get_PublicOnly() { }

	private RandomNumberGenerator get_Random() { }

	public virtual string get_SignatureAlgorithm() { }

	public virtual void ImportParameters(DSAParameters parameters) { }

	private Byte[] NormalizeArray(Byte[] array) { }

	[CompilerGenerated]
	public void remove_KeyGenerated(KeyGeneratedEventHandler value) { }

	public virtual bool VerifySignature(Byte[] rgbHash, Byte[] rgbSignature) { }

}

