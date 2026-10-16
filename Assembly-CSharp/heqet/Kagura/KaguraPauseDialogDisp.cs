namespace Heqet.Kagura;

public class KaguraPauseDialogDisp : DispBase
{
	[CompilerGenerated]
	private struct <Open>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public bool visible; //Field offset: 0xC
		public KaguraPauseDialogDisp <>4__this; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum eButtonId
	{
		Back = 0,
		Exit = 1,
		Max = 2,
	}

	private enum eTextId
	{
		Information = 0,
		Max = 1,
	}

	private static readonly String[] m_TextList; //Field offset: 0x0
	private KaguraPauseDialogLayer m_Layer; //Field offset: 0x114
	private String[] m_ButtonDataList; //Field offset: 0x118
	private Animator RootAnimator; //Field offset: 0x11C

	private static KaguraPauseDialogDisp() { }

	public KaguraPauseDialogDisp() { }

	[CompilerGenerated]
	private bool <Open>b__12_0() { }

	public void CallbackButton(int button_id) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	[AsyncStateMachine(typeof(<Open>d__12))]
	public UniTask Open(bool visible) { }

	protected virtual void UpdateDispMain() { }

}

