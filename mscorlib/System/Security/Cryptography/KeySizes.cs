namespace System.Security.Cryptography;

[ComVisible(True)]
public sealed class KeySizes
{
	private int m_minSize; //Field offset: 0x8
	private int m_maxSize; //Field offset: 0xC
	private int m_skipSize; //Field offset: 0x10

	public int MaxSize
	{
		 get { } //Length: 11
	}

	public int MinSize
	{
		 get { } //Length: 11
	}

	public int SkipSize
	{
		 get { } //Length: 11
	}

	public KeySizes(int minSize, int maxSize, int skipSize) { }

	public int get_MaxSize() { }

	public int get_MinSize() { }

	public int get_SkipSize() { }

	internal bool IsLegal(int keySize) { }

	internal static bool IsLegalKeySize(KeySizes[] legalKeys, int size) { }

}

