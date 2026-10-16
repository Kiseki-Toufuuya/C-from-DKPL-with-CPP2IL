namespace XeApp.Game.Transition;

public class LoadingDisp : DispBase
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
		IMG_NUM = 1,
		TEXT_BASE = 1,
		TEXT_NUM = 1,
	}

	internal enum STATE
	{
		NONE = 0,
		IN = 1,
		IN_WAIT = 2,
		WAIT = 3,
		PRE_OUT = 4,
		PRE_OUT_WAIT = 5,
		OUT = 6,
		OUT_WAIT = 7,
		END = 8,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private static readonly String[] m_ButtonIdList; //Field offset: 0x4
	private STATE MainState; //Field offset: 0x114
	private STATE MainStateReq; //Field offset: 0x118
	private Animator m_RootAnimator; //Field offset: 0x11C
	private TransitionLayer m_ParentLayer; //Field offset: 0x120
	private readonly float OUT_MARGIN; //Field offset: 0x124
	private float m_OutMarginTime; //Field offset: 0x128

	protected override string LayoutPrefabName
	{
		 get { } //Length: 35
	}

	private static LoadingDisp() { }

	public LoadingDisp() { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent) { }

	public void End() { }

	public void ForceEnd() { }

	protected override string get_LayoutPrefabName() { }

	protected virtual void InitUguiOther() { }

	public bool IsEnd() { }

	protected virtual void LateUpdate() { }

	public virtual void ReleaseAll() { }

	public void Start() { }

	protected virtual void UpdateDispMain() { }

}

