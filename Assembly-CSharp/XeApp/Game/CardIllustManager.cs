namespace XeApp.Game;

public class CardIllustManager : MonoBehaviour
{
	private enum CANVAS_TYPE
	{
		CANVAS_01 = 0,
		CANVAS_02 = 1,
		CANVAS_03 = 2,
	}

	internal enum TYPE
	{
		NONE = -1,
		ILLUST_01 = 0,
		ILLUST_02 = 1,
		ILLUST_03 = 2,
		SMALL_ILUST_01 = 3,
		SMALL_ILUST_02 = 4,
		SMALL_ILUST_03 = 5,
		SMALL_ILUST_04 = 6,
		SMALL_ILUST_05 = 7,
		SMALL_ILUST_06 = 8,
		SMALL_ILUST_07 = 9,
		SMALL_ILUST_08 = 10,
		SMALL_ILUST_09 = 11,
		SMALL_ILUST_10 = 12,
	}

	private static CardIllustManager instance; //Field offset: 0x0
	private const int imageNum = 13; //Field offset: 0x0
	private const int canvasNum = 3; //Field offset: 0x0
	private const int RENDER_TEXTURE_BASE_SIZE = 2048; //Field offset: 0x0
	private Shader cardIllustShader; //Field offset: 0x10
	private Material cardIllustStampMaterial; //Field offset: 0x14
	private Material dstMaterial; //Field offset: 0x18
	private Material dstCutinMaterial; //Field offset: 0x1C
	private Image[] image; //Field offset: 0x20
	private RectTransform[] imageRect; //Field offset: 0x24
	private Canvas[] canvas; //Field offset: 0x28
	private RenderTexture[] renderTexture; //Field offset: 0x2C
	private Camera[] illustCamera; //Field offset: 0x30
	private Vector2 renderTextureSize; //Field offset: 0x34

	public static CardIllustManager Instance
	{
		 get { } //Length: 40
	}

	public CardIllustManager() { }

	[CompilerGenerated]
	private void <Load>b__34_0(AssetBundleLoadAssetOperation ope) { }

	[CompilerGenerated]
	private void <Load>b__34_1(AssetBundleLoadAssetOperation ope) { }

	[CompilerGenerated]
	private void <Load>b__34_2(AssetBundleLoadAssetOperation ope) { }

	[CompilerGenerated]
	private void <Load>b__34_3(AssetBundleLoadAssetOperation ope) { }

	private void Awake() { }

	public void DisableCardIllust(TYPE type) { }

	public void EnableCardIllust(TYPE type, Material material) { }

	public static CardIllustManager get_Instance() { }

	public Camera GetCamera(TYPE type) { }

	public Canvas GetCanvas(TYPE type) { }

	public Shader GetCardIllustShader() { }

	public Material GetCardIllustStampMaterial() { }

	public Material GetCutinMaterial() { }

	public TYPE GetFreeType(bool isSmallTexture = false) { }

	public GameObject GetIllustObject(TYPE type) { }

	public Material GetMaterial() { }

	public RenderTexture GetRenderTexture(TYPE type) { }

	public Rect GetUVRect(TYPE type) { }

	public void Load() { }

	public Vector3 MakeEffectPos(TYPE type) { }

	public Vector3 MakeIllustPos(TYPE type) { }

	private void OnDestroy() { }

	private void Start() { }

	public void Unload() { }

}

