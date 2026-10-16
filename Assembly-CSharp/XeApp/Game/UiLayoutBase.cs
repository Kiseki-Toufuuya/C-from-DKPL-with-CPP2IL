namespace XeApp.Game;

public class UiLayoutBase : LayoutUGUIScriptBase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass42_0
	{
		public Action<UiButtonBase> act; //Field offset: 0x8
		public UiLayoutBase <>4__this; //Field offset: 0xC
		public int no1; //Field offset: 0x10

		public <>c__DisplayClass42_0() { }

		internal void <SetButtonCallbackOnClick>b__0() { }

	}

	[SerializeField]
	protected List<Text> m_TextList; //Field offset: 0x10
	[SerializeField]
	protected List<Text> m_BtnTextList; //Field offset: 0x14
	[SerializeField]
	protected List<Text> m_BtnTextList2; //Field offset: 0x18
	[SerializeField]
	protected LayoutUGUIScrollSupport m_ScrollSp; //Field offset: 0x1C
	[SerializeField]
	protected List<RawImageEx> m_PasteImageList; //Field offset: 0x20
	[SerializeField]
	protected Int32[] m_PasteTexIndices; //Field offset: 0x24
	[SerializeField]
	protected String[] m_ABTexList; //Field offset: 0x28
	[SerializeField]
	public bool m_HasCacheList; //Field offset: 0x2C
	[SerializeField]
	public RawImageEx[] m_RawImageList; //Field offset: 0x30
	[SerializeField]
	public LayoutUGUIHitOnly[] m_HitOnlyList; //Field offset: 0x34
	[SerializeField]
	private TexUVFilePack[] m_texUVFilePack; //Field offset: 0x38
	[SerializeField]
	private UiButtonBase[] m_ButtonList; //Field offset: 0x3C
	[SerializeField]
	private Animator[] m_AnimatorList; //Field offset: 0x40
	private LayoutUGUIRuntime m_LayoutUGUIRuntime; //Field offset: 0x44
	private Action<UiLayoutBase> m_FuncUpdate; //Field offset: 0x48
	protected Layout m_LayoutData; //Field offset: 0x4C
	protected int m_AnimInSeReq; //Field offset: 0x50
	protected int m_AnimOutSeReq; //Field offset: 0x54
	protected int m_Id; //Field offset: 0x58
	private bool m_AnimOutReq; //Field offset: 0x5C
	private bool m_InitFg; //Field offset: 0x5D

	public String[] ABTexList
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public Layout LayoutData
	{
		 get { } //Length: 11
	}

	public bool LoadTexFg
	{
		 get { } //Length: 72
	}

	public List<RawImageEx> PasteImageList
	{
		 set { } //Length: 27
	}

	public LayoutUGUIScrollSupport ScrollSp
	{
		 get { } //Length: 11
	}

	public LayoutUGUIRuntime uguiRuntime
	{
		 get { } //Length: 11
	}

	public UiLayoutBase() { }

	public bool ChkInitLayout() { }

	public String[] get_ABTexList() { }

	public Layout get_LayoutData() { }

	public bool get_LoadTexFg() { }

	public LayoutUGUIScrollSupport get_ScrollSp() { }

	public LayoutUGUIRuntime get_uguiRuntime() { }

	public UiButtonBase GetButton(string btn_name) { }

	public Text GetText(int textno) { }

	public virtual bool InitializeFromLayout(Layout layout, TexUVListManager[] uvMan) { }

	public bool IsAnimPlayingAll() { }

	private void OnDestroy() { }

	public void ReleaseButton() { }

	public void set_ABTexList(String[] value) { }

	public void set_PasteImageList(List<RawImageEx> value) { }

	public void SetButtonCallback(UiButtonBase button, string tag, Action<String> cb_down, Action<String> cb_up, Func<String, Boolean> cb_enable, Func<String, Boolean> cb_next, float next_rag) { }

	public void SetButtonCallbackLongTap(UiButtonBase button, string tag, float sec, Action<String, Single, Boolean> cb_update, Action<String, Single, Boolean> cb_up = null, Action<String, Single> cb_comp = null) { }

	public void SetButtonCallbackOnClick(UiButtonBase button, Action click, Func<Boolean> chk, Func<Boolean> end_chk) { }

	public void SetButtonCallbackOnClick(Action<UiButtonBase> act) { }

	public void SetButtonCallbackOther(UiButtonBase button, Action<UiButtonBase> init = null, Action<UiButtonBase> down = null, Action<UiButtonBase> update = null) { }

	public void SetCallbackUpdate(Action<UiLayoutBase> callback) { }

	public void SetText(int textno, string textdata) { }

	public void SetTextBestFit(int textno, bool fit, int size_max = 0, int size_min = 0) { }

	public void StartAnim(string anim, string target = null) { }

	private void Update() { }

}

