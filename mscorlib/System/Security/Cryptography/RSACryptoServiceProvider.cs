namespace System.Security.Cryptography;

[ComVisible(True)]
public sealed class RSACryptoServiceProvider : RSA, ICspAsymmetricAlgorithm
{
	private static CspProviderFlags s_UseMachineKeyStore; //Field offset: 0x0
	private const int PROV_RSA_FULL = 1; //Field offset: 0x0
	private const int AT_KEYEXCHANGE = 1; //Field offset: 0x0
	private const int AT_SIGNATURE = 2; //Field offset: 0x0
	private KeyPairPersistence store; //Field offset: 0x10
	private bool persistKey; //Field offset: 0x14
	private bool persisted; //Field offset: 0x15
	private bool privateKeyExportable; //Field offset: 0x16
	private bool m_disposed; //Field offset: 0x17
	private RSAManaged rsa; //Field offset: 0x18

	[ComVisible(False)]
	public override CspKeyContainerInfo CspKeyContainerInfo
	{
		 get { } //Length: 106
	}

	public virtual string KeyExchangeAlgorithm
	{
		 get { } //Length: 35
	}

	public virtual int KeySize
	{
		 get { } //Length: 42
	}

	public bool PersistKeyInCsp
	{
		 get { } //Length: 11
		 set { } //Length: 115
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
		 get { } //Length: 53
		 set { } //Length: 53
	}

	public RSACryptoServiceProvider(int dwKeySize, CspParameters parameters) { }

	public RSACryptoServiceProvider(int dwKeySize) { }

	public RSACryptoServiceProvider() { }

	public RSACryptoServiceProvider(CspParameters parameters) { }

	private void Common(CspParameters p) { }

	private void Common(int dwKeySize, bool parameters) { }

	public Byte[] Decrypt(Byte[] rgb, bool fOAEP) { }

	public virtual Byte[] Decrypt(Byte[] data, RSAEncryptionPadding padding) { }

	public virtual Byte[] DecryptValue(Byte[] rgb) { }

	protected virtual void Dispose(bool disposing) { }

	public Byte[] Encrypt(Byte[] rgb, bool fOAEP) { }

	public virtual Byte[] Encrypt(Byte[] data, RSAEncryptionPadding padding) { }

	public virtual Byte[] EncryptValue(Byte[] rgb) { }

	[ComVisible(False)]
	public override Byte[] ExportCspBlob(bool includePrivateParameters) { }

	public virtual RSAParameters ExportParameters(bool includePrivateParameters) { }

	protected virtual void Finalize() { }

	public override CspKeyContainerInfo get_CspKeyContainerInfo() { }

	public virtual string get_KeyExchangeAlgorithm() { }

	public virtual int get_KeySize() { }

	public bool get_PersistKeyInCsp() { }

	public bool get_PublicOnly() { }

	public virtual string get_SignatureAlgorithm() { }

	public static bool get_UseMachineKeyStore() { }

	private static int GetAlgorithmId(HashAlgorithmName hashAlgorithm) { }

	private HashAlgorithm GetHash(object halg) { }

	private HashAlgorithm GetHashFromString(string name) { }

	private string GetHashNameFromOID(string oid) { }

	protected virtual Byte[] HashData(Stream data, HashAlgorithmName hashAlgorithm) { }

	protected virtual Byte[] HashData(Byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm) { }

	[ComVisible(False)]
	public override void ImportCspBlob(Byte[] keyBlob) { }

	public virtual void ImportParameters(RSAParameters parameters) { }

	private static HashAlgorithm InternalHashToHashAlgorithm(int calgHash) { }

	private void OnKeyGenerated(object sender, EventArgs e) { }

	private static Exception PaddingModeNotSupported() { }

	public void set_PersistKeyInCsp(bool value) { }

	public static void set_UseMachineKeyStore(bool value) { }

	public Byte[] SignData(Stream inputStream, object halg) { }

	public Byte[] SignData(Byte[] buffer, object halg) { }

	public Byte[] SignData(Byte[] buffer, int offset, int count, object halg) { }

	public Byte[] SignHash(Byte[] rgbHash, string str) { }

	private Byte[] SignHash(Byte[] rgbHash, int calgHash) { }

	public virtual Byte[] SignHash(Byte[] hash, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding) { }

	public bool VerifyData(Byte[] buffer, object halg, Byte[] signature) { }

	public bool VerifyHash(Byte[] rgbHash, string str, Byte[] rgbSignature) { }

	private bool VerifyHash(Byte[] rgbHash, int calgHash, Byte[] rgbSignature) { }

	public virtual bool VerifyHash(Byte[] hash, Byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding) { }

}

