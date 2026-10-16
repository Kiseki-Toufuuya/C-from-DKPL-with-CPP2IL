namespace Heqet.StoryMode;

public class SpotManager : MonoBehaviour
{
	private static float s_MapFadeDuration; //Field offset: 0x0
	[SerializeField]
	public List<Area> areaList; //Field offset: 0x10
	[SerializeField]
	public List<SpotPoint> spotList; //Field offset: 0x14
	[SerializeField]
	public GameObject spotSectorRoot; //Field offset: 0x18
	private SpotSector[] m_sectorList; //Field offset: 0x1C
	private int m_currentIndex; //Field offset: 0x20
	private bool m_isSpotMode; //Field offset: 0x24
	private Tween m_mapChipTween; //Field offset: 0x28

	public SpotPoint current
	{
		 get { } //Length: 67
		 set { } //Length: 228
	}

	public int currentIndex
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static SpotManager() { }

	public SpotManager() { }

	[CompilerGenerated]
	private void <Awake>b__16_0(float value) { }

	[CompilerGenerated]
	private void <InitMapChipTween>b__26_0(float tweenValue) { }

	private void Awake() { }

	public void ChangeMapChipDispMode(bool isSpotMode, bool isImmediate = false) { }

	private void ChangeSectorSortLayer() { }

	private int FindListndex(SpotPoint point) { }

	public SpotPoint get_current() { }

	public int get_currentIndex() { }

	private void InitMapChipTween() { }

	public static bool IsEpisodeIconVisible(SpotPoint spot) { }

	public static bool isOpenSpot(WorldSpotModel spotModel) { }

	public SpotPoint OffsetIndex(int offset, ref int currentIndex) { }

	public void set_current(SpotPoint value) { }

	public void set_currentIndex(int value) { }

	private void Update() { }

	public void UpdateCloud() { }

	public void UpdateDisplay() { }

	[ContextMenu("UpdateList")]
	private void UpdateLink() { }

	public void UpdateSector() { }

	public static void UpdateSpotDisplay(SpotPoint spot) { }

}

