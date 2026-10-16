namespace System.Security.Cryptography;

[ComVisible(True)]
public class SignatureDescription
{
	private string _strKey; //Field offset: 0x8
	private string _strDigest; //Field offset: 0xC
	private string _strFormatter; //Field offset: 0x10
	private string _strDeformatter; //Field offset: 0x14

	public string DeformatterAlgorithm
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public string DigestAlgorithm
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public string FormatterAlgorithm
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public string KeyAlgorithm
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public SignatureDescription() { }

	public SignatureDescription(SecurityElement el) { }

	public override AsymmetricSignatureDeformatter CreateDeformatter(AsymmetricAlgorithm key) { }

	public override HashAlgorithm CreateDigest() { }

	public override AsymmetricSignatureFormatter CreateFormatter(AsymmetricAlgorithm key) { }

	public string get_DeformatterAlgorithm() { }

	public string get_DigestAlgorithm() { }

	public string get_FormatterAlgorithm() { }

	public string get_KeyAlgorithm() { }

	public void set_DeformatterAlgorithm(string value) { }

	public void set_DigestAlgorithm(string value) { }

	public void set_FormatterAlgorithm(string value) { }

	public void set_KeyAlgorithm(string value) { }

}

