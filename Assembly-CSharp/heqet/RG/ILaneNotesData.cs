namespace Heqet.RG;

public interface ILaneNotesData
{

	public List<NoteData> AvailableNotesList
	{
		 get { } //Length: 0
	}

	public List<NotesBase> DisplayNotesList
	{
		 get { } //Length: 0
	}

	public List<NoteData> UnavailableNotesList
	{
		 get { } //Length: 0
	}

	public NotesBase CreateNotes(NoteData noteData) { }

	public List<NoteData> get_AvailableNotesList() { }

	public List<NotesBase> get_DisplayNotesList() { }

	public List<NoteData> get_UnavailableNotesList() { }

	public void ReleaseNotes(NotesBase notes) { }

}

