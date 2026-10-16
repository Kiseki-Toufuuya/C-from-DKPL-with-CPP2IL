namespace XeSys.Gfx;

public class LayoutUGUIExporter : ScriptableObject
{
	internal class Setting
	{
		public TexUVFilePack[] TexUVFilePackList; //Field offset: 0x8
		public Font[] Font; //Field offset: 0xC
		public bool IsUseImage; //Field offset: 0x10
		public Layout Layout; //Field offset: 0x14
		public TexUVListManager UvMan; //Field offset: 0x18

		public Setting() { }

	}

	private static Regex s_hitCheckRegex; //Field offset: 0x0
	[SerializeField]
	private GameObject m_prefabCanvas; //Field offset: 0xC
	[SerializeField]
	private GameObject m_prefabButton; //Field offset: 0x10
	[SerializeField]
	private GameObject m_prefabImage; //Field offset: 0x14
	[SerializeField]
	private GameObject m_prefabRawImage; //Field offset: 0x18
	[SerializeField]
	private GameObject m_prefabText; //Field offset: 0x1C
	[SerializeField]
	private GameObject m_prefabInputText; //Field offset: 0x20
	[SerializeField]
	private GameObject m_prefabPanel; //Field offset: 0x24
	[SerializeField]
	private GameObject m_prefabScroll; //Field offset: 0x28
	[SerializeField]
	private GameObject m_prefabInfiniteScroll; //Field offset: 0x2C
	[SerializeField]
	private GameObject m_prefabImageScrollBarV; //Field offset: 0x30
	[SerializeField]
	private GameObject m_prefabRawImageScrollBarV; //Field offset: 0x34
	[SerializeField]
	private GameObject m_prefabImageScrollBarH; //Field offset: 0x38
	[SerializeField]
	private GameObject m_prefabRawImageScrollBarH; //Field offset: 0x3C
	[SerializeField]
	private GameObject m_prefabMask; //Field offset: 0x40
	private GameObject m_prefabScrollBarV; //Field offset: 0x44
	private GameObject m_prefabScrollBarH; //Field offset: 0x48
	private Layout m_layout; //Field offset: 0x4C
	private TexUVListManager m_uvMan; //Field offset: 0x50
	private int m_level; //Field offset: 0x54
	private Setting m_setting; //Field offset: 0x58
	private List<String> m_textureNameList; //Field offset: 0x5C
	private List<ILayoutUGUIAfterExport> m_afterExportList; //Field offset: 0x60
	private List<Sprite> m_createdSpriteList; //Field offset: 0x64

	private static LayoutUGUIExporter() { }

	public LayoutUGUIExporter() { }

	public static void CopyAnchorSetting(RectTransform src, RectTransform dest) { }

	private RectTransform CreateAnchorObject(RectTransform parent, EAlignH aH, EAlignV aV, Vector2 screenSize) { }

	private static Vector2 GetScreenSize() { }

	private void MakeUGUI(AbsoluteLayout rootLayout, GameObject rootObj, List<RectTransform> anchorList) { }

	private void SetAnchor(RectTransform rt, EAlignH aH, EAlignV aV, Vector2 screenSize) { }

	public static void SetCanvasScaler(CanvasScaler scaler) { }

	private List<RectTransform> SetRootPanel(RectTransform panelRt, AbsoluteLayout rootLayout, Vector2 screenSize) { }

	public LayoutUGUIRuntime Setup(Setting setting) { }

	private void SetupFromLayerName(GameObject obj) { }

	private void SetupImage(GameObject obj, TexUVList texList, TexUVData uvData, string name, bool isRawimage = true) { }

	private void SetupImageButton(GameObject obj, ImageButton view) { }

	private void SetupImageView(GameObject obj, ImageView view) { }

	private void SetupMaskView(GameObject obj, MaskView view) { }

	private Scrollbar SetupScrollBar(RectTransform scrollRt, ScrollView view, ScrollBar scrollBarView, GameObject prefab, Vector2 pos, Vector2 size) { }

	private void SetupScrollBarAccessory(Scrollbar sbar, TexUVList tex, TexUVData uvData, string name) { }

	private void SetupScrollView(GameObject obj, ScrollView view, bool isVertical) { }

	private void SetupTextView(GameObject obj, TextView view) { }

	private LayoutUGUIRuntime SetupUGUI(Setting setting) { }

}

