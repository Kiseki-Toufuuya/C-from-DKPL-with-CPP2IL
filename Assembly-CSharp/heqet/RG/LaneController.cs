namespace Heqet.RG;

public class LaneController : MonoBehaviour
{
	[CompilerGenerated]
	private struct <Initialize>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public LaneController <>4__this; //Field offset: 0xC
		public RhythmGame rhythmGame_; //Field offset: 0x10
		private Enumerator<Lane> <>7__wrap1; //Field offset: 0x14
		private Awaiter <>u__1; //Field offset: 0x24

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public List<Lane> lanes; //Field offset: 0x10
	private RhythmGame rg; //Field offset: 0x14
	private List<InputActionSprite> inputActionSprites; //Field offset: 0x18

	public int LaneCount
	{
		 get { } //Length: 52
	}

	public LaneController() { }

	public void DoLateUpdate() { }

	public void DoUpdate() { }

	public int get_LaneCount() { }

	public Lane GetLaneFromId(int id) { }

	[AsyncStateMachine(typeof(<Initialize>d__5))]
	public UniTask Initialize(RhythmGame rhythmGame_) { }

	public void Pause(bool enable) { }

	public void Release() { }

	public void SetGameParam() { }

}

