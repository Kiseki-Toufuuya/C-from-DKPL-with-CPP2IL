namespace TMPro;

public class TMP_SpriteCharacter : TMP_TextElement
{
	[SerializeField]
	private string m_Name; //Field offset: 0x20

	public string name
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public TMP_SpriteCharacter() { }

	public TMP_SpriteCharacter(uint unicode, TMP_SpriteGlyph glyph) { }

	public TMP_SpriteCharacter(uint unicode, TMP_SpriteAsset spriteAsset, TMP_SpriteGlyph glyph) { }

	internal TMP_SpriteCharacter(uint unicode, uint glyphIndex) { }

	public string get_name() { }

	public void set_name(string value) { }

}

