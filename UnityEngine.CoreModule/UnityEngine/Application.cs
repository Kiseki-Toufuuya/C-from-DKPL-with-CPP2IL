namespace UnityEngine;

[NativeHeader("Runtime/Utilities/URLUtility.h")]
[NativeHeader("Runtime/Application/AdsIdHandler.h")]
[NativeHeader("Runtime/Input/TargetFrameRate.h")]
[NativeHeader("Runtime/Input/InputManager.h")]
[NativeHeader("Runtime/Application/ApplicationInfo.h")]
[NativeHeader("Runtime/BaseClasses/IsPlaying.h")]
[NativeHeader("Runtime/Export/Application/Application.bindings.h")]
[NativeHeader("Runtime/Utilities/Argv.h")]
[NativeHeader("Runtime/Input/GetInput.h")]
[NativeHeader("Runtime/Misc/Player.h")]
[NativeHeader("Runtime/Misc/PlayerSettings.h")]
[NativeHeader("Runtime/Misc/SystemInfo.h")]
[NativeHeader("Runtime/Network/NetworkUtility.h")]
[NativeHeader("Runtime/PreloadManager/LoadSceneOperation.h")]
[NativeHeader("Runtime/PreloadManager/PreloadManager.h")]
[NativeHeader("Runtime/Logging/LogSystem.h")]
[NativeHeader("Runtime/Misc/BuildSettings.h")]
[NativeHeader("Runtime/File/ApplicationSpecificPersistentDataPath.h")]
public class Application
{
	internal sealed class LogCallback : MulticastDelegate
	{

		public LogCallback(object object, IntPtr method) { }

		public override void Invoke(string condition, string stackTrace, LogType type) { }

	}

	internal sealed class LowMemoryCallback : MulticastDelegate
	{

		public LowMemoryCallback(object object, IntPtr method) { }

		public override void Invoke() { }

	}

	internal sealed class MemoryUsageChangedCallback : MulticastDelegate
	{

		public MemoryUsageChangedCallback(object object, IntPtr method) { }

		public override void Invoke(in ApplicationMemoryUsageChange usage) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static LowMemoryCallback lowMemory; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static MemoryUsageChangedCallback memoryUsageChanged; //Field offset: 0x4
	private static LogCallback s_LogCallbackHandler; //Field offset: 0x8
	private static LogCallback s_LogCallbackHandlerThreaded; //Field offset: 0xC
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<Boolean> focusChanged; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<String> deepLinkActivated; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Func<Boolean> wantsToQuit; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action quitting; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action unloading; //Field offset: 0x20
	private static CancellationTokenSource s_currentCancellationTokenSource; //Field offset: 0x24

	public static event Action<Boolean> focusChanged
	{
		[CompilerGenerated]
		 add { } //Length: 196
		[CompilerGenerated]
		 remove { } //Length: 196
	}

	public static event LogCallback logMessageReceived
	{
		 add { } //Length: 222
		 remove { } //Length: 188
	}

	public static event LowMemoryCallback lowMemory
	{
		[CompilerGenerated]
		 add { } //Length: 173
		[CompilerGenerated]
		 remove { } //Length: 173
	}

	public static event Action quitting
	{
		[CompilerGenerated]
		 add { } //Length: 177
		[CompilerGenerated]
		 remove { } //Length: 177
	}

	public static string buildGUID
	{
		[FreeFunction("Application_Bindings::GetBuildGUID")]
		 get { } //Length: 265
	}

	public static string cloudProjectId
	{
		[FreeFunction("GetPlayerSettings().GetCloudProjectId")]
		 get { } //Length: 265
	}

	public static string dataPath
	{
		[FreeFunction("GetAppDataPath", IsThreadSafe = True)]
		 get { } //Length: 265
	}

	public static string identifier
	{
		[FreeFunction("GetApplicationInfo().GetApplicationIdentifier")]
		 get { } //Length: 265
	}

	public static bool isBatchMode
	{
		[FreeFunction("::IsBatchmode")]
		 get { } //Length: 29
	}

	public static bool isEditor
	{
		 get { } //Length: 3
	}

	public static bool isFocused
	{
		[FreeFunction("IsPlayerFocused")]
		 get { } //Length: 29
	}

	public static bool isPlaying
	{
		[FreeFunction("IsWorldPlaying")]
		 get { } //Length: 29
	}

	public static string persistentDataPath
	{
		[FreeFunction("GetPersistentDataPathApplicationSpecific")]
		 get { } //Length: 265
	}

	public static RuntimePlatform platform
	{
		[FreeFunction("systeminfo::GetRuntimePlatform", IsThreadSafe = True)]
		 get { } //Length: 29
	}

	public static string productName
	{
		[FreeFunction("GetPlayerSettings().GetProductName")]
		 get { } //Length: 265
	}

	public static bool runInBackground
	{
		[FreeFunction("GetPlayerSettingsRunInBackground")]
		 get { } //Length: 29
		[FreeFunction("SetPlayerSettingsRunInBackground")]
		 set { } //Length: 40
	}

	public static string streamingAssetsPath
	{
		[FreeFunction("GetStreamingAssetsPath", IsThreadSafe = True)]
		 get { } //Length: 265
	}

	public static SystemLanguage systemLanguage
	{
		[FreeFunction("(SystemLanguage)systeminfo::GetSystemLanguage")]
		 get { } //Length: 29
	}

