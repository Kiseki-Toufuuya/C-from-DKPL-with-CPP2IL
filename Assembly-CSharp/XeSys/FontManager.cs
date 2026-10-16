namespace XeSys;

public class FontManager : MonoBehaviour
{
	[SerializeField]
	private FontInfo[] fontTable; //Field offset: 0x10

	public int GetFontInfoLength
	{
		 get { } //Length: 23
	}

	public FontManager() { }

	public int get_GetFontInfoLength() { }

	public FontInfo GetFontInfo(int index) { }

}

