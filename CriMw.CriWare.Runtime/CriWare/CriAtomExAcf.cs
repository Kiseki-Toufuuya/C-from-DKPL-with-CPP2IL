namespace CriWare;

public class CriAtomExAcf
{
	internal enum AcfAisacType
	{
		normal = 0,
		autoModulation = 1,
	}

	internal struct AcfDspBusInfo
	{
		public IntPtr namePointer; //Field offset: 0x0
		public float volume; //Field offset: 0x4
		public float pan3dVolume; //Field offset: 0x8
		public float pan3dAngle; //Field offset: 0xC
		public float pan3dDistance; //Field offset: 0x10
		public float pan3dSpread; //Field offset: 0x14
		public float pan3dWideness; //Field offset: 0x18
		public UInt16[] fxIndexes; //Field offset: 0x1C
		public UInt16[] busLinkIndexes; //Field offset: 0x20
		public ushort busNo; //Field offset: 0x24
		public byte numFxes; //Field offset: 0x26
		public byte numBusLinks; //Field offset: 0x27
		public SpeakerMapping speakerMapping; //Field offset: 0x28
		public DspBusOutputType outputType; //Field offset: 0x2C
		public byte outputOptions; //Field offset: 0x30

		public string name
		{
			 get { } //Length: 72
		}

		public string get_name() { }

	}

	internal struct AcfDspBusLinkInfo
	{
		public AcfDspBusLinkType type; //Field offset: 0x0
		public float sendLevel; //Field offset: 0x4
		public ushort busNo; //Field offset: 0x8
		public ushort busId; //Field offset: 0xA

		public AcfDspBusLinkInfo(Byte[] data, int startIndex) { }

	}

	internal enum AcfDspBusLinkType
	{
		preVolume = 0,
		postVolume = 1,
		postPan = 2,
	}

	internal struct AcfDspSettingInfo
	{
		public string name; //Field offset: 0x0
		public UInt16[] busIndexes; //Field offset: 0x4
		public UInt16[] extendBusIndexes; //Field offset: 0x8
		public ushort snapshotStartIndex; //Field offset: 0xC
		public byte numBuses; //Field offset: 0xE
		public byte numExtendBuses; //Field offset: 0xF
		public ushort numSnapshots; //Field offset: 0x10
		public ushort snapshotWorkSize; //Field offset: 0x12
		public ushort numMixerAisacs; //Field offset: 0x14
		public ushort mixerAisacStartIndex; //Field offset: 0x16

		public AcfDspSettingInfo(Byte[] data, int startIndex) { }

	}

	internal struct AcfDspSettingSnapshotInfo
	{
		public string name; //Field offset: 0x0
		public byte numBuses; //Field offset: 0x4
		public byte numExtendBuses; //Field offset: 0x5
		public Byte[] reserved; //Field offset: 0x8
		public UInt16[] busIndexes; //Field offset: 0xC
		public UInt16[] extendBusIndexes; //Field offset: 0x10

		public AcfDspSettingSnapshotInfo(Byte[] data, int startIndex) { }

	}

	internal struct AcfInfo
	{
		public string name; //Field offset: 0x0
		public uint size; //Field offset: 0x4
		public uint version; //Field offset: 0x8
		public string userData; //Field offset: 0xC
		public CharacterEncoding characterEncoding; //Field offset: 0x10
		public int numDspSettings; //Field offset: 0x14
		public int numCategories; //Field offset: 0x18
		public int numCategoriesPerPlayback; //Field offset: 0x1C
		public int numReacts; //Field offset: 0x20
		public int numAisacControls; //Field offset: 0x24
		public int numGlobalAisacs; //Field offset: 0x28
		public int numGameVariables; //Field offset: 0x2C
		public int maxBusesOfDspBusSettings; //Field offset: 0x30
		public int numBuses; //Field offset: 0x34
		public int numVoiceLimitGroups; //Field offset: 0x38
		public int numOutputPorts; //Field offset: 0x3C

		public AcfInfo(Byte[] data, int startIndex) { }

	}

	internal struct AisacGraphInfo
	{
		public AisacGraphType type; //Field offset: 0x0

		public AisacGraphInfo(Byte[] data, int startIndex) { }

	}

