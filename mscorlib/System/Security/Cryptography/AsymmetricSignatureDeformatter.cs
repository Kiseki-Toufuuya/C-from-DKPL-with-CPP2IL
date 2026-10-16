namespace System.Security.Cryptography;

[ComVisible(True)]
public abstract class AsymmetricSignatureDeformatter
{

	protected AsymmetricSignatureDeformatter() { }

	public abstract void SetHashAlgorithm(string strName) { }

	public abstract void SetKey(AsymmetricAlgorithm key) { }

	public override bool VerifySignature(HashAlgorithm hash, Byte[] rgbSignature) { }

	public abstract bool VerifySignature(Byte[] rgbHash, Byte[] rgbSignature) { }

}

