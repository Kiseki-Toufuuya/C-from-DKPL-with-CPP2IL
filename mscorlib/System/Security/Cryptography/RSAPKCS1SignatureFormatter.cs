namespace System.Security.Cryptography;

[ComVisible(True)]
public class RSAPKCS1SignatureFormatter : AsymmetricSignatureFormatter
{
	private RSA rsa; //Field offset: 0x8
	private string hash; //Field offset: 0xC

	public RSAPKCS1SignatureFormatter() { }

	public RSAPKCS1SignatureFormatter(AsymmetricAlgorithm key) { }

	public virtual Byte[] CreateSignature(Byte[] rgbHash) { }

	public virtual void SetHashAlgorithm(string strName) { }

	public virtual void SetKey(AsymmetricAlgorithm key) { }

}

