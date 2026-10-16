namespace XeApp.Game.Transition;

public class TransitionLayer : LayerBase
{
	internal enum STATE
	{
		NONE = 0,
		DISP_START = 1,
		DISP_WAIT = 2,
		WAIT = 3,
		DISP_END = 4,
		END_WAIT = 5,
		END = 6,
	}

	public static TransitionLayer instance; //Field offset: 0x0
	public static readonly int orderId; //Field offset: 0x4
	private STATE MainState; //Field offset: 0x58
	private STATE MainStateReq; //Field offset: 0x5C
	private ConnectingDisp m_ConnectingDisp; //Field offset: 0x60
	private DownloadingDisp m_DownloadingDisp; //Field offset: 0x64
	private LoadingDisp m_LoadingDisp; //Field offset: 0x68
	public bool m_IsConnectingDisp; //Field offset: 0x6C
	public bool m_IsDownloadingDisp; //Field offset: 0x6D
	public bool m_IsLoadingDisp; //Field offset: 0x6E
	public bool m_IsDisableTouchUpdate; //Field offset: 0x6F

	public virtual bool IS_DISP_BACKGROUND
	{
		 get { } //Length: 3
	}

	public virtual bool IS_STATIC_LAYER
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

	private static TransitionLayer() { }

	public TransitionLayer() { }

	protected virtual bool AccessBefore() { }

	public void EndConnecting() { }

	public void EndDownloading() { }

	public void EndLoading() { }

	protected virtual bool EndUpdateAfter() { }

	public void ForceEnd() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_STATIC_LAYER() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	protected virtual void InitAll() { }

	protected virtual bool InitResourceWait() { }

	protected virtual bool InitUpdateBefore() { }

	public bool IsDisp() { }

	public bool IsEnd() { }

	private bool IsProgressEnd() { }

	protected virtual void LateUpdate(bool is_active) { }

	public virtual void OverDeleteLayer() { }

	protected virtual bool ReleaseLayer() { }

	public void SetDispConnecting(bool isDisp) { }

	public void SetDownloadProcessing(float rate) { }

	public void StartConnecting() { }

	public void StartDownloading() { }

	public void StartLoading() { }

	public void TransitionDisable() { }

	public void TransitionEnable() { }

	protected virtual void Update(bool is_active) { }

	private void UpdateCommon() { }

}

