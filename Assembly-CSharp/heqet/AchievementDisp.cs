namespace Heqet;

public class AchievementDisp : DispBase
{
	[CompilerGenerated]
	private struct <Open>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public bool visible; //Field offset: 0xC
		public AchievementDisp <>4__this; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private enum eImageId
	{
		Icon = 0,
		Max = 1,
	}

	private enum eTextId
	{
		Text = 0,
		Max = 1,
	}

	private String[] m_TextList; //Field offset: 0x114
	private String[] m_ImageList; //Field offset: 0x118
	private Animator RootAnimator; //Field offset: 0x11C
	private RawImageEx m_icon; //Field offset: 0x120
	private int m_imageId; //Field offset: 0x124

	public AchievementDisp() { }

	[CompilerGenerated]
	private bool <Open>b__15_0() { }

	[CompilerGenerated]
	private void <UpdateDisp>b__11_0(AssetBundleLoadAssetOperation ope) { }

	public void CallbackButton(int button_id) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	[AsyncStateMachine(typeof(<Open>d__15))]
	public UniTask Open(bool visible) { }

	public virtual void ReleaseAll() { }

	public void UpdateDisp(AchievementModel model) { }

	protected virtual void UpdateDispMain() { }

}

