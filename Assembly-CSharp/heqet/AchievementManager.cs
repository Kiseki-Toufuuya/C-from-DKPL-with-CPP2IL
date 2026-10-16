namespace Heqet;

public class AchievementManager
{
	public static AchievementManager instance; //Field offset: 0x0
	public Queue<Int32> m_queue; //Field offset: 0x8
	private AchievementLayer m_currentLayer; //Field offset: 0xC
	private int m_phase; //Field offset: 0x10

	public AchievementManager() { }

	public void Create() { }

	public void CreateLayer(int order_d = -1) { }

	public static ValueTuple<Int32, Int32> GetAchievementCount() { }

	public static float GetAchievementRate() { }

	public static List<Int32> GetOwnedAchievementIds() { }

	public bool IsOpen(int id) { }

	public void Open(int id) { }

	public void Update() { }

}

