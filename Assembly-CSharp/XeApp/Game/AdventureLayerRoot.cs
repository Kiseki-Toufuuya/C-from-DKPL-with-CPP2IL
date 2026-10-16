namespace XeApp.Game;

public class AdventureLayerRoot : LayerBase
{
	private AdventureDisp m_RootDisp; //Field offset: 0x58
	private GameObject CameraObj; //Field offset: 0x5C
	private Camera AdvCamera; //Field offset: 0x60
	private int CanvasNo; //Field offset: 0x64
	private Camera OverCamera; //Field offset: 0x68
	private string OverSortingLayerName; //Field offset: 0x6C
	private Camera TopCamera; //Field offset: 0x70
	private string TopSortingLayerName; //Field offset: 0x74
	private Camera MiddleCamera; //Field offset: 0x78
	private string MiddleSortingLayerName; //Field offset: 0x7C
	private Camera BottomCamera; //Field offset: 0x80
	private string BottomSortingLayerName; //Field offset: 0x84
	private Camera BgCamera; //Field offset: 0x88
	private string BgSortingLayerName; //Field offset: 0x8C

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

	public AdventureLayerRoot() { }

	public void AllDisp(bool active) { }

	protected virtual bool EndUpdateAfter() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	public AdventureDisp GetDisp() { }

	protected virtual void InitAll() { }

	protected virtual bool InitUpdateBefore() { }

	public bool IsFinish() { }

	protected virtual void LateUpdate(bool is_active) { }

	protected virtual void OnSetDisp(bool enable) { }

	protected virtual void OnSetTouch(bool enable) { }

	public virtual void OverDeleteLayer() { }

	protected virtual bool ReleaseLayer() { }

	protected virtual void Update(bool is_active) { }

	protected virtual bool WaitInAnim() { }

}

