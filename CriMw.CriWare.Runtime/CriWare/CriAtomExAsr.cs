namespace CriWare;

public class CriAtomExAsr
{
	private struct BusAnalyzerConfig
	{
		public int interval; //Field offset: 0x0
		public int peakHoldTime; //Field offset: 0x4

	}

	internal struct BusAnalyzerInfo
	{
		public int numChannels; //Field offset: 0x0
		public Single[] rmsLevels; //Field offset: 0x4
		public Single[] peakLevels; //Field offset: 0x8
		public Single[] peakHoldLevels; //Field offset: 0xC

		public BusAnalyzerInfo(Byte[] data) { }

	}


	public CriAtomExAsr() { }

	public static void AttachBusAnalyzer(string busName, int interval, int peakHoldTime) { }

	public static void AttachBusAnalyzer(int interval, int peakHoldTime) { }

	private static void criAtomExAsr_AttachBusAnalyzer(int busNo, ref BusAnalyzerConfig config) { }

	private static void criAtomExAsr_AttachBusAnalyzerByName(string busName, ref BusAnalyzerConfig config) { }

	private static void criAtomExAsr_DetachBusAnalyzer(int busNo) { }

	private static void criAtomExAsr_DetachBusAnalyzerByName(string busName) { }

	private static void criAtomExAsr_EnableBinauralizer(bool enabled) { }

	private static void criAtomExAsr_GetBusAnalyzerInfo(int busNo, IntPtr info) { }

	private static void criAtomExAsr_GetBusAnalyzerInfoByName(string busName, IntPtr info) { }

	private static void criAtomExAsr_GetBusVolumeByName(string busName, out float volume) { }

	private static float criAtomExAsr_GetEffectParameter(string busName, string effectName, uint parameterIndex) { }

	private static bool criAtomExAsr_IsEnabledBinauralizer() { }

	private static void criAtomExAsr_PauseOutputVoice(bool sw) { }

	private static bool criAtomExAsr_RegisterEffectInterface(IntPtr afx_interface) { }

	private static void criAtomExAsr_SetBusMatrix(int busNo, int inputChannels, int outputChannels, Single[] matrix) { }

	private static void criAtomExAsr_SetBusMatrixByName(string busName, int inputChannels, int outputChannels, Single[] matrix) { }

	private static void criAtomExAsr_SetBusSendLevel(int busNo, int sendtoNo, float level) { }

	private static void criAtomExAsr_SetBusSendLevelByName(string busName, string sendtoName, float level) { }

	private static void criAtomExAsr_SetBusVolume(int busNo, float volume) { }

	private static void criAtomExAsr_SetBusVolumeByName(string busName, float volume) { }

	private static void criAtomExAsr_SetEffectBypass(string busName, string effectName, bool bypass) { }

	private static void criAtomExAsr_SetEffectParameter(string busName, string effectName, uint parameterIndex, float parameterValue) { }

	private static void criAtomExAsr_UnregisterEffectInterface(IntPtr afx_interface) { }

	private static void criAtomExAsr_UpdateEffectParameters(string busName, string effectName) { }

	private static int criAtomExAsrRack_GetNumBuses(int rackId) { }

	public static void DetachBusAnalyzer(string busName) { }

	public static void DetachBusAnalyzer() { }

	public static void EnableBinauralizer(bool enabled) { }

	public static void GetBusAnalyzerInfo(string busName, out BusAnalyzerInfo info) { }

	[Obsolete("Use CriAtomExAsr.GetBusAnalyzerInfo(string busName, out BusAnalyzerInfo info)")]
	public static void GetBusAnalyzerInfo(int busId, out BusAnalyzerInfo info) { }

	public static void GetBusVolume(string busName, out float volume) { }

	public static float GetEffectParameter(string busName, string effectName, uint parameterIndex) { }

	public static int GetNumBufferedPcmOutputSamples() { }

	public static int GetPcmOutput(int outputChannels, int outputSamples, Single[][] buffer) { }

	public static bool IsEnabledBinauralizer() { }

	public static void PauseOutputVoice(bool sw) { }

	public static bool RegisterEffectInterface(IntPtr afx_interface) { }

	public static void SetBusMatrix(string busName, int inputChannels, int outputChannels, Single[] matrix) { }

	[Obsolete("Use CriAtomExAsr.SetBusMatrix(string busName, int inputChannels, int outputChannels, float[] matrix)")]
	public static void SetBusMatrix(int busId, int inputChannels, int outputChannels, Single[] matrix) { }

	[Obsolete("Use CriAtomExAsr.SetBusSendLevel(string busName, string sendTo, float level)")]
	public static void SetBusSendLevel(int busId, int sendTo, float level) { }

	public static void SetBusSendLevel(string busName, string sendTo, float level) { }

	[Obsolete("Use CriAtomExAsr.SetBusVolume(string busName, float volume)")]
	public static void SetBusVolume(int busId, float volume) { }

	public static void SetBusVolume(string busName, float volume) { }

	public static void SetEffectBypass(string busName, string effectName, bool bypass) { }

	public static void SetEffectParameter(string busName, string effectName, uint parameterIndex, float parameterValue) { }

	public static void SetPcmBufferSize(int numSamples) { }

	public static void UnregisterEffectInterface(IntPtr afx_interface) { }

}

