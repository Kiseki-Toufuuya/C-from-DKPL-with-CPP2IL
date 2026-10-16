namespace XeApp.Game;

public class AdventureTestScene : MainSceneBase
{
	internal enum eStepMain
	{
		INIT_ALL = 0,
		INIT_START = 1,
		QUICK_START = 2,
		SE_LOAD = 3,
		CONT_MAIN = 4,
		ADV_WAIT = 5,
		FadeOut = 6,
		FadeIn = 7,
		End = 8,
		NUM = 9,
	}

	private eStepMain m_StepMain; //Field offset: 0x14
	private AdvStartButton StartButton; //Field offset: 0x18
	private AdvReturnButton ReturnButton; //Field offset: 0x1C
	[SerializeField]
	private Dropdown CategoryDropDown; //Field offset: 0x20
	[SerializeField]
	private Dropdown FileNameDropDown; //Field offset: 0x24
	[SerializeField]
	private Image DebugMask; //Field offset: 0x28
	[SerializeField]
	private InputField EpisodeIdInput; //Field offset: 0x2C
	[SerializeField]
	private Toggle UiOffToggle; //Field offset: 0x30
	[SerializeField]
	private Toggle BGOffToggle; //Field offset: 0x34
	[SerializeField]
	private Toggle AutoToggle; //Field offset: 0x38
	private AdbentureTestLayerRoot rootLayer; //Field offset: 0x3C

	public AdventureTestScene() { }

	[CompilerGenerated]
	private void <DoUpdateMain>b__15_0() { }

	[CompilerGenerated]
	private void <DoUpdateMain>b__15_1() { }

	[CompilerGenerated]
	private void <DoUpdateMain>b__15_2() { }

	[CompilerGenerated]
	private void <DoUpdateMain>b__15_3() { }

	private EpisodeCategory CategoryDropDownValueToCategory(int a_value) { }

	private void ContMain() { }

	protected virtual void DoAwake() { }

	protected virtual void DoStart() { }

	protected virtual void DoUpdateMain() { }

	private void EpisodeFinish() { }

	private void InitCanvas() { }

	private void OnDestroy() { }

	private void SetEventScriptCategory(int id) { }

	private void SetUpScriptFileList() { }

}

