namespace Heqet.RG;

public abstract class NotesBase : MonoBehaviour
{
	public NoteExtensionData extension; //Field offset: 0x10
	protected NoteData noteData; //Field offset: 0x14
	protected Vector3 begin; //Field offset: 0x18
	protected GameStyle gameStyle; //Field offset: 0x24
	protected NotesManager notesManager; //Field offset: 0x28
	public int ColorNumber; //Field offset: 0x2C
	protected StageGimmickCalculator stageGimmickCalculator; //Field offset: 0x30

	protected NotesBase() { }

	public override void Initialize(NotesManager nm_, GameObject beginObject, NoteData noteData_, StageGimmickCalculator sgc) { }

	public override void UpdateNotes(float elapsedTime) { }

}

