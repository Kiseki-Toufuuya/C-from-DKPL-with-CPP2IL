namespace XeApp.Game;

public class BackGroundScreenBtnLayer : LayerBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<DispBase> <>9__17_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <InitAll>b__17_0(DispBase dispBase) { }

	}

	public static BackGroundScreenBtnLayer instance; //Field offset: 0x0
	public static readonly int orderId; //Field offset: 0x4
	private BackGroundMaskDisp m_DispBg; //Field offset: 0x58
	private int m_Counter; //Field offset: 0x5C
	private readonly int DefaultCanvasId; //Field offset: 0x60

	public BackGroundMaskDisp BGDisp
	{
		 get { } //Length: 11
	}

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

	private static BackGroundScreenBtnLayer() { }

	public BackGroundScreenBtnLayer() { }

	protected virtual bool EndUpdateAfter() { }

	public BackGroundMaskDisp get_BGDisp() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	protected virtual void InitAll() { }

	protected virtual bool InitResourceWait() { }

	protected virtual bool InitUpdateBefore() { }

	protected virtual void LateUpdate(bool is_active) { }

	public virtual void LauncherTransition() { }

	public virtual void OverDeleteLayer() { }

	protected virtual bool ReleaseLayer() { }

	public void SetActive(bool active) { }

	public void SetCanvas(int canvas_id = -1) { }

	public void SetHitButton(bool enable) { }

	public void StartInAnimation() { }

	public void StartOutAnimation() { }

	protected virtual void Update(bool is_active) { }

}

