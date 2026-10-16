namespace Heqet.RG;

public class ResultButtonDisp : DispBase
{
	internal enum eButtonId
	{
		BUTTON_NEXT = 0,
		BUTTON_BACK = 1,
		BUTTON_RETRY = 2,
		BUTTON_SCREEN = 3,
		BUTTON_GRAPH_SWITCH = 4,
		BUTTON_REWARD_INFO = 5,
	}

	private enum eLayerId
	{
		ROOT_BUTTON_NEXT = 0,
		ROOT_BUTTON_BACK = 1,
		ROOT_BUTTON_RETRY = 2,
		ROOT_BUTTON_GRAPH_SWITCH = 3,
		ROOT_BUTTON_REWARD_INFO = 4,
	}

	internal enum UiState
	{
		Wait = 0,
		Open = 1,
		OpenWait = 2,
		CloseWait = 3,
		Close = 4,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private String[] m_ButtonList; //Field offset: 0x114
	private UiState WindowState; //Field offset: 0x118
	private Animator RootAnimator; //Field offset: 0x11C
	[CompilerGenerated]
	private Action<Int32> <OnClickButtonCallback>k__BackingField; //Field offset: 0x120

	public private Action<Int32> OnClickButtonCallback
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	private static ResultButtonDisp() { }

	public ResultButtonDisp() { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	public void DispBackButton(bool _enable) { }

	public void DispGraphSwitchButton(bool _enable) { }

	public void DispNextButton(bool _enable) { }

	public void DispRetryButton(bool _enable) { }

	public void DispRewardInfoButton(bool _enable) { }

	[CompilerGenerated]
	private Action<Int32> get_OnClickButtonCallback() { }

	protected virtual void InitUguiOther() { }

	public virtual bool IsPlaying() { }

	public bool IsPlayingAnime() { }

	protected virtual void LateUpdate() { }

	private void OnClickButton(int _id) { }

	[CompilerGenerated]
	public void set_OnClickButtonCallback(Action<Int32> value) { }

	public void SetPlayMode(int playMode) { }

	public void StartCloseAnimation() { }

	public void StartOpenAnimation() { }

	protected virtual void UpdateDispMain() { }

}

