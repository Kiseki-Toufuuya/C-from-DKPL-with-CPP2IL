namespace XeApp.Game;

public abstract class UiScrollListPanelBase : DispBase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_0
	{
		public UiScrollListPanelBase <>4__this; //Field offset: 0x8
		public string path; //Field offset: 0xC
		public Action<AssetBundleLoadAssetOperation> load_end; //Field offset: 0x10

		public <>c__DisplayClass38_0() { }

		internal void <GetIconSprite>b__0(AssetBundleLoadAssetOperation ope) { }

	}

	protected int m_nIndex; //Field offset: 0x114
	protected RectTransform m_transform; //Field offset: 0x118
	private bool m_bTap; //Field offset: 0x11C
	private bool m_bLongTap; //Field offset: 0x11D
	private UiScrollListLayerBase m_ScrollLayer; //Field offset: 0x120
	protected bool m_bDispActive; //Field offset: 0x124
	private bool m_bSeEnable; //Field offset: 0x125
	protected Dictionary<String, Sprite> m_SpriteList; //Field offset: 0x128
	protected Dictionary<String, Boolean> m_SpriteLoadedList; //Field offset: 0x12C

	protected UiScrollListPanelBase() { }

	protected virtual void CallbackAnimInComp() { }

	public override void ChangePanelSE(ALL_SE btn_se) { }

	public virtual void Create(LayerBase parent) { }

	protected Sprite GetIconSprite(string path, Action<AssetBundleLoadAssetOperation> load_end) { }

	public int GetIndex() { }

	public object GetLayerDispData(int index = -1) { }

	public RectTransform GetObjectTransform() { }

	public abstract Vector2 GetPanelSize() { }

	public override Vector2 GetPanelSizeByIndex(int index) { }

	public override object GetUniqueData() { }

	public override void HideNoUsedPanel() { }

	protected virtual void InitUguiOther() { }

	public bool IsDragTouchCheck() { }

	public override bool IsInit() { }

	public bool IsLayerLoadEnableFlag() { }

	public int IsLongSelect() { }

	public bool IsPanelActive() { }

	public bool IsScrollLayer() { }

	public int IsSelect() { }

	protected virtual void LateUpdate() { }

	public void LayerLoadReq() { }

	public void LongTapActive() { }

	public bool LongTapNoticeLayer(int btn_id) { }

	public virtual void ReleaseAll() { }

	public override void SetActive(bool active) { }

	public void SetContents(RectTransform parent) { }

	public override void SetData(int index, bool active) { }

	public void TapActive() { }

	public bool TapEnableNoticeLayer(int btn_id) { }

	public bool TapNoticeLayer(int btn_id) { }

	protected virtual void UpdateDispMain() { }

}

