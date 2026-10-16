namespace Heqet;

public class StageListItemDisp : UiScrollListPanelBase
{
	private enum eButtonId
	{
		Body = 0,
		Max = 1,
	}

	private enum eCommonLayerId
	{
		MissionOnly = 0,
		StageKindKagura = 1,
		StageKindDanmaku = 2,
		Max = 3,
	}

	private enum eImageId
	{
		ClearIcon = 0,
		SelectFrame = 1,
		FavoriteIcon = 2,
		reward_icon_1 = 3,
		reward_icon_2 = 4,
		reward_icon_3 = 5,
		Max = 6,
	}

	private enum eTextId
	{
		SpotName = 0,
		StageDifficultyText = 1,
		Max = 2,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private const string REARD_ON_ICON_SPRITE_NAME = "reward_icon_on"; //Field offset: 0x0
	private const string REARD_OFF_ICON_SPRITE_NAME = "reward_icon_off"; //Field offset: 0x0
	private StageListLayer m_Layer; //Field offset: 0x130
	private String[] m_ButtonDataList; //Field offset: 0x134
	private String[] m_TextList; //Field offset: 0x138
	private String[] m_ImageList; //Field offset: 0x13C
	private UIWrapperButton m_bodyButton; //Field offset: 0x140
	private AtlasImage m_ClearIconImage; //Field offset: 0x144
	private AtlasImage m_FavoriteIconImage; //Field offset: 0x148
	private AtlasImage m_SelectFrameImage; //Field offset: 0x14C
	private AtlasImage[] m_RewardIcons; //Field offset: 0x150
	private GameObject m_KindKagura; //Field offset: 0x154
	private GameObject m_KindDanmaku; //Field offset: 0x158
	private TextMeshProUGUI m_DifficultNumberText; //Field offset: 0x15C
	private int m_StageModelDataId; //Field offset: 0x160

	public UIWrapperButton BodyButton
	{
		 get { } //Length: 14
	}

	public int StageDataId
	{
		 get { } //Length: 14
	}

	private static StageListItemDisp() { }

	public StageListItemDisp() { }

	public void CallbackButton(int button_id) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	public UIWrapperButton get_BodyButton() { }

	public int get_StageDataId() { }

	public virtual Vector2 GetPanelSize() { }

	public GameObject GetSelectableObject() { }

	protected virtual void InitUguiOther() { }

	public virtual void SetData(int list_index, bool active) { }

	public void UpdateDisp(WorldStageModel stageModel) { }

	public void VisibleSelectFrame(bool isVisible) { }

}

