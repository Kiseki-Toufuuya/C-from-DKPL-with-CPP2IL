namespace Heqet;

public class UnlockMusicDialogDisp : DispBase
{
	[CompilerGenerated]
	private struct <Open>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public bool visible; //Field offset: 0xC
		public UnlockMusicDialogDisp <>4__this; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum eButtonId
	{
		Screen = 0,
		Close = 1,
		Max = 2,
	}

	private enum eCommonLayerId
	{
		Max = 0,
	}

	private enum eImageId
	{
		JacketIcon = 0,
		Max = 1,
	}

	private enum eTextId
	{
		Body = 0,
		NUM = 1,
	}

	private static readonly String[] m_ImageList; //Field offset: 0x0
	private static readonly String[] m_LayerIdList; //Field offset: 0x4
	private static readonly String[] m_TextList; //Field offset: 0x8
	private String[] m_ButtonDataList; //Field offset: 0x114
	private Animator RootAnimator; //Field offset: 0x118
	[CompilerGenerated]
	private Action<Int32> <OnPressButtonAction>k__BackingField; //Field offset: 0x11C
	private int m_JacketId; //Field offset: 0x120
	private RawImageEx m_JacketImage; //Field offset: 0x124
	private JacketAssetBunleLoader m_JacketLoader; //Field offset: 0x128

	public Action<Int32> OnPressButtonAction
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	private static UnlockMusicDialogDisp() { }

	public UnlockMusicDialogDisp() { }

	[CompilerGenerated]
	private bool <Open>b__21_0() { }

	[CompilerGenerated]
	private void <UpdateDisp>b__24_0(AssetBundleLoadAssetOperation ope) { }

	public void CallbackButton(int id) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	[CompilerGenerated]
	public Action<Int32> get_OnPressButtonAction() { }

	public GameObject GetFirstSelectButtonObject() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	[AsyncStateMachine(typeof(<Open>d__21))]
	public UniTask Open(bool visible) { }

	public virtual void ReleaseAll() { }

	[CompilerGenerated]
	public void set_OnPressButtonAction(Action<Int32> value) { }

	public void UpdateDisp(int mudicId, string bodyText) { }

	protected virtual void UpdateDispMain() { }

}

