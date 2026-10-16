namespace System.Security.Cryptography;

[ComVisible(True)]
public abstract class RSA : AsymmetricAlgorithm
{

	public virtual string KeyExchangeAlgorithm
	{
		 get { } //Length: 35
	}

	public virtual string SignatureAlgorithm
	{
		 get { } //Length: 35
	}

	protected RSA() { }

	public static RSA Create() { }

	public static RSA Create(string algName) { }

	public static RSA Create(RSAParameters parameters) { }

	public static RSA Create(int keySizeInBits) { }

	public override Byte[] Decrypt(Byte[] data, RSAEncryptionPadding padding) { }

	public override Byte[] DecryptValue(Byte[] rgb) { }

	private static Exception DerivedClassMustOverride() { }

	public override Byte[] Encrypt(Byte[] data, RSAEncryptionPadding padding) { }

	public override Byte[] EncryptValue(Byte[] rgb) { }

	public abstract RSAParameters ExportParameters(bool includePrivateParameters) { }

	public override Byte[] ExportRSAPrivateKey() { }

	public override Byte[] ExportRSAPublicKey() { }

	public virtual void FromXmlString(string xmlString) { }

	public virtual string get_KeyExchangeAlgorithm() { }

	public virtual string get_SignatureAlgorithm() { }

	internal static Exception HashAlgorithmNameNullOrEmpty() { }

	protected override Byte[] HashData(Stream data, HashAlgorithmName hashAlgorithm) { }

	protected override Byte[] HashData(Byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm) { }

	public abstract void ImportParameters(RSAParameters parameters) { }

	public override void ImportRSAPrivateKey(ReadOnlySpan<Byte> source, out int bytesRead) { }

	public override void ImportRSAPublicKey(ReadOnlySpan<Byte> source, out int bytesRead) { }

	public override Byte[] SignData(Stream data, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding) { }

	public override Byte[] SignData(Byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding) { }

	public Byte[] SignData(Byte[] data, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding) { }

	public override Byte[] SignHash(Byte[] hash, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding) { }

	public virtual string ToXmlString(bool includePrivateParameters) { }

	public override bool TryDecrypt(ReadOnlySpan<Byte> data, Span<Byte> destination, RSAEncryptionPadding padding, out int bytesWritten) { }

	public override bool TryEncrypt(ReadOnlySpan<Byte> data, Span<Byte> destination, RSAEncryptionPadding padding, out int bytesWritten) { }

	public override bool TryExportRSAPrivateKey(Span<Byte> destination, out int bytesWritten) { }

	public override bool TryExportRSAPublicKey(Span<Byte> destination, out int bytesWritten) { }

	protected override bool TryHashData(ReadOnlySpan<Byte> data, Span<Byte> destination, HashAlgorithmName hashAlgorithm, out int bytesWritten) { }

	public override bool TrySignData(ReadOnlySpan<Byte> data, Span<Byte> destination, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding, out int bytesWritten) { }

	public override bool TrySignHash(ReadOnlySpan<Byte> hash, Span<Byte> destination, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding, out int bytesWritten) { }

	public override bool VerifyData(ReadOnlySpan<Byte> data, ReadOnlySpan<Byte> signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding) { }

	public bool VerifyData(Stream data, Byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding) { }

	public bool VerifyData(Byte[] data, Byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding) { }

	public override bool VerifyData(Byte[] data, int offset, int count, Byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding) { }

	public override bool VerifyHash(ReadOnlySpan<Byte> hash, ReadOnlySpan<Byte> signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding) { }

	public override bool VerifyHash(Byte[] hash, Byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding) { }

}

