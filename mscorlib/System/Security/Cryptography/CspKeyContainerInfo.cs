namespace System.Security.Cryptography;

[ComVisible(True)]
public sealed class CspKeyContainerInfo
{
	private CspParameters _params; //Field offset: 0x8
	internal bool _random; //Field offset: 0xC

	public bool Accessible
	{
		 get { } //Length: 3
	}

	public CryptoKeySecurity CryptoKeySecurity
	{
		 get { } //Length: 3
	}

	public bool Exportable
	{
		 get { } //Length: 3
	}

	public bool HardwareDevice
	{
		 get { } //Length: 3
	}

	public string KeyContainerName
	{
		 get { } //Length: 23
	}

	public KeyNumber KeyNumber
	{
		 get { } //Length: 23
	}

	public bool MachineKeyStore
	{
		 get { } //Length: 3
	}

	public bool Protected
	{
		 get { } //Length: 3
	}

	public string ProviderName
	{
		 get { } //Length: 23
	}

	public int ProviderType
	{
		 get { } //Length: 23
	}

	public bool RandomlyGenerated
	{
		 get { } //Length: 11
	}

	public bool Removable
	{
		 get { } //Length: 3
	}

	public string UniqueKeyContainerName
	{
		 get { } //Length: 73
	}

	public CspKeyContainerInfo(CspParameters parameters) { }

	public bool get_Accessible() { }

	public CryptoKeySecurity get_CryptoKeySecurity() { }

	public bool get_Exportable() { }

	public bool get_HardwareDevice() { }

	public string get_KeyContainerName() { }

	public KeyNumber get_KeyNumber() { }

	public bool get_MachineKeyStore() { }

	public bool get_Protected() { }

	public string get_ProviderName() { }

	public int get_ProviderType() { }

	public bool get_RandomlyGenerated() { }

	public bool get_Removable() { }

	public string get_UniqueKeyContainerName() { }

}

