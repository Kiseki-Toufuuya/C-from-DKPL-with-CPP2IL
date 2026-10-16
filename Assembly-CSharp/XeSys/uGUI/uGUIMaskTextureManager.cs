namespace XeSys.uGUI;

public class uGUIMaskTextureManager : SingletonBehaviour<uGUIMaskTextureManager>, IDisposable
{
	private class MaskTextureData
	{
		public RenderTexture m_renderTexture; //Field offset: 0x8
		public Material m_MaskMaterial; //Field offset: 0xC
		public Material m_MaskMaterialSplit; //Field offset: 0x10
		public bool m_IsAutoMaskClear; //Field offset: 0x14
		public bool m_RequestAutoMaskClear; //Field offset: 0x15
		public Dictionary<Material, Material> m_MaskedMaterialDic; //Field offset: 0x18

		public MaskTextureData() { }

	}

	private enum ShaderType
	{
		Transparent = 0,
		TransparentAdd = 1,
		SplitTexture = 2,
		SplitTextureAdd = 3,
		num = 4,
	}

	[SerializeField]
	private Canvas m_BaseCanvas; //Field offset: 0x10
	[SerializeField]
	private int m_MaskNum; //Field offset: 0x14
	[SerializeField]
	private float m_Sacle; //Field offset: 0x18
	private Dictionary<String, ShaderType> m_ShaderTypeDic; //Field offset: 0x1C
	private Dictionary<String, Boolean> m_IsSplitShaderDic; //Field offset: 0x20
	private MaskTextureData[] m_MaskTextureDatas; //Field offset: 0x24
	private Shader[] m_MaskedShaders; //Field offset: 0x28
	private float m_canvasWidth; //Field offset: 0x2C
	private float m_canvasHeight; //Field offset: 0x30
	private float m_Width; //Field offset: 0x34
	private float m_Height; //Field offset: 0x38
	private float m_Scale; //Field offset: 0x3C

	public uGUIMaskTextureManager() { }

	protected virtual void Awake() { }

	public void ClearTexture(int maskId) { }

	private Material CreateMaskedMaterial(Material material, int maskId) { }

	private void CreateMaterial() { }

	private void CreateTexture(int maskNum, int width, int height) { }

	private void CreateTexture(int maskNum, Canvas canvas, float scale) { }

	public override void Dispose() { }

	public Material GetMaskedMaterial(Material material, int maskId) { }

	public Material GetMaskMaterial(bool isSplit, int maskId) { }

	public RenderTexture GetRenderTexutre(int maskId) { }

	public void Init(int maskNum, Canvas canvas, float scale) { }

	private void InitIsSplitShaderDictionary() { }

	private void InitShaderTypeDictionary() { }

	public bool IsSplitShader(string shaderName) { }

	public void LateUpdate() { }

	public void RenderMask(Texture m_MaskTexture, bool isSplitTexture, Rect uvRect, RectTransform rectTransform, int maskId) { }

	public void SetAutoMaskClearFlg(int maskId, bool flg) { }

}

