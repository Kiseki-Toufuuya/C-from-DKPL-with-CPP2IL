namespace CriWare;

public static class CriAtomEx
{
	internal struct AisacControlInfo
	{
		public readonly string name; //Field offset: 0x0
		public uint id; //Field offset: 0x4

		public AisacControlInfo(Byte[] data, int startIndex) { }

	}

	internal struct AisacInfo
	{
		public readonly string name; //Field offset: 0x0
		public bool defaultControlFlag; //Field offset: 0x4
		public float defaultControlValue; //Field offset: 0x8
		public uint controlId; //Field offset: 0xC
		public readonly string controlName; //Field offset: 0x10

		public AisacInfo(Byte[] data, int startIndex) { }

	}

	internal enum BiquadFilterType
	{
		Off = 0,
		LowPass = 1,
		HighPass = 2,
		Notch = 3,
		LowShelf = 4,
		HighShelf = 5,
		Peaking = 6,
	}

	internal enum CharacterEncoding
	{
		Utf8 = 0,
		Sjis = 1,
	}

	internal struct CueInfo
	{
		public int id; //Field offset: 0x0
		public CueType type; //Field offset: 0x4
		public readonly string name; //Field offset: 0x8
		public readonly string userData; //Field offset: 0xC
		public long length; //Field offset: 0x10
		public UInt16[] categories; //Field offset: 0x18
		public short numLimits; //Field offset: 0x1C
		public ushort numBlocks; //Field offset: 0x1E
		public ushort numTracks; //Field offset: 0x20
		public ushort numRelatedWaveForms; //Field offset: 0x22
		public byte priority; //Field offset: 0x24
		public byte headerVisibility; //Field offset: 0x25
		public byte ignore_player_parameter; //Field offset: 0x26
		public byte probability; //Field offset: 0x27
		public PanType panType; //Field offset: 0x28
		public CuePos3dInfo pos3dInfo; //Field offset: 0x2C
		public GameVariableInfo gameVariableInfo; //Field offset: 0x6C
		public float volume; //Field offset: 0x78
		public SilentMode silentMode; //Field offset: 0x7C
		public float pitch; //Field offset: 0x80
		public ushort selectorIndex; //Field offset: 0x84

		public CueInfo(Byte[] data, int startIndex) { }

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	internal sealed class CueLinkCbFunc : MulticastDelegate
	{

		public CueLinkCbFunc(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ref CueLinkInfo info, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref CueLinkInfo info, IAsyncResult result) { }

		public override void Invoke(ref CueLinkInfo info) { }

	}

	internal struct CueLinkInfo
	{
		public IntPtr nativePlayerHn; //Field offset: 0x0
		public uint basePlaybackId; //Field offset: 0x4
		public uint targetPlaybackId; //Field offset: 0x8
		public int cueLinkType; //Field offset: 0xC

	}

	internal struct CuePos3dInfo
	{
		public float coneInsideAngle; //Field offset: 0x0
		public float coneOutsideAngle; //Field offset: 0x4
		public float coneOutsideVolume; //Field offset: 0x8
		public float minAttenuationDistance; //Field offset: 0xC
		public float maxAttenuationDistance; //Field offset: 0x10
		public float sourceRadius; //Field offset: 0x14
		public float interiorDistance; //Field offset: 0x18
		public float dopplerFactor; //Field offset: 0x1C
		public Randomize3dConfig randomPos; //Field offset: 0x20
		public uint distanceAisacControl; //Field offset: 0x2C
		public uint listenerBaseAngleAisacControl; //Field offset: 0x30
		public uint sourceBaseAngleAisacControl; //Field offset: 0x34
		public uint listenerBaseElevationAisacControl; //Field offset: 0x38
		public uint sourceBaseElevationAisacControl; //Field offset: 0x3C

		public CuePos3dInfo(Byte[] data, int startIndex) { }

	}

	internal enum CueType
	{
		Polyphonic = 0,
		Sequential = 1,
		Shuffle = 2,
		Random = 3,
		RandomNoRepeat = 4,
		SwitchGameVariable = 5,
		ComboSequential = 6,
		SwitchSelector = 7,
		TrackTransitionBySelector = 8,
	}

	internal enum CurveType
	{
		Linear = 0,
		Square = 1,
		SquareReverse = 2,
		SCurve = 3,
		FlatAtHalf = 4,
	}

	internal enum Format
	{
		ADX = 1,
		HCA = 3,
		HCA_MX = 4,
		WAVE = 5,
		RAW_PCM = 6,
		AUDIO_BUFFER = 9,
		HW1 = 65537,
		HW2 = 65538,
		HW3 = 65539,
		MP3 = 65539,
	}

