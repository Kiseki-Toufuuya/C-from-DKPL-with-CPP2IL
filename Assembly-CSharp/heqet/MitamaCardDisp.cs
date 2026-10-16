namespace Heqet;

public class MitamaCardDisp : UiScrollListPanelBase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public MitamaCardDisp <>4__this; //Field offset: 0x8
		public int card_id; //Field offset: 0xC

		public <>c__DisplayClass22_0() { }

		internal void <SetCardIcon>b__0(AssetBundleLoadAssetOperation operation) { }

	}

	private enum eButtonId
	{
		BodyBtn = 0,
		Max = 1,
	}

	private enum eImageId
	{
		CardImage = 0,
		AttributeIcon = 1,
		EquipIcon = 2,
		SelectFrame = 3,
		Max = 4,
	}

	private enum eTextId
	{
		Max = 0,
	}

	private static readonly String[] m_TextList; //Field offset: 0x0
	private FormationMitamaLayer m_Layer; //Field offset: 0x130
	private String[] m_ButtonDataList; //Field offset: 0x134
	private String[] m_ImageList; //Field offset: 0x138
	private RawImageEx m_CardImage; //Field offset: 0x13C
	private AtlasImage m_AttrImage; //Field offset: 0x140
	private AtlasImage m_EquipIcon; //Field offset: 0x144
	private AtlasImage m_SelectFrame; //Field offset: 0x148
	private int m_disp_index; //Field offset: 0x14C
	private int m_lastLoadCardId; //Field offset: 0x150

	private static MitamaCardDisp() { }

	public MitamaCardDisp() { }

	public void CallbackButton(int button_id) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	public virtual Vector2 GetPanelSize() { }

	public GameObject GetSelectableObject() { }

	protected virtual void InitUguiOther() { }

	private void SetCardIcon(int card_id) { }

	public virtual void SetData(int list_index, bool active) { }

	public void VisibleEquipIcon(bool select) { }

	public void VisibleSelectFrame(bool select) { }

}

