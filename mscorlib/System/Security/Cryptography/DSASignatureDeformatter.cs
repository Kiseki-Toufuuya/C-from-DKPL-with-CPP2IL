namespace System.Security.Cryptography;

[ComVisible(True)]
public class DSASignatureDeformatter : AsymmetricSignatureDeformatter
{
	private DSA _dsaKey; //Field offset: 0x8
	private string _oid; //Field offset: 0xC

	public DSASignatureDeformatter() { }

	public DSASignatureDeformatter(AsymmetricAlgorithm key) { }

	public virtual void SetHashAlgorithm(string strName) { }

	public virtual void SetKey(AsymmetricAlgorithm key) { }

	public virtual bool VerifySignature(Byte[] rgbHash, Byte[] rgbSignature) { }

}

