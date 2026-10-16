namespace XeSys.Gfx;

public class DynamicPolygonManager
{
	private static readonly Color32 Col32_White; //Field offset: 0x0
	private const float HalfDeg2Rad = 0.008726646; //Field offset: 0x0
	private PolygonPrimitiveData m_PrimitiveData; //Field offset: 0x8
	private DrawDynamicPolygon m_Drawer; //Field offset: 0xC
	private Matrix4x4 m_WorkMatrix; //Field offset: 0x10
	private Vector3 m_WorkPosition; //Field offset: 0x50
	private Color32 m_WorkColor; //Field offset: 0x5C
	private Vector2[] m_WorkVerts; //Field offset: 0x60
	private Vector2[] m_WorkUvs; //Field offset: 0x64
	private Vector3 m_WorkPos1; //Field offset: 0x68
	private Vector3 m_WorkPos2; //Field offset: 0x74
	private Vector3 m_WorkPos3; //Field offset: 0x80
	private Vector3 m_WorkPos4; //Field offset: 0x8C
	private Vector2 m_WorkUV1; //Field offset: 0x98
	private Vector2 m_WorkUV2; //Field offset: 0xA0
	private Vector2 m_WorkUV3; //Field offset: 0xA8
	private Vector2 m_WorkUV4; //Field offset: 0xB0
	private RegistPolygonSpriteData m_RegistSpriteData; //Field offset: 0xB8
	private Quaternion m_WorkQuaternion; //Field offset: 0xBC
	private Material m_WorkMaterial; //Field offset: 0xCC
	private float m_WorkPositionx; //Field offset: 0xD0
	private float m_WorkPositiony; //Field offset: 0xD4
	private float m_WorkPositionz; //Field offset: 0xD8
	private float m_WorkPivotx; //Field offset: 0xDC
	private float m_WorkPivoty; //Field offset: 0xE0
	private float m_WorkPivotz; //Field offset: 0xE4
	private float m_WorkSizex; //Field offset: 0xE8
	private float m_WorkSizey; //Field offset: 0xEC
	private float m_WorkUVx; //Field offset: 0xF0
	private float m_WorkUVy; //Field offset: 0xF4
	private float m_WorkUVSizex; //Field offset: 0xF8
	private float m_WorkUVSizey; //Field offset: 0xFC
	private byte m_WorkColora; //Field offset: 0x100
	private byte m_WorkColorr; //Field offset: 0x101
	private byte m_WorkColorg; //Field offset: 0x102
	private byte m_WorkColorb; //Field offset: 0x103
	private float m_WorkRotationx; //Field offset: 0x104
	private float m_WorkRotationy; //Field offset: 0x108
	private float m_WorkRotationz; //Field offset: 0x10C
	private float m_WorkScalex; //Field offset: 0x110
	private float m_WorkScaley; //Field offset: 0x114
	private float m_WorkScalez; //Field offset: 0x118
	private RegistPolygonLineData m_RegistLineData; //Field offset: 0x11C

	public DrawDynamicPolygon Drawer
	{
		 get { } //Length: 11
	}

	private static DynamicPolygonManager() { }

	public DynamicPolygonManager(int VertexMax, int TriangleMax, int DrawSettingMax) { }

	public void Dispose() { }

	public void EndEdit() { }

	public DrawDynamicPolygon get_Drawer() { }

	public GameObject GetGameObject() { }

	public Transform GetTransform() { }

	public void Init() { }

	public void RegistSprite(IDynamicPolygonSprite polygonSprite) { }

	public void RegistSprite(IDynammicPolygonSpriteData polygonSprite) { }

	public void RegistSpriteArrayFast(Material material, int length, IDynammicPolygonSpriteDataIndividual[] polygonSprite) { }

	public void RegistSpriteArrayMatrix(Material material, int length, IDynammicPolygonSpriteDataMatrix[] polygonSprite) { }

	public void RegistSpriteArrayMatrixFast(Material material, int length, IDynammicPolygonSpriteDataMatrixIndividual[] polygonSprite) { }

	public void RegistSpriteFast(IDynammicPolygonSpriteData polygonSprite) { }

	public void RegistSpriteFastIndividual(IDynammicPolygonSpriteDataIndividual polygonSprite) { }

	public void RegistSpriteLine(IDynammicPolygonLineData polygonLine) { }

	public void SetMaterial(Material mat) { }

	public void SetQuadrangle(Vector3 pos1, Vector2 uv1, Vector3 pos2, Vector2 uv2, Vector3 pos3, Vector2 uv3, Vector3 pos4, Vector2 uv4) { }

	public void SetQuadrangle(Vector3 pos1, Vector2 uv1, Color32 col1, Vector3 pos2, Vector2 uv2, Color32 col2, Vector3 pos3, Vector2 uv3, Color32 col3, Vector3 pos4, Vector2 uv4, Color32 col4) { }

	public void SetTriangle(Vector3 pos1, Vector2 uv1, Vector3 pos2, Vector2 uv2, Vector3 pos3, Vector2 uv3) { }

	public void SetTriangle(Vector3 pos1, Vector2 uv1, Color32 col1, Vector3 pos2, Vector2 uv2, Color32 col2, Vector3 pos3, Vector2 uv3, Color32 col3) { }

	public void SetVertex(Vector3 pos, Vector2 uv) { }

	public void SetVertex(Vector3 pos, Vector2 uv, Color32 col) { }

	public void StartEdit() { }

}

