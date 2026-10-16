namespace System.Security.Cryptography;

[ComVisible(True)]
public class RSAOAEPKeyExchangeFormatter : AsymmetricKeyExchangeFormatter
{
	private Byte[] ParameterValue; //Field offset: 0x8
	private RSA _rsaKey; //Field offset: 0xC
	private Nullable<Boolean> _rsaOverridesEncrypt; //Field offset: 0x10
	private RandomNumberGenerator RngValue; //Field offset: 0x14

	private bool OverridesEncrypt
	{
		private get { } //Length: 445
	}

	public Byte[] Parameter
	{
		 get { } //Length: 101
		 set { } //Length: 170
	}

	public virtual string Parameters
	{
		 get { } //Length: 3
	}

	public RandomNumberGenerator Rng
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public RSAOAEPKeyExchangeFormatter() { }

	public RSAOAEPKeyExchangeFormatter(AsymmetricAlgorithm key) { }

	public virtual Byte[] CreateKeyExchange(Byte[] rgbData) { }

	public virtual Byte[] CreateKeyExchange(Byte[] rgbData, Type symAlgType) { }

	private bool get_OverridesEncrypt() { }

	public Byte[] get_Parameter() { }

	public virtual string get_Parameters() { }

	public RandomNumberGenerator get_Rng() { }

	public void set_Parameter(Byte[] value) { }

	public void set_Rng(RandomNumberGenerator value) { }

	public virtual void SetKey(AsymmetricAlgorithm key) { }

}

