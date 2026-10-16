namespace XeApp.Game;

public class FrameWorkBehaviour : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <WaitDeviceRotate>d__48 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public FrameWorkBehaviour <>4__this; //Field offset: 0x10
		private int <i>5__2; //Field offset: 0x14

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		[DebuggerHidden]
		public <WaitDeviceRotate>d__48(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private class AssetLoadData
	{
		public string assetBundleName; //Field offset: 0x8
		public string assetName; //Field offset: 0xC
		public Type assetType; //Field offset: 0x10
		public Action<AssetBundleLoadAssetOperation> onLoadAction; //Field offset: 0x14

		public AssetLoadData() { }

	}

	private enum eStepMain
	{
		NONE = 0,
		INIT_MANAGER = 1,
		INIT_EVENT_SYSTEM = 2,
		MAIN_UPDATE = 3,
		NUM = 4,
	}

	private enum SeState
	{
		NONE = 0,
		INIT = 1,
		PREPARE = 2,
	}

	private static FrameWorkBehaviour m_Instance; //Field offset: 0x0
	private ButtonManager m_ButtonManager; //Field offset: 0x10
	private UguiButtonManager m_UguiButtonManager; //Field offset: 0x14
	private LayerBase m_LayerRoot; //Field offset: 0x18
	private GameManger m_GameManger; //Field offset: 0x1C
	private DialogManager m_DialogManager; //Field offset: 0x20
	private SubDialogManager m_SubDialogManager; //Field offset: 0x24
	private Live2DModelManager Live2DModelManager; //Field offset: 0x28
	private EffectManager EffectManager; //Field offset: 0x2C
	private GameParamManager m_GameParamManager; //Field offset: 0x30
	private RenderTextureMan RenderTexManger; //Field offset: 0x34
	private GameTouchEffect gameTouchEffect; //Field offset: 0x38
	private ResidentResource m_ResidentResource; //Field offset: 0x3C
	private InputActionManager m_InputActionManager; //Field offset: 0x40
	private AchievementManager m_AchievementManager; //Field offset: 0x44
	private AutoSaveManager m_AutoSaveManager; //Field offset: 0x48
	private bool m_IsDownloadAllData; //Field offset: 0x4C
	private bool m_IsDownloadLaunch; //Field offset: 0x4D
	private Canvas[] m_Canvas; //Field offset: 0x50
	private Camera SysCamera; //Field offset: 0x54
	private AutoSceneTransition m_AutoTransition; //Field offset: 0x58
	private eStepMain m_StepMain; //Field offset: 0x5C
	private SeState m_SeState; //Field offset: 0x60
	public bool RythmUpdateFlg; //Field offset: 0x64
	public bool AdvUpdateFlg; //Field offset: 0x65
	private bool IsLoadAssetBundle; //Field offset: 0x66
	private bool IsFirstRotateEnd; //Field offset: 0x67
	private UnionAssetBundleLoadOperation m_FontOpe; //Field offset: 0x68
	private UnionAssetBundleLoadOperation m_FontOpe2; //Field offset: 0x6C
	private UnionAssetBundleLoadOperation m_InputActionOpe; //Field offset: 0x70
	private AssetBundleLoadAssetOperation m_EventSystemOpe; //Field offset: 0x74
	private bool IsLoadResidentAssetbundles; //Field offset: 0x78

	public static FrameWorkBehaviour Instance
	{
		 get { } //Length: 40
	}

	public bool IsDownloadAllData
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public bool IsDownloadLaunch
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public Camera SystemCamera
	{
		 get { } //Length: 11
	}

	public FrameWorkBehaviour() { }

	[CompilerGenerated]
	private void <Update>b__49_0(AssetBundleLoadAssetOperation assetbundle) { }

	public static void Create(string layer_tag) { }

	private void CreateGameMasterManger() { }

	private void DoStart() { }

	public static FrameWorkBehaviour get_Instance() { }

	public bool get_IsDownloadAllData() { }

	public bool get_IsDownloadLaunch() { }

	public Camera get_SystemCamera() { }

	public static bool IsInitialize() { }

	public void LateUpdate() { }

	public void LoadCommonAssetBundle() { }

	private void LoadResidentResources() { }

	public void set_IsDownloadAllData(bool value) { }

	public void set_IsDownloadLaunch(bool value) { }

	private void SetStepMain(eStepMain next) { }

	private void SetupAssetBundleBasePath() { }

	private void Start() { }

	public void UnloadCommonAssetBundle() { }

	private void Update() { }

	[IteratorStateMachine(typeof(<WaitDeviceRotate>d__48))]
	private IEnumerator WaitDeviceRotate() { }

}

