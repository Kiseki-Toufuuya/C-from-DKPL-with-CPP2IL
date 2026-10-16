namespace XeSys.Gfx;

public class PolygonDrawSetting
{
	private Material m_Material; //Field offset: 0x8
	private int m_StartTriangles; //Field offset: 0xC
	private int m_EndTriangles; //Field offset: 0x10

	public int EndTriangles
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public Material Material
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public int StartTriangles
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public PolygonDrawSetting() { }

	public int get_EndTriangles() { }

	public Material get_Material() { }

	public int get_StartTriangles() { }

	public void set_EndTriangles(int value) { }

	public void set_Material(Material value) { }

	public void set_StartTriangles(int value) { }

}

