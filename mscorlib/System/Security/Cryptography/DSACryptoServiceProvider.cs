namespace System.Security.Cryptography;

[ComVisible(True)]
public sealed class DSACryptoServiceProvider : DSA, ICspAsymmetricAlgorithm
{
	private const int PROV_DSS_DH = 13; //Field offset: 0x0
	private static bool useMachineKeyStore; //Field offset: 0x0
	private KeyPairPersistence store; //Field offset: 0x10
	private bool persistKey; //Field offset: 0x14
	private bool persisted; //Field offset: 0x15
	private bool privateKeyExportable; //Field offset: 0x16
	private bool m_disposed; //Field offset: 0x17
	private DSAManaged dsa; //Field offset: 0x18

	[ComVisible(False)]
	[MonoTODO("call into KeyPairPersistence to get details")]
	public override CspKeyContainerInfo CspKeyContainerInfo
	{
		 get { } //Length: 3
	}

	public virtual string KeyExchangeAlgorithm
	{
		 get { } //Length: 3
	}

	public virtual int KeySize
	{
		 get { } //Length: 40
	}

	public bool PersistKeyInCsp
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[ComVisible(False)]
	public bool PublicOnly
	{
		 get { } //Length: 34
	}

	public virtual string SignatureAlgorithm
	{
		 get { } //Length: 35
	}

	public static bool UseMachineKeyStore
	{
		 get { } //Length: 40
		 set { } //Length: 47
	}

	public DSACryptoServiceProvider() { }

	public DSACryptoServiceProvider(CspParameters parameters) { }

	public DSACryptoServiceProvider(int dwKeySize) { }

	public DSACryptoServiceProvider(int dwKeySize, CspParameters parameters) { }

	private void Common(int dwKeySize, bool parameters) { }

	private void Common(CspParameters parameters) { }

	public virtual Byte[] CreateSignature(Byte[] rgbHash) { }

	protected virtual void Dispose(bool disposing) { }

	[ComVisible(False)]
	public override Byte[] ExportCspBlob(bool includePrivateParameters) { }

	public virtual DSAParameters ExportParameters(bool includePrivateParameters) { }

	protected virtual void Finalize() { }

	public override CspKeyContainerInfo get_CspKeyContainerInfo() { }

	public virtual string get_KeyExchangeAlgorithm() { }

	public virtual int get_KeySize() { }

	public bool get_PersistKeyInCsp() { }

	public bool get_PublicOnly() { }

	public virtual string get_SignatureAlgorithm() { }

	public static bool get_UseMachineKeyStore() { }

	protected virtual Byte[] HashData(Stream data, HashAlgorithmName hashAlgorithm) { }

	protected virtual Byte[] HashData(Byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm) { }

	[ComVisible(False)]
	public override void ImportCspBlob(Byte[] keyBlob) { }

	public virtual void ImportParameters(DSAParameters parameters) { }

	private void OnKeyGenerated(object sender, EventArgs e) { }

	public void set_PersistKeyInCsp(bool value) { }

	public static void set_UseMachineKeyStore(bool value) { }

	public Byte[] SignData(Byte[] buffer, int offset, int count) { }

	public Byte[] SignData(Byte[] buffer) { }

	public Byte[] SignData(Stream inputStream) { }

	public Byte[] SignHash(Byte[] rgbHash, string str) { }

	public bool VerifyData(Byte[] rgbData, Byte[] rgbSignature) { }

	public bool VerifyHash(Byte[] rgbHash, string str, Byte[] rgbSignature) { }

	public virtual bool VerifySignature(Byte[] rgbHash, Byte[] rgbSignature) { }

}

