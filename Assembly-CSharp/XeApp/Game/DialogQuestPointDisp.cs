namespace XeApp.Game;

public class DialogQuestPointDisp : DialogChildObject
{
	private enum eCheckStep
	{
		None = 0,
		AnimationWait = 1,
	}

	private enum eLayerId
	{
		BASE_NUM = 0,
		IMG_BASE = 0,
		IMG_NUM = 0,
		TEXT_BASE = 0,
		TEXT_CONTEXT = 0,
		TEXT_CAUTION = 1,
		TEXT_QUEST_POINT = 2,
		TEXT_QUEST_POINT_HD = 3,
		TEXT_NUM = 4,
	}

	internal class InOutParam
	{
		public int QuestItemId; //Field offset: 0x8
		public int QuestPoint; //Field offset: 0xC
		public int QuestPointMax; //Field offset: 0x10

		public InOutParam() { }

	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private sDialogChildArg ChildArg; //Field offset: 0x12C
	private DialogLayer m_Layer; //Field offset: 0x130
	private InOutParam m_InOutParam; //Field offset: 0x134
	private eCheckStep m_CheckStep; //Field offset: 0x138
	private int m_ItemId; //Field offset: 0x13C
	private RawImageEx m_ItemIcon; //Field offset: 0x140
	private bool m_IsIconLoaded; //Field offset: 0x144

	private static DialogQuestPointDisp() { }

	public DialogQuestPointDisp() { }

	public virtual void Create(LayerBase parent_layer) { }

	public virtual void InitLoadAfter() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	public virtual void ReleaseAll() { }

	private void UnloadItemIcon(int itemId) { }

	protected virtual void UpdateDispMain() { }

}

