namespace CriWare;

public class CriAtomExAsrRack : CriDisposable
{
	internal struct Config
	{
		public float serverFrequency; //Field offset: 0x0
		public int numBuses; //Field offset: 0x4
		public int outputChannels; //Field offset: 0x8
		public SpeakerMapping speakerMapping; //Field offset: 0xC
		public int outputSamplingRate; //Field offset: 0x10
		public SoundRendererType soundRendererType; //Field offset: 0x14
		public int outputRackId; //Field offset: 0x18
		public IntPtr context; //Field offset: 0x1C

		public static Config Default() { }

	}

	internal interface IPlatformConfig
	{

		public bool IsSupportedPlatform() { }

	}

	internal class NativeMethods
	{

		public NativeMethods() { }

		internal static int criAtomExAsrRack_GetCurrentNpadId_SWITCH(int rackId, string busName) { }

		internal static int criAtomExAsrRack_GetCurrentNpadId_SWITCH2(int rackId, string busName) { }

		internal static int criAtomExAsrRack_GetCurrentUserId_PS4(int rackId, string busName) { }

		internal static int criAtomExAsrRack_IsNpadIdSettable_SWITCH(int rackId, string busName) { }

		internal static int criAtomExAsrRack_IsNpadIdSettable_SWITCH2(int rackId, string busName) { }

		internal static int criAtomExAsrRack_IsUserIdSettable_PS4(int rackId, string busName) { }

		internal static void criAtomExAsrRack_SetDefaultConfig_ANDROID_Macro(ref PlatformConfigAndroid config) { }

		internal static void criAtomExAsrRack_SetDefaultConfig_PS4_Macro(ref PlatformConfigPS4 config) { }

		internal static void criAtomExAsrRack_SetDefaultConfig_SWITCH_Macro(ref PlatformConfigSwitch config) { }

		internal static void criAtomExAsrRack_SetNpadId_SWITCH(int rackId, string busName, int npadId) { }

		internal static void criAtomExAsrRack_SetNpadId_SWITCH2(int rackId, string busName, int npadId) { }

		internal static void criAtomExAsrRack_SetUserId_PS4(int rackId, string busName, int userId) { }

	}

	internal struct PerformanceInfo
	{
		public uint processCount; //Field offset: 0x0
		public uint lastProcessTime; //Field offset: 0x4
		public uint maxProcessTime; //Field offset: 0x8
		public uint averageProcessTime; //Field offset: 0xC
		public uint lastProcessInterval; //Field offset: 0x10
		public uint maxProcessInterval; //Field offset: 0x14
		public uint averageProcessInterval; //Field offset: 0x18
		public uint lastProcessSamples; //Field offset: 0x1C
		public uint maxProcessSamples; //Field offset: 0x20
		public uint averageProcessSamples; //Field offset: 0x24

	}

	internal struct PlatformConfig
	{
		public byte reserved; //Field offset: 0x0

	}

	internal struct PlatformConfigAndroid : IPlatformConfig
	{
		public StreamType streamType; //Field offset: 0x0
		public bool enableSpatialAudio; //Field offset: 0x4

		public static PlatformConfigAndroid Default() { }

		public override bool IsSupportedPlatform() { }

	}

	internal struct PlatformConfigPS4 : IPlatformConfig
	{
		public int userId; //Field offset: 0x0
		public AudioPortType portType; //Field offset: 0x4
		public AudioPortAttribute portAttr; //Field offset: 0x8

		public static PlatformConfigPS4 Default() { }

		public override bool IsSupportedPlatform() { }

	}

	internal struct PlatformConfigSwitch : IPlatformConfig
	{
		public uint npadId; //Field offset: 0x0

		public static PlatformConfigSwitch Default() { }

		public override bool IsSupportedPlatform() { }

	}

	internal enum StreamType
	{
		Music = 0,
		Alarm = 1,
		Dtmf = 2,
		Notification = 3,
		Ring = 4,
		System = 5,
		VoiceCall = 6,
	}

	[CompilerGenerated]
	private static readonly CriAtomExAsrRack <Default>k__BackingField; //Field offset: 0x0
	public const int defaultRackId = 0; //Field offset: 0x0
	public const int IllegalRackId = -1; //Field offset: 0x0
	private int _rackId; //Field offset: 0x18
	private bool hasExistingRackId; //Field offset: 0x1C

	public static CriAtomExAsrRack Default
	{
		[CompilerGenerated]
		 get { } //Length: 60
	}

