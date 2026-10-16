namespace Heqet;

public class PanelHeroineDisp : UiScrollListPanelBase
{
	private enum eButtonId
	{
		BodyBtn = 0,
		Max = 1,
	}

	private enum eCommonLayerId
	{
		NormalRoot = 0,
		ImageRoot = 1,
		HexaDeactiveRoot = 2,
		NewMark = 3,
		FavoriteIcon = 4,
		Max = 5,
	}

	private enum eImageId
	{
		HeroineImage = 0,
		ArrowImage = 1,
		DisableRoot = 2,
		Max = 3,
	}

	private enum eTextId
	{
		Number = 0,
		Max = 1,
	}

	private static readonly String[] m_TextList; //Field offset: 0x0
	private static readonly String[] m_LayerIdList; //Field offset: 0x4
	private GalleryHeroineLayer m_Layer; //Field offset: 0x130
	private String[] m_ButtonDataList; //Field offset: 0x134
	private String[] m_ImageList; //Field offset: 0x138
	private RawImageEx m_HeroineImage; //Field offset: 0x13C
	private GameObject m_ArrowImage; //Field offset: 0x140
	private GameObject m_DisableImage; //Field offset: 0x144
	private GameObject m_NewMarkObj; //Field offset: 0x148
	private GameObject m_FavoriteIcon; //Field offset: 0x14C
	private int m_disp_index; //Field offset: 0x150
	private ListNavigation m_navigation; //Field offset: 0x154
	private CharacterAssetBunleLoader m_HeroineImageLoader; //Field offset: 0x158
	private readonly int DEFAULT_SKIN_ID; //Field offset: 0x15C

	public GameObject SelectTargetObject
	{
		 get { } //Length: 37
	}

	private static PanelHeroineDisp() { }

	public PanelHeroineDisp() { }

	[CompilerGenerated]
	private void <InitUguiOther>b__21_0(AxisEventData eventData) { }

	[CompilerGenerated]
	private void <InitUguiOther>b__21_1(AxisEventData eventData) { }

	[CompilerGenerated]
	private void <SetHeroine>b__30_0(AssetBundleLoadAssetOperation ope) { }

	public void CallbackButton(int button_id) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	public GameObject get_SelectTargetObject() { }

	public virtual Vector2 GetPanelSize() { }

	protected virtual void InitUguiOther() { }

	public virtual void ReleaseAll() { }

	public void SetArrowActive(bool flg) { }

	public virtual void SetData(int list_index, bool active) { }

	public void SetFavoriteIcon(bool flg) { }

	private void SetHeroine(int heroineId) { }

	public void SetNewMarkAction(bool flg) { }

}

