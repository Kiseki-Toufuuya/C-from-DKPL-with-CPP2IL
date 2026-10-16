namespace XeApp.Game;

public class MemoryUsageText : MonoBehaviour
{
	[SerializeField]
	private Text MemoryText; //Field offset: 0x10
	private StringBuilder sb; //Field offset: 0x14
	private int frame; //Field offset: 0x18

	public MemoryUsageText() { }

	private void BuildSizeString(long byteSize) { }

	private void Update() { }

	private void UpdateText() { }

}

