namespace System.Security.Cryptography;

[ComVisible(True)]
public class RSAOAEPKeyExchangeDeformatter : AsymmetricKeyExchangeDeformatter
{
	private RSA _rsaKey; //Field offset: 0x8
	private Nullable<Boolean> _rsaOverridesDecrypt; //Field offset: 0xC

	private bool OverridesDecrypt
	{
		private get { } //Length: 445
	}

	public virtual string Parameters
	{
		 get { } //Length: 3
		 set { } //Length: 3
	}

	public RSAOAEPKeyExchangeDeformatter() { }

	public RSAOAEPKeyExchangeDeformatter(AsymmetricAlgorithm key) { }

	public virtual Byte[] DecryptKeyExchange(Byte[] rgbData) { }

	private bool get_OverridesDecrypt() { }

	public virtual string get_Parameters() { }

	public virtual void set_Parameters(string value) { }

	public virtual void SetKey(AsymmetricAlgorithm key) { }

}

