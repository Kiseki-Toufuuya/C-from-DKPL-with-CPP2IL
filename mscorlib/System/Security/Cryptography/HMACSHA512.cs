namespace System.Security.Cryptography;

[ComVisible(True)]
public class HMACSHA512 : HMAC
{
	private bool m_useLegacyBlockSize; //Field offset: 0x38

	private int BlockSize
	{
		private get { } //Length: 25
	}

	public bool ProduceLegacyHmacValues
	{
		 get { } //Length: 11
		 set { } //Length: 41
	}

	public HMACSHA512() { }

	public HMACSHA512(Byte[] key) { }

	private int get_BlockSize() { }

	public bool get_ProduceLegacyHmacValues() { }

	public void set_ProduceLegacyHmacValues(bool value) { }

}

