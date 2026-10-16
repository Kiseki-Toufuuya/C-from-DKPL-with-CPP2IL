namespace XeApp.Game;

public class AdvCardMessageOutlineLayer : UiScrollListLayerBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<DispBase> <>9__10_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <InitAll>b__10_0(DispBase disp) { }

	}

	internal enum eStartMesState
	{
		NONE = 0,
		MESSAGE = 1,
		NEWPAGE = 2,
	}

	private readonly int PAGE_LINE_MAX; //Field offset: 0x7C
	private readonly int TEXT_SPEED_DEFAULT; //Field offset: 0x80
	private AdvCardMessageDisp m_MesBaseDisp; //Field offset: 0x84

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

	public AdvCardMessageOutlineLayer() { }

	protected void CreateListView() { }

	protected virtual UiScrollListPanelBase CreatePanel() { }

	protected virtual UiScrollListPanelBase CreateSubLayerPanel(Transform parent) { }

	protected virtual bool EndUpdateAfter() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	public virtual object GetDispData(int index) { }

	public Vector2 GetTextSize(int index) { }

	protected virtual void InitAll() { }

	protected virtual bool InitResourceWait() { }

	protected virtual bool InitUpdateBefore() { }

	protected virtual void LateUpdate(bool is_active) { }

	public virtual void OverDeleteLayer() { }

	protected virtual bool ReleaseLayer() { }

	public void SetDataCallback(int index, bool active) { }

	protected virtual void Update(bool is_active) { }

}