	internal struct FormatInfo
	{
		public Format format; //Field offset: 0x0
		public int samplingRate; //Field offset: 0x4
		public long numSamples; //Field offset: 0x8
		public long loopOffset; //Field offset: 0x10
		public long loopLength; //Field offset: 0x18
		public int numChannels; //Field offset: 0x20
		public uint reserved; //Field offset: 0x24

	}

	internal struct GameVariableInfo
	{
		public readonly string name; //Field offset: 0x0
		public uint id; //Field offset: 0x4
		public float gameValue; //Field offset: 0x8

		public GameVariableInfo(Byte[] data, int startIndex) { }

		public GameVariableInfo(string name, uint id, float gameValue) { }

	}

	internal struct NativeVector
	{
		public float x; //Field offset: 0x0
		public float y; //Field offset: 0x4
		public float z; //Field offset: 0x8

		public NativeVector(float x, float y, float z) { }

		public NativeVector(Vector3 vector) { }

	}

	internal enum PanType
	{
		Unknown = -1,
		Pan3d = 0,
		Pos3d = 1,
		Auto = 2,
	}

	internal enum Parameter
	{
		Volume = 0,
		Pitch = 1,
		Pan3dAngle = 2,
		Pan3dDistance = 3,
		Pan3dVolume = 4,
		BusSendLevel0 = 9,
		BusSendLevel1 = 10,
		BusSendLevel2 = 11,
		BusSendLevel3 = 12,
		BusSendLevel4 = 13,
		BusSendLevel5 = 14,
		BusSendLevel6 = 15,
		BusSendLevel7 = 16,
		BandPassFilterCofLow = 17,
		BandPassFilterCofHigh = 18,
		BiquadFilterType = 19,
		BiquadFilterFreq = 20,
		BiquadFIlterQ = 21,
		BiquadFilterGain = 22,
		EnvelopeAttackTime = 23,
		EnvelopeHoldTime = 24,
		EnvelopeDecayTime = 25,
		EnvelopeReleaseTime = 26,
		EnvelopeSustainLevel = 27,
		StartTime = 28,
		Priority = 31,
	}

	internal struct PerformanceInfo
	{
		public uint serverProcessCount; //Field offset: 0x0
		public uint lastServerTime; //Field offset: 0x4
		public uint maxServerTime; //Field offset: 0x8
		public uint averageServerTime; //Field offset: 0xC
		public uint lastServerInterval; //Field offset: 0x10
		public uint maxServerInterval; //Field offset: 0x14
		public uint averageServerInterval; //Field offset: 0x18

	}

	internal enum Randomize3dCalcType
	{
		None = -1,
		Rectangle = 0,
		Cuboid = 1,
		Circle = 2,
		Cylinder = 3,
		Sphere = 4,
		List = 6,
	}

	internal struct Randomize3dConfig
	{
		public const int NumOfCalcParams = 3; //Field offset: 0x0
		[SerializeField]
		private bool followsOriginalSource; //Field offset: 0x0
		[SerializeField]
		private Randomize3dCalcType calculationType; //Field offset: 0x4
		[SerializeField]
		private Single[] calculationParameters; //Field offset: 0x8

		public float CalculationParameter1
		{
			 get { } //Length: 33
		}

		public float CalculationParameter2
		{
			 get { } //Length: 33
		}

		public float CalculationParameter3
		{
			 get { } //Length: 33
		}

		public Randomize3dCalcType CalculationType
		{
			 get { } //Length: 11
		}

		public bool FollowsOriginalSource
		{
			 get { } //Length: 10
		}

		internal Randomize3dConfig(Byte[] data, int startIndex) { }

		public Randomize3dConfig(bool followsOriginalSource, Randomize3dCalcType calculationType, float param1 = 0, float param2 = 0, float param3 = 0) { }

		public Randomize3dConfig(int dummy) { }

		public void ClearCalcParams(float initVal = 0) { }

		public float get_CalculationParameter1() { }

		public float get_CalculationParameter2() { }

		public float get_CalculationParameter3() { }

		public Randomize3dCalcType get_CalculationType() { }

		public bool get_FollowsOriginalSource() { }

		public bool GetParamByType(Randomize3dParamType paramType, ref float paramVal) { }

		public bool SetParamByType(Randomize3dParamType paramType, float paramVal) { }

	}

	internal enum Randomize3dParamType
	{
		None = 0,
		Width = 1,
		Depth = 2,
		Height = 3,
		Radius = 4,
	}

	internal struct ResourceUsage
	{
		public uint useCount; //Field offset: 0x0
		public uint limit; //Field offset: 0x4

	}

	internal enum ResumeMode
	{
		AllPlayback = 0,
		PausedPlayback = 1,
		PreparedPlayback = 2,
	}

	internal enum SilentMode
	{
		Normal = 0,
		Stop = 1,
		Virtual = 2,
		VirtualRetrigger = 3,
	}

