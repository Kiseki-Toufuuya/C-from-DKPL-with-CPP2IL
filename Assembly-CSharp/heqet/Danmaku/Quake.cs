namespace Heqet.Danmaku;

[RequireComponent(typeof(STGGimmick))]
public class Quake : MonoBehaviour, ITimeControl
{
	[CompilerGenerated]
	private struct <FinishShake>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public Quake <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const float SHAKE_LEVEL = 1; //Field offset: 0x0
	private const float FINISH_SHAKE_TIME = 0.5; //Field offset: 0x0
	private Transform m_Camera; //Field offset: 0x10
	private float m_Timer; //Field offset: 0x14
	private bool m_IsShake; //Field offset: 0x18
	private Vector3 m_StartPos; //Field offset: 0x1C

	public Quake() { }

	[AsyncStateMachine(typeof(<FinishShake>d__9))]
	private UniTaskVoid FinishShake() { }

	public override void OnControlTimeStart() { }

	public override void OnControlTimeStop() { }

	public override void SetTime(double time) { }

}

