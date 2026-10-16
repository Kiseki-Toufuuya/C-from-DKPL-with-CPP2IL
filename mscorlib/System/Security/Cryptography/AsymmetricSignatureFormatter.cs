namespace System.Security.Cryptography;

[ComVisible(True)]
public abstract class AsymmetricSignatureFormatter
{

	protected AsymmetricSignatureFormatter() { }

	public override Byte[] CreateSignature(HashAlgorithm hash) { }

	public abstract Byte[] CreateSignature(Byte[] rgbHash) { }

	public abstract void SetHashAlgorithm(string strName) { }

	public abstract void SetKey(AsymmetricAlgorithm key) { }

}

