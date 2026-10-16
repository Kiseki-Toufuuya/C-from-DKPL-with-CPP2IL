namespace Heqet;

public class HeroineDisp : UiScrollListPanelBase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public HeroineDisp <>4__this; //Field offset: 0x8
		public int heroineId; //Field offset: 0xC

		public <>c__DisplayClass23_0() { }

		internal void <SetHeroineIcon>b__0(AssetBundleLoadAssetOperation operation) { }

	}

	private enum eButtonId
	{
		BodyBtn = 0,
		Max = 1,
	}

	private enum eImageId
	{
		CardImage = 0,
		SelectFrame = 1,
		Equip = 2,
		Disable = 3,
		Max = 4,
	}

	private enum eTextId
	{
		Max = 0,
	}

	private static readonly String[] m_TextList; //Field offset: 0x0
	private FormationHeroineLayer m_Layer; //Field offset: 0x130
	private String[] m_ButtonDataList; //Field offset: 0x134
	private String[] m_ImageList; //Field offset: 0x138
	private RawImageEx m_HeroineImage; //Field offset: 0x13C
	private AtlasImage m_EquipIcon; //Field offset: 0x140
	private AtlasImage m_SelectFrame; //Field offset: 0x144
	private int m_disp_index; //Field offset: 0x148
	private int m_lastLoadHeroienId; //Field offset: 0x14C
	private Color disableColor; //Field offset: 0x150
	private readonly int DEFAULT_SKIN_ID; //Field offset: 0x160

	private static HeroineDisp() { }

	public HeroineDisp() { }

	public void CallbackButton(int button_id) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	public virtual Vector2 GetPanelSize() { }

	public GameObject GetSelectableObject() { }

	protected virtual void InitUguiOther() { }

	public virtual void SetData(int list_index, bool active) { }

	private void SetHeroineIcon(int heroineId) { }

	public void VisibleEquipIcon(bool visible) { }

	public void VisibleSelectFrame(bool select) { }

}