	[Obsolete("Use CriAtomExAsrRack.Config.Default")]
	public static Config defaultConfig
	{
		 get { } //Length: 63
	}

	public int rackId
	{
		 get { } //Length: 11
	}

	private static CriAtomExAsrRack() { }

	public CriAtomExAsrRack(int existingRackId) { }

	[Obsolete("Use CriAtomExAsrRack.CriAtomExAsrRack(Config config, IPlatformConfig platformConfig)")]
	public CriAtomExAsrRack(Config config, PlatformConfig platformConfig) { }

	public CriAtomExAsrRack(Config config, IPlatformConfig platformConfig) { }

	public void ApplyDspBusSnapshot(string snapshotName, int timeMs) { }

	public void AttachDspBusSetting(string settingName) { }

	private static void criAtomExAsrRack_ApplyDspBusSnapshot(int rackId, string snapshotName, int timeMs) { }

	private static void criAtomExAsrRack_AttachDspBusSetting(int rackId, string setting, IntPtr work, int workSize) { }

	private static int criAtomExAsrRack_Create(in Config config, IntPtr work, int work_size) { }

	private static void criAtomExAsrRack_Destroy(int rackId) { }

	private static void criAtomExAsrRack_DetachDspBusSetting(int rackId) { }

	private static int criAtomExAsrRack_GetAmbisonicRackId() { }

	private static IntPtr criAtomExAsrRack_GetAppliedDspBusSnapshotName(int rackId) { }

	private static int criAtomExAsrRack_GetChannelBasedAudioRackId() { }

	private static void criAtomExAsrRack_GetNumRenderedSamples(int rack_id, ref long num_samples, ref int sampling_rate) { }

	private static int criAtomExAsrRack_GetObjectBasedAudioRackId() { }

	private static int criAtomExAsrRack_GetPassThroughRackId() { }

	private static void criAtomExAsrRack_GetPerformanceInfo(int rackId, out PerformanceInfo perfInfo) { }

	private static void criAtomExAsrRack_ResetPerformanceMonitor(int rackId) { }

	private static void criAtomExAsrRack_SetAisacControlById(int rackId, ushort controlId, float value) { }

	private static void criAtomExAsrRack_SetAisacControlByName(int rackId, string controlName, float value) { }

	private static void CRIWARE97C88CCE(ref Config config) { }

	private static int CRIWAREE14A600F(in Config config, in PlatformConfig platformConfig) { }

	public void DetachDspBusSetting() { }

	public virtual void Dispose() { }

	protected virtual void Finalize() { }

	[CompilerGenerated]
	public static CriAtomExAsrRack get_Default() { }

	public static Config get_defaultConfig() { }

	public int get_rackId() { }

	public static int GetAmbisonicRackId() { }

	public static string GetAppliedDspBusSnapshotName(int rackId) { }

	public string GetAppliedDspBusSnapshotName() { }

	public static int GetChannelBasedAudioRackId() { }

	public int GetCurrentNpadIdSWITCH(string busName) { }

	public int GetCurrentNpadIdSWITCH2(string busName) { }

	public int GetCurrentUserIdPS4(string busName) { }

	public static void GetNumRenderedSamples(int rackId, out long numSamples, out int samplingRate) { }

	public static int GetObjectBasedAudioRackId() { }

	public static int GetPassThroughRackId() { }

	public PerformanceInfo GetPerformanceInfo() { }

	public static PerformanceInfo GetPerformanceInfoByRackId(int rackId = 0) { }

	public bool IsNpadIdSettableSWITCH(string busName) { }

	public bool IsNpadIdSettableSWITCH2(string busName) { }

	public bool IsUserIdSettablePS4(string busName) { }

	public void ResetPerformanceMonitor() { }

	public static void ResetPerformanceMonitorByRackId(int rackId = 0) { }

	public static void SetAisacControl(int rackId, int controlId, float value) { }

	public static void SetAisacControl(int rackId, string controlName, float value) { }

	public static void SetDefaultConfig(ref Config config) { }

	public static void SetDefaultConfig_ANDROID(ref PlatformConfigAndroid platformConfig) { }

	public static void SetDefaultConfig_PS4(ref PlatformConfigPS4 platformConfig) { }

	public static void SetDefaultConfig_SWITCH(ref PlatformConfigSwitch platformConfig) { }

	public void SetNpadIdSWITCH(string busName, int npadId) { }

	public void SetNpadIdSWITCH2(string busName, int npadId) { }

	public void SetUserIdPS4(string busName, int userId) { }

}

