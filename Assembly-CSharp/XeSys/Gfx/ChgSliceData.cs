namespace XeSys.Gfx;

public class ChgSliceData
{
	[SerializeField]
	public string TexUvName; //Field offset: 0x8
	[SerializeField]
	public bool IsColoredTex; //Field offset: 0xC
	[SerializeField]
	public Color TexColor; //Field offset: 0x10
	[SerializeField]
	public List<ChgFontColorData> FontColorList; //Field offset: 0x20

	public ChgSliceData() { }

}

