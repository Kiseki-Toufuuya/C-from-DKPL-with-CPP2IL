namespace XeApp.Game.Travel;

public class TravelRootLayer : LayerBase
{
	public static readonly int HEROINE_MAX; //Field offset: 0x0
	public static readonly int SPELLCARD_MAX; //Field offset: 0x4
	public static readonly float FADE_TIME; //Field offset: 0x8

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

	private static TravelRootLayer() { }

	public TravelRootLayer() { }

	protected virtual bool EndUpdateAfter() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	protected virtual void InitAll() { }

	protected virtual bool InitUpdateBefore() { }

	protected virtual void LateUpdate(bool is_active) { }

	public virtual void OverDeleteLayer() { }

	protected virtual bool ReleaseLayer() { }

	public void SetTravelListZoom(float f) { }

	protected virtual void Update(bool is_active) { }

}

