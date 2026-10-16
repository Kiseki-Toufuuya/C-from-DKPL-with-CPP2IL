namespace XeApp.Game;

public class HomeLayerRoot : LayerBase, IHomeLayer
{

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

	public HomeLayerRoot() { }

	protected virtual bool EndUpdateAfter() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	public override List<NoticeBase> GetNoticeDispList() { }

	public override HomeViewModel HomeViewModel() { }

	protected virtual void InitAll() { }

	protected virtual bool InitUpdateBefore() { }

	protected virtual void LateUpdate(bool is_active) { }

	public virtual void OverDeleteLayer() { }

	protected virtual bool ReleaseLayer() { }

	public void SetStateFadeIn() { }

	protected virtual void Update(bool is_active) { }

}

