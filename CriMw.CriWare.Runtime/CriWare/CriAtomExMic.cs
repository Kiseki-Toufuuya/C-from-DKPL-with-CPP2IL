namespace CriWare;

public class CriAtomExMic : CriDisposable
{
	internal struct Config
	{
		public string deviceId; //Field offset: 0x0
		public uint flags; //Field offset: 0x4
		public int numChannels; //Field offset: 0x8
		public int samplingRate; //Field offset: 0xC
		public uint frameSize; //Field offset: 0x10
		public uint bufferingTime; //Field offset: 0x14
		public IntPtr context; //Field offset: 0x18

		public static Config Default
		{
			 get { } //Length: 106
		}

		public static Config get_Default() { }

	}

	internal struct DeviceInfo
	{
		public string deviceId; //Field offset: 0x0
		public string deviceName; //Field offset: 0x4
		public uint deviceFlags; //Field offset: 0x8
		public int maxChannels; //Field offset: 0xC
		public int maxSamplingRate; //Field offset: 0x10

	}

	internal class Effect
	{
		[CompilerGenerated]
		private IntPtr <handle>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		private IntPtr <afxInstance>k__BackingField; //Field offset: 0xC

		public private IntPtr afxInstance
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			private set { } //Length: 14
		}

		public private IntPtr handle
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			private set { } //Length: 14
		}

		public Effect(IntPtr handle, IntPtr afxInstance) { }

		[CompilerGenerated]
		public IntPtr get_afxInstance() { }

		[CompilerGenerated]
		public IntPtr get_handle() { }

		[CompilerGenerated]
		private void set_afxInstance(IntPtr value) { }

		[CompilerGenerated]
		private void set_handle(IntPtr value) { }

	}

	private const string errorInvalidHandle = "[CRIWARE] Invalid native handle of CriAtomMic."; //Field offset: 0x0
	private const string errorInvalidBufferLength = "[CRIWARE] Invalid buffer length for CriAtomMic.ReadData."; //Field offset: 0x0
	private const string errorInvalidNumBuffers = "[CRIWARE] Number of buffers are not same with channels of CriAtomMic."; //Field offset: 0x0
	private const string errorAlreadyInitialized = "[CRIWARE] CriAtomMic module is already initialized."; //Field offset: 0x0
	private const string errorNotInitialized = "[CRIWARE] CriAtomMic module is not initialized."; //Field offset: 0x0
	[CompilerGenerated]
	private static bool <isInitialized>k__BackingField; //Field offset: 0x0
	private static int _initializationCount; //Field offset: 0x4
	private IntPtr handle; //Field offset: 0x18
	private IntPtr[] bufferPointers; //Field offset: 0x1C
	private GCHandle[] gcHandles; //Field offset: 0x20
	private CriAudioWriteStream outputWriteStream; //Field offset: 0x24

	public private static bool isInitialized
	{
		[CompilerGenerated]
		 get { } //Length: 40
		[CompilerGenerated]
		private set { } //Length: 47
	}

	private CriAtomExMic(IntPtr handle) { }

	public Effect AttachEffect(IntPtr afxInterface, Single[] configParameters) { }

	public static CriAtomExMic Create(Nullable<Config> config = null) { }

	private static IntPtr criAtomMic_AttachEffect(IntPtr mic, IntPtr afx_interface, Single[] config_parameters, uint num_config_parameters, IntPtr work, int work_size) { }

	private static int criAtomMic_CalculateWorkSizeForEffect(IntPtr mic, IntPtr afx_interface, Single[] config_parameters, uint num_config_parameters) { }

	private static IntPtr criAtomMic_Create(in Config config, IntPtr work, int work_size) { }

	private static void criAtomMic_Destroy(IntPtr mic) { }

	private static void criAtomMic_DetachEffect(IntPtr mic, IntPtr effect) { }

	private static bool criAtomMic_GetDefaultDevice(out DeviceInfo info) { }

	private static bool criAtomMic_GetDevice(int index, out DeviceInfo info) { }

	private static IntPtr criAtomMic_GetEffectInstance(IntPtr mic, IntPtr effect) { }

	private static float criAtomMic_GetEffectParameter(IntPtr mic, IntPtr effect, uint parameter_index) { }

	private static uint criAtomMic_GetNumBufferedSamples(IntPtr mic) { }

	private static int criAtomMic_GetNumChannels(IntPtr mic) { }

	private static int criAtomMic_GetNumDevices() { }

	private static IntPtr criAtomMic_GetOutputReadStream() { }

	private static int criAtomMic_GetSamplingRate(IntPtr mic) { }

	private static bool criAtomMic_IsAvailable(IntPtr mic) { }

	private static bool criAtomMic_IsFormatSupported(in Config config) { }

	private static uint criAtomMic_ReadData(IntPtr mic, IntPtr[] data, uint num_samples) { }

	private static void criAtomMic_SetEffectBypass(IntPtr mic, IntPtr effect, bool bypass) { }

	private static void criAtomMic_SetEffectParameter(IntPtr mic, IntPtr effect, uint parameter_index, float parameter_value) { }

	private static void criAtomMic_SetOutputWriteStream(IntPtr mic, IntPtr stream_cbfunc, IntPtr stream_ptr) { }

	private static void criAtomMic_Start(IntPtr mic) { }

	private static void criAtomMic_Stop(IntPtr mic) { }

	private static void criAtomMic_UpdateEffectParameters(IntPtr mic, IntPtr effect) { }

	private static void criAtomMicUnity_Finalize() { }

	private static void criAtomMicUnity_Initialize() { }

	public void DetachEffect(Effect effect) { }

	public virtual void Dispose() { }

	private void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	public static void FinalizeModule() { }

	[CompilerGenerated]
	public static bool get_isInitialized() { }

	public static Nullable<DeviceInfo> GetDefaultDevice() { }

	public static DeviceInfo[] GetDevices() { }

	public float GetEffectParameter(Effect effect, int parameterIndex) { }

	public uint GetNumBufferedSamples() { }

	[Obsolete("Use CriWare.CriAtomExMic.GetNumBufferedSamples")]
	public uint GetNumBufferredSamples() { }

	public int GetNumChannels() { }

	public static int GetNumDevices() { }

	public CriAudioReadStream GetOutputReadStream() { }

	public int GetSamplingRate() { }

	public static void InitializeModule() { }

	private void InternalClearBuffers() { }

	private uint InternalReadDataFromBufferPointers(uint numToRead) { }

	public bool IsAvailable() { }

	public static bool IsFormatSupported(Config config) { }

	public uint ReadData(Single[][] buffers, uint numToRead) { }

	public uint ReadData(Single[] bufferMono) { }

	public uint ReadData(Single[] bufferL, Single[] bufferR, uint numToRead) { }

	public uint ReadData(Single[] bufferL, Single[] bufferR) { }

	public uint ReadData(Single[] bufferMono, uint numToRead) { }

	public uint ReadData(Single[][] buffers) { }

	[CompilerGenerated]
	private static void set_isInitialized(bool value) { }

	public void SetEffectBypass(Effect effect, bool bypass) { }

	public void SetEffectParameter(Effect effect, int parameterIndex, float parameterValue) { }

	public void SetOutputWriteStream(CriAudioWriteStream stream) { }

	public static void SetupOutputCategoryForMic_IOS(bool enable) { }

	public void Start() { }

	public void Stop() { }

	public void UpdateEffectParameters(Effect effect) { }

}

