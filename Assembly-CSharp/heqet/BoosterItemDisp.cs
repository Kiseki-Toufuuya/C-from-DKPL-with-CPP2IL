namespace Heqet;

public class BoosterItemDisp : UiScrollListPanelBase
{
	private enum eButtonId
	{
		BodyBtn = 0,
		Max = 1,
	}

	private enum eImageId
	{
		EnableIcon = 0,
		ItemImage = 1,
		Max = 2,
	}

	private enum eTextId
	{
		Price = 0,
		ItemName = 1,
		Max = 2,
	}

	private static readonly String[] m_TextList; //Field offset: 0x0
	private BoosterSelectLayer m_Layer; //Field offset: 0x130
	private String[] m_ButtonDataList; //Field offset: 0x134
	private String[] m_ImageList; //Field offset: 0x138
	private String[] m_ItemNameLabels; //Field offset: 0x13C
	private AtlasImage m_enableIcon; //Field offset: 0x140
	private ImageEx m_itemImage; //Field offset: 0x144
	private TextMeshProUGUI m_Price; //Field offset: 0x148
	private TextMeshProUGUI m_ItemName; //Field offset: 0x14C
	private int m_disp_index; //Field offset: 0x150
	private readonly int DEFAULT_SKIN_ID; //Field offset: 0x154

	private static BoosterItemDisp() { }

	public BoosterItemDisp() { }

	[CompilerGenerated]
	private void <RefreshDisp>b__20_0(AssetBundleLoadAssetOperation asset) { }

	public void CallbackButton(int button_id) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	public virtual Vector2 GetPanelSize() { }

	public GameObject GetSelectableGameObject() { }

	protected virtual void InitUguiOther() { }

	public void RefreshDisp() { }

	public virtual void ReleaseAll() { }

	public virtual void SetData(int list_index, bool active) { }

	public void SetEnableIcon(bool enable) { }

	public void VisibleSelectFrame(bool select) { }

}

