namespace Ionic.Zip;

internal class ZipCrypto
{
	private UInt32[] _Keys; //Field offset: 0x8
	private CRC32 crc32; //Field offset: 0xC

	private byte MagicByte
	{
		private get { } //Length: 48
	}

	private ZipCrypto() { }

	public Byte[] DecryptMessage(Byte[] cipherText, int length) { }

	public Byte[] EncryptMessage(Byte[] plainText, int length) { }

	public static ZipCrypto ForRead(string password, ZipEntry e) { }

	public static ZipCrypto ForWrite(string password) { }

	private byte get_MagicByte() { }

	public void InitCipher(string passphrase) { }

	private void UpdateKeys(byte byteValue) { }

}

