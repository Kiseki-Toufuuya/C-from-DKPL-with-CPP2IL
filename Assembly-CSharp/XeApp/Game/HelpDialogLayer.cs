namespace XeApp.Game;

public class HelpDialogLayer : LayerBase
{
	[CompilerGenerated]
	private struct <LoadImagesAsync>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public HelpDialogLayer <>4__this; //Field offset: 0x8
		private HeqetHelpPageModel[] <>7__wrap1; //Field offset: 0xC
		private int <>7__wrap2; //Field offset: 0x10
		private HeqetHelpPageModel <page>5__4; //Field offset: 0x14
		private string <xabName>5__5; //Field offset: 0x18
		private AssetBundleLoadAssetOperation <operation>5__6; //Field offset: 0x1C
		private Awaiter <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal class HelpDialogArg
	{
		public string closeText; //Field offset: 0x8
		public HeqetHelpGroupModel helpModel; //Field offset: 0xC

		public HelpDialogArg() { }

	}

	private enum STATE
	{
		INIT = 0,
		WAIT = 1,
		CLOSE = 2,
		END = 3,
	}

	private STATE MainState; //Field offset: 0x58
	private STATE MainStateReq; //Field offset: 0x5C
	private HelpDialogDisp m_Disp; //Field offset: 0x60
	private HelpDialogArg m_WindowArg; //Field offset: 0x64
	private List<String> m_ImageLoadReq; //Field offset: 0x68
	private Dictionary<Int32, Sprite> m_ImageList; //Field offset: 0x6C
	private int m_LoadPageCount; //Field offset: 0x70
	private int m_PageCount; //Field offset: 0x74
	public bool iSFirstTime; //Field offset: 0x78
	public bool iSGallery; //Field offset: 0x79

	public virtual bool IS_DISP_BACKGROUND
	{
		 get { } //Length: 3
	}

	public virtual bool IS_TOUCH_BACKGROUND
	{
		 get { } //Length: 3
	}

	public virtual bool IS_UPDATE_BACKGROUND
	{
		 get { } //Length: 3
	}

	public HelpDialogArg WindowArgData
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public HelpDialogLayer() { }

	protected void AddImage(AssetBundleLoadAssetOperation op, int ImageId) { }

	protected virtual bool EndUpdateAfter() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	public HelpDialogArg get_WindowArgData() { }

	public Sprite GetImageTexture(int imageID) { }

	protected AssetBundleLoadAssetOperation ImageLoadRequest(string xabName, int ImageId, string langCode) { }

	protected virtual void InitAll() { }

	protected virtual bool InitResourceWait() { }

	protected virtual bool InitUpdateBefore() { }

	protected virtual void LateUpdate(bool is_active) { }

	[AsyncStateMachine(typeof(<LoadImagesAsync>d__24))]
	protected UniTaskVoid LoadImagesAsync() { }

	public virtual void OverDeleteLayer() { }

	protected virtual bool ReleaseLayer() { }

	public void set_WindowArgData(HelpDialogArg value) { }

	protected virtual void Update(bool is_active) { }

}

