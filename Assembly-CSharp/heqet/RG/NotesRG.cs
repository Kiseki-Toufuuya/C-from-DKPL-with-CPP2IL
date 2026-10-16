namespace Heqet.RG;

public class NotesRG : NotesBase
{
	private Lane lane; //Field offset: 0x34
	[SerializeField]
	private GameObject noteNormal; //Field offset: 0x38
	[SerializeField]
	private GameObject noteAttack; //Field offset: 0x3C
	[SerializeField]
	private GameObject top; //Field offset: 0x40
	[SerializeField]
	private GameObject bootom; //Field offset: 0x44
	[SerializeField]
	private LineRenderer linkLine; //Field offset: 0x48
	[SerializeField]
	private GameObject linkTarget; //Field offset: 0x4C
	[SerializeField]
	private LineRenderer multiPressLine; //Field offset: 0x50
	[SerializeField]
	private Texture lineMiddle; //Field offset: 0x54
	private Sprite normalNotesSprite; //Field offset: 0x58
	private Sprite attackNotesSprite; //Field offset: 0x5C
	public Sprite mineNotes; //Field offset: 0x60
	public Sprite moneyNotes; //Field offset: 0x64
	public Sprite yukkuriNotes; //Field offset: 0x68

	public Lane Lane
	{
		 get { } //Length: 11
	}

	public LineRenderer MultiPressLine
	{
		 get { } //Length: 11
	}

	public NotesRG() { }

	private void ApplyGimmick(StageGimmickCalculator sgc) { }

	private void Awake() { }

	private void dbgInit() { }

	private void dbgUpdate(float z) { }

	public Lane get_Lane() { }

	public LineRenderer get_MultiPressLine() { }

	public virtual void Initialize(NotesManager nm_, GameObject beginObject, NoteData noteData_, StageGimmickCalculator sgc) { }

	public void Setup() { }

	public void UpdateLine() { }

	public virtual void UpdateNotes(float elapsedTime) { }

}

