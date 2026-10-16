namespace System.Security.Cryptography;

[ComVisible(True)]
public abstract class TripleDES : SymmetricAlgorithm
{
	private static KeySizes[] s_legalBlockSizes; //Field offset: 0x0
	private static KeySizes[] s_legalKeySizes; //Field offset: 0x4

	public virtual Byte[] Key
	{
		 get { } //Length: 186
		 set { } //Length: 449
	}

	private static TripleDES() { }

	protected TripleDES() { }

	public static TripleDES Create() { }

	public static TripleDES Create(string str) { }

	private static bool EqualBytes(Byte[] rgbKey, int start1, int start2, int count) { }

	public virtual Byte[] get_Key() { }

	private static bool IsLegalKeySize(Byte[] rgbKey) { }

	public static bool IsWeakKey(Byte[] rgbKey) { }

	public virtual void set_Key(Byte[] value) { }

}

