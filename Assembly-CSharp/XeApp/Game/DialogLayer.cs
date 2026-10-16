namespace XeApp.Game;

public class DialogLayer : UiScrollListLayerBase
{
	private enum DialogState
	{
		Init = 0,
		Wait = 1,
		Close = 2,
		End = 3,
	}

	public DialogLayout m_Layout; //Field offset: 0x7C
	public DialogChildObject m_SubLayout; //Field offset: 0x80
	public DialogItemResult m_ItemFrame; //Field offset: 0x84
	public CardLimitUpPanelItemDisp m_ItemIcon; //Field offset: 0x88
	public CharacterListIconHeroinePanel m_HeroineIcon; //Field offset: 0x8C
	public GenericItemIconPanel m_GenItemIcon; //Field offset: 0x90
	public DialogFukidashiObject m_FukiLayout; //Field offset: 0x94
	public List<GenericItemIconPanel> dialogCardIconDispList; //Field offset: 0x98
	public List<DialogItemUseNumDisp> dialogItemUseNumDispList; //Field offset: 0x9C
	public List<TravelItem> dialogTravelitemList; //Field offset: 0xA0
	public DialogCommonItemUse dialogCommonItemUseDisp; //Field offset: 0xA4
	private DialogState State; //Field offset: 0xA8
	private UnionAssetBundleLoadOperation m_AssetBundleOperation; //Field offset: 0xAC
	private sDialogArg DialogArg; //Field offset: 0xB0

	public sDialogArg DialogArgData
	{
		 get { } //Length: 14
		 set { } //Length: 33
	}

	public virtual bool IS_DISP_BACKGROUND
	{
		 get { } //Length: 3
	}

	public virtual bool IS_TOUCH_BACKGROUND
	{
		 get { } //Length: 3
	}

	public virtual bool IS_UPDATE_BACKGROUND
	{
		 get { } //Length: 3
	}

	public virtual eLayerType LAYER_TYPE
	{
		 get { } //Length: 6
	}

	public DialogLayer() { }

	[CompilerGenerated]
	private void <InitResourceWait>b__29_0(DispBase disp) { }

	protected virtual bool AccessAfter() { }

	public CharacterCardSmallIcon AddCardIconDisp(Transform parent) { }

	public CardLimitUpPanelItemDisp AddIconDisp(Transform parent) { }

	public GenericItemIconPanel AddItemIconDisp(Transform parent) { }

	protected virtual UiScrollListPanelBase CreatePanel() { }

	protected virtual bool EndUpdateAfter() { }

	public void ForceClose() { }

	public sDialogArg get_DialogArgData() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	public virtual eLayerType get_LAYER_TYPE() { }

	protected virtual void InitAll() { }

	protected virtual bool InitResourceWait() { }

	protected virtual bool InitUpdateBefore() { }

	public bool IsAnim() { }

	public bool IsWait() { }

	protected virtual void LateUpdate(bool is_active) { }

	public virtual void OverDeleteLayer() { }

	protected virtual bool ReleaseLayer() { }

	public void set_DialogArgData(sDialogArg value) { }

	protected virtual void Update(bool is_active) { }

}