	internal enum AisacGraphType
	{
		none = 0,
		volume = 1,
		pitch = 2,
		bandpassHigh = 3,
		bandpassLow = 4,
		biquadFreq = 5,
		biquadQ = 6,
		busSend0 = 7,
		busSend1 = 8,
		busSend2 = 9,
		busSend3 = 10,
		busSend4 = 11,
		busSend5 = 12,
		busSend6 = 13,
		busSend7 = 14,
		pan3dAngel = 15,
		pan3dVolume = 16,
		pan3dInteriorDistance = 17,
		pan3dCenter = 18,
		pan3dLfe = 19,
		aisac0 = 20,
		aisac1 = 21,
		aisac2 = 22,
		aisac3 = 23,
		aisac4 = 24,
		aisac5 = 25,
		aisac6 = 26,
		aisac7 = 27,
		aisac8 = 28,
		aisac9 = 29,
		aisac10 = 30,
		aisac11 = 31,
		aisac12 = 32,
		aisac13 = 33,
		aisac14 = 34,
		aisac15 = 35,
		priority = 36,
		preDelayTime = 37,
		biquadGain = 38,
		pan3dMixdownCenter = 39,
		pan3dMixdownLfe = 40,
		egAttack = 41,
		egRelease = 42,
		playbackRatio = 43,
		drySendL = 44,
		drySendR = 45,
		drySendCenter = 46,
		drySendLfe = 47,
		drySendSl = 48,
		drySendSr = 49,
		drySendEx1 = 50,
		drySendEx2 = 51,
		panSpread = 52,
	}

	internal struct CategoryInfo
	{
		public uint groupNo; //Field offset: 0x0
		public uint id; //Field offset: 0x4
		public string name; //Field offset: 0x8
		public uint numCueLimits; //Field offset: 0xC
		public float volume; //Field offset: 0x10

		public CategoryInfo(Byte[] data, int startIndex) { }

	}

	internal enum CharacterEncoding
	{
		utf8 = 0,
		sjis = 1,
	}

	internal enum DspBusOutputType
	{
		None = 0,
		Main = 1,
		MainPassthrough = 2,
		PadHaptic = 3,
		PadSpeaker = 4,
		Personal = 5,
		PersonalPassthrough = 6,
	}

	internal struct GlobalAisacInfo
	{
		public string name; //Field offset: 0x0
		public ushort index; //Field offset: 0x4
		public ushort numGraphs; //Field offset: 0x6
		public AcfAisacType type; //Field offset: 0x8
		public float randomRange; //Field offset: 0xC
		public ushort controlId; //Field offset: 0x10
		public ushort dummy; //Field offset: 0x12

		public GlobalAisacInfo(Byte[] data, int startIndex) { }

	}

	internal struct SelectorInfo
	{
		public string name; //Field offset: 0x0
		public ushort index; //Field offset: 0x4
		public ushort numLabels; //Field offset: 0x6
		public ushort globalLabelIndex; //Field offset: 0x8

		public SelectorInfo(Byte[] data, int startIndex) { }

	}

	internal struct SelectorLabelInfo
	{
		public string selectorName; //Field offset: 0x0
		public string labelName; //Field offset: 0x4

		public SelectorLabelInfo(Byte[] data, int startIndex) { }

	}


	public CriAtomExAcf() { }

	private static string criAtomExAcf_FindBusName(string bus_name) { }

	private static bool criAtomExAcf_GetAcfInfo(IntPtr acf_info) { }

	private static bool criAtomExAcf_GetAcfInfoFromAcfData(IntPtr acf_data, int acf_data_size, IntPtr acf_info) { }

	private static uint criAtomExAcf_GetAisacControlIdByName(string name) { }

	private static bool criAtomExAcf_GetAisacControlInfo(ushort index, IntPtr info) { }

	private static string criAtomExAcf_GetAisacControlNameById(uint id) { }

	private static bool criAtomExAcf_GetCategoryInfo(ushort index, IntPtr info) { }

	private static bool criAtomExAcf_GetCategoryInfoById(uint id, IntPtr info) { }

	private static bool criAtomExAcf_GetCategoryInfoByName(string name, IntPtr info) { }

	private static bool criAtomExAcf_GetDspBusInformation(ushort index, out AcfDspBusInfo info) { }

	private static bool criAtomExAcf_GetDspBusLinkInformation(ushort index, IntPtr info) { }

	private static string criAtomExAcf_GetDspFxName(ushort index) { }

	private static bool criAtomExAcf_GetDspFxParameters(ushort index, IntPtr parameters, int size) { }

	private static int criAtomExAcf_GetDspFxType(ushort index) { }

	private static bool criAtomExAcf_GetDspSettingInformation(string name, IntPtr info) { }

	private static IntPtr criAtomExAcf_GetDspSettingNameByIndex(ushort index) { }

	private static IntPtr criAtomExAcf_GetDspSettingNameByIndexFromAcfData(IntPtr acf_data, int acf_data_size, ushort index) { }

