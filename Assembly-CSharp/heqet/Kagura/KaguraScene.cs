namespace Heqet.Kagura;

public class KaguraScene : MainSceneBase
{
	internal enum eContStep
	{
		FADE_IN = 0,
		MUSIC_INFO_WAIT = 1,
		NAMEPLATE_WAIT = 2,
		START = 3,
		PLAYING = 4,
		PAUSE = 5,
		GAME_FINISH = 6,
		GAME_FINISH_FADE = 7,
		RESULT_INIT = 8,
		RESULT = 9,
		END = 10,
	}

	internal enum eStepMain
	{
		WAIT_PREV_UNLOAD = 0,
		TAKASHO_QUIC_WAIT = 1,
		PRE_LOAD_WAIT = 2,
		INIT_START = 3,
		LOAD_WAIT = 4,
		CONT_MAIN = 5,
		FADE_OUT = 6,
		RELESE = 7,
		DO_SAVE = 8,
		WAIT_SYSTEM_DIALOG = 9,
		GO_TO_SCENE = 10,
		CONT_END = 11,
		NUM = 12,
	}

	private const float NAMEPLATE_WAIT_TIME = 2; //Field offset: 0x0
	private eStepMain m_StepMain; //Field offset: 0x14
	private eContStep m_ContStep; //Field offset: 0x18
	private String[] assetBundleNameList; //Field offset: 0x1C
	private List<AssetBundleLoadAllAssetOperationBase> loadOperationList; //Field offset: 0x20
	private EffectCategory[] effectCategoryList; //Field offset: 0x24
	[SerializeField]
	private RhythmGameResult2 rhythmGameResult; //Field offset: 0x28
	private KaguraLayer kaguraLayer; //Field offset: 0x2C
	private bool layerCreated; //Field offset: 0x30
	private float waitTimer; //Field offset: 0x34
	private KaguraPauseDialogLayer pauseDialogLayer; //Field offset: 0x38
	private KaguraManager manager; //Field offset: 0x3C
	private bool isRetry; //Field offset: 0x40
	private InputActionReference keyFunction3; //Field offset: 0x44

	public KaguraScene() { }

	[CompilerGenerated]
	private void <DoUpdateMain>b__17_0() { }

	[CompilerGenerated]
	private void <InitCanvas>b__20_0(LayerBase layerBase) { }

	private void ApplyCanvasCameraSetting() { }

	private void ContMain() { }

	protected virtual void DoDestroy() { }

	protected virtual void DoUpdateMain() { }

	public void ExitScene(bool retry = false) { }

	public void GameFinish() { }

	private void GoToScene() { }

	private void InitCanvas() { }

	private void InitFromFreeMode() { }

	private void InitFromStoryMode() { }

	private void InitGame() { }

	private void LateUpdate() { }

	private void OnApplicationPause(bool pauseStatus) { }

	private void PauseGame() { }

	private void RestartGame() { }

	private void RevertCanvasCameraSetting() { }

	private void SetDummyData() { }

	private void StartRhythmGameResult() { }

}

