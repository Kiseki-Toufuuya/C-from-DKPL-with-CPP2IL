namespace Heqet.RG;

public class LaneNotesData : ILaneNotesData
{
	private Lane lane; //Field offset: 0x0
	private List<NoteData> availableNotesList; //Field offset: 0x0
	private List<NoteData> unavailableNotesList; //Field offset: 0x0
	private List<NotesBase> displayNotesList; //Field offset: 0x0
	public bool longPress; //Field offset: 0x0
	private INotesObjectPool notesObjectPool; //Field offset: 0x0
	private NotesManager notesManager; //Field offset: 0x0
	private StageGimmickCalculator sgc; //Field offset: 0x0
	private GameObject beginObject; //Field offset: 0x0

	public override List<NoteData> AvailableNotesList
	{
		 get { } //Length: 11
	}

	public override List<NotesBase> DisplayNotesList
	{
		 get { } //Length: 11
	}

	public Lane Lane
	{
		 get { } //Length: 11
	}

	public override List<NoteData> UnavailableNotesList
	{
		 get { } //Length: 11
	}

	public LaneNotesData`1(INotesObjectPool notesObjectPool_, NotesManager notesManager_, StageGimmickCalculator sgc_, GameObject beginObject_) { }

	public override NotesBase CreateNotes(NoteData noteData) { }

	public override List<NoteData> get_AvailableNotesList() { }

	public override List<NotesBase> get_DisplayNotesList() { }

	public Lane get_Lane() { }

	public override List<NoteData> get_UnavailableNotesList() { }

	public override void ReleaseNotes(NotesBase notes) { }

	public void SetBeginObject(GameObject beginObject_) { }

}

