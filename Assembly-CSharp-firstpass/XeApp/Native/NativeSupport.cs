namespace XeApp.Native;

public static class NativeSupport
{
	private static bool IsInit; //Field offset: 0x0
	public static bool IsSupportAndroidAudioLowLatancy; //Field offset: 0x1
	public static bool IsSupportAndroidAudioPro; //Field offset: 0x2
	public static bool IsSupportCamera; //Field offset: 0x3
	public static int AndroidDeviveSdkInt; //Field offset: 0x4
	private static string m_versionCode; //Field offset: 0x8

	public static string BuildVersion
	{
		 get { } //Length: 216
	}

	private static NativeSupport() { }

	private static void CheckAndroidNativeInfos() { }

	private static void CheckDeviceCapabilities() { }

	private static void CheckSDKVersion() { }

	public static void CopyToClipboard(string text) { }

	public static void DumpMemoryInfo() { }

	public static string get_BuildVersion() { }

	public static long GetApplicationUseMemorySize() { }

	public static int GetATTTrackingStatus() { }

	public static int GetATTTrackingType() { }

	public static long GetDisplayRealSize() { }

	public static void Init() { }

	private static void InitVersionCode() { }

	public static bool IsConnectedOutputBluetoothAudioDevice() { }

	public static void RequestStoreReviewiOS() { }

}