	public static int targetFrameRate
	{
		[FreeFunction("GetTargetFrameRate")]
		 get { } //Length: 29
		[FreeFunction("SetTargetFrameRate")]
		 set { } //Length: 40
	}

	public static string temporaryCachePath
	{
		[FreeFunction("GetTemporaryCachePathApplicationSpecific")]
		 get { } //Length: 265
	}

	public static string version
	{
		[FreeFunction("GetApplicationInfo().GetVersion")]
		 get { } //Length: 265
	}

	private static Application() { }

	[CompilerGenerated]
	public static void add_focusChanged(Action<Boolean> value) { }

	public static void add_logMessageReceived(LogCallback value) { }

	[CompilerGenerated]
	public static void add_lowMemory(LowMemoryCallback value) { }

	[CompilerGenerated]
	public static void add_quitting(Action value) { }

	[RequiredByNativeCode]
	private static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread) { }

	[RequiredByNativeCode]
	internal static void CallLowMemory(ApplicationMemoryUsage usage) { }

	[FreeFunction("Application_Bindings::GetBuildGUID")]
	public static string get_buildGUID() { }

	private static void get_buildGUID_Injected(out ManagedSpanWrapper ret) { }

	[FreeFunction("GetPlayerSettings().GetCloudProjectId")]
	public static string get_cloudProjectId() { }

	private static void get_cloudProjectId_Injected(out ManagedSpanWrapper ret) { }

	[FreeFunction("GetAppDataPath", IsThreadSafe = True)]
	public static string get_dataPath() { }

	private static void get_dataPath_Injected(out ManagedSpanWrapper ret) { }

	[FreeFunction("GetApplicationInfo().GetApplicationIdentifier")]
	public static string get_identifier() { }

	private static void get_identifier_Injected(out ManagedSpanWrapper ret) { }

	[FreeFunction("::IsBatchmode")]
	public static bool get_isBatchMode() { }

	public static bool get_isEditor() { }

	[FreeFunction("IsPlayerFocused")]
	public static bool get_isFocused() { }

	[FreeFunction("IsWorldPlaying")]
	public static bool get_isPlaying() { }

	[FreeFunction("GetPersistentDataPathApplicationSpecific")]
	public static string get_persistentDataPath() { }

	private static void get_persistentDataPath_Injected(out ManagedSpanWrapper ret) { }

	[FreeFunction("systeminfo::GetRuntimePlatform", IsThreadSafe = True)]
	public static RuntimePlatform get_platform() { }

	[FreeFunction("GetPlayerSettings().GetProductName")]
	public static string get_productName() { }

	private static void get_productName_Injected(out ManagedSpanWrapper ret) { }

	[FreeFunction("GetPlayerSettingsRunInBackground")]
	public static bool get_runInBackground() { }

	[FreeFunction("GetStreamingAssetsPath", IsThreadSafe = True)]
	public static string get_streamingAssetsPath() { }

	private static void get_streamingAssetsPath_Injected(out ManagedSpanWrapper ret) { }

	[FreeFunction("(SystemLanguage)systeminfo::GetSystemLanguage")]
	public static SystemLanguage get_systemLanguage() { }

	[FreeFunction("GetTargetFrameRate")]
	public static int get_targetFrameRate() { }

	[FreeFunction("GetTemporaryCachePathApplicationSpecific")]
	public static string get_temporaryCachePath() { }

	private static void get_temporaryCachePath_Injected(out ManagedSpanWrapper ret) { }

	[FreeFunction("GetApplicationInfo().GetVersion")]
	public static string get_version() { }

	private static void get_version_Injected(out ManagedSpanWrapper ret) { }

	[RequiredByNativeCode]
	internal static bool HasLogCallback() { }

	[RequiredByNativeCode]
	private static void Internal_ApplicationQuit() { }

	[RequiredByNativeCode]
	private static void Internal_ApplicationUnload() { }

	[RequiredByNativeCode]
	private static bool Internal_ApplicationWantsToQuit() { }

	[RequiredByNativeCode]
	private static void Internal_InitializeExitCancellationToken() { }

	[RequiredByNativeCode]
	private static void Internal_RaiseExitCancellationToken() { }

	[RequiredByNativeCode]
	internal static void InvokeDeepLinkActivated(string url) { }

	[RequiredByNativeCode]
	internal static void InvokeFocusChanged(bool focus) { }

	[RequiredByNativeCode]
	internal static void InvokeOnBeforeRender() { }

	[FreeFunction("OpenURL")]
	public static void OpenURL(string url) { }

	private static void OpenURL_Injected(ref ManagedSpanWrapper url) { }

	public static void Quit() { }

	[FreeFunction("GetInputManager().QuitApplication")]
	public static void Quit(int exitCode) { }

	[CompilerGenerated]
	public static void remove_focusChanged(Action<Boolean> value) { }

	public static void remove_logMessageReceived(LogCallback value) { }

	[CompilerGenerated]
	public static void remove_lowMemory(LowMemoryCallback value) { }

	[CompilerGenerated]
	public static void remove_quitting(Action value) { }

	[FreeFunction("SetPlayerSettingsRunInBackground")]
	public static void set_runInBackground(bool value) { }

	[FreeFunction("SetTargetFrameRate")]
	public static void set_targetFrameRate(int value) { }

	[FreeFunction("Application_Bindings::SetLogCallbackDefined")]
	private static void SetLogCallbackDefined(bool defined) { }

}

