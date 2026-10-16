namespace XeApp.Game;

public class AdvScreenColor
{
	private const float m_Default_0R = 0.257; //Field offset: 0x0
	private const float m_Default_0G = 0.504; //Field offset: 0x0
	private const float m_Default_0B = 0.098; //Field offset: 0x0
	private const float m_Default_1R = 1; //Field offset: 0x0
	private const float m_Default_1G = 1; //Field offset: 0x0
	private const float m_Default_1B = 1; //Field offset: 0x0
	private GameObject m_Parent; //Field offset: 0x8
	private GameObject m_Screen; //Field offset: 0xC
	private Material m_MatColChange; //Field offset: 0x10
	private Material m_MatMosaic; //Field offset: 0x14

	public AdvScreenColor(GameObject parent, bool disp = false, int mode = -1) { }

	public void ColReset() { }

	public void Destroy() { }

	public void SetColor0(float r, float g, float b, float a) { }

	public void SetColor0Rate(float rate) { }

	public void SetColor1(float r, float g, float b, float a) { }

	public void SetMode(int mode) { }

}

