namespace XeApp.Game.Transition;

public class DownloadingDisp : DispBase
{
	private enum eButtonId
	{
		BUTTON_BASE = 0,
		BUTTON_NUM = 1,
	}

	private enum eLayerId
	{
		BASE_NUM = 0,
		COMMON_BASE = 0,
		COMMON_ROOT = 0,
		COMMON_NUM = 1,
		IMG_BASE = 1,
		IMG_PROCESS_BAR = 1,
		IMG_NUM = 2,
		TEXT_BASE = 2,
		TEXT_PROCESS = 2,
		TEXT_DOWNLOADING = 3,
		TEXT_NUM = 4,
	}

	internal enum STATE
	{
		NONE = 0,
		IN = 1,
		IN_WAIT = 2,
		WAIT = 3,
		OUT = 4,
		OUT_WAIT = 5,
		END = 6,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private static readonly String[] m_ButtonIdList; //Field offset: 0x4
	private readonly String[] DOWNLOAD_STRING; //Field offset: 0x114
	private STATE MainState; //Field offset: 0x118
	private STATE MainStateReq; //Field offset: 0x11C
	private Animator m_RootAnimator; //Field offset: 0x120
	private TransitionLayer m_ParentLayer; //Field offset: 0x124
	private AtlasImage m_ProcessBar; //Field offset: 0x128
	private float m_DownloadRate; //Field offset: 0x12C
	private float m_DownloadingTime; //Field offset: 0x130
	private bool m_IsDownloading; //Field offset: 0x134

	private static DownloadingDisp() { }

	public DownloadingDisp() { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent) { }

	public void End() { }

	public void ForceEnd() { }

	protected virtual void InitUguiOther() { }

	public bool IsEnd() { }

	protected virtual void LateUpdate() { }

	public virtual void ReleaseAll() { }

	private void SetDownloadingText() { }

	public void SetDownloadProcessing(float rate) { }

	public void Start() { }

	private void UpdateCommon() { }

	protected virtual void UpdateDispMain() { }

}

