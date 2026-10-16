namespace XeApp.Game;

public class UiRadioButtonBase
{
	private enum STATE
	{
		OFF = 0,
		ON = 1,
		NUM = 2,
	}

	private DispBase m_Owner; //Field offset: 0x8
	private int m_Count; //Field offset: 0xC
	private int m_TopButtonId; //Field offset: 0x10
	private AtlasImage[] m_AtlasImage; //Field offset: 0x14
	private String[] m_SpriteIdList; //Field offset: 0x18
	private int m_CheckedIndex; //Field offset: 0x1C

	public UiRadioButtonBase(DispBase dispBase, int buttonId, int count, String[] spriteIdList) { }

	public int GetCheckedIndex() { }

	public void SetCheck(int index) { }

	public void SetCheckButtonId(int buttonId) { }

}

