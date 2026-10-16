namespace Heqet;

public class ConfirmationBgDisp : DispBase
{
	[CompilerGenerated]
	private struct <Open>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public bool visible; //Field offset: 0xC
		public ConfirmationBgDisp <>4__this; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private Animator RootAnimator; //Field offset: 0x114

	public ConfirmationBgDisp() { }

	[CompilerGenerated]
	private bool <Open>b__3_0() { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	protected virtual void LateUpdate() { }

	[AsyncStateMachine(typeof(<Open>d__3))]
	public UniTask Open(bool visible) { }

	protected virtual void UpdateDispMain() { }

}

