namespace CriWare;

public class CriAtomExWaveVoicePool : CriAtomExVoicePool
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


	public CriAtomExWaveVoicePool(Config config) { }

	public CriAtomExWaveVoicePool(int numVoices, int maxChannels, int maxSamplingRate, bool streamingFlag, uint identifier = 0) { }

	private static IntPtr criAtomExVoicePool_AllocateWaveVoicePool(ref Config config, IntPtr work, int work_size) { }

	private static void CRIWARE128BE3D1(ref Config config) { }

	public static void SetDefaultConfigForWaveVoicePool(ref Config config) { }

}

