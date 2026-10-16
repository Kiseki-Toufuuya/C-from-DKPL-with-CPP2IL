namespace System.Security.Cryptography;

[ComVisible(True)]
public class RSAPKCS1KeyExchangeDeformatter : AsymmetricKeyExchangeDeformatter
{
	private RSA _rsaKey; //Field offset: 0x8
	private Nullable<Boolean> _rsaOverridesDecrypt; //Field offset: 0xC
	private RandomNumberGenerator RngValue; //Field offset: 0x10

	private bool OverridesDecrypt
	{
		private get { } //Length: 445
	}

	public virtual string Parameters
	{
		 get { } //Length: 3
		 set { } //Length: 3
	}

	public RandomNumberGenerator RNG
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public RSAPKCS1KeyExchangeDeformatter() { }

	public RSAPKCS1KeyExchangeDeformatter(AsymmetricAlgorithm key) { }

	public virtual Byte[] DecryptKeyExchange(Byte[] rgbIn) { }

	private bool get_OverridesDecrypt() { }

	public virtual string get_Parameters() { }

	public RandomNumberGenerator get_RNG() { }

	public virtual void set_Parameters(string value) { }

	public void set_RNG(RandomNumberGenerator value) { }

	public virtual void SetKey(AsymmetricAlgorithm key) { }

}

