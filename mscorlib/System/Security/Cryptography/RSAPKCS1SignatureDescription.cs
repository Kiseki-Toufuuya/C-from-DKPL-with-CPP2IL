namespace System.Security.Cryptography;

internal abstract class RSAPKCS1SignatureDescription : SignatureDescription
{
	private string _hashAlgorithm; //Field offset: 0x18

	protected RSAPKCS1SignatureDescription(string hashAlgorithm, string digestAlgorithm) { }

	public virtual AsymmetricSignatureDeformatter CreateDeformatter(AsymmetricAlgorithm key) { }

	public virtual AsymmetricSignatureFormatter CreateFormatter(AsymmetricAlgorithm key) { }

}

