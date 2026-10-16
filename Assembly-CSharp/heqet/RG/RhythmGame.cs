namespace Heqet.RG;

public class RhythmGame
{
	[CompilerGenerated]
	private struct <LoadAsssetAsync>d__73 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public RhythmGame <>4__this; //Field offset: 0xC
		private Awaiter <>u__1; //Field offset: 0x10

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public const string ScoreRootPath = "Score~/"; //Field offset: 0x0
	[CompilerGenerated]
	private NotesManager <NotesManager>k__BackingField; //Field offset: 0x8
	public InputObserver InputObserver; //Field offset: 0xC
	[CompilerGenerated]
	private MusicManager <MusicManager>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private IngameSEManager <SEManager>k__BackingField; //Field offset: 0x14
	private TouchObserver touchObserver; //Field offset: 0x18
	private string currentScorePath; //Field offset: 0x1C
	private int currentMusicId; //Field offset: 0x20
	private SettingData currentMusicSettingData; //Field offset: 0x24
	private string currentBGMFile; //Field offset: 0x28
	[SerializeField]
	private GameStyles currentGameStyles; //Field offset: 0x2C
	[SerializeField]
	public GameObject debugObject; //Field offset: 0x30
	private float musicStartTime; //Field offset: 0x34
	public bool isScoreStartTime; //Field offset: 0x38
	public int startMeasure; //Field offset: 0x3C
	public bool isPauseMusic; //Field offset: 0x40
	public bool initialized; //Field offset: 0x41
	private bool isDone; //Field offset: 0x42
	private NotesSkin notesSkin; //Field offset: 0x44
	[CompilerGenerated]
	private Vector3 <DefaultGameCameraPosition>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private Action<NoteData, Int32> OnJudge; //Field offset: 0x54

	public event Action<NoteData, Int32> OnJudge
	{
		[CompilerGenerated]
		 add { } //Length: 125
		[CompilerGenerated]
		 remove { } //Length: 125
	}

	public bool AutoPlay
	{
		 get { } //Length: 23
		 set { } //Length: 44
	}

	public Camera BackCamera
	{
		 get { } //Length: 23
	}

	public string CurrentBGMFile
	{
		 get { } //Length: 11
	}

	public GameStyles CurrentGameStyles
	{
		 get { } //Length: 11
	}

	public int CurrentMusicId
	{
		 get { } //Length: 11
	}

	public SettingData CurrentMusicSettingData
	{
		 get { } //Length: 11
	}

	public string CurrentScorePath
	{
		 get { } //Length: 11
	}

	public private Vector3 DefaultGameCameraPosition
	{
		[CompilerGenerated]
		 get { } //Length: 26
		[CompilerGenerated]
		private set { } //Length: 24
	}

	public float ElapsedTime
	{
		 get { } //Length: 23
	}

	public Camera GameCamera
	{
		 get { } //Length: 23
	}

	public bool IsPause
	{
		 get { } //Length: 23
	}

	public bool IsStart
	{
		 get { } //Length: 23
	}

	public private MusicManager MusicManager
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public float MusicTimingOffset
	{
		 get { } //Length: 93
	}

	public private NotesManager NotesManager
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public float NoteSpeedScale
	{
		 get { } //Length: 23
		 set { } //Length: 50
	}

	public NotesSkin NotesSkin
	{
		 get { } //Length: 11
	}

	public private IngameSEManager SEManager
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public bool UseSyncAudioTime
	{
		 get { } //Length: 23
		 set { } //Length: 26
	}

	public RhythmGame() { }

	[CompilerGenerated]
	private bool <LoadAsssetAsync>b__73_0() { }

	[CompilerGenerated]
	public void add_OnJudge(Action<NoteData, Int32> value) { }

	public void DoLateUpdate() { }

	public void DoUpdate() { }

	public bool get_AutoPlay() { }

	public Camera get_BackCamera() { }

	public string get_CurrentBGMFile() { }

	public GameStyles get_CurrentGameStyles() { }

	public int get_CurrentMusicId() { }

	public SettingData get_CurrentMusicSettingData() { }

	public string get_CurrentScorePath() { }

	[CompilerGenerated]
	public Vector3 get_DefaultGameCameraPosition() { }

	public float get_ElapsedTime() { }

	public Camera get_GameCamera() { }

	public bool get_IsPause() { }

	public bool get_IsStart() { }

	[CompilerGenerated]
	public MusicManager get_MusicManager() { }

	public float get_MusicTimingOffset() { }

	[CompilerGenerated]
	public NotesManager get_NotesManager() { }

	public float get_NoteSpeedScale() { }

	public NotesSkin get_NotesSkin() { }

	[CompilerGenerated]
	public IngameSEManager get_SEManager() { }

	public bool get_UseSyncAudioTime() { }

	public int GetMaxNotesCount() { }

	public static int GetMusicScoreID(int musicId, int difficulty) { }

	public static string GetMusicScoreIDString(int musicId, int difficulty) { }

	public static string GetScoreByteFileName(int musicId, int difficulty) { }

	public static string GetScoreDatFileName(int musicId) { }

	public void Initialize(NotesManager nm, MusicManager mm) { }

	public bool IsDone() { }

	public bool IsPlayEndMusic() { }

	[AsyncStateMachine(typeof(<LoadAsssetAsync>d__73))]
	private UniTask LoadAsssetAsync() { }

	private bool LoadScore(string datFilePath, string scoreFileName, int musicId, int musicScoreId, SettingData musicSettingData, StageGimmickCalculator sgc) { }

	private void OnLaneJudge(NoteData noteData, int judge) { }

	public void PauseMusic(bool enable) { }

	public void PlayLaneSE(int id, bool loop = false) { }

	public bool PlayMusic(string datFilePath, string scoreFileName, int musicId, int musicScoreId, SettingData musicSettingData, StageGimmickCalculator sgc) { }

	[CompilerGenerated]
	public void remove_OnJudge(Action<NoteData, Int32> value) { }

	public void ResetGameCamera() { }

	public void set_AutoPlay(bool value) { }

	[CompilerGenerated]
	private void set_DefaultGameCameraPosition(Vector3 value) { }

	[CompilerGenerated]
	private void set_MusicManager(MusicManager value) { }

	[CompilerGenerated]
	private void set_NotesManager(NotesManager value) { }

	public void set_NoteSpeedScale(float value) { }

	[CompilerGenerated]
	private void set_SEManager(IngameSEManager value) { }

	public void set_UseSyncAudioTime(bool value) { }

	public void StartMusic(string datFilePath, string scoreFileName, int musicId, int musicScoreId, SettingData musicSettingData, StageGimmickCalculator sgc) { }

	public void StopLaneSE(int id) { }

	public void StopMusic() { }

	public void Terminate() { }

}

