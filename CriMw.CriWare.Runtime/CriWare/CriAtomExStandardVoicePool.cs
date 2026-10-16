namespace CriWare;

public class CriAtomExStandardVoicePool : CriAtomExVoicePool
{
	internal struct Config
	{
		public uint identifier; //Field offset: 0x0
		public int numVoices; //Field offset: 0x4
		public PlayerConfig playerConfig; //Field offset: 0x8
		public bool isStreamingOnly; //Field offset: 0x20
		public int minChannels; //Field offset: 0x24

		public static Config Default() { }

	}


	public CriAtomExStandardVoicePool(Config config) { }

	public CriAtomExStandardVoicePool(int numVoices, int maxChannels, int maxSamplingRate, bool streamingFlag, uint identifier = 0) { }

	private static IntPtr criAtomExVoicePool_AllocateStandardVoicePool(ref Config config, IntPtr work, int work_size) { }

	private static void CRIWAREA83A62EE(ref Config config) { }

	public static void SetDefaultConfigForStandardVoicePool(ref Config config) { }

}

