namespace XeApp.Game;

public class EventProfilerManager
{
	internal enum GroupID
	{
		Boot = 0,
		Title = 1,
		MasterLoad = 2,
		PlayerLoad = 3,
		Download = 4,
		HakoniwaMapLoad = 5,
		RythmGameLoad = 6,
		HomeLoad = 7,
		HakoniwaSpotLoad = 8,
		HomeCharacterLoad = 9,
		HomeStageSelectLoad = 10,
		FormationLoad = 11,
		PartyChangeLoad = 12,
		LiveFormationLoad = 13,
		ResultLoad = 14,
		ResultStageSelectLoad = 15,
		HomeGachaLoad = 16,
		GachaPurchase = 17,
		TravelLoad = 18,
		NUM = 19,
	}

	private static List<EventProfiler> Profilers; //Field offset: 0x0
	private static bool init; //Field offset: 0x4

	private static EventProfilerManager() { }

	public EventProfilerManager() { }

	private static void Init() { }

	[Conditional("GAME_DEBUG")]
	public static void Lap(GroupID grp, string label) { }

	[Conditional("GAME_DEBUG")]
	public static void Save(GroupID grp) { }

	[Conditional("GAME_DEBUG")]
	public static void Start(GroupID grp, string label) { }

	[Conditional("GAME_DEBUG")]
	public static void Stop(GroupID grp, string label) { }

}

