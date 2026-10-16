namespace XeApp.Game;

public class RenderTextureMan : MonoBehaviour
{
	private enum DRAWRECT
	{
		ID00 = 0,
		ID01 = 1,
		ID02 = 2,
		ID03 = 3,
		ID04 = 4,
		ID05 = 5,
		ID06 = 6,
		ID07 = 7,
		ID08 = 8,
		ID09 = 9,
		ID10 = 10,
		ID11 = 11,
		ID12 = 12,
		ID13 = 13,
		ID14 = 14,
		ID15 = 15,
		ID16 = 16,
		ID17 = 17,
		ID18 = 18,
		ID19 = 19,
		ID20 = 20,
		ID21 = 21,
		ID22 = 22,
		NUM = 23,
	}

	private class RectObject
	{
		public GameObject clear; //Field offset: 0x8
		public GameObject mask; //Field offset: 0xC
		public bool enable; //Field offset: 0x10
		public bool active; //Field offset: 0x11
		public float zpos; //Field offset: 0x14
		public TYPE rt_type; //Field offset: 0x18

		public RectObject(GameObject go_clear, GameObject go_mask, float zpos) { }

	}

	private class RenderSetting
	{
		public SITUATION situation; //Field offset: 0x8
		public TYPE type; //Field offset: 0xC
		public Rect rect; //Field offset: 0x10
		public DRAWRECT drawrect; //Field offset: 0x20
		public Vector2 offset; //Field offset: 0x24
		public float scale; //Field offset: 0x2C

		public RenderSetting(SITUATION situation, TYPE type, Rect rect, DRAWRECT drawrect, Vector2 offset, float scale) { }

	}

	internal enum SITUATION
	{
		FULL = 0,
		BOSS = 1,
		SD01 = 2,
		SD02 = 3,
		SD03 = 4,
		SD04 = 5,
		SD05 = 6,
		SD06 = 7,
		SD07 = 8,
		SD08 = 9,
		SD09 = 10,
		SD10 = 11,
		SD11 = 12,
		SD12 = 13,
		SD13 = 14,
		SD14 = 15,
		SD15 = 16,
		SD16 = 17,
		TRAVEL_CUTIN_01 = 18,
		TRAVEL_CUTIN_02 = 19,
		TRAVEL_CUTIN_03 = 20,
		TRAVEL01 = 21,
		TRAVEL02 = 22,
		TRAVEL03 = 23,
		TRAVEL04 = 24,
		HEROIN01 = 25,
		HEROIN02 = 26,
		HEROIN03 = 27,
		HEROIN04 = 28,
		CARD_ILLUST = 29,
		SETTING_PREVIEW = 30,
		SETTING_PREVIEW_HIDDEN = 31,
		KEYCONFIG_PREVIEW = 32,
		KAGURA_BOSS = 33,
		KAGURA_PLAYER = 34,
	}

	internal enum TYPE
	{
		NONE = 0,
		FULL = 1,
		BOSS = 2,
		SD01 = 3,
		SD02 = 4,
		SD03 = 5,
		SD04 = 6,
		SD05 = 7,
		SD06 = 8,
		SD07 = 9,
		SD08 = 10,
		SD09 = 11,
		SD10 = 12,
		SD11 = 13,
		SD12 = 14,
		SD13 = 15,
		SD14 = 16,
		SD15 = 17,
		SD16 = 18,
		TRAVEL_CUTIN_01 = 19,
		TRAVEL_CUTIN_02 = 20,
		TRAVEL_CUTIN_03 = 21,
		TRAVEL_01 = 22,
		TRAVEL_02 = 23,
		TRAVEL_03 = 24,
		TRAVEL_04 = 25,
		HEROIN01 = 26,
		HEROIN02 = 27,
		HEROIN03 = 28,
		HEROIN04 = 29,
		CARD_ILLUST = 30,
		SETTING_PREVIEW = 31,
		SETTING_PREVIEW_HIDDEN = 32,
		KEYCONFIG_PREVIEW = 33,
		KAGURA_BOSS = 34,
		KAGURA_PLAYER = 35,
	}

	private static RenderTextureMan m_Instance; //Field offset: 0x0
	private const float TEX_BASE_SIZE = 2048; //Field offset: 0x0
	private const int TEXTURE_SIZE = 2048; //Field offset: 0x0
	private GameObject m_goCamera; //Field offset: 0x10
	private Camera m_Camera; //Field offset: 0x14
	private GameObject m_goCanvas; //Field offset: 0x18
	private RenderTexture m_RenderTexture; //Field offset: 0x1C
	private GameObject m_goStencilFill; //Field offset: 0x20
	private int TextureSize; //Field offset: 0x24
	private RenderSetting[] m_Settings; //Field offset: 0x28
	private RectObject[] m_RectObject; //Field offset: 0x2C
	private float m_ScrSize; //Field offset: 0x30
	private bool m_RenderTextureOff; //Field offset: 0x34

	public GameObject BgCanvas
	{
		 get { } //Length: 11
	}

	public static RenderTextureMan Instance
	{
		 get { } //Length: 40
	}

	public RenderTextureMan() { }

	public void AddCameraCullingMask(string layerName) { }

	private void Awake() { }

	public void CameraColorClear() { }

	public void CameraColorToWhite() { }

	public void CameraToDefaultView() { }

	public void CameraToTopDownView() { }

	private void CreateRenderTexture() { }

	public void DisableDrawRect(TYPE type) { }

	public Vector4 EnableDrawRect(TYPE type) { }

	public GameObject get_BgCanvas() { }

	public static RenderTextureMan get_Instance() { }

	public Rect GetDrawRect(TYPE type) { }

	public Vector4 GetEnableDrawRect(TYPE type) { }

	public Vector3 GetRectObjectScale(TYPE type) { }

	public float GetRectScale(TYPE type) { }

	public Camera GetRenderCamera() { }

	private RenderSetting GetRenderSetting(TYPE type) { }

	public float GetScrSpaceX(float posx) { }

	public float GetScrSpaceY(float posy) { }

	public float GetTexSpaceU(float x) { }

	public float GetTexSpaceV(float y) { }

	public float GetTexSpaceX(float posx) { }

	public float GetTexSpaceY(float posy) { }

	public Texture GetTexture() { }

	public Rect GetUVRect(TYPE type) { }

	public Rect GetViewportRectBias(TYPE type) { }

	public void InitDrawRect() { }

	public void InversionRenderTexture(bool isLeft, MeshFilter filter, TYPE type) { }

	public void InversionRenderTexture(bool isLeft, RawImageEx image, TYPE type) { }

	private void OnDestroy() { }

	public void PasteRenderTexture(MeshFilter filter, MeshRenderer render, TYPE type) { }

	public void PasteRenderTexture(RawImageEx image, TYPE type) { }

	public void RemoveCameraCullingMask(string layerName) { }

	public void RenderTextureOff(bool render_texture_off) { }

	private void SetRenderTextureEnable() { }

	private void Start() { }

}

