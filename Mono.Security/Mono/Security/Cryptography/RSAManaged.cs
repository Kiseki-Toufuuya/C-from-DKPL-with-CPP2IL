namespace Mono.Security.Cryptography;

public class RSAManaged : RSA
{
	internal sealed class KeyGeneratedEventHandler : MulticastDelegate
	{

		public KeyGeneratedEventHandler(object object, IntPtr method) { }

		public override void Invoke(object sender, EventArgs e) { }

	}

	private bool isCRTpossible; //Field offset: 0x10
	private bool keyBlinding; //Field offset: 0x11
	private bool keypairGenerated; //Field offset: 0x12
	private bool m_disposed; //Field offset: 0x13
	private BigInteger d; //Field offset: 0x14
	private BigInteger p; //Field offset: 0x18
	private BigInteger q; //Field offset: 0x1C
	private BigInteger dp; //Field offset: 0x20
	private BigInteger dq; //Field offset: 0x24
	private BigInteger qInv; //Field offset: 0x28
	private BigInteger n; //Field offset: 0x2C
	private BigInteger e; //Field offset: 0x30
	[CompilerGenerated]
	private KeyGeneratedEventHandler KeyGenerated; //Field offset: 0x34

	public virtual string KeyExchangeAlgorithm
	{
		 get { } //Length: 35
	}

	public virtual int KeySize
	{
		 get { } //Length: 134
	}

	public bool PublicOnly
	{
		 get { } //Length: 133
	}

	public virtual string SignatureAlgorithm
	{
		 get { } //Length: 35
	}

	public RSAManaged() { }

	public RSAManaged(int keySize) { }

	public virtual Byte[] DecryptValue(Byte[] rgb) { }

	protected virtual void Dispose(bool disposing) { }

	public virtual Byte[] EncryptValue(Byte[] rgb) { }

	public virtual RSAParameters ExportParameters(bool includePrivateParameters) { }

	protected virtual void Finalize() { }

	private void GenerateKeyPair() { }

	public virtual string get_KeyExchangeAlgorithm() { }

	public virtual int get_KeySize() { }

	public bool get_PublicOnly() { }

	public virtual string get_SignatureAlgorithm() { }

	private Byte[] GetPaddedValue(BigInteger value, int length) { }

	public virtual void ImportParameters(RSAParameters parameters) { }

	public virtual string ToXmlString(bool includePrivateParameters) { }

}

