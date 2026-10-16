namespace Heqet.RG;

public class LaneJudge : MonoBehaviour
{
	private enum InputState
	{
		None = 0,
		LongPress = 1,
	}

	[SerializeField]
	private Lane lane; //Field offset: 0x10
	private RhythmGame rg; //Field offset: 0x14
	[SerializeField]
	private TapEffect tapEffect; //Field offset: 0x18
	[CompilerGenerated]
	private Action<NoteData, Int32> OnJudgeBefore; //Field offset: 0x1C
	[CompilerGenerated]
	private Action<NoteData, Int32> OnJudge; //Field offset: 0x20
	private InputState inputState; //Field offset: 0x24
	private int normalNotesSeId; //Field offset: 0x28
	private int impactlNotesSeId; //Field offset: 0x2C
	private int longNotesLoopSeId; //Field offset: 0x30
	private int badJudgeSeId; //Field offset: 0x34

	public event Action<NoteData, Int32> OnJudge
	{
		[CompilerGenerated]
		 add { } //Length: 125
		[CompilerGenerated]
		 remove { } //Length: 125
	}

	public event Action<NoteData, Int32> OnJudgeBefore
	{
		[CompilerGenerated]
		 add { } //Length: 125
		[CompilerGenerated]
		 remove { } //Length: 125
	}

	public LaneJudge() { }

	[CompilerGenerated]
	public void add_OnJudge(Action<NoteData, Int32> value) { }

	[CompilerGenerated]
	public void add_OnJudgeBefore(Action<NoteData, Int32> value) { }

	private void Awake() { }

	public void DoLateUpdate() { }

	public void DoUpdate() { }

	private void EffectFunc(NoteExtensionData note, bool semi, bool bad = false) { }

	public void Initialize(RhythmGame rhythmGame) { }

	private void message(NoteData noteData, int judge) { }

	public void OnNotesJudge(int notesJudge, NoteExtensionData note) { }

	public void Pause(bool enable) { }

	[CompilerGenerated]
	public void remove_OnJudge(Action<NoteData, Int32> value) { }

	[CompilerGenerated]
	public void remove_OnJudgeBefore(Action<NoteData, Int32> value) { }

	public void SetGameParam() { }

	public void StopEffectAndSE() { }

}

