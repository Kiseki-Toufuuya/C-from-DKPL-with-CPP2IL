namespace CriWare;

public class CriManaMoviePlayerHolder : CriMonoBehaviour
{
	private Player _player; //Field offset: 0x20

	public Player player
	{
		 set { } //Length: 27
	}

	public CriManaMoviePlayerHolder() { }

	private void Awake() { }

	public virtual void CriInternalLateUpdate() { }

	public virtual void CriInternalUpdate() { }

	public void set_player(Player value) { }

	private void Start() { }

}

