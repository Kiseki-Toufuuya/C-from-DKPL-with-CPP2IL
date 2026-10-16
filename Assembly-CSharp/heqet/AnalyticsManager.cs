namespace Heqet;

public class AnalyticsManager : MonoBehaviour
{
	private static AnalyticsManager instance; //Field offset: 0x0
	[CompilerGenerated]
	private bool <IsInitialized>k__BackingField; //Field offset: 0x10

	public static AnalyticsManager Instance
	{
		 get { } //Length: 40
	}

	public private bool IsInitialized
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public AnalyticsManager() { }

	private void Awake() { }

	public static AnalyticsManager get_Instance() { }

	[CompilerGenerated]
	public bool get_IsInitialized() { }

	public bool GetStat(string name, out int value) { }

	public bool GetStat(string name, out float value) { }

	public bool Initialize() { }

	[CompilerGenerated]
	private void set_IsInitialized(bool value) { }

	public bool SetStat(string name, int value) { }

	public bool SetStat(string name, float value) { }

	public bool StoreStats() { }

	public bool UpdateAvgRateStat(string name, float flCountThisSession, double dSessionLength) { }

	private void UpdateHeroineCount() { }

	private void UpdateMitamaCardCount() { }

}

