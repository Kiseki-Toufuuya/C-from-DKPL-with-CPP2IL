namespace Heqet;

public class PanelStoryDisp : UiScrollListPanelBase
{
	private enum eButtonId
	{
		BodyBtn = 0,
		Max = 1,
	}

	private enum eCommonLayerId
	{
		NormalRoot = 0,
		NewMark = 1,
		Max = 2,
	}

	private enum eImageId
	{
		StoryImage = 0,
		ArrowImage = 1,
		WakuImage = 2,
		Max = 3,
	}

	private enum eTextId
	{
		TitleName = 0,
		Max = 1,
	}

	private static readonly String[] m_TextList; //Field offset: 0x0
	private static readonly String[] m_LayerIdList; //Field offset: 0x4
	private GalleryStoryLayer m_Layer; //Field offset: 0x130
	private String[] m_ButtonDataList; //Field offset: 0x134
	private String[] m_ImageList; //Field offset: 0x138
	private RawImageEx m_StoryImage; //Field offset: 0x13C
	private GameObject m_ArrowImage; //Field offset: 0x140
	private GameObject m_WakuImage; //Field offset: 0x144
	private GameObject m_NewMarkObj; //Field offset: 0x148
	private int m_disp_index; //Field offset: 0x14C
	private ListNavigation m_navigation; //Field offset: 0x150
	private EpisodeAssetBunleLoader m_episodeLoader; //Field offset: 0x154

	public GameObject SelectTargetObject
	{
		 get { } //Length: 37
	}

	private static PanelStoryDisp() { }

	public PanelStoryDisp() { }

	[CompilerGenerated]
	private void <InitUguiOther>b__19_0(AxisEventData eventData) { }

	[CompilerGenerated]
	private void <InitUguiOther>b__19_1(AxisEventData eventData) { }

	[CompilerGenerated]
	private void <SetStory>b__27_0(AssetBundleLoadAssetOperation ope) { }

	public void CallbackButton(int button_id) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	public GameObject get_SelectTargetObject() { }

	public virtual Vector2 GetPanelSize() { }

	protected virtual void InitUguiOther() { }

	public virtual void ReleaseAll() { }

	public void SetArrowActive(bool flg) { }

	public virtual void SetData(int list_index, bool active) { }

	public void SetNewMarkAction(bool flg) { }

	private void SetStory(int storyId) { }

}

