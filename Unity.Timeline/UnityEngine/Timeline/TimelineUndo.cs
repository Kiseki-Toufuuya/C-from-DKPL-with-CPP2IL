namespace UnityEngine.Timeline;

internal static class TimelineUndo
{

	internal static bool undoEnabled
	{
		internal get { } //Length: 3
	}

	internal static bool get_undoEnabled() { }

	public static void PushDestroyUndo(TimelineAsset timeline, object thingToDirty, object objectToDestroy) { }

	[Conditional("UNITY_EDITOR")]
	public static void PushUndo(Object[] thingsToDirty, string operation) { }

	[Conditional("UNITY_EDITOR")]
	public static void PushUndo(object thingToDirty, string operation) { }

	[Conditional("UNITY_EDITOR")]
	public static void RegisterCreatedObjectUndo(object thingCreated, string operation) { }

	internal static string UndoName(string name) { }

}

