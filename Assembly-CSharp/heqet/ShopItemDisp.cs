namespace Heqet;

public class ShopItemDisp : UiScrollListPanelBase
{
	private enum eButtonId
	{
		BodyBtn = 0,
		Max = 1,
	}

	private enum eImageId
	{
		OffFrame = 0,
		OnFrame = 1,
		CategoryMitama = 2,
		CategoryEmblem = 3,
		Max = 4,
	}

	private enum eTextId
	{
		ItemName = 0,
		CharacterName = 1,
		CategoryName = 2,
		Price = 3,
		Max = 4,
	}

	private static readonly String[] m_TextList; //Field offset: 0x0
	private ShopLayer m_Layer; //Field offset: 0x130
	private String[] m_ButtonDataList; //Field offset: 0x134
	private String[] m_ImageList; //Field offset: 0x138
	private AtlasImage m_OffFrame; //Field offset: 0x13C
	private AtlasImage m_OnFrame; //Field offset: 0x140
	private TextMeshProUGUI m_CategoryName; //Field offset: 0x144
	private TextMeshProUGUI m_ItemName; //Field offset: 0x148
	private TextMeshProUGUI m_CharacterName; //Field offset: 0x14C
	private TextMeshProUGUI m_Price; //Field offset: 0x150
	private Tween m_Tween; //Field offset: 0x154
	private int m_disp_index; //Field offset: 0x158
	private readonly int DEFAULT_SKIN_ID; //Field offset: 0x15C

	private static ShopItemDisp() { }

	public ShopItemDisp() { }

	public void CallbackButton(int button_id) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	public virtual Vector2 GetPanelSize() { }

	protected virtual void InitUguiOther() { }

	public void RefreshDisp() { }

	private void SetBodyColor(Color color) { }

	public virtual void SetData(int list_index, bool active) { }

	public void ShakeAnimation() { }

	public void VisibleSelectFrame(bool select) { }

}

