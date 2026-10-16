namespace CriWare;

public class CriAtomConfig
{
	internal class AndroidLowLatencyStandardVoicePoolConfig
	{
		public int memoryVoices; //Field offset: 0x8
		public int streamingVoices; //Field offset: 0xC

		public AndroidLowLatencyStandardVoicePoolConfig() { }

	}

	internal class EditorPcmOutputConfig
	{
		public bool enable; //Field offset: 0x8
		public int bufferLength; //Field offset: 0xC

		public EditorPcmOutputConfig() { }

	}

	internal class HcaMxVoicePoolConfig
	{
		public int memoryVoices; //Field offset: 0x8
		public int streamingVoices; //Field offset: 0xC

		public HcaMxVoicePoolConfig() { }

	}

	internal class InGamePreviewConfig
	{
		public int maxPreviewObjects; //Field offset: 0x8
		public int communicationBufferSize; //Field offset: 0xC
		public int playbackPositionUpdateInterval; //Field offset: 0x10

		public InGamePreviewConfig() { }

	}

	internal enum InGamePreviewSwitchMode
	{
		Disable = 0,
		Enable = 1,
		FollowBuildSetting = 2,
		Default = 3,
	}

	internal enum LinuxOutput
	{
		Default = 0,
		PulseAudio = 1,
		ALSA = 2,
	}

	internal class Ps4Atrac9VoicePoolConfig
	{
		public int memoryVoices; //Field offset: 0x8
		public int streamingVoices; //Field offset: 0xC

		public Ps4Atrac9VoicePoolConfig() { }

	}

	internal class Ps4Audio3dConfig
	{
		internal class VoicePoolConfig
		{
			public int memoryVoices; //Field offset: 0x8
			public int streamingVoices; //Field offset: 0xC

			public VoicePoolConfig() { }

		}

		public bool useAudio3D; //Field offset: 0x8
		public VoicePoolConfig voicePoolConfig; //Field offset: 0xC

		public Ps4Audio3dConfig() { }

	}

	internal class Ps5PortConfig
	{
		public int maxChannelPorts; //Field offset: 0x8
		public int maxObjectPorts; //Field offset: 0xC

		public Ps5PortConfig() { }

	}

	internal class StandardVoicePoolConfig
	{
		public int memoryVoices; //Field offset: 0x8
		public int streamingVoices; //Field offset: 0xC

		public StandardVoicePoolConfig() { }

	}

	internal class Switch2OpusVoicePoolConfig
	{
		public int memoryVoices; //Field offset: 0x8
		public int streamingVoices; //Field offset: 0xC

		public Switch2OpusVoicePoolConfig() { }

	}

	internal class SwitchOpusVoicePoolConfig
	{
		public int memoryVoices; //Field offset: 0x8
		public int streamingVoices; //Field offset: 0xC

		public SwitchOpusVoicePoolConfig() { }

	}

	internal class VitaAtrac9VoicePoolConfig
	{
		public int memoryVoices; //Field offset: 0x8
		public int streamingVoices; //Field offset: 0xC

		public VitaAtrac9VoicePoolConfig() { }

	}

	internal class VitaManaVoicePoolConfig
	{
		public int numberOfManaDecoders; //Field offset: 0x8

		public VitaManaVoicePoolConfig() { }

	}

	internal class WebGLWebAudioVoicePoolConfig
	{
		public int voices; //Field offset: 0x8

		public WebGLWebAudioVoicePoolConfig() { }

	}

