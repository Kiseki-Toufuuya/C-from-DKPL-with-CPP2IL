namespace Heqet.RG;

public class ResultMissionDisp : DispBase
{
	[CompilerGenerated]
	private struct <InitEffect>d__33 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public ResultMissionDisp <>4__this; //Field offset: 0x8
		private Vector3 <pos>5__2; //Field offset: 0xC
		private Awaiter <>u__1; //Field offset: 0x18

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private enum eLayerId
	{
		MISSION_CLEAR = 0,
		MISSION1 = 1,
		MISSION2 = 2,
		MISSION3 = 3,
		MISSION1_CHECK = 4,
		MISSION2_CHECK = 5,
		MISSION3_CHECK = 6,
	}

	private enum eTextId
	{
		MISSION1_NAME_TEXT = 0,
		MISSION2_NAME_TEXT = 1,
		MISSION3_NAME_TEXT = 2,
	}

	internal class MissionParam
	{
		public int MissionId; //Field offset: 0x8
		public bool IsCleared; //Field offset: 0xC
		public bool IsNewCleared; //Field offset: 0xD

		public MissionParam() { }

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
	private static readonly String[] m_TextIdList; //Field offset: 0x4
	private readonly string GAME_CAMERA; //Field offset: 0x114
	private List<MissionParam> m_MissionParams; //Field offset: 0x118
	private Animator RootAnimator; //Field offset: 0x11C
	private UiState WindowState; //Field offset: 0x120
	private List<Animator> m_MissionCheckAnims; //Field offset: 0x124
	private Animator m_MissionClearAnim; //Field offset: 0x128
	private EffectObjectBase m_MissionClearEffect; //Field offset: 0x12C

	private static ResultMissionDisp() { }

	public ResultMissionDisp() { }

	[CompilerGenerated]
	private bool <InitEffect>b__33_0() { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	[AsyncStateMachine(typeof(<InitEffect>d__33))]
	public UniTaskVoid InitEffect() { }

	protected virtual void InitUguiOther() { }

	public virtual bool IsPlaying() { }

	public bool IsPlayingAnime() { }

	protected virtual void LateUpdate() { }

	public virtual void ReleaseAll() { }

	public void SetupMissionParam(List<MissionParam> _params) { }

	public void StartCloseAnimation() { }

	public void StartOpenAnimation(float _timer = 0) { }

	private void UpdateCrearCheck() { }

	public void UpdateCrearCheck(int _index, bool _value) { }

	public void UpdateCrearCheckPlayAnim(int _index, float _timer = 0) { }

	protected virtual void UpdateDispMain() { }

	public void UpdateMissionComplete() { }

	public void UpdateMissionCompleteSkip() { }

	public void UpdateMissionText(int _index, string _missionName) { }

	private void UpdateMissionText() { }

	public void UpdateNewMissionComplete() { }

	public void UpdateNowCrearCheck(int _index) { }

}

