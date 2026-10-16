namespace XeApp.Game;

public class CMContentLog : MonoBehaviour
{
	private StringBuilder sb; //Field offset: 0x10
	[SerializeField]
	private Text TextLog; //Field offset: 0x14
	private LogDataSet WatchLog; //Field offset: 0x18
	private long PrevCounter; //Field offset: 0x20
	private RectTransform rectTransform; //Field offset: 0x28

	public CMContentLog() { }

	private void Awake() { }

	public void Init(LogDataSet dataSet) { }

	private void Update() { }

	private void UpdateLogText() { }

}

