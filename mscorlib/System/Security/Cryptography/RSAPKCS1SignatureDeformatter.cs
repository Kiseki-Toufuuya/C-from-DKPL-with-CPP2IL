namespace System.Security.Cryptography;

[ComVisible(True)]
public class RSAPKCS1SignatureDeformatter : AsymmetricSignatureDeformatter
{
	private RSA rsa; //Field offset: 0x8
	private string hashName; //Field offset: 0xC

	public RSAPKCS1SignatureDeformatter() { }

	public RSAPKCS1SignatureDeformatter(AsymmetricAlgorithm key) { }

	public virtual void SetHashAlgorithm(string strName) { }

	public virtual void SetKey(AsymmetricAlgorithm key) { }

	public virtual bool VerifySignature(Byte[] rgbHash, Byte[] rgbSignature) { }

}

