namespace XeApp.Game;

public class AdvLogWindowLayer : UiScrollListLayerBase
{
	internal enum State
	{
		Init = 0,
		Open = 1,
		OpenWait = 2,
		Close = 3,
		CloseWait = 4,
		EndWait = 5,
		End = 6,
		Idle = 7,
	}

	private readonly int LogPanelNum; //Field offset: 0x7C
	private State m_State; //Field offset: 0x80
	private List<GameEventScriptLogInfo> m_LogList; //Field offset: 0x84
	private AdvLogWindowDisp m_DispMain; //Field offset: 0x88
	private List<AdvLogPanelDisp> m_DispPanelList; //Field offset: 0x8C
	private InputActionReference m_keyClose; //Field offset: 0x90

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

	public virtual eLayerType LAYER_TYPE
	{
		 get { } //Length: 3
	}

	public List<GameEventScriptLogInfo> LogList
	{
		 get { } //Length: 14
		 set { } //Length: 33
	}

	public AdvLogWindowLayer() { }

	protected virtual UiScrollListPanelBase CreatePanel() { }

	protected virtual bool EndUpdateAfter() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	public virtual eLayerType get_LAYER_TYPE() { }

	public List<GameEventScriptLogInfo> get_LogList() { }

	public GameObject GetScrollRoot() { }

	protected virtual void InitAll() { }

	protected virtual bool InitResourceWait() { }

	protected virtual bool InitUpdateBefore() { }

	public bool IsEnd() { }

	public bool IsFinish() { }

	protected virtual void LateUpdate(bool is_active) { }

	public virtual void OverDeleteLayer() { }

	protected virtual bool ReleaseLayer() { }

	public void set_LogList(List<GameEventScriptLogInfo> value) { }

	protected virtual void Update(bool is_active) { }

}

