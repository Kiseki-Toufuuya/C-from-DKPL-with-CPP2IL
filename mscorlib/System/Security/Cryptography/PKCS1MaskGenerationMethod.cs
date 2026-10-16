namespace System.Security.Cryptography;

[ComVisible(True)]
public class PKCS1MaskGenerationMethod : MaskGenerationMethod
{
	private string HashNameValue; //Field offset: 0x8

	public string HashName
	{
		 get { } //Length: 11
		 set { } //Length: 90
	}

	public PKCS1MaskGenerationMethod() { }

	public virtual Byte[] GenerateMask(Byte[] rgbSeed, int cbReturn) { }

	public string get_HashName() { }

	public void set_HashName(string value) { }

}