	internal enum SoundRendererType
	{
		Default = 0,
		Native = 1,
		Asr = 2,
		Extended = 3,
		Spatial = 4,
		Hw1 = 1,
		Hw2 = 65537,
		Hw3 = 131073,
		Hw4 = 196609,
		Haptic = 3,
		Pseudo = 65539,
		SpatialChannels = 4,
		Ambisonics = 65540,
		Passtrough = 131076,
		Object = 196612,
	}

	internal enum Speaker
	{
		FrontLeft = 0,
		FrontRight = 1,
		FrontCenter = 2,
		LowFrequency = 3,
		SurroundLeft = 4,
		SurroundRight = 5,
		SurroundBackLeft = 6,
		SurroundBackRight = 7,
	}

	internal struct SpeakerAngles6ch
	{
		public float frontLeft; //Field offset: 0x0
		public float frontRight; //Field offset: 0x4
		public float frontCenter; //Field offset: 0x8
		public float lowFrequency; //Field offset: 0xC
		public float surroundLeft; //Field offset: 0x10
		public float surroundRight; //Field offset: 0x14

		public static SpeakerAngles6ch Default() { }

	}

	internal struct SpeakerAngles8ch
	{
		public float frontLeft; //Field offset: 0x0
		public float frontRight; //Field offset: 0x4
		public float frontCenter; //Field offset: 0x8
		public float lowFrequency; //Field offset: 0xC
		public float surroundLeft; //Field offset: 0x10
		public float surroundRight; //Field offset: 0x14
		public float surroundBackLeft; //Field offset: 0x18
		public float surroundBackRight; //Field offset: 0x1C

		public static SpeakerAngles8ch Default() { }

	}

	private enum SpeakerSystem
	{
		Surround_5_1 = 0,
		Surround_7_1 = 1,
	}

	internal enum VoiceAllocationMethod
	{
		Once = 0,
		Retry = 1,
	}

	internal enum VoiceControlMethod
	{
		PreferLast = 0,
		PreferFirst = 1,
	}

	internal struct WaveformInfo
	{
		public int waveId; //Field offset: 0x0
		public uint format; //Field offset: 0x4
		public int samplingRate; //Field offset: 0x8
		public int numChannels; //Field offset: 0xC
		public long numSamples; //Field offset: 0x10
		public bool streamingFlag; //Field offset: 0x18
		public UInt32[] reserved; //Field offset: 0x1C

		public WaveformInfo(Byte[] data, int startIndex) { }

	}

	public const uint InvalidAisacControlId = 4294967295; //Field offset: 0x0
	public static readonly Dictionary<Randomize3dCalcType, Randomize3dParamType[]> randomize3dParamTable; //Field offset: 0x0

	public static event CueLinkCbFunc OnCueLinkCallback
	{
		 add { } //Length: 16
		 remove { } //Length: 227
	}

	private static CriAtomEx() { }

	public static void add_OnCueLinkCallback(CueLinkCbFunc value) { }

	public static void ApplyDspBusSnapshot(string snapshot_name, int time_ms) { }

	public static void AttachDspBusSetting(string settingName) { }

	public static void ControlVirtualSpeakerSetting(bool sw) { }

	private static int criAtom_GetDeviceId_WASAPI(SoundRendererType soundRendererType, StringBuilder deviceId, int count, out int is_default_device) { }

	private static void criAtom_GetPerformanceInfo(out PerformanceInfo info) { }

	private static void criAtom_ResetPerformanceMonitor() { }

	private static void criAtom_SetDeviceId_WASAPI(SoundRendererType soundRendererType, string deviceId) { }

	private static void criAtom_SetDeviceId_WASAPI(SoundRendererType type, IntPtr deviceId) { }

	private static void criAtomEx_ApplyDspBusSnapshot(string snapshot_name, int time_ms) { }

	private static void criAtomEx_AttachDspBusSetting(string settingName, IntPtr work, int workSize) { }

	private static void criAtomEx_ControlVirtualSpeakerSetting(bool sw) { }

	private static void criAtomEx_DetachDspBusSetting() { }

	private static void criAtomEx_EnableBusSendOffsetWhenLevelNotExist(bool enable) { }

	private static IntPtr criAtomEx_GetAppliedDspBusSnapshotName() { }

	private static float criAtomEx_GetGameVariableById(uint game_variable_id) { }

	private static float criAtomEx_GetGameVariableByName(string game_variable_name) { }

	private static bool criAtomEx_GetGameVariableInfo(ushort index, IntPtr game_variable_info) { }

	private static int criAtomEx_GetNumGameVariables() { }

	private static void criAtomEx_Lock() { }

	private static void criAtomEx_PauseTimer(bool sw) { }

