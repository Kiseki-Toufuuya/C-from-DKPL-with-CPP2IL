namespace Heqet.StoryMode;

public class StoryModeCharacter : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public StoryModeCharacter <>4__this; //Field offset: 0x8
		public Action onCombplete; //Field offset: 0xC

		public <>c__DisplayClass18_0() { }

		internal void <JumpNode>b__0() { }

	}

	[CompilerGenerated]
	private struct <DropAnimation>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public StoryModeCharacter <>4__this; //Field offset: 0xC
		private Awaiter <>u__1; //Field offset: 0x10
		private Awaiter <>u__2; //Field offset: 0x18

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static readonly int hashDrop; //Field offset: 0x0
	private Live2DModel m_live2dModel; //Field offset: 0x10
	[SerializeField]
	private GameObject m_dummyObject; //Field offset: 0x14
	[SerializeField]
	private GameObject m_rootObject; //Field offset: 0x18
	[SerializeField]
	private Animator m_animator; //Field offset: 0x1C
	[SerializeField]
	private float m_scale; //Field offset: 0x20
	private Tween m_jumpTweener; //Field offset: 0x24

	public Transform FollowTarget
	{
		 get { } //Length: 49
	}

	public bool IsReady
	{
		 get { } //Length: 23
	}

	private static StoryModeCharacter() { }

	public StoryModeCharacter() { }

	[CompilerGenerated]
	private void <DropAnimation>b__15_0(float value) { }

	public void CreateLive2DModel(int characterId, int skinId, TYPE type = 18) { }

	[AsyncStateMachine(typeof(<DropAnimation>d__15))]
	public UniTask DropAnimation() { }

	public void EffectEvent(int id) { }

	public Transform get_FollowTarget() { }

	public bool get_IsReady() { }

	public void Initialize() { }

	private bool IsPlayingAnimation(int stateHash, int layerNo) { }

	public void JumpNode(NodePoint stagePoint, Action onCombplete) { }

	private void OnDestroy() { }

	public void VisibleModel(bool active) { }

}