	private static bool criAtomExAcf_GetDspSettingSnapshotInformation(ushort index, IntPtr info) { }

	private static bool criAtomExAcf_GetGlobalAisacGraphInfo(IntPtr aisac_info, ushort graph_index, IntPtr graph_info) { }

	private static bool criAtomExAcf_GetGlobalAisacInfo(ushort index, IntPtr info) { }

	private static bool criAtomExAcf_GetGlobalAisacInfoByName(string name, IntPtr info) { }

	private static bool criAtomExAcf_GetGlobalAisacValue(IntPtr aisac_info, float control, AisacGraphType type, out float value) { }

	private static int criAtomExAcf_GetMaxBusesOfDspBusSettings() { }

	private static int criAtomExAcf_GetMaxBusesOfDspBusSettingsFromAcfData(IntPtr acf_data, int acf_data_size) { }

	private static int criAtomExAcf_GetNumAisacControls() { }

	private static int criAtomExAcf_GetNumBuses() { }

	private static int criAtomExAcf_GetNumBusesFromAcfData(IntPtr acf_data, int acf_data_size) { }

	private static int criAtomExAcf_GetNumCategories() { }

	private static int criAtomExAcf_GetNumCategoriesFromAcfData(IntPtr acf_data, int acf_data_size) { }

	private static int criAtomExAcf_GetNumCategoriesPerPlayback() { }

	private static int criAtomExAcf_GetNumCategoriesPerPlaybackFromAcfData(IntPtr acf_data, int acf_data_size) { }

	private static int criAtomExAcf_GetNumDspSettings() { }

	private static int criAtomExAcf_GetNumDspSettingsFromAcfData(IntPtr acf_data, int acf_data_size) { }

	private static int criAtomExAcf_GetNumGlobalAisacs() { }

	private static int criAtomExAcf_GetNumSelectors() { }

	private static IntPtr criAtomExAcf_GetOutputPortHnByName(string name) { }

	private static bool criAtomExAcf_GetSelectorInfoByIndex(ushort index, IntPtr info) { }

	private static bool criAtomExAcf_GetSelectorInfoByName(string name, IntPtr info) { }

	private static bool criAtomExAcf_GetSelectorLabelInfo(IntPtr selector_info, ushort label_index, IntPtr info) { }

	public static string FindBusName(string busName) { }

	public static bool GetAcfInfo(out AcfInfo acfInfo) { }

	public static bool GetAisacControlInfo(ushort index, out AisacControlInfo info) { }

	public static bool GetCategoryInfoById(uint id, out CategoryInfo info) { }

	public static bool GetCategoryInfoByIndex(ushort index, out CategoryInfo info) { }

	public static bool GetCategoryInfoByName(string name, out CategoryInfo info) { }

	public static bool GetDspBusInformation(ushort index, out AcfDspBusInfo info) { }

	public static bool GetDspBusLinkInformation(ushort index, out AcfDspBusLinkInfo info) { }

	public static bool GetDspSettingInformation(string name, out AcfDspSettingInfo info) { }

	public static string GetDspSettingNameByIndex(IntPtr acfData, int size, ushort index) { }

	public static string GetDspSettingNameByIndex(ushort index) { }

	public static bool GetDspSettingSnapshotInformation(ushort index, out AcfDspSettingSnapshotInfo info) { }

	public static bool GetGlobalAisacGraphInfo(GlobalAisacInfo aisacInfo, ushort graphIndex, out AisacGraphInfo graphInfo) { }

	public static bool GetGlobalAisacInfoByIndex(ushort index, out GlobalAisacInfo info) { }

	public static bool GetGlobalAisacInfoByName(string name, out GlobalAisacInfo info) { }

	public static bool GetGlobalAisacValue(GlobalAisacInfo aisacInfo, float control, AisacGraphType type, out float value) { }

	public static int GetMaxBusesOfDspBusSettings() { }

	public static int GetNumAisacControls() { }

	public static int GetNumBuses() { }

	public static int GetNumCategories() { }

	public static int GetNumCategoriesPerPlayback() { }

	public static int GetNumDspSettings(IntPtr acfData, int size) { }

	public static int GetNumDspSettings() { }

	public static int GetNumGlobalAisacs() { }

	public static int GetNumSelectors() { }

	public static CriAtomExOutputPort GetOutputPort(string name) { }

	public static bool GetSelectorInfoByIndex(ushort index, out SelectorInfo info) { }

	public static bool GetSelectorInfoByName(string name, out SelectorInfo info) { }

	public static bool GetSelectorLabelInfo(SelectorInfo selectorInfo, ushort labelIndex, out SelectorLabelInfo info) { }

}

