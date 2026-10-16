namespace Heqet;

public class ViewMusicInfoLayer : LayerBase
{
	internal enum TYPE
	{
		KAGURA = 0,
		DANMAKU = 1,
		RESULT = 2,
		STORY_KAGURA = 3,
		STORY_DANMAKU = 4,
		NONE = 1,
	}

	[CompilerGenerated]
	private TYPE <LayerType>k__BackingField; //Field offset: 0x58
	private ViewMusicInfoDispBase m_ViewMusicInfoDisp; //Field offset: 0x5C
	[CompilerGenerated]
	private Action<SetupParam> <SetupViewData>k__BackingField; //Field offset: 0x60

	public virtual bool IS_DISP_BACKGROUND
	{
		 get { } //Length: 3
	}

	public virtual bool IS_TOUCH_BACKGROUND
	{
		 get { } //Length: 3
	}

	public virtual bool IS_UPDATE_BACKGROUND
	{
		 get { } //Length: 3
	}

	public private TYPE LayerType
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public private Action<SetupParam> SetupViewData
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public ViewMusicInfoLayer() { }

	protected virtual bool EndUpdateAfter() { }

	public void Entry() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	[CompilerGenerated]
	private TYPE get_LayerType() { }

	[CompilerGenerated]
	public Action<SetupParam> get_SetupViewData() { }

	protected virtual void InitAll() { }

	protected virtual bool InitResourceWait() { }

	protected virtual bool InitSubResourceWait() { }

	protected virtual bool InitUpdateBefore() { }

	protected virtual void LateUpdate(bool is_active) { }

	public virtual void OverDeleteLayer() { }

	protected virtual bool ReleaseLayer() { }

	[CompilerGenerated]
	public void set_LayerType(TYPE value) { }

	[CompilerGenerated]
	private void set_SetupViewData(Action<SetupParam> value) { }

	public void SetAsLastSibling() { }

	protected virtual void Update(bool is_active) { }

}

