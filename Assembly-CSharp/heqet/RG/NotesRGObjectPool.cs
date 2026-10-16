namespace Heqet.RG;

public class NotesRGObjectPool : NotesObjectPool<NotesRG>
{

	public NotesRGObjectPool() { }

	protected virtual NotesRG Create(int type) { }

	public virtual void Initialize(NotesSkin notesSkin_) { }

}

