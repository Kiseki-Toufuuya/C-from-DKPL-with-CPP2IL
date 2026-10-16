namespace XeApp.Game;

public class GenericItemIconPanel : UiScrollListPanelBase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public GenericItemIconPanel <>4__this; //Field offset: 0x8
		public RawImage tmp_image; //Field offset: 0xC

		public <>c__DisplayClass34_0() { }

		internal void <SetSpotObjectIcon>b__0(AssetBundleLoadAssetOperation operation) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_0
	{
		public GenericItemIconPanel <>4__this; //Field offset: 0x8
		public RawImage tmp_image; //Field offset: 0xC

		public <>c__DisplayClass35_0() { }

		internal void <SetEmblemIcon>b__0(AssetBundleLoadAssetOperation operation) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass36_0
	{
		public GenericItemIconPanel <>4__this; //Field offset: 0x8
		public RawImage tmp_image; //Field offset: 0xC

		public <>c__DisplayClass36_0() { }

		internal void <SetSpotThemeIcon>b__0(AssetBundleLoadAssetOperation operation) { }

	}

	private enum eButtonId
	{
		BTN_SELF = 0,
		NUM = 1,
	}

	private enum eIconTypeId
	{
		NORMAL = 0,
		KAKERA = 1,
		HEROINE = 2,
		SPOT = 3,
		THEME = 4,
	}

	private enum eLayerId
	{
		BASE = 0,
		ITEM_FRAME = 1,
		ITEM_ICON = 2,
		ITEM_KAKERA = 3,
		ITEM_COUNT_BASE = 4,
		ITEM_SHADOW = 5,
		SPOT_ICON = 6,
		BASE_NUM = 7,
		TEXT_ITEM_COUNT = 7,
		TEXT_HUKI = 8,
		TEXT_NUM = 9,
	}

	internal class PanelInfo
	{
		public object Model; //Field offset: 0x8
		public int Count; //Field offset: 0xC
		public bool IsBonusHeroineFlagment; //Field offset: 0x10
		public object SendData; //Field offset: 0x14
		public bool IsForceTouchEnable; //Field offset: 0x18
		public bool IsTouchEnable; //Field offset: 0x19

		public PanelInfo() { }

	}

	private String[] m_LayerIdList; //Field offset: 0x130
	private String[2] m_ButtonDataList; //Field offset: 0x134
	private UnityAction<GenericItemIconPanel> m_ButtonCallback; //Field offset: 0x138
	private UnityAction<GenericItemIconPanel> m_LongTapButtonCallback; //Field offset: 0x13C
	private RawImageEx m_RawImageEx; //Field offset: 0x140
	private eIconTypeId m_IconType; //Field offset: 0x144
	private bool m_isCountView; //Field offset: 0x148
	private bool m_isHukiView; //Field offset: 0x149
	private bool m_HitEnable; //Field offset: 0x14A
	private bool m_buttonEnable; //Field offset: 0x14B
	private GenericItemModel m_detailModel; //Field offset: 0x14C
	private LayerBase m_Layer; //Field offset: 0x150

	public GenericItemModel DetailModel
	{
		 get { } //Length: 14
	}

	public GenericItemIconPanel() { }

	[CompilerGenerated]
	private void <SetItemIcon>b__32_0(AssetBundleLoadAssetOperation operation) { }

	[CompilerGenerated]
	private void <SetItemIcon>b__33_0(AssetBundleLoadAssetOperation operation) { }

	public void CallbackButton(int id) { }

	private void CallbackInitLayout() { }

	public bool CallbackInputEnable(int id) { }

	public void CallbackLongTapComp(int id, float sec) { }

	public virtual void Create(LayerBase parent) { }

	public GenericItemModel get_DetailModel() { }

	public virtual Vector2 GetPanelSize() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	public virtual void ReleaseAll() { }

	public virtual void SetActive(bool active) { }

	public void SetBonusHeroine(bool enable) { }

	public void SetButtonCallback(UnityAction<GenericItemIconPanel> func) { }

	public void SetButtonEnable(bool enable) { }

	public virtual void SetButtonHit(bool flg) { }

	public virtual void SetData(int index, bool active) { }

	private void SetEmblemIcon(int id) { }

	public void SetHuki(bool enable, string message = "") { }

	public void SetItemCount(int itemNum, bool isForceView = false) { }

	public void SetItemCount(string itemNum) { }

	private void SetItemIcon(int id) { }

	public void SetItemIcon(string itemStr, string num = "") { }

	public void SetItemIcon(int itemId, string num = "") { }

	private void SetItemIcon(string str) { }

	public void SetKakeraItemIcon(string num = "") { }

	public void SetLongTapButtonCallback(UnityAction<GenericItemIconPanel> func) { }

	public void SetParam(object a_param) { }

	public void SetParent(Transform parent) { }

	private void SetSpotObjectIcon(int id) { }

	private void SetSpotThemeIcon(int id) { }

	private void SetTouchShdow(bool enable) { }

	public void ShowUi() { }

	protected virtual void UpdateDispMain() { }

}

