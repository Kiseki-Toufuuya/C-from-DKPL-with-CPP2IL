namespace XeSys.Gfx;

public class ChgFontColorData
{
	[SerializeField]
	public string id; //Field offset: 0x8
	[SerializeField]
	public List<FontColorData> fontColorList; //Field offset: 0xC

	public ChgFontColorData() { }

}

