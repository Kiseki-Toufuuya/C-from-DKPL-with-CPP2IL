namespace System.Security.Cryptography;

[ComVisible(True)]
public abstract class Rijndael : SymmetricAlgorithm
{
	private static KeySizes[] s_legalBlockSizes; //Field offset: 0x0
	private static KeySizes[] s_legalKeySizes; //Field offset: 0x4

	private static Rijndael() { }

	protected Rijndael() { }

	public static Rijndael Create() { }

	public static Rijndael Create(string algName) { }

}

