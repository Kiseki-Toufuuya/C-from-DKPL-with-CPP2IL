namespace System.Security.Cryptography;

[ComVisible(True)]
public abstract class AsymmetricAlgorithm : IDisposable
{
	protected int KeySizeValue; //Field offset: 0x8
	protected KeySizes[] LegalKeySizesValue; //Field offset: 0xC

	public override string KeyExchangeAlgorithm
	{
		 get { } //Length: 47
	}

	public override int KeySize
	{
		 get { } //Length: 11
		 set { } //Length: 274
	}

	public override KeySizes[] LegalKeySizes
	{
		 get { } //Length: 101
	}

	public override string SignatureAlgorithm
	{
		 get { } //Length: 47
	}

	protected AsymmetricAlgorithm() { }

	public void Clear() { }

	public static AsymmetricAlgorithm Create(string algName) { }

	public static AsymmetricAlgorithm Create() { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	public override Byte[] ExportEncryptedPkcs8PrivateKey(ReadOnlySpan<Byte> passwordBytes, PbeParameters pbeParameters) { }

	public override Byte[] ExportEncryptedPkcs8PrivateKey(ReadOnlySpan<Char> password, PbeParameters pbeParameters) { }

	public override Byte[] ExportPkcs8PrivateKey() { }

	public override Byte[] ExportSubjectPublicKeyInfo() { }

	public override void FromXmlString(string xmlString) { }

	public override string get_KeyExchangeAlgorithm() { }

	public override int get_KeySize() { }

	public override KeySizes[] get_LegalKeySizes() { }

	public override string get_SignatureAlgorithm() { }

	public override void ImportEncryptedPkcs8PrivateKey(ReadOnlySpan<Char> password, ReadOnlySpan<Byte> source, out int bytesRead) { }

	public override void ImportEncryptedPkcs8PrivateKey(ReadOnlySpan<Byte> passwordBytes, ReadOnlySpan<Byte> source, out int bytesRead) { }

	public override void ImportPkcs8PrivateKey(ReadOnlySpan<Byte> source, out int bytesRead) { }

	public override void ImportSubjectPublicKeyInfo(ReadOnlySpan<Byte> source, out int bytesRead) { }

	public override void set_KeySize(int value) { }

	public override string ToXmlString(bool includePrivateParameters) { }

	public override bool TryExportEncryptedPkcs8PrivateKey(ReadOnlySpan<Byte> passwordBytes, PbeParameters pbeParameters, Span<Byte> destination, out int bytesWritten) { }

	public override bool TryExportEncryptedPkcs8PrivateKey(ReadOnlySpan<Char> password, PbeParameters pbeParameters, Span<Byte> destination, out int bytesWritten) { }

	public override bool TryExportPkcs8PrivateKey(Span<Byte> destination, out int bytesWritten) { }

	public override bool TryExportSubjectPublicKeyInfo(Span<Byte> destination, out int bytesWritten) { }

}

