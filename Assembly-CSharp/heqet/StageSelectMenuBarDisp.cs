namespace Heqet;

public class StageSelectMenuBarDisp : DispBase
{
	private enum eBtnLayerId
	{
		TITLE = 0,
		STORY = 1,
		GALLERY = 2,
		MITAMA = 3,
		HEROINE = 4,
		OPTION = 5,
		BACK = 6,
	}

	private enum eCommonLayerId
	{
		SCENE_ANIM_ROOT = 0,
	}

	private enum eTxtLayerId
	{
		TITLE_LABEL = 0,
		STORY_LABEL = 1,
		GALLERY_LABEL = 2,
		MITAMA_LABEL = 3,
		HEROINE_LABEL = 4,
		OPTION_LABEL = 5,
	}

	[CompilerGenerated]
	private Action <OnClickGalleryCallback>k__BackingField; //Field offset: 0x114
	[CompilerGenerated]
	private Action <OnClickOptionCallback>k__BackingField; //Field offset: 0x118
	[CompilerGenerated]
	private Action <OnClickTitleCallback>k__BackingField; //Field offset: 0x11C
	[CompilerGenerated]
	private Action <OnClickStoryCallback>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	private Action <OnClickMitamaCallback>k__BackingField; //Field offset: 0x124
	[CompilerGenerated]
	private Action <OnClickHeroineCallback>k__BackingField; //Field offset: 0x128
	[CompilerGenerated]
	private Action <OnClickCancelCallback>k__BackingField; //Field offset: 0x12C
	private GameObject m_FirstTargetObject; //Field offset: 0x130
	private String[] m_CommonLayerList; //Field offset: 0x134
	private String[] m_TxtLayerList; //Field offset: 0x138
	private String[] m_BtnLayerList; //Field offset: 0x13C
	public SceneInOutAnimation m_SceneInOutAnimator; //Field offset: 0x140

	public private Action OnClickCancelCallback
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public private Action OnClickGalleryCallback
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public private Action OnClickHeroineCallback
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public private Action OnClickMitamaCallback
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public private Action OnClickOptionCallback
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public private Action OnClickStoryCallback
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public private Action OnClickTitleCallback
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public StageSelectMenuBarDisp() { }

	private void CallbackInitLayout() { }

	public void Close() { }

	public virtual void Create(LayerBase parent) { }

	[CompilerGenerated]
	private Action get_OnClickCancelCallback() { }

	[CompilerGenerated]
	private Action get_OnClickGalleryCallback() { }

	[CompilerGenerated]
	private Action get_OnClickHeroineCallback() { }

	[CompilerGenerated]
	private Action get_OnClickMitamaCallback() { }

	[CompilerGenerated]
	private Action get_OnClickOptionCallback() { }

	[CompilerGenerated]
	private Action get_OnClickStoryCallback() { }

	[CompilerGenerated]
	private Action get_OnClickTitleCallback() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	private void OnClickButton(int buttonId) { }

	public void Open() { }

	[CompilerGenerated]
	public void set_OnClickCancelCallback(Action value) { }

	[CompilerGenerated]
	public void set_OnClickGalleryCallback(Action value) { }

	[CompilerGenerated]
	public void set_OnClickHeroineCallback(Action value) { }

	[CompilerGenerated]
	public void set_OnClickMitamaCallback(Action value) { }

	[CompilerGenerated]
	public void set_OnClickOptionCallback(Action value) { }

	[CompilerGenerated]
	public void set_OnClickStoryCallback(Action value) { }

	[CompilerGenerated]
	public void set_OnClickTitleCallback(Action value) { }

	public void UpdateButtonHit(bool _enable) { }

	protected virtual void UpdateDispMain() { }

}

