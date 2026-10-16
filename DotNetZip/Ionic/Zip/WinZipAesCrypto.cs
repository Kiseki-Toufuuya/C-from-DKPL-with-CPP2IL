namespace Ionic.Zip;

internal class WinZipAesCrypto
{
	internal Byte[] _Salt; //Field offset: 0x8
	internal Byte[] _providedPv; //Field offset: 0xC
	internal Byte[] _generatedPv; //Field offset: 0x10
	internal int _KeyStrengthInBits; //Field offset: 0x14
	private Byte[] _MacInitializationVector; //Field offset: 0x18
	private Byte[] _StoredMac; //Field offset: 0x1C
	private Byte[] _keyBytes; //Field offset: 0x20
	private short PasswordVerificationStored; //Field offset: 0x24
	private short PasswordVerificationGenerated; //Field offset: 0x26
	private int Rfc2898KeygenIterations; //Field offset: 0x28
	private string _Password; //Field offset: 0x2C
	private bool _cryptoGenerated; //Field offset: 0x30
	public Byte[] CalculatedMac; //Field offset: 0x34

	private int _KeyStrengthInBytes
	{
		private get { } //Length: 20
	}

	public Byte[] GeneratedPV
	{
		 get { } //Length: 30
	}

	public Byte[] KeyBytes
	{
		 get { } //Length: 30
	}

	public Byte[] MacIv
	{
		 get { } //Length: 30
	}

	public string Password
	{
		 set { } //Length: 188
	}

	public Byte[] Salt
	{
		 get { } //Length: 11
	}

	public int SizeOfEncryptionMetadata
	{
		 get { } //Length: 23
	}

	private void _GenerateCryptoBytes() { }

	private WinZipAesCrypto(string password, int KeyStrengthInBits) { }

	public static WinZipAesCrypto Generate(string password, int KeyStrengthInBits) { }

	private int get__KeyStrengthInBytes() { }

	public Byte[] get_GeneratedPV() { }

	public Byte[] get_KeyBytes() { }

	public Byte[] get_MacIv() { }

	public Byte[] get_Salt() { }

	public int get_SizeOfEncryptionMetadata() { }

	public void ReadAndVerifyMac(Stream s) { }

	public static WinZipAesCrypto ReadFromStream(string password, int KeyStrengthInBits, Stream s) { }

	public void set_Password(string value) { }

}

