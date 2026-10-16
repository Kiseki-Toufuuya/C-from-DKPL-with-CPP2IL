namespace System.Security.Cryptography;

[ComVisible(True)]
public abstract class DSA : AsymmetricAlgorithm
{

	protected DSA() { }

	public static DSA Create(DSAParameters parameters) { }

	public static DSA Create(int keySizeInBits) { }

	public static DSA Create(string algName) { }

	public static DSA Create() { }

	public abstract Byte[] CreateSignature(Byte[] rgbHash) { }

	private static Exception DerivedClassMustOverride() { }

	public abstract DSAParameters ExportParameters(bool includePrivateParameters) { }

	public virtual void FromXmlString(string xmlString) { }

	internal static Exception HashAlgorithmNameNullOrEmpty() { }

	protected override Byte[] HashData(Byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm) { }

	protected override Byte[] HashData(Stream data, HashAlgorithmName hashAlgorithm) { }

	public abstract void ImportParameters(DSAParameters parameters) { }

	public override Byte[] SignData(Stream data, HashAlgorithmName hashAlgorithm) { }

	public override Byte[] SignData(Byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm) { }

	public Byte[] SignData(Byte[] data, HashAlgorithmName hashAlgorithm) { }

	public virtual string ToXmlString(bool includePrivateParameters) { }

	public override bool TryCreateSignature(ReadOnlySpan<Byte> hash, Span<Byte> destination, out int bytesWritten) { }

	protected override bool TryHashData(ReadOnlySpan<Byte> data, Span<Byte> destination, HashAlgorithmName hashAlgorithm, out int bytesWritten) { }

	public override bool TrySignData(ReadOnlySpan<Byte> data, Span<Byte> destination, HashAlgorithmName hashAlgorithm, out int bytesWritten) { }

	public override bool VerifyData(Stream data, Byte[] signature, HashAlgorithmName hashAlgorithm) { }

	public override bool VerifyData(Byte[] data, int offset, int count, Byte[] signature, HashAlgorithmName hashAlgorithm) { }

	public bool VerifyData(Byte[] data, Byte[] signature, HashAlgorithmName hashAlgorithm) { }

	public override bool VerifyData(ReadOnlySpan<Byte> data, ReadOnlySpan<Byte> signature, HashAlgorithmName hashAlgorithm) { }

	public abstract bool VerifySignature(Byte[] rgbHash, Byte[] rgbSignature) { }

	public override bool VerifySignature(ReadOnlySpan<Byte> hash, ReadOnlySpan<Byte> signature) { }

}

