namespace System.Security.Cryptography;

[ComVisible(True)]
public abstract class AsymmetricKeyExchangeFormatter
{

	public abstract string Parameters
	{
		 get { } //Length: 0
	}

	protected AsymmetricKeyExchangeFormatter() { }

	public abstract Byte[] CreateKeyExchange(Byte[] data) { }

	public abstract Byte[] CreateKeyExchange(Byte[] data, Type symAlgType) { }

	public abstract string get_Parameters() { }

	public abstract void SetKey(AsymmetricAlgorithm key) { }

}

