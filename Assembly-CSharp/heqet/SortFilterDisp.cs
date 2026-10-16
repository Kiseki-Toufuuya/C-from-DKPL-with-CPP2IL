namespace Heqet;

public class SortFilterDisp : DispBase
{
	private enum eBtnLayerId
	{
		FILTER = 0,
		SORT = 1,
	}

	private enum eCommonLayerId
	{
		SCENE_ANIM_ROOT = 0,
	}

	private enum eTxtLayerId
	{
		FILTER = 0,
		SORT = 1,
	}

	private String[] m_CommonLayerList; //Field offset: 0x114
	private String[] m_TxtLayerList; //Field offset: 0x118
	private String[] m_BtnLayerList; //Field offset: 0x11C
	[CompilerGenerated]
	private Action <OnClickSortCallback>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	private Action <OnClickFilterCallback>k__BackingField; //Field offset: 0x124
	public SceneInOutAnimation m_SceneInOutAnimator; //Field offset: 0x128
	[CompilerGenerated]
	private Func<StageSelectManager2> <GetStageSelectManager>k__BackingField; //Field offset: 0x12C

	public private Func<StageSelectManager2> GetStageSelectManager
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public private Action OnClickFilterCallback
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public private Action OnClickSortCallback
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	private StageSelectManager2 StageSelectManager
	{
		private get { } //Length: 37
	}

	public SortFilterDisp() { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent) { }

	public void DispUpdate() { }

	[CompilerGenerated]
	private Func<StageSelectManager2> get_GetStageSelectManager() { }

	[CompilerGenerated]
	private Action get_OnClickFilterCallback() { }

	[CompilerGenerated]
	private Action get_OnClickSortCallback() { }

	private StageSelectManager2 get_StageSelectManager() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	private void OnClickButtonRelation(int buttonId) { }

	[CompilerGenerated]
	public void set_GetStageSelectManager(Func<StageSelectManager2> value) { }

	[CompilerGenerated]
	public void set_OnClickFilterCallback(Action value) { }

	[CompilerGenerated]
	public void set_OnClickSortCallback(Action value) { }

	public void SetFilter() { }

	public void SetSort() { }

	public void UpdateButtonHit(bool _enable) { }

	protected virtual void UpdateDispMain() { }

}

