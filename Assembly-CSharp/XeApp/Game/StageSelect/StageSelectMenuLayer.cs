namespace XeApp.Game.StageSelect;

public class StageSelectMenuLayer : LayerBase
{
	[CompilerGenerated]
	private StageSelectManager <StageSelectManager>k__BackingField; //Field offset: 0x58

	public virtual bool IS_DISP_BACKGROUND
	{
		 get { } //Length: 47
	}

	public virtual bool IS_TOUCH_BACKGROUND
	{
		 get { } //Length: 47
	}

	public virtual bool IS_UPDATE_BACKGROUND
	{
		 get { } //Length: 47
	}

	public StageSelectManager StageSelectManager
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public StageSelectMenuLayer() { }

	public void CreateInit(int a) { }

	protected virtual bool EndUpdateAfter() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	[CompilerGenerated]
	public StageSelectManager get_StageSelectManager() { }

	protected virtual void InitAll() { }

	protected virtual bool InitUpdateBefore() { }

	protected virtual void LateUpdate(bool is_active) { }

	public virtual void OverDeleteLayer() { }

	protected virtual bool ReleaseLayer() { }

	[CompilerGenerated]
	public void set_StageSelectManager(StageSelectManager value) { }

	protected virtual void Update(bool is_active) { }

}

