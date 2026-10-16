namespace XeSys.Gfx;

public class TexUVData
{
	public string name; //Field offset: 0x8
	public float u; //Field offset: 0xC
	public float v; //Field offset: 0x10
	public float width; //Field offset: 0x14
	public float height; //Field offset: 0x18
	public int left; //Field offset: 0x1C
	public int top; //Field offset: 0x20
	public int right; //Field offset: 0x24
	public int bottom; //Field offset: 0x28
	private Sprite m_sprite; //Field offset: 0x2C

	public Sprite sprite
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public TexUVData() { }

	public Sprite get_sprite() { }

	public void set_sprite(Sprite value) { }

}

