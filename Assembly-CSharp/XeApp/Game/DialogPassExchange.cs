namespace XeApp.Game;

public class DialogPassExchange : DialogChildObject
{
	private enum eCommonLayerId
	{
		ITEM_ICON_ROOT = 0,
		ITEM_ICON1_ROOT = 1,
		ITEM_ICON2_ROOT = 2,
		DISABLE_CARD_ICON_ROOT = 3,
		DISABLE_HEROINE_ICON_ROOT = 4,
		DISABLE_OBJECT_ICON_ROOT = 5,
		DISABLE_THEME_ICON_ROOT = 6,
		DISABLE_EMBLEM_ICON_ROOT = 7,
		NUM = 8,
	}

	private enum eTxtLayerId
	{
		TRADE_1 = 0,
		TRADE_2 = 1,
		NUM = 2,
	}

	private sDialogChildArg ChildArg; //Field offset: 0x12C
	private DialogLayer m_Layer; //Field offset: 0x130
	private GenericItemIconPanel m_Item1Disp; //Field offset: 0x134
	private GenericItemIconPanel m_Item2Disp; //Field offset: 0x138
	private DialogPassExchangeData m_DialogData; //Field offset: 0x13C
	private String[] m_CommonLayerList; //Field offset: 0x140
	private String[] m_TxtLayerList; //Field offset: 0x144

	public DialogPassExchange() { }

	public virtual void Create(LayerBase parent_layer) { }

	public void DispUpdate() { }

	protected virtual void InitUguiOther() { }

	public virtual void ReleaseAll() { }

	public void SetIconDisp(GenericItemIconPanel item1, GenericItemIconPanel item2) { }

	private void SetItemDisp(GenericItemIconPanel disp, int itemPrefix, int itemValue, int itemCount) { }

	protected virtual void UpdateDispMain() { }

}

