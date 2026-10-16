namespace XeSys;

public class CipherRsa
{
	private RSACryptoServiceProvider mEncryptRsaCSP; //Field offset: 0x8
	private RSACryptoServiceProvider mDecryptRsaCSP; //Field offset: 0xC

	public CipherRsa() { }

	public Byte[] Decrypt(Byte[] encrytedBytes) { }

	public string DecryptFromBase64(string encryptedBase64Text) { }

	public string DecryptFromBase64(ref string cipherBase64Text) { }

	public string EncryptToBase64(string plainText) { }

	public void InitializePrivateKey(Byte[] pfxBytes, string password) { }

	public void InitializePublicKey(Byte[] bytes, int bytesIndex, int bytesLength) { }

}

