namespace DG.Tweening.Core;

public class DOTweenSettings : ScriptableObject
{
	internal class ModulesSetup
	{
		public bool showPanel; //Field offset: 0x8
		public bool audioEnabled; //Field offset: 0x9
		public bool physicsEnabled; //Field offset: 0xA
		public bool physics2DEnabled; //Field offset: 0xB
		public bool spriteEnabled; //Field offset: 0xC
		public bool uiEnabled; //Field offset: 0xD
		public bool textMeshProEnabled; //Field offset: 0xE
		public bool tk2DEnabled; //Field offset: 0xF
		public bool deAudioEnabled; //Field offset: 0x10
		public bool deUnityExtendedEnabled; //Field offset: 0x11
		public bool epoOutlineEnabled; //Field offset: 0x12

		public ModulesSetup() { }

	}

	internal class SafeModeOptions
	{
		public SafeModeLogBehaviour logBehaviour; //Field offset: 0x8
		public NestedTweenFailureBehaviour nestedTweenFailureBehaviour; //Field offset: 0xC

		public SafeModeOptions() { }

	}

	internal enum SettingsLocation
	{
		AssetsDirectory = 0,
		DOTweenDirectory = 1,
		DemigiantDirectory = 2,
	}

	public const string AssetName = "DOTweenSettings"; //Field offset: 0x0
	public const string AssetFullFilename = "DOTweenSettings.asset"; //Field offset: 0x0
	public bool useSafeMode; //Field offset: 0xC
	public SafeModeOptions safeModeOptions; //Field offset: 0x10
	public float timeScale; //Field offset: 0x14
	public float unscaledTimeScale; //Field offset: 0x18
	public bool useSmoothDeltaTime; //Field offset: 0x1C
	public float maxSmoothUnscaledTime; //Field offset: 0x20
	public RewindCallbackMode rewindCallbackMode; //Field offset: 0x24
	public bool showUnityEditorReport; //Field offset: 0x28
	public LogBehaviour logBehaviour; //Field offset: 0x2C
	public bool drawGizmos; //Field offset: 0x30
	public bool defaultRecyclable; //Field offset: 0x31
	public AutoPlay defaultAutoPlay; //Field offset: 0x34
	public UpdateType defaultUpdateType; //Field offset: 0x38
	public bool defaultTimeScaleIndependent; //Field offset: 0x3C
	public Ease defaultEaseType; //Field offset: 0x40
	public float defaultEaseOvershootOrAmplitude; //Field offset: 0x44
	public float defaultEasePeriod; //Field offset: 0x48
	public bool defaultAutoKill; //Field offset: 0x4C
	public LoopType defaultLoopType; //Field offset: 0x50
	public bool debugMode; //Field offset: 0x54
	public bool debugStoreTargetId; //Field offset: 0x55
	public bool showPreviewPanel; //Field offset: 0x56
	public SettingsLocation storeSettingsLocation; //Field offset: 0x58
	public ModulesSetup modules; //Field offset: 0x5C
	public bool createASMDEF; //Field offset: 0x60
	public bool showPlayingTweens; //Field offset: 0x61
	public bool showPausedTweens; //Field offset: 0x62

	public DOTweenSettings() { }

}

