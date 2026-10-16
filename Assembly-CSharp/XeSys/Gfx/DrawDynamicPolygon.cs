namespace XeSys.Gfx;

public class DrawDynamicPolygon
{
	private GameObject m_gameObj; //Field offset: 0x8
	private Mesh m_DynamicMesh; //Field offset: 0xC
	private MeshFilter m_MeshFil; //Field offset: 0x10
	private MeshRenderer m_Renderer; //Field offset: 0x14
	private Mesh[] m_Mesh; //Field offset: 0x18
	private int m_CurrentMesh; //Field offset: 0x1C

	private Mesh DynamicMesh
	{
		private get { } //Length: 11
	}

	private GameObject GameObj
	{
		private get { } //Length: 11
	}

	private MeshFilter MeshFil
	{
		private get { } //Length: 11
	}

	private MeshRenderer Renderer
	{
		private get { } //Length: 11
	}

	public DrawDynamicPolygon() { }

	public void Dispose() { }

	private Mesh get_DynamicMesh() { }

	private GameObject get_GameObj() { }

	private MeshFilter get_MeshFil() { }

	private MeshRenderer get_Renderer() { }

	public GameObject GetGameObject() { }

	public Transform GetTransform() { }

	public void Init() { }

	public void SettingDraw(PolygonPrimitiveData data) { }

	public void StartSetting() { }

}

