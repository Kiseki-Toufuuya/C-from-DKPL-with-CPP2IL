namespace Heqet.RG;

[DefaultExecutionOrder(-10000)]
public class NotesManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<NoteData> <>9__125_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal int <ReadCISModel>b__125_0(NoteData a, NoteData b) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass134_0
	{
		public int laneId; //Field offset: 0x8

		public <>c__DisplayClass134_0() { }

		internal void <LaneRandom>b__0(NoteData noteData) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass136_0
	{
		public int laneId; //Field offset: 0x8

		public <>c__DisplayClass136_0() { }

		internal void <Mirror>b__0(NoteData noteData) { }

	}

	[CompilerGenerated]
	private struct <Initialize>d__70 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public NotesManager <>4__this; //Field offset: 0xC
		public RhythmGame rhythmGame; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal class NoteExtensionData
	{
		public GameObject gameObject; //Field offset: 0x8
		public float scoreTime; //Field offset: 0xC
		public int laneId; //Field offset: 0x10
		public NoteData noteData; //Field offset: 0x14
		public int id; //Field offset: 0x18
		public float beat; //Field offset: 0x1C
		public bool display; //Field offset: 0x20
		public float deleteDelayTime; //Field offset: 0x24
		public int gimmickOption; //Field offset: 0x28
		public bool multiPressLine; //Field offset: 0x2C
		public int multiPressToLaneId; //Field offset: 0x30

		public NoteExtensionData() { }

	}

	internal struct TimingPoint
	{
		public float bpm; //Field offset: 0x0
		public float beat; //Field offset: 0x4
		public float time; //Field offset: 0x8

	}

	public static float AutoPlayJudgeTimeLag; //Field offset: 0x0
	private const float TouchModeDisplayZ = 50; //Field offset: 0x0
	private const float MissTimeLag = 2; //Field offset: 0x0
	private const float NormalModeDisplayZ = 10; //Field offset: 0x0
	public static bool UseFixedBPMCalc; //Field offset: 0x4
	[SerializeField]
	private LaneController laneController; //Field offset: 0x10
	[SerializeField]
	private Camera backCamera; //Field offset: 0x14
	[SerializeField]
	private Camera gameCamera; //Field offset: 0x18
	public GameStyle _GameStyle; //Field offset: 0x1C
	public RhythmGame rg; //Field offset: 0x20
	private InputObserver InputObserver; //Field offset: 0x24
	[CompilerGenerated]
	private MusicManager <MusicManager>k__BackingField; //Field offset: 0x28
	[SerializeField]
	private TouchObserver touchObserver; //Field offset: 0x2C
	[CompilerGenerated]
	private bool <IsStart>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private bool <IsPause>k__BackingField; //Field offset: 0x31
	[CompilerGenerated]
	private float <ElapsedTime>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private float <NoteTapTimingOffset>k__BackingField; //Field offset: 0x38
	private float noteSpeedScale; //Field offset: 0x3C
	public float scoreOffset; //Field offset: 0x40
	private List<BPMData> bpms; //Field offset: 0x44
	[CompilerGenerated]
	private bool <UseSyncAudioTime>k__BackingField; //Field offset: 0x48
	private float timeLag; //Field offset: 0x4C
	[CompilerGenerated]
	private Action OnRefresh; //Field offset: 0x50
	private float baseBPM; //Field offset: 0x54
	[CompilerGenerated]
	private float <CurrentBPM>k__BackingField; //Field offset: 0x58
	private int maxNotesCount; //Field offset: 0x5C
	private List<NotesRecordData> notesRecordDataList; //Field offset: 0x60
	private bool autoPlay; //Field offset: 0x64
	private Int32[] autoPressLaneId; //Field offset: 0x68
	private float prevElapsedTime; //Field offset: 0x6C
	private float timeLagPerfect; //Field offset: 0x70
	private float timeLagBrilliant; //Field offset: 0x74
	private float timeLagGreat; //Field offset: 0x78
	private float timeLagBad; //Field offset: 0x7C
	private float timeLagMiss; //Field offset: 0x80
	[CompilerGenerated]
	private Action<NoteData, Int32, Single> OnJudgeTimeLag; //Field offset: 0x84
	private StageGimmickCalculator stageGimmickCalculator; //Field offset: 0x88
	private int musicId; //Field offset: 0x8C
	private int musicScoreId; //Field offset: 0x90
	private List<LaneNotesData`1<NotesRG>> laneNotesDataList; //Field offset: 0x94
	private List<LaneNotesData`1<NotesBarLine>> barLineDataList; //Field offset: 0x98

	public event Action<NoteData, Int32, Single> OnJudgeTimeLag
	{
		[CompilerGenerated]
		 add { } //Length: 130
		[CompilerGenerated]
		 remove { } //Length: 130
	}

	public event Action OnRefresh
	{
		[CompilerGenerated]
		 add { } //Length: 116
		[CompilerGenerated]
		 remove { } //Length: 116
	}

	public bool AutoPlay
	{
		 get { } //Length: 11
		 set { } //Length: 37
	}

	public int AvailableNotesCount
	{
		 get { } //Length: 355
	}

	public Camera BackCamera
	{
		 get { } //Length: 11
	}

	public float BaseBPM
	{
		 get { } //Length: 11
	}

	public private float CurrentBPM
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 18
	}

	public private float ElapsedTime
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 18
	}

	public Camera GameCamera
	{
		 get { } //Length: 11
	}

	public private bool IsPause
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public private bool IsStart
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public LaneController LaneController
	{
		 get { } //Length: 11
	}

	public int MaxNotesCount
	{
		 get { } //Length: 11
	}

	public float MeasureLengthOnView
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
		 get { } //Length: 86
	}

	public float NoteSpeedScale
	{
		 get { } //Length: 11
		 set { } //Length: 38
	}

	public List<NotesRecordData> NotesRecordDataList
	{
		 get { } //Length: 11
	}

	public float NoteTapTimingOffset
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 18
	}

	public TouchObserver TouchObserver
	{
		 get { } //Length: 11
	}

	public bool UseSyncAudioTime
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	private void _OnJudgeTimeLag(NoteData noteData, int judge, float timeLag) { }

	private static NotesManager() { }

	public NotesManager() { }

	[CompilerGenerated]
	public void add_OnJudgeTimeLag(Action<NoteData, Int32, Single> value) { }

	[CompilerGenerated]
	public void add_OnRefresh(Action value) { }

	private void AddNotesRecordData(int notesJudge, float timeLag) { }

	public void Awake() { }

	public static float BeatPerSec(float bpm) { }

	public static double BeatPerSecD(double bpm) { }

	public static float CalcActualNotesSpeed(float bpm, float speed) { }

	public float CalcNotesPosition(NoteData noteData, float elapsedTime, GameStyle gameStyle) { }

	public static int CheckFastOrSlow(int judge, float timeLag) { }

	private bool CheckMultiPressNotes(MeasureData measureData, int index, out float beat, out NoteExtensionData notesEx0, out NoteExtensionData notesEx1) { }

	private void CheckRandom(SettingData musicSettingData) { }

	public void Clear() { }

	private void ConnectionLongNotes(LaneNotesData<NotesRG> laneNotesData) { }

	private void CreateBarLine(CISModel model, NotesSkin notesSkin, StageGimmickCalculator sgc) { }

	private void CreateBarLine2(CISModel model, NotesSkin notesSkin, StageGimmickCalculator sgc) { }

	private void CreateHLine(CISModel model, NotesSkin notesSkin, StageGimmickCalculator sgc) { }

	private void DeleteAvailableNotes(LaneNotesData<NotesRG> laneNotesData, int notesIndex, NoteData noteData, int notesJudge, float deleteDelayTime, bool deleteToLink, float timeLag) { }

	public void DeleteNotesBeforeTime(float time) { }

	public void DoLateUpdate() { }

	public void DoUpdate() { }

	private NoteData FindAndLinkLongEndNote(List<NoteData> noteList, int beginIndex) { }

	public bool get_AutoPlay() { }

	public int get_AvailableNotesCount() { }

	public Camera get_BackCamera() { }

	public float get_BaseBPM() { }

	[CompilerGenerated]
	public float get_CurrentBPM() { }

	[CompilerGenerated]
	public float get_ElapsedTime() { }

	public Camera get_GameCamera() { }

	[CompilerGenerated]
	public bool get_IsPause() { }

	[CompilerGenerated]
	public bool get_IsStart() { }

	public LaneController get_LaneController() { }

	public int get_MaxNotesCount() { }

	public float get_MeasureLengthOnView() { }

	[CompilerGenerated]
	public MusicManager get_MusicManager() { }

	public float get_MusicTimingOffset() { }

	public float get_NoteSpeedScale() { }

	public List<NotesRecordData> get_NotesRecordDataList() { }

	[CompilerGenerated]
	public float get_NoteTapTimingOffset() { }

	public TouchObserver get_TouchObserver() { }

	[CompilerGenerated]
	public bool get_UseSyncAudioTime() { }

	public static float GetActualNotesSpeed(int musicId, float speed) { }

	public TimingPoint GetBeatAtSec(float sec) { }

	public float GetBPMAtBeat(float beat) { }

	public float GetBPMAtSec(float sec) { }

	private LaneNotesData<NotesRG> GetLaneNotesData(int laneId) { }

	public static float GetMaxMeasure(float bpm, float len) { }

	public float GetNearestJudgeableTimeLag(int laneId) { }

	private int GetNotesIndex(LaneNotesData<NotesRG> laneNotesData, NotesRG target) { }

	public TimingPoint GetSecAtBeat(float beat) { }

	public static float GetSecPerMeasure(float bpm, float secPerBeat = -1) { }

	[AsyncStateMachine(typeof(<Initialize>d__70))]
	public UniTask Initialize(RhythmGame rhythmGame) { }

	public bool IsValidNotesJudge(int notesJudge) { }

	private bool Judgement(int laneId, NoteExtensionData note, float timeLag, int notesIndex) { }

	private void LaneJudge(int laneId) { }

	private void LaneNotesJudge(int laneId, int notesIndex, int notesJudge, float timeLag) { }

	private void LaneRandom(int min, int max) { }

	public bool Load(CISModel model, NotesSkin notesSkin, int musicId, int musicScoreId, SettingData musicSettingData, StageGimmickCalculator sgc) { }

	private void Mirror() { }

	private void MoveUnavailableNotesList(ILaneNotesData laneNotesData, int availableNotesIndex, float deleteDelayTime) { }

	private void OuterRandom() { }

	public void Pause(bool enable) { }

	public void Play() { }

	private void ReadCISModel(CISModel model, NotesSkin notesSkin, SettingData musicSettingData, StageGimmickCalculator sgc) { }

	public void Refresh() { }

	[CompilerGenerated]
	public void remove_OnJudgeTimeLag(Action<NoteData, Int32, Single> value) { }

	[CompilerGenerated]
	public void remove_OnRefresh(Action value) { }

	public static float SecPerBeat(float bpm) { }

	public static double SecPerBeatD(double bpm) { }

	public void set_AutoPlay(bool value) { }

	[CompilerGenerated]
	private void set_CurrentBPM(float value) { }

	[CompilerGenerated]
	private void set_ElapsedTime(float value) { }

	[CompilerGenerated]
	private void set_IsPause(bool value) { }

	[CompilerGenerated]
	private void set_IsStart(bool value) { }

	[CompilerGenerated]
	private void set_MusicManager(MusicManager value) { }

	public void set_NoteSpeedScale(float value) { }

	[CompilerGenerated]
	public void set_NoteTapTimingOffset(float value) { }

	[CompilerGenerated]
	public void set_UseSyncAudioTime(bool value) { }

	private void SetAutoPlay(bool value) { }

	public void Stop() { }

	public void Terminate() { }

	public void UpdateAllLaneNotes(float elapsedTime) { }

	private void UpdateLaneAutoPlay(int laneId, float elapsedTime, LaneNotesData<NotesRG> laneNotesData) { }

	private void UpdateLaneNotes(float elapsedTime, ILaneNotesData laneNotesData) { }

	private void UpdateTimelag() { }

}

