namespace CriWare;

public abstract class CriAtomExVoicePool : CriDisposable
{
	private struct ExPitchShifterConfig
	{
		public int numDsp; //Field offset: 0x0
		public int maxChannels; //Field offset: 0x4
		public int maxSamplingRate; //Field offset: 0x8
		public PitchShifterConfig config; //Field offset: 0xC

	}

	private struct ExTimeStretchConfig
	{
		public int numDsp; //Field offset: 0x0
		public int maxChannels; //Field offset: 0x4
		public int maxSamplingRate; //Field offset: 0x8
		public TimeStretchConfig config; //Field offset: 0xC

	}

	private struct PitchShifterConfig
	{
		public int mode; //Field offset: 0x0
		public int windowSize; //Field offset: 0x4
		public int overlapTimes; //Field offset: 0x8

	}

	internal enum PitchShifterMode
	{
		Music = 0,
		Vocal = 1,
		SoundEffect = 2,
		Speech = 3,
	}

	internal struct PlayerConfig
	{
		public int maxChannels; //Field offset: 0x0
		public int maxSamplingRate; //Field offset: 0x4
		public bool streamingFlag; //Field offset: 0x8
		public int soundRendererType; //Field offset: 0xC
		public int decodeLatency; //Field offset: 0x10
		private IntPtr context; //Field offset: 0x14

	}

	private struct TimeStretchConfig
	{
		public int reserved; //Field offset: 0x0

	}

	internal struct UsedVoicesInfo
	{
		public int numUsedVoices; //Field offset: 0x0
		public int numPoolVoices; //Field offset: 0x4

	}

	internal enum VoicePoolId
	{
		StandardMemory = 0,
		StandardStreaming = 1,
		HcaMxMemory = 4,
		HcaMxStreaming = 5,
	}

	public const int StandardMemoryAsrVoicePoolId = 0; //Field offset: 0x0
	public const int StandardStreamingAsrVoicePoolId = 1; //Field offset: 0x0
	public const int StandardMemoryNsrVoicePoolId = 2; //Field offset: 0x0
	public const int StandardStreamingNsrVoicePoolId = 3; //Field offset: 0x0
	protected IntPtr _handle; //Field offset: 0x18
	protected uint _identifier; //Field offset: 0x1C
	protected int _numVoices; //Field offset: 0x20
	protected int _maxChannels; //Field offset: 0x24
	protected int _maxSamplingRate; //Field offset: 0x28

	public uint identifier
	{
		 get { } //Length: 11
	}

	public int maxChannels
	{
		 get { } //Length: 11
	}

	public int maxSamplingRate
	{
		 get { } //Length: 11
	}

	public IntPtr nativeHandle
	{
		 get { } //Length: 11
	}

	public int numVoices
	{
		 get { } //Length: 11
	}

	protected CriAtomExVoicePool() { }

	public void AttachDspPitchShifter(PitchShifterMode mode = 0, int windosSize = 1024, int overlapTimes = 4) { }

	public void AttachDspTimeStretch() { }

	private static void criAtomExVoicePool_AttachDspPitchShifter(IntPtr pool, ref ExPitchShifterConfig config, IntPtr work, int work_size) { }

	private static void criAtomExVoicePool_AttachDspTimeStretch(IntPtr pool, ref ExTimeStretchConfig config, IntPtr work, int work_size) { }

	private static void criAtomExVoicePool_DetachDsp(IntPtr pool) { }

	public static void criAtomExVoicePool_Free(IntPtr pool) { }

	private static void criAtomExVoicePool_GetNumUsedVoices(IntPtr pool, out int num_used_voices, out int num_pool_voices) { }

	private static void CRIWARE9250A0E0(int voice_pool_id, out int num_used_voices, out int num_pool_voices) { }

	public void DetachDsp() { }

	public virtual void Dispose() { }

	protected virtual void Finalize() { }

	public uint get_identifier() { }

	public int get_maxChannels() { }

	public int get_maxSamplingRate() { }

	public IntPtr get_nativeHandle() { }

	public int get_numVoices() { }

	public UsedVoicesInfo GetNumUsedVoices() { }

	public static UsedVoicesInfo GetNumUsedVoices(VoicePoolId voicePoolId) { }

}

