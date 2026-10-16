namespace Heqet.RG;

public abstract class NotesObjectPool : INotesObjectPool
{
	private const int DefaultPoolSize = 128; //Field offset: 0x0
	private const int GrowPoolSize = 4; //Field offset: 0x0
	private const int NotesTypeCount = 2; //Field offset: 0x0
	protected GameObject root; //Field offset: 0x0
	private int currentPoolSize; //Field offset: 0x0
	private NotesSkin notesSkin; //Field offset: 0x0
	private List<TNotes>[] notesPoolArray; //Field offset: 0x0

	public override bool IsInitialized
	{
		 get { } //Length: 15
	}

	public NotesSkin NotesSkin
	{
		 get { } //Length: 11
	}

	private TNotes _Get(int n) { }

	protected NotesObjectPool`1() { }

	private void AddPoolItems(int colorNumber, int count) { }

	protected abstract TNotes Create(int type) { }

	public override NotesBase Get(int colorNumber) { }

	public override bool get_IsInitialized() { }

	public NotesSkin get_NotesSkin() { }

	public override void Initialize(NotesSkin notesSkin_) { }

	public override void Release(NotesBase notes) { }

}

