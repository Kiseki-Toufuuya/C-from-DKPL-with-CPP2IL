namespace Heqet;

public class SettingKeyconfigPreviewDisp : DispBase
{
	[CompilerGenerated]
	private struct <InitSettingPreview>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public SettingKeyconfigPreviewDisp <>4__this; //Field offset: 0x8
		private string <prefabAssetBundleName>5__2; //Field offset: 0xC
		private string <imageAssetBundleName>5__3; //Field offset: 0x10
		private AssetBundleLoadAllAssetOperationBase <opePrefab>5__4; //Field offset: 0x14
		private AssetBundleLoadAllAssetOperationBase <opeImage>5__5; //Field offset: 0x18
		private Awaiter <>u__1; //Field offset: 0x1C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private enum eButtonId
	{
		Screen = 0,
		Close = 1,
		Dummy = 2,
	}

	internal enum eGameMode
	{
		Kagura = 0,
		Danmaku = 1,
	}

	private enum eLayerId
	{
		RAW_IMAGE = 0,
		CLOSE_GAUGE_CIRCLE = 1,
	}

	private enum eTextId
	{
		TITLE = 0,
		DETAIL = 1,
		CLOSE = 2,
	}

	private static readonly String[] m_LayerList; //Field offset: 0x0
	private static readonly String[] m_ButtonList; //Field offset: 0x4
	private static readonly String[] m_TextList; //Field offset: 0x8
	private Animator RootAnimator; //Field offset: 0x114
	private AtlasImage m_CloseGaugeCircle; //Field offset: 0x118
	private eGameMode m_GameMode; //Field offset: 0x11C
	private KeyConfigPreview m_Preview; //Field offset: 0x120
	private UIWrapperButton m_CloseButton; //Field offset: 0x124
	[CompilerGenerated]
	private Action <OnClickCloseButton>k__BackingField; //Field offset: 0x128

	public bool isPressCloseButton
	{
		 get { } //Length: 43
	}

	public Action OnClickCloseButton
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	private static SettingKeyconfigPreviewDisp() { }

	public SettingKeyconfigPreviewDisp() { }

	public void ChangeDisp() { }

	public virtual void Create(LayerBase parent_layer) { }

	public void DispLineLight(int _id, bool _enable) { }

	public bool get_isPressCloseButton() { }

	[CompilerGenerated]
	public Action get_OnClickCloseButton() { }

	private void InitLayout() { }

	[AsyncStateMachine(typeof(<InitSettingPreview>d__28))]
	private UniTaskVoid InitSettingPreview() { }

	protected virtual void InitUguiOther() { }

	public bool IsDone() { }

	protected virtual void LateUpdate() { }

	private void OnClickButton(int _id) { }

	public void Open(bool visible) { }

	public virtual void ReleaseAll() { }

	[CompilerGenerated]
	public void set_OnClickCloseButton(Action value) { }

	public void SetGamemode(eGameMode _mode) { }

	public void UpdateCloseGaugeCircle(float _amount) { }

	protected virtual void UpdateDispMain() { }

}

