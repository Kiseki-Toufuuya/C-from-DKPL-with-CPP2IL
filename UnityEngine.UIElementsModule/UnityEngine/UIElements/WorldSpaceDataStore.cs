namespace UnityEngine.UIElements;

internal static class WorldSpaceDataStore
{
	private static Dictionary<UInt32, WorldSpaceData> m_WorldSpaceData; //Field offset: 0x0

	private static WorldSpaceDataStore() { }

	public static WorldSpaceData GetWorldSpaceData(VisualElement ve) { }

	public static void SetWorldSpaceData(VisualElement ve, WorldSpaceData data) { }

}

