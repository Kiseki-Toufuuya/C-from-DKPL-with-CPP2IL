namespace XeApp.Game;

public class DialogSdSkinExchange : DialogChildObject
{
	private enum eCommonLayerId
	{
		SD_SKIN_ICON_ROOT = 0,
		NUM = 1,
	}

	private enum eTxtLayerId
	{
		TRADE_1 = 0,
		NUM = 1,
	}

	private sDialogChildArg ChildArg; //Field offset: 0x12C
	private DialogLayer m_Layer; //Field offset: 0x130
	private AssetBundleLoadAssetOperation m_Operation; //Field offset: 0x134
	private bool m_IconLoaded; //Field offset: 0x138
	private RawImageEx m_SelectImage; //Field offset: 0x13C
	private int m_ItemPrefix; //Field offset: 0x140
	private int m_ItemValue; //Field offset: 0x144
	private int m_ItemCount; //Field offset: 0x148
	private String[] m_CommonLayerList; //Field offset: 0x14C
	private String[] m_TxtLayerList; //Field offset: 0x150

	public DialogSdSkinExchange() { }

	private void AllIconDisable() { }

	public virtual void Create(LayerBase parent_layer) { }

	public void DispUpdate() { }

	protected virtual void InitUguiOther() { }

	public virtual void ReleaseAll() { }

	private void ReleaseIcon() { }

	private void SetItemImage() { }

	protected virtual void UpdateDispMain() { }

}

