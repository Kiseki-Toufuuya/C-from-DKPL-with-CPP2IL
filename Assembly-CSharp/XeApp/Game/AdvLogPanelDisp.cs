namespace XeApp.Game;

public class AdvLogPanelDisp : UiScrollListPanelBase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public AdvLogPanelDisp <>4__this; //Field offset: 0x8
		public int index; //Field offset: 0xC

		public <>c__DisplayClass19_0() { }

		internal void <SetData>b__0(AssetBundleLoadAssetOperation ope) { }

	}

	private enum eButtonId
	{
		VOICE = 0,
		NUM = 1,
	}

	private enum eLayerId
	{
		BASE_NUM = 0,
		TEXT_NAME = 0,
		TEXT_MESSAGE = 1,
		TEXT_CONTEXT = 2,
		TEXT_NUM = 3,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private String[2] m_ButtonDataList; //Field offset: 0x130
	private AdvLogWindowLayer m_Layer; //Field offset: 0x134
	private List<GameEventScriptLogInfo> m_LogList; //Field offset: 0x138
	private string m_MessageId; //Field offset: 0x13C
	private Image m_CharaIcon; //Field offset: 0x140
	private GameObject m_NameImage; //Field offset: 0x144
	private AtlasImage m_CharaIconCover; //Field offset: 0x148
	private AtlasImage m_CharaIconFr; //Field offset: 0x14C
	private List<UIWrapperButton> m_ButtonList; //Field offset: 0x150
	private int m_RequestCharaIcon; //Field offset: 0x154
	private LoadingIconSubDisp m_LoadingIconDisp; //Field offset: 0x158

	private static AdvLogPanelDisp() { }

	public AdvLogPanelDisp() { }

	public void CallbackButton(int id) { }

	private void CallbackInitLayout() { }

	public bool CallbackInputEnable(int id) { }

	public virtual void Create(LayerBase parent_layer) { }

	public Transform GetLoadingIconRoot() { }

	public virtual Vector2 GetPanelSize() { }

	protected virtual void InitUguiOther() { }

	public bool IsLoadingIconReady() { }

	protected virtual void LateUpdate() { }

	private void LoadCharaIconComplete(int index, Sprite sprite) { }

	public virtual void SetActive(bool active) { }

	public virtual void SetData(int index, bool active) { }

	public void SetLoadingIconDisp(LoadingIconSubDisp loadingIconDisp) { }

	private void ShowLoadingIcon(bool show) { }

	protected virtual void UpdateDispMain() { }

}

