namespace System.Security.Cryptography;

[ComVisible(True)]
public class DSASignatureFormatter : AsymmetricSignatureFormatter
{
	private DSA _dsaKey; //Field offset: 0x8
	private string _oid; //Field offset: 0xC

	public DSASignatureFormatter() { }

	public DSASignatureFormatter(AsymmetricAlgorithm key) { }

	public virtual Byte[] CreateSignature(Byte[] rgbHash) { }

	public virtual void SetHashAlgorithm(string strName) { }

	public virtual void SetKey(AsymmetricAlgorithm key) { }

}

