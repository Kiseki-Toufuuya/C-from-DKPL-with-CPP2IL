namespace CriWare;

public class CriAtomExAuxIn : CriDisposable
{
	internal struct Config
	{
		public int maxChannels; //Field offset: 0x0
		public int maxSamplingRate; //Field offset: 0x4
		public SoundRendererType soundRendererType; //Field offset: 0x8

		public static Config Default
		{
			 get { } //Length: 28
		}

		public static Config get_Default() { }

	}

	private const string errorInvalidHandle = "[CRIWARE] Invalid native handle of CriAtomExAuxIn."; //Field offset: 0x0
	private IntPtr handle; //Field offset: 0x18
	private CriAudioReadStream inputReadStream; //Field offset: 0x1C

	public CriAtomExAuxIn(Nullable<Config> config = null) { }

	private static IntPtr criAtomAuxIn_Create(in Config config, IntPtr work, int work_size) { }

	private static void criAtomAuxIn_Destroy(IntPtr aux_in) { }

	private static void criAtomAuxIn_GetFormat(IntPtr aux_in, out int num_channels, out int sampling_rate) { }

	private static void criAtomAuxIn_SetBusSendLevelByName(IntPtr aux_in, string bus_name, float level) { }

	private static void criAtomAuxIn_SetFormat(IntPtr aux_in, int num_channels, int sampling_rate) { }

	private static void criAtomAuxIn_SetFrequencyRatio(IntPtr aux_in, float ratio) { }

	private static void criAtomAuxIn_SetInputReadStream(IntPtr aux_in, IntPtr stream_cbfunc, IntPtr stream_ptr) { }

	private static void criAtomAuxIn_SetVolume(IntPtr aux_in, float volume) { }

	private static void criAtomAuxIn_Start(IntPtr aux_in) { }

	private static void criAtomAuxIn_Stop(IntPtr aux_in) { }

	public virtual void Dispose() { }

	protected virtual void Finalize() { }

	public void GetFormat(out int numChannels, out int samplingRate) { }

	public void SetBusSendLevel(string busName, float level) { }

	public void SetFormat(int numChannels, int samplingRate) { }

	public void SetFrequencyRatio(float frequencyRatio) { }

	public void SetInputReadStream(CriAudioReadStream stream) { }

	public void SetVolume(float volume) { }

	public void Start() { }

	public void Stop() { }

}

