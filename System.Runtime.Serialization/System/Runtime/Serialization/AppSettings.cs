namespace System.Runtime.Serialization;

internal static class AppSettings
{
	internal const string MaxMimePartsAppSettingsString = "microsoft:xmldictionaryreader:maxmimeparts"; //Field offset: 0x0
	private const int DefaultMaxMimeParts = 1000; //Field offset: 0x0
	private static int maxMimeParts; //Field offset: 0x0
	private static bool settingsInitalized; //Field offset: 0x4
	private static object appSettingsLock; //Field offset: 0x8

	internal static int MaxMimeParts
	{
		internal get { } //Length: 70
	}

	private static AppSettings() { }

	private static void EnsureSettingsLoaded() { }

	internal static int get_MaxMimeParts() { }

}

