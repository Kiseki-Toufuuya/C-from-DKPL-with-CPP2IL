namespace Heqet;

public class PanelAchievementDisp : UiScrollListPanelBase
{
	private enum eButtonId
	{
		BodyBtn = 0,
		Max = 1,
	}

	private enum eCommonLayerId
	{
		NormalRoot = 0,
		AchieveFrame = 1,
		NewMark = 2,
		Max = 3,
	}

	private enum eImageId
	{
		SelectFrameImage = 0,
		Max = 1,
	}

	private enum eTextId
	{
		AchievementName = 0,
		Max = 1,
	}

	private static readonly String[] m_TextList; //Field offset: 0x0
	private static readonly String[] m_LayerIdList; //Field offset: 0x4
	private GalleryAchievementLayer m_Layer; //Field offset: 0x130
	private String[] m_ButtonDataList; //Field offset: 0x134
	private String[] m_ImageList; //Field offset: 0x138
	private GameObject m_SelectFrameImage; //Field offset: 0x13C
	private GameObject m_NewMarkObj; //Field offset: 0x140
	private GameObject m_BodyObj; //Field offset: 0x144
	private int m_disp_index; //Field offset: 0x148
	private ListNavigation m_navigation; //Field offset: 0x14C

	public GameObject SelectTargetObject
	{
		 get { } //Length: 37
	}

	private static PanelAchievementDisp() { }

	public PanelAchievementDisp() { }

	[CompilerGenerated]
	private void <InitUguiOther>b__17_0(AxisEventData eventData) { }

	[CompilerGenerated]
	private void <InitUguiOther>b__17_1(AxisEventData eventData) { }

	public void CallbackButton(int button_id) { }

	private bool CallbackEnableButton(int id) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	public GameObject get_SelectTargetObject() { }

	public virtual Vector2 GetPanelSize() { }

	protected virtual void InitUguiOther() { }

	public void SetArrowActive(bool flg) { }

	public virtual void SetData(int list_index, bool active) { }

	public void SetNewMarkAction(bool flg) { }

}

