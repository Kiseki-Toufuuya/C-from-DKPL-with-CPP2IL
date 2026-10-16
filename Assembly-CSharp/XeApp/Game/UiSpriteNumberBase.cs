namespace XeApp.Game;

public class UiSpriteNumberBase
{
	private DispBase m_Owner; //Field offset: 0x8
	private int m_Digit; //Field offset: 0xC
	private int m_LayerId; //Field offset: 0x10
	private int m_NothingLayerId; //Field offset: 0x14
	private AtlasImage[] m_AtlasImage; //Field offset: 0x18
	private string m_ImageFormat; //Field offset: 0x1C
	private int m_maxValue; //Field offset: 0x20

	public UiSpriteNumberBase(DispBase dispBase, int layerId, int digit, string format) { }

	public void HideNumbers() { }

	private bool IsZeroPadding() { }

	public void SetInfo(int value) { }

	public void SetInfo(float value) { }

	public void SetNothing() { }

	public void SetNothingLayerId(int layerId) { }

}

