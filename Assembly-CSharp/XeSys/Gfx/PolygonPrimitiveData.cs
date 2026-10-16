namespace XeSys.Gfx;

public class PolygonPrimitiveData
{
	private int VERTEX_MAX; //Field offset: 0x8
	private int TRIANGLE_MAX; //Field offset: 0xC
	private int DRAW_SETTING_MAX; //Field offset: 0x10
	private Vector3[] m_Vertices; //Field offset: 0x14
	private Vector2[] m_Uvs; //Field offset: 0x18
	private Color32[] m_Colors; //Field offset: 0x1C
	private Int32[] m_Triangles; //Field offset: 0x20
	private PolygonDrawSetting[] m_DrawSettings; //Field offset: 0x24
	private int m_VerticesCount; //Field offset: 0x28
	private int m_TrianglesCount; //Field offset: 0x2C
	private int m_DrawSettingsCount; //Field offset: 0x30
	private int m_SetCount; //Field offset: 0x34

	public Color32[] Colors
	{
		 get { } //Length: 11
	}

	public PolygonDrawSetting[] DrawSettings
	{
		 get { } //Length: 11
	}

	public int DrawSettingsCount
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public Int32[] Triangles
	{
		 get { } //Length: 11
	}

	private int TrianglesCount
	{
		private get { } //Length: 11
		private set { } //Length: 14
	}

	public Vector2[] Uvs
	{
		 get { } //Length: 11
	}

	public Vector3[] Vertices
	{
		 get { } //Length: 11
	}

	private int VerticesCount
	{
		private get { } //Length: 11
		private set { } //Length: 14
	}

	public PolygonPrimitiveData(int VertexMax, int TriangleMax, int DrawSettingMax) { }

	public void AddCount(int addVertexCount, int addTriangleCount) { }

	public void EndEdit() { }

	public Color32[] get_Colors() { }

	public PolygonDrawSetting[] get_DrawSettings() { }

	public int get_DrawSettingsCount() { }

	public Int32[] get_Triangles() { }

	private int get_TrianglesCount() { }

	public Vector2[] get_Uvs() { }

	public Vector3[] get_Vertices() { }

	private int get_VerticesCount() { }

	public void set_DrawSettingsCount(int value) { }

	private void set_TrianglesCount(int value) { }

	private void set_VerticesCount(int value) { }

	public void SetMaterial(Material material) { }

	public void SetQuadrangle(Vector3 pos1, Vector2 uv1, Color32 col1, Vector3 pos2, Vector2 uv2, Color32 col2, Vector3 pos3, Vector2 uv3, Color32 col3, Vector3 pos4, Vector2 uv4, Color32 col4) { }

	public void SetQuadrangleFast(int VertexIdxOffset, int TriangleIdxOffset, float pos1x, float pos1y, float pos1z, float uv1x, float uv1y, byte col1a, byte col1r, byte col1g, byte col1b, float pos2x, float pos2y, float pos2z, float uv2x, float uv2y, byte col2a, byte col2r, byte col2g, byte col2b, float pos3x, float pos3y, float pos3z, float uv3x, float uv3y, byte col3a, byte col3r, byte col3g, byte col3b, float pos4x, float pos4y, float pos4z, float uv4x, float uv4y, byte col4a, byte col4r, byte col4g, byte col4b) { }

	public void SetQuadrangleFast(float pos1x, float pos1y, float pos1z, float uv1x, float uv1y, byte col1a, byte col1r, byte col1g, byte col1b, float pos2x, float pos2y, float pos2z, float uv2x, float uv2y, byte col2a, byte col2r, byte col2g, byte col2b, float pos3x, float pos3y, float pos3z, float uv3x, float uv3y, byte col3a, byte col3r, byte col3g, byte col3b, float pos4x, float pos4y, float pos4z, float uv4x, float uv4y, byte col4a, byte col4r, byte col4g, byte col4b) { }

	public void SetTriangle(Vector3 pos1, Vector2 uv1, Color32 col1, Vector3 pos2, Vector2 uv2, Color32 col2, Vector3 pos3, Vector2 uv3, Color32 col3) { }

	public void SetVertex(Vector3 pos, Vector2 uv, Color32 col) { }

	public void StartEdit() { }

}

