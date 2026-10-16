namespace System.Security.Cryptography;

[ComVisible(True)]
public sealed class RC2CryptoServiceProvider : RC2
{
	private static KeySizes[] s_legalKeySizes; //Field offset: 0x0
	private bool m_use40bitSalt; //Field offset: 0x30

	public virtual int EffectiveKeySize
	{
		 get { } //Length: 11
		 set { } //Length: 90
	}

	[ComVisible(False)]
	public bool UseSalt
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static RC2CryptoServiceProvider() { }

	public RC2CryptoServiceProvider() { }

	public virtual ICryptoTransform CreateDecryptor(Byte[] rgbKey, Byte[] rgbIV) { }

	public virtual ICryptoTransform CreateEncryptor(Byte[] rgbKey, Byte[] rgbIV) { }

	public virtual void GenerateIV() { }

	public virtual void GenerateKey() { }

	public virtual int get_EffectiveKeySize() { }

	public bool get_UseSalt() { }

	public virtual void set_EffectiveKeySize(int value) { }

	public void set_UseSalt(bool value) { }

}

