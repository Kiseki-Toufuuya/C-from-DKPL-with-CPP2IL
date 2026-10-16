namespace XeSys;

public class CipherRijndael
{
	[CompilerGenerated]
	private Rijndael <rijndale>k__BackingField; //Field offset: 0x8

	private Rijndael rijndale
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public CipherRijndael(string password, string salt) { }

	public string DecryptFromBase64(string cipherText) { }

	public string EncryptToBase64(string plainText) { }

	private static void GenerateKeyFromPassword(string password, string salt, int keySize, out Byte[] key, int blockSize, out Byte[] iv) { }

	[CompilerGenerated]
	private Rijndael get_rijndale() { }

	[CompilerGenerated]
	private void set_rijndale(Rijndael value) { }

}