	public string acfFileName; //Field offset: 0x8
	public int maxVirtualVoices; //Field offset: 0xC
	public int maxVoiceLimitGroups; //Field offset: 0x10
	public int maxCategories; //Field offset: 0x14
	public int maxAisacs; //Field offset: 0x18
	public int maxBusSends; //Field offset: 0x1C
	public int maxSequenceEventsPerFrame; //Field offset: 0x20
	public int maxBeatSyncCallbacksPerFrame; //Field offset: 0x24
	public int maxCueLinkCallbacksPerFrame; //Field offset: 0x28
	public StandardVoicePoolConfig standardVoicePoolConfig; //Field offset: 0x2C
	public HcaMxVoicePoolConfig hcaMxVoicePoolConfig; //Field offset: 0x30
	public int outputSamplingRate; //Field offset: 0x34
	public bool usesInGamePreview; //Field offset: 0x38
	public InGamePreviewSwitchMode inGamePreviewMode; //Field offset: 0x3C
	public bool switchInitializeSocket; //Field offset: 0x40
	public bool switch2InitializeSocket; //Field offset: 0x41
	public InGamePreviewConfig inGamePreviewConfig; //Field offset: 0x44
	public float serverFrequency; //Field offset: 0x48
	public SpeakerMapping speakerMapping; //Field offset: 0x4C
	public int asrOutputChannels; //Field offset: 0x50
	public bool useRandomSeedWithTime; //Field offset: 0x54
	public int categoriesPerPlayback; //Field offset: 0x58
	public int maxFaders; //Field offset: 0x5C
	public int maxBuses; //Field offset: 0x60
	public float maxPitch; //Field offset: 0x64
	public int maxParameterBlocks; //Field offset: 0x68
	public SoundRendererType soundRendererType; //Field offset: 0x6C
	public bool keepPlayingSoundOnPause; //Field offset: 0x70
	public bool enableSonicSync; //Field offset: 0x71
	public bool enableAtomSoundDisabledMode; //Field offset: 0x72
	public bool enableAtomSoundDisabledModeLinux; //Field offset: 0x73
	public EditorPcmOutputConfig editorPcmOutputConfig; //Field offset: 0x74
	public int pcBufferingTime; //Field offset: 0x78
	public bool useMicrosoftSpatialSound; //Field offset: 0x7C
	public LinuxOutput linuxOutput; //Field offset: 0x80
	public int linuxPulseLatencyUsec; //Field offset: 0x84
	public bool iosEnableSonicSync; //Field offset: 0x88
	public int iosBufferingTime; //Field offset: 0x8C
	public bool iosOverrideIPodMusic; //Field offset: 0x90
	public bool iosEnableOSNotificationHandling; //Field offset: 0x91
	public bool androidEnableSonicSync; //Field offset: 0x92
	public int androidBufferingTime; //Field offset: 0x94
	public int androidStartBufferingTime; //Field offset: 0x98
	public AndroidLowLatencyStandardVoicePoolConfig androidLowLatencyStandardVoicePoolConfig; //Field offset: 0x9C
	public bool androidUsesAndroidFastMixer; //Field offset: 0xA0
	public bool androidForceToUseAsrForDefaultPlayback; //Field offset: 0xA1
	public bool androidUsesAAudio; //Field offset: 0xA2
	public int androidStreamType; //Field offset: 0xA4
	public VitaManaVoicePoolConfig vitaManaVoicePoolConfig; //Field offset: 0xA8
	public VitaAtrac9VoicePoolConfig vitaAtrac9VoicePoolConfig; //Field offset: 0xAC
	public Ps4Atrac9VoicePoolConfig ps4Atrac9VoicePoolConfig; //Field offset: 0xB0
	public Ps5PortConfig ps5PortConfig; //Field offset: 0xB4
	public int ps5Mp3StreamingVoices; //Field offset: 0xB8
	public bool switchEnableSonicSync; //Field offset: 0xBC
	public SwitchOpusVoicePoolConfig switchOpusVoicePoolConfig; //Field offset: 0xC0
	public Switch2OpusVoicePoolConfig switch2OpusVoicePoolConfig; //Field offset: 0xC4
	public Ps4Audio3dConfig ps4Audio3dConfig; //Field offset: 0xC8
	public int ps4Mp3StreamingVoices; //Field offset: 0xCC
	public WebGLWebAudioVoicePoolConfig webglWebAudioVoicePoolConfig; //Field offset: 0xD0
	public bool webglUseWebAudioMixerAsDefault; //Field offset: 0xD4

	public CriAtomConfig() { }

}

