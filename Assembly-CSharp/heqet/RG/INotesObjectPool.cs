namespace Heqet.RG;

public interface INotesObjectPool
{

	public bool IsInitialized
	{
		 get { } //Length: 0
	}

	public NotesBase Get(int colorNumber) { }

	public bool get_IsInitialized() { }

	public void Release(NotesBase notes) { }

}

