namespace XeApp.Game;

public class ServerTimeText : MonoBehaviour
{
	[SerializeField]
	private Text TimeText; //Field offset: 0x10
	private StringBuilder sb; //Field offset: 0x14
	private long prevTime; //Field offset: 0x18

	public ServerTimeText() { }

	private void Update() { }

	private void UpdateText(long currentTime) { }

}

