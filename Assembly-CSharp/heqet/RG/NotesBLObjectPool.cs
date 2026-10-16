namespace Heqet.RG;

public class NotesBLObjectPool : NotesObjectPool<NotesBarLine>
{

	public NotesBLObjectPool() { }

	protected virtual NotesBarLine Create(int type) { }

	public virtual void Initialize(NotesSkin notesSkin_) { }

}

