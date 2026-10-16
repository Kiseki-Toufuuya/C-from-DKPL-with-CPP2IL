namespace CriWare;

public class CriAtomExRawPcmVoicePool : CriAtomExVoicePool
{
	internal enum RawPcmFormat
	{
		Sint16 = 0,
		Float32 = 1,
	}

	internal struct RawPcmPlayerConfig
	{
		public RawPcmFormat format; //Field offset: 0x0
		public int maxChannels; //Field offset: 0x4
		public int maxSamplingRate; //Field offset: 0x8
		public int soundRendererType; //Field offset: 0xC
		public int decodeLatency; //Field offset: 0x10
		private IntPtr context; //Field offset: 0x14

	}

	internal struct RawPcmVoicePoolConfig
	{
		public uint identifier; //Field offset: 0x0
		public int numVoices; //Field offset: 0x4
		public RawPcmPlayerConfig playerConfig; //Field offset: 0x8

	}


	public CriAtomExRawPcmVoicePool(int numVoices, int maxChannels, int maxSamplingRate, RawPcmFormat format, uint identifier = 0) { }

	private static IntPtr criAtomExVoicePool_AllocateRawPcmVoicePool(ref RawPcmVoicePoolConfig config, IntPtr work, int work_size) { }

}

