namespace System.Security.Cryptography;

[ComVisible(True)]
public abstract class AsymmetricKeyExchangeDeformatter
{

	public abstract string Parameters
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	protected AsymmetricKeyExchangeDeformatter() { }

	public abstract Byte[] DecryptKeyExchange(Byte[] rgb) { }

	public abstract string get_Parameters() { }

	public abstract void set_Parameters(string value) { }

	public abstract void SetKey(AsymmetricAlgorithm key) { }

}

