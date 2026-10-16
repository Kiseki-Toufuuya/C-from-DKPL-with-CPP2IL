namespace UnityEngine.Playables;

[Extension]
public static class PlayableOutputExtensions
{

	[Extension]
	public static void AddNotificationReceiver(U output, INotificationReceiver receiver) { }

	[Extension]
	public static int GetSourceOutputPort(U output) { }

	[Extension]
	public static Playable GetSourcePlayable(U output) { }

	[Extension]
	public static void PushNotification(U output, Playable origin, INotification notification, object context = null) { }

	[Extension]
	public static void SetReferenceObject(U output, object value) { }

	[Extension]
	public static void SetSourcePlayable(U output, V value) { }

	[Extension]
	public static void SetSourcePlayable(U output, V value, int port) { }

	[Extension]
	public static void SetUserData(U output, object value) { }

	[Extension]
	public static void SetWeight(U output, float value) { }

}

