namespace TMPro;

public struct TMP_WordInfo
{
	public TMP_Text textComponent; //Field offset: 0x0
	public int firstCharacterIndex; //Field offset: 0x4
	public int lastCharacterIndex; //Field offset: 0x8
	public int characterCount; //Field offset: 0xC

	public string GetWord() { }

}

