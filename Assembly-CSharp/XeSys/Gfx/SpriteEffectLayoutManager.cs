namespace XeSys.Gfx;

public class SpriteEffectLayoutManager
{
	private static SpriteEffectLayoutManager m_Instance; //Field offset: 0x0
	private Layout[] m_Layouts; //Field offset: 0x8

	public static SpriteEffectLayoutManager Instance
	{
		 get { } //Length: 40
	}

	private SpriteEffectLayoutManager(int effectTypeNum) { }

	public static void Create(int effectTypeNum) { }

	public void Dispose() { }

	public static SpriteEffectLayoutManager get_Instance() { }

	public Layout GetEffectLayout(int effectType) { }

	public void SetEffectLayout(int effectType, Layout layout) { }

}