	private static bool criAtomEx_RegisterAcfData(IntPtr acfData, int acfDataSize, IntPtr work, int workSize) { }

	private static bool criAtomEx_RegisterAcfData(Byte[] acfData, int acfDataSize, IntPtr work, int workSize) { }

	private static bool criAtomEx_RegisterAcfFile(IntPtr binder, string path, IntPtr work, int workSize) { }

	private static void criAtomEx_SetGameVariableById(uint game_variable_id, float game_variable_value) { }

	private static void criAtomEx_SetGameVariableByName(string game_variable_name, float game_variable_value) { }

	private static void criAtomEx_SetRandomSeed(uint seed) { }

	private static void criAtomEx_SetSpeakerAngleArray(SpeakerSystem speaker_system, ref SpeakerAngles8ch angle_array) { }

	private static void criAtomEx_SetSpeakerAngleArray(SpeakerSystem speaker_system, ref SpeakerAngles6ch angle_array) { }

	private static void criAtomEx_SetVirtualSpeakerAngleArray(SpeakerSystem speaker_system, ref SpeakerAngles8ch angle_array) { }

	private static void criAtomEx_SetVirtualSpeakerAngleArray(SpeakerSystem speaker_system, ref SpeakerAngles6ch angle_array) { }

	private static void criAtomEx_Unlock() { }

	private static void criAtomEx_UnregisterAcf() { }

	private static void criAtomExAcf_SetGlobalLabelToSelectorByIndex(ushort selector_index, ushort label_index) { }

	private static void criAtomExAcf_SetGlobalLabelToSelectorByName(string selector_name, string label_name) { }

	private static IntPtr criAtomUnity_GetAudioDeviceId_PC(int index) { }

	private static IntPtr criAtomUnity_GetAudioDeviceName_PC(int index) { }

	private static int criAtomUnity_GetNumAudioDevices_PC() { }

	private static bool criAtomUnity_LoadAudioDeviceList_PC() { }

	public static void DetachDspBusSetting() { }

	public static void DisableBackgroundPlayback_IOS() { }

	public static void EnableAudioSessionRestoration_IOS(bool flag) { }

	public static void EnableBackgroundPlayback_IOS() { }

	public static void EnableBusSendOffsetWhenLevelNotExist(bool enable) { }

	public static string GetAppliedDspBusSnapshotName() { }

	public static string GetAudioDeviceName_PC(int index) { }

	public static float GetGameVariable(uint game_variable_id) { }

	public static float GetGameVariable(string game_variable_name) { }

	public static bool GetGameVariableInfo(ushort index, out GameVariableInfo info) { }

	public static int GetNumAudioDevices_PC() { }

	public static int GetNumGameVariables() { }

	public static string GetOutputAudioDeviceId_PC(out bool isDefaultDevice) { }

	public static int GetOutputAudioDeviceIndex_PC(out bool isDefaultDevice) { }

	public static void GetPerformanceInfo(out PerformanceInfo info) { }

	public static bool IsBgmPortAcquired_VITA() { }

	public static bool IsInterruptedOtherAudio_IOS() { }

	public static bool IsSoundStopped_IOS() { }

	public static bool LoadAudioDeviceList_PC() { }

	public static void Lock() { }

	public static void PauseTimer(bool sw) { }

	public static bool RegisterAcf(IntPtr acfData, int dataSize) { }

	public static bool RegisterAcf(CriFsBinder binder, string acfPath) { }

	[Obsolete("Use RegisterAcf(IntPtr, int) instead")]
	public static bool RegisterAcf(Byte[] acfData) { }

	public static void remove_OnCueLinkCallback(CueLinkCbFunc value) { }

	public static void ResetPerformanceMonitor() { }

	public static void ResumeAudio_IOS() { }

	public static void SetGameVariable(string game_variable_name, float game_variable_value) { }

	public static void SetGameVariable(uint game_variable_id, float game_variable_value) { }

	public static void SetGlobalLabelToSelectorByIndex(ushort selector_index, ushort label_index) { }

	public static void SetGlobalLabelToSelectorByName(string selector_name, string label_name) { }

	public static void SetOutputAudioDevice_PC(string deviceId) { }

	public static void SetOutputAudioDevice_PC(int index) { }

	public static void SetOutputVolume_VITA(float volume) { }

	public static void SetRandomSeed(uint seed) { }

	public static void SetSpeakerAngle(SpeakerAngles8ch speakerAngle) { }

	public static void SetSpeakerAngle(SpeakerAngles6ch speakerAngle) { }

	public static void SetVirtualSpeakerAngle(SpeakerAngles8ch speakerAngle) { }

	public static void SetVirtualSpeakerAngle(SpeakerAngles6ch speakerAngle) { }

	public static void Unlock() { }

	public static void UnregisterAcf() { }

}

