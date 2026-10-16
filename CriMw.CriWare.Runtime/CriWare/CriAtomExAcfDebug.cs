namespace CriWare;

public static class CriAtomExAcfDebug
{
	internal struct AisacControlInfo
	{
		public string name; //Field offset: 0x0
		public uint id; //Field offset: 0x4

	}

	private struct AisacControlInfoForMarshaling
	{
		public IntPtr namePtr; //Field offset: 0x0
		public uint id; //Field offset: 0x4

		public void Convert(out AisacControlInfo x) { }

	}

	internal enum AisacType
	{
		Normal = 0,
		AutoModulation = 1,
	}

	internal struct CategoryInfo
	{
		public uint groupNo; //Field offset: 0x0
		public uint id; //Field offset: 0x4
		public string name; //Field offset: 0x8
		public uint numCueLimits; //Field offset: 0xC
		public float volume; //Field offset: 0x10

	}

	private struct CategoryInfoForMarshaling
	{
		public uint groupNo; //Field offset: 0x0
		public uint id; //Field offset: 0x4
		public IntPtr namePtr; //Field offset: 0x8
		public uint numCueLimits; //Field offset: 0xC
		public float volume; //Field offset: 0x10

		public void Convert(out CategoryInfo x) { }

	}

	internal struct DspBusInfo
	{
		public string name; //Field offset: 0x0
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

	}

	private struct DspBusInfoForMarshaling
	{
		public IntPtr namePtr; //Field offset: 0x0
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

		public void Convert(out DspBusInfo x) { }

	}

	internal struct GlobalAisacInfo
	{
		public string name; //Field offset: 0x0
		public ushort index; //Field offset: 0x4
		public ushort numGraphs; //Field offset: 0x6
		public AisacType type; //Field offset: 0x8
		public float randomRange; //Field offset: 0xC
		public ushort controlId; //Field offset: 0x10

	}

	private struct GlobalAisacInfoForMarshaling
	{
		public IntPtr namePtr; //Field offset: 0x0
		public ushort index; //Field offset: 0x4
		public ushort numGraphs; //Field offset: 0x6
		public uint type; //Field offset: 0x8
		public float randomRange; //Field offset: 0xC
		public ushort controlId; //Field offset: 0x10
		public ushort dummy; //Field offset: 0x12

		public void Convert(out GlobalAisacInfo x) { }

	}

	internal struct SelectorInfo
	{
		public string name; //Field offset: 0x0
		public ushort index; //Field offset: 0x4
		public ushort numLabels; //Field offset: 0x6
		public ushort globalLabelIndex; //Field offset: 0x8

	}

	private struct SelectorInfoForMarshaling
	{
		public IntPtr namePtr; //Field offset: 0x0
		public ushort index; //Field offset: 0x4
		public ushort numLabels; //Field offset: 0x6
		public ushort globalLabelIndex; //Field offset: 0x8

		public void Convert(out SelectorInfo x) { }

	}

	internal struct SelectorLabelInfo
	{
		public string selectorName; //Field offset: 0x0
		public string labelName; //Field offset: 0x4

	}

	private struct SelectorLabelInfoForMarshaling
	{
		public IntPtr selectorNamePtr; //Field offset: 0x0
		public IntPtr labelNamePtr; //Field offset: 0x4

		public void Convert(out SelectorLabelInfo x) { }

	}


	private static uint criAtomExAcf_GetAisacControlIdByName(string name) { }

	private static int criAtomExAcf_GetAisacControlInfo(ushort index, out AisacControlInfoForMarshaling info) { }

	private static IntPtr criAtomExAcf_GetAisacControlNameById(uint id) { }

	private static int criAtomExAcf_GetCategoryInfo(ushort index, out CategoryInfoForMarshaling categoryInfo) { }

	private static int criAtomExAcf_GetCategoryInfoById(uint id, out CategoryInfoForMarshaling categoryInfo) { }

	private static int criAtomExAcf_GetCategoryInfoByName(string name, out CategoryInfoForMarshaling categoryInfo) { }

	private static int criAtomExAcf_GetDspBusInformation(ushort index, out DspBusInfoForMarshaling dspBusInfo) { }

	private static int criAtomExAcf_GetGlobalAisacInfo(ushort index, out GlobalAisacInfoForMarshaling info) { }

	private static int criAtomExAcf_GetGlobalAisacInfoByName(string name, out GlobalAisacInfoForMarshaling info) { }

	private static int criAtomExAcf_GetNumAisacControls() { }

	private static int criAtomExAcf_GetNumBuses() { }

	private static int criAtomExAcf_GetNumCategories() { }

	private static int criAtomExAcf_GetNumGlobalAisacs() { }

	private static int criAtomExAcf_GetNumSelectors() { }

	private static int criAtomExAcf_GetSelectorInfoByIndex(ushort index, out SelectorInfoForMarshaling info) { }

	private static int criAtomExAcf_GetSelectorInfoByName(string name, out SelectorInfoForMarshaling info) { }

	private static int criAtomExAcf_GetSelectorLabelInfo(ref SelectorInfoForMarshaling info, ushort labelIndex, out SelectorLabelInfoForMarshaling label_info) { }

	public static uint GetAisacControlIdByName(string name) { }

	public static bool GetAisacControlInfo(ushort index, out AisacControlInfo info) { }

	public static string GetAisacControlNameById(uint id) { }

	public static bool GetCategoryInfoById(uint id, out CategoryInfo categoryInfo) { }

	public static bool GetCategoryInfoByIndex(ushort index, out CategoryInfo categoryInfo) { }

	public static bool GetCategoryInfoByName(string name, out CategoryInfo categoryInfo) { }

	public static bool GetDspBusInformation(ushort index, out DspBusInfo dspBusInfo) { }

	public static bool GetGlobalAisacInfo(ushort index, out GlobalAisacInfo info) { }

	public static bool GetGlobalAisacInfoByName(string name, out GlobalAisacInfo info) { }

	public static int GetNumAisacControls() { }

	public static int GetNumBuses() { }

	public static int GetNumCategories() { }

	public static int GetNumGlobalAisacs() { }

	public static int GetNumSelectors() { }

	public static bool GetSelectorInfoByIndex(ushort index, out SelectorInfo info) { }

	public static bool GetSelectorInfoByName(string name, out SelectorInfo info) { }

	public static bool GetSelectorLabelInfo(ref SelectorInfo selectorInfo, ushort index, out SelectorLabelInfo labelInfo) { }

}

