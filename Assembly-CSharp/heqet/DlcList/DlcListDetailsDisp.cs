namespace Heqet.DlcList;

public class DlcListDetailsDisp : DispBase
{
	[CompilerGenerated]
	private struct <Open>d__26 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public bool visible; //Field offset: 0xC
		public DlcListDetailsDisp <>4__this; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum eButtonId
	{
		BACK = 0,
		GO_TO_STORE = 1,
		HELP = 2,
		NUM = 3,
	}

	private enum eCommonLayerId
	{
		SCROLL_ROOT = 0,
		Max = 1,
	}

	private enum eImageId
	{
		Jacket = 0,
		Max = 1,
	}

	private enum eTextId
	{
		MusicName = 0,
		Bmp = 1,
		CircleName = 2,
		VocalName = 3,
		Max = 4,
	}

	internal enum eUIState
	{
		NONE = 0,
		IN = 1,
		OUT = 2,
	}

	private static readonly String[] m_ButtonIdList; //Field offset: 0x0
	private static readonly String[] m_LayerIdList; //Field offset: 0x4
	private String[] m_TextList; //Field offset: 0x114
	private String[] m_ImageList; //Field offset: 0x118
	[CompilerGenerated]
	private Action<Int32> <OnPressButtonAction>k__BackingField; //Field offset: 0x11C
	public Action<AxisEventData> OnMoveAction; //Field offset: 0x120
	public Action<AxisEventData> OnMovePageAciton; //Field offset: 0x124
	public Func<GameObject> GetSelectGameobjectAction; //Field offset: 0x128
	private int m_JacketId; //Field offset: 0x12C
	private RawImageEx m_JacketImage; //Field offset: 0x130
	private JacketAssetBunleLoader m_JacketLoader; //Field offset: 0x134

	public Action<Int32> OnPressButtonAction
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	private static DlcListDetailsDisp() { }

	public DlcListDetailsDisp() { }

	[CompilerGenerated]
	private void <InitUguiOther>b__22_0(int v) { }

	[CompilerGenerated]
	private bool <Open>b__26_0() { }

	[CompilerGenerated]
	private void <SetupDisp>b__24_0(AssetBundleLoadAssetOperation ope) { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	[CompilerGenerated]
	public Action<Int32> get_OnPressButtonAction() { }

	public CreditDialog GetCreditDialogComponent() { }

	public GameObject GetScrollRoot() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	[AsyncStateMachine(typeof(<Open>d__26))]
	public UniTask Open(bool visible) { }

	public virtual void ReleaseAll() { }

	[CompilerGenerated]
	public void set_OnPressButtonAction(Action<Int32> value) { }

	public void SetupDisp(HeqetMusicModel model) { }

	protected virtual void UpdateDispMain() { }

}

