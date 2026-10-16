namespace System.Security.Cryptography;

[ComVisible(True)]
public class RSAPKCS1KeyExchangeFormatter : AsymmetricKeyExchangeFormatter
{
	private RandomNumberGenerator RngValue; //Field offset: 0x8
	private RSA _rsaKey; //Field offset: 0xC
	private Nullable<Boolean> _rsaOverridesEncrypt; //Field offset: 0x10

	private bool OverridesEncrypt
	{
		private get { } //Length: 445
	}

	public virtual string Parameters
	{
		 get { } //Length: 35
	}

	public RandomNumberGenerator Rng
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public RSAPKCS1KeyExchangeFormatter() { }

	public RSAPKCS1KeyExchangeFormatter(AsymmetricAlgorithm key) { }

	public virtual Byte[] CreateKeyExchange(Byte[] rgbData) { }

	public virtual Byte[] CreateKeyExchange(Byte[] rgbData, Type symAlgType) { }

	private bool get_OverridesEncrypt() { }

	public virtual string get_Parameters() { }

	public RandomNumberGenerator get_Rng() { }

	public void set_Rng(RandomNumberGenerator value) { }

	public virtual void SetKey(AsymmetricAlgorithm key) { }

}

