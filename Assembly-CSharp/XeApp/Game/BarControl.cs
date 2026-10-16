namespace XeApp.Game;

public class BarControl : MonoBehaviour
{
	internal enum ControlType
	{
		MemoryMax = 0,
		MemoryCurrent = 1,
		CpuMax = 2,
		CpuCur = 3,
		MemoryApp = 4,
	}

	private const float FULL_SIZE = 1000; //Field offset: 0x0
	private const float BAR_SIZE = 4; //Field offset: 0x0
	private const long TARGET_MEMORY_SIZE = 1073741824; //Field offset: 0x0
	private const long SafeSize = 524288000; //Field offset: 0x0
	private const long WarningSize = 734003200; //Field offset: 0x0
	private const long AlertSize = 943718400; //Field offset: 0x0
	private Image barImage; //Field offset: 0x10
	[SerializeField]
	private ControlType controlType; //Field offset: 0x14
	private RectTransform rectTransform; //Field offset: 0x18
	private int updateWait; //Field offset: 0x1C

	public BarControl() { }

	private void Awake() { }

	private float GetLength() { }

	private int GetUpdateWait() { }

	private void Update() { }

	private void UpdateGuage() { }

}

