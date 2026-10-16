namespace XeSys.Gfx;

public class LayoutUGUIRuntime : MonoBehaviour, ISortTarget
{
	[CompilerGenerated]
	private sealed class <Co_Initialize>d__66 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public LayoutUGUIRuntime <>4__this; //Field offset: 0x10
		private Component[] <scripts>5__2; //Field offset: 0x14
		private int <i>5__3; //Field offset: 0x18
		private ILayoutUGUIInitializeFromLayout <script>5__4; //Field offset: 0x1C

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		[DebuggerHidden]
		public <Co_Initialize>d__66(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal class FontLayerData
	{
		[SerializeField]
		public Text TextComponent; //Field offset: 0x8
		public TextMeshProUGUI TextMeshComponent; //Field offset: 0xC
		public string FontName; //Field offset: 0x10

		public FontLayerData() { }

	}

	internal class TextureSet
	{
		public Material MaterialMul; //Field offset: 0x8
		public Material MaterialAdd; //Field offset: 0xC
		public List<Sprite> m_Sprites; //Field offset: 0x10
		private Dictionary<String, Sprite> m_SpriteDic; //Field offset: 0x14

		public Texture2D AlphaTexture
		{
			 get { } //Length: 192
		}

		public bool IsSplitTexture
		{
			 get { } //Length: 149
		}

		public Texture2D Texture
		{
			 get { } //Length: 148
		}

		public TextureSet() { }

		public void AddSprites(Sprite sprite) { }

		public void ClearSprites() { }

		public Texture2D get_AlphaTexture() { }

		public bool get_IsSplitTexture() { }

		public Texture2D get_Texture() { }

		public Sprite GetSprite(string name) { }

		public void InitSpriteDictionary() { }

		public bool IsMatchTexture(string textureName) { }

		public bool IsValid(bool isSplitTexture) { }

		public void SetAlphaTexture(IAlphaTexture tex) { }

	}

	private static float s_commonTimeScale; //Field offset: 0x0
	private static bool m_isAlwaysUpdateSRT; //Field offset: 0x4
	private static StringBuilder s_texNameWork; //Field offset: 0x8
	[HideInInspector]
	[SerializeField]
	private bool m_IsHM; //Field offset: 0x10
	[HideInInspector]
	[SerializeField]
	private bool m_IsDependenceTexture; //Field offset: 0x11
	[SerializeField]
	private ScriptableLayout m_layoutAsset; //Field offset: 0x14
	[SerializeField]
	private String[] m_textureNameList; //Field offset: 0x18
	[SerializeField]
	private Font[] m_font; //Field offset: 0x1C
	[SerializeField]
	private TMP_FontAsset[] m_fontAsset; //Field offset: 0x20
	[SerializeField]
	private FontLayerData[] m_fontLayerData; //Field offset: 0x24
	[SerializeField]
	private bool m_isUseImage; //Field offset: 0x28
	[SerializeField]
	private float m_timeScale; //Field offset: 0x2C
	[SerializeField]
	private Color m_color; //Field offset: 0x30
	private Action m_updater; //Field offset: 0x40
	private Layout m_layout; //Field offset: 0x44
	private TexUVListManager[] m_uvManList; //Field offset: 0x48
	private LayoutuGUITweenAnimBehaviour[] m_layoutuGUITweenAnimBehaviourList; //Field offset: 0x4C
	private Transform m_transform; //Field offset: 0x50
	[CompilerGenerated]
	private int <Priority>k__BackingField; //Field offset: 0x54
	private bool m_IsReady; //Field offset: 0x58

	public static float CommonTimeScale
	{
		 get { } //Length: 60
		 set { } //Length: 71
	}

	public Font[] Font
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public TMP_FontAsset[] FontAsset
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public FontLayerData[] FontDataLayer
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public override GameObject GetObject
	{
		 get { } //Length: 16
	}

	public static bool IsAlwaysUpdateSRT
	{
		 get { } //Length: 61
		 set { } //Length: 80
	}

	public bool IsDependenceTexture
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private bool IsExistAnchorObject
	{
		private get { } //Length: 294
	}

	public bool IsHM
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public private bool IsReady
	{
		 get { } //Length: 11
		private set { } //Length: 14
	}

	public bool IsUpdate
	{
		 get { } //Length: 96
		 set { } //Length: 272
	}

	public bool IsUseImage
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public Layout Layout
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public ScriptableLayout LayoutAsset
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public override int Priority
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public String[] TextureNameList
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public float TimeScale
	{
		 get { } //Length: 11
		 set { } //Length: 18
	}

	public TexUVListManager[] UvManList
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	private static LayoutUGUIRuntime() { }

	public LayoutUGUIRuntime() { }

	public void AddFont(Font font) { }

	public void AddFontAsset(TMP_FontAsset font) { }

	private void Awake() { }

	[IteratorStateMachine(typeof(<Co_Initialize>d__66))]
	public IEnumerator Co_Initialize() { }

	public TextureSet[] CollectUseTextureSet(TexUVFilePack[] packList) { }

	private void ConnectUguiInfo(AbsoluteLayout rootLayout, Transform rootTrans) { }

	private int ConnectUguiInfoInner(AbsoluteLayout rootLayout, Transform rootTrans, int vw = 0) { }

	public bool ContainsFont(Font font) { }

	public bool ContainsFontAsset(TMP_FontAsset font) { }

	public TexUVListManager CreateCustomUvManager(TexUVListManager[] uvManList) { }

	public void DeleteFont() { }

	public void DeleteTexture() { }

	public static float get_CommonTimeScale() { }

	public Font[] get_Font() { }

	public TMP_FontAsset[] get_FontAsset() { }

	public FontLayerData[] get_FontDataLayer() { }

	public override GameObject get_GetObject() { }

	public static bool get_IsAlwaysUpdateSRT() { }

	public bool get_IsDependenceTexture() { }

	private bool get_IsExistAnchorObject() { }

	public bool get_IsHM() { }

	public bool get_IsReady() { }

	public bool get_IsUpdate() { }

	public bool get_IsUseImage() { }

	public Layout get_Layout() { }

	public ScriptableLayout get_LayoutAsset() { }

	[CompilerGenerated]
	public override int get_Priority() { }

	public String[] get_TextureNameList() { }

	public float get_TimeScale() { }

	public TexUVListManager[] get_UvManList() { }

	public void InitChgSliceData(List<TexUVFilePack> texUVFilePacks) { }

	public void Initialize(TexUVListManager[] uvManList) { }

	public void Initialize() { }

	public void InitializeTexUvListManager(TexUVListManager[] uvManList) { }

	public void InitTweenAnime() { }

	public void PasteFont(List<Font> fontList, bool isRewrite = false) { }

	public void PasteFontAsset(List<TMP_FontAsset> fontList, bool isRewrite = false) { }

	public void PasteTexture(TextureSet[] texList) { }

	public void ResetUguiInfo() { }

	public static void set_CommonTimeScale(float value) { }

	public void set_Font(Font[] value) { }

	public void set_FontAsset(TMP_FontAsset[] value) { }

	public void set_FontDataLayer(FontLayerData[] value) { }

	public static void set_IsAlwaysUpdateSRT(bool value) { }

	public void set_IsDependenceTexture(bool value) { }

	public void set_IsHM(bool value) { }

	private void set_IsReady(bool value) { }

	public void set_IsUpdate(bool value) { }

	public void set_IsUseImage(bool value) { }

	public void set_Layout(Layout value) { }

	public void set_LayoutAsset(ScriptableLayout value) { }

	[CompilerGenerated]
	public override void set_Priority(int value) { }

	public void set_TextureNameList(String[] value) { }

	public void set_TimeScale(float value) { }

	public void set_UvManList(TexUVListManager[] value) { }

	public void SetActiveChildren(bool active) { }

	public void SetUseSpriteMesh(bool flg) { }

	private void Update() { }

	public void UpdateAnimation(float dt) { }

	private void UpdateIdle() { }

	public void UpdateTextureInfo() { }

	private void UpdateUgui() { }

}

