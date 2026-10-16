namespace Heqet;

public class PanelHelpDisp : UiScrollListPanelBase
{
	private enum eButtonId
	{
		BodyBtn = 0,
		Max = 1,
	}

	private enum eCommonLayerId
	{
		NormalRoot = 0,
		Max = 1,
	}

	private enum eImageId
	{
		ArrowImage = 0,
		SelectPanelImage = 1,
		Max = 2,
	}

	private enum eTextId
	{
		HelpName = 0,
		Max = 1,
	}

	private static readonly String[] m_TextList; //Field offset: 0x0
	private static readonly String[] m_LayerIdList; //Field offset: 0x4
	private GalleryHelpLayer m_Layer; //Field offset: 0x130
	private String[] m_ButtonDataList; //Field offset: 0x134
	private String[] m_ImageList; //Field offset: 0x138
	private GameObject m_ArrowImage; //Field offset: 0x13C
	private GameObject m_SelectPanelImage; //Field offset: 0x140
	private RawImageEx m_HelpImage; //Field offset: 0x144
	private int m_disp_index; //Field offset: 0x148
	private int m_lastLoadHelpId; //Field offset: 0x14C
	private ListNavigation m_navigation; //Field offset: 0x150

	public GameObject SelectTargetObject
	{
		 get { } //Length: 37
	}

	private static PanelHelpDisp() { }

	public PanelHelpDisp() { }

	[CompilerGenerated]
	private void <InitUguiOther>b__18_0(AxisEventData eventData) { }

	[CompilerGenerated]
	private void <InitUguiOther>b__18_1(AxisEventData eventData) { }

	public void CallbackButton(int button_id) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	public GameObject get_SelectTargetObject() { }

	public virtual Vector2 GetPanelSize() { }

	protected virtual void InitUguiOther() { }

	public void SetArrowActive(bool flg) { }

	public virtual void SetData(int list_index, bool active) { }

}

