namespace XeApp.Game;

public sealed class BootScene : MainSceneBase
{
	[CompilerGenerated]
	private struct <<InitializeTakasho>b__2_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public BootScene <>4__this; //Field offset: 0x8
		private TaskAwaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum eStepMain
	{
		INIT_START = 0,
		CONT_MAIN = 1,
		END = 2,
		WAIT_SYSTEM_DIALOG = 3,
		NUM = 4,
	}

	private bool isTakashoInitialized; //Field offset: 0x14
	[SerializeField]
	private RenderTextureMan m_RenderTextureManPrefab; //Field offset: 0x18
	private RenderTextureMan m_RenderTextureMan; //Field offset: 0x1C
	[SerializeField]
	private CardIllustManager m_CardIllustManagerPrefab; //Field offset: 0x20
	private CardIllustManager m_CardIllustManager; //Field offset: 0x24
	[SerializeField]
	private GameObject m_CriAtomPrefab; //Field offset: 0x28
	private bool IsSignInTakasho; //Field offset: 0x2C
	private bool isLocalizationSettingsInitialized; //Field offset: 0x2D
	private bool isLoadedGameData; //Field offset: 0x2E
	private bool isInitedSystem; //Field offset: 0x2F
	private eStepMain m_StepMain; //Field offset: 0x30
	private eStepMain m_ReturnStepMain; //Field offset: 0x34
	private int check; //Field offset: 0x38
	private int checkTime; //Field offset: 0x3C

	public BootScene() { }

	[AsyncStateMachine(typeof(<<InitializeTakasho>b__2_0>d))]
	[CompilerGenerated]
	private UniTaskVoid <InitializeTakasho>b__2_0() { }

	[CompilerGenerated]
	private void <InitializeTakasho>b__2_1() { }

	[Preserve]
	public void AppWillStart1_Always() { }

	[Preserve]
	public void AppWillStart2_Once() { }

	[Preserve]
	public void AppWillStart3_Once() { }

	private void CommandLine() { }

	private void ContMain() { }

	private void CreateCardIllustRenderTexture() { }

	private void CreateRenderTexture() { }

	protected virtual void DoAwake() { }

	protected virtual void DoStart() { }

	protected virtual void DoUpdateMain() { }

	[Preserve]
	private static void DummyTamp(string s) { }

	private void InitCanvas() { }

	private void InitializeTakasho() { }

	private void InitSystem() { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	private static void OnBeforeSceneLoadRuntimeMethod() { }

	private void SetupDotNetCulture() { }

	private void ToNextScene() { }

}

