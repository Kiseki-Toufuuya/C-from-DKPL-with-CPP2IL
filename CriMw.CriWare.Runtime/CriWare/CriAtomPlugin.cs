namespace CriWare;

public static class CriAtomPlugin
{
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	internal sealed class CallbackFromNativeDelegate : MulticastDelegate
	{

		public CallbackFromNativeDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IntPtr ptr1, AsyncCallback callback, object object) { }

		public override ulong EndInvoke(IAsyncResult result) { }

		public override ulong Invoke(IntPtr ptr1) { }

	}

	internal struct FileOpenCondition
	{
		public int freeBindsCount; //Field offset: 0x0
		public int freeFilesCount; //Field offset: 0x4
		public int freeLoadersCount; //Field offset: 0x8

		public bool CanAttachAwb
		{
			 get { } //Length: 105
		}

		public bool CanLoadAcb
		{
			 get { } //Length: 106
		}

		public bool CanLoadAcbWithAwb
		{
			 get { } //Length: 35
		}

		public bool CanLoadAcf
		{
			 get { } //Length: 106
		}

		public bool get_CanAttachAwb() { }

		public bool get_CanLoadAcb() { }

		public bool get_CanLoadAcbWithAwb() { }

		public bool get_CanLoadAcf() { }

	}

	private static int initializationCount; //Field offset: 0x0
	[CompilerGenerated]
	private static Action OnBeforeInitialize; //Field offset: 0x4
	[CompilerGenerated]
	private static Action OnInitialized; //Field offset: 0x8
	[CompilerGenerated]
	private static Action OnBeforeFinalize; //Field offset: 0xC
	[CompilerGenerated]
	private static Action OnFinalized; //Field offset: 0x10
	private static List<IntPtr> effectInterfaceList; //Field offset: 0x14
	private static bool isConfigured; //Field offset: 0x18
	private static float timeSinceStartup; //Field offset: 0x1C
	private static CpuUsage cpuUsage; //Field offset: 0x20
	private static int CRIATOMUNITY_PARAMETER_ID_LOOP_COUNT; //Field offset: 0x2C
	private static ushort CRIATOMPARAMETER2_ID_INVALID; //Field offset: 0x30
	private static ulong temporalStorage; //Field offset: 0x38

	public static event Action OnBeforeFinalize
	{
		[CompilerGenerated]
		 add { } //Length: 177
		[CompilerGenerated]
		 remove { } //Length: 177
	}

	public static event Action OnBeforeInitialize
	{
		[CompilerGenerated]
		 add { } //Length: 177
		[CompilerGenerated]
		 remove { } //Length: 177
	}

	public static event Action OnFinalized
	{
		[CompilerGenerated]
		 add { } //Length: 177
		[CompilerGenerated]
		 remove { } //Length: 177
	}

	public static event Action OnInitialized
	{
		[CompilerGenerated]
		 add { } //Length: 177
		[CompilerGenerated]
		 remove { } //Length: 177
	}

	public static bool isInitialized
	{
		 get { } //Length: 64
	}

	private static CriAtomPlugin() { }

	[CompilerGenerated]
	public static void add_OnBeforeFinalize(Action value) { }

	[CompilerGenerated]
	public static void add_OnBeforeInitialize(Action value) { }

	[CompilerGenerated]
	public static void add_OnFinalized(Action value) { }

	[CompilerGenerated]
	public static void add_OnInitialized(Action value) { }

	[MonoPInvokeCallback(typeof(CallbackFromNativeDelegate))]
	private static ulong CallbackFromNative(IntPtr ptr1) { }

	private static void CRIWARE0FE67E68(int output, int pulse_latency_usec) { }

	public static uint CRIWARE273DF5E8() { }

	public static bool CRIWARE2813B966() { }

	public static void CRIWARE2A5CBE16() { }

	private static bool CRIWARE338D91B7() { }

	private static void CRIWARE37BB6FF2(uint max_preivew_objects, uint communication_buffer_size, int playback_position_update_interval) { }

	public static ushort CRIWARE3C2FD4B9(int id) { }

	public static void CRIWARE5A309D9A(IntPtr cbfunc) { }

	private static void CRIWARE5EA82A41() { }

	private static void CRIWARE7EF379E5() { }

	private static int CRIWARE80AAB043() { }

	public static void CRIWARE8A487D0C(int code) { }

	private static void CRIWARE8D750D00(bool enable_sonicsync, uint buffering_time_ios, bool override_ipod_music_ios, bool enable_os_notification_handling) { }

	private static void CRIWARE8EC5CE35(bool pause) { }

	private static void CRIWAREA21D153E(int sampling_rate_for_memory, int sampling_rate_for_streaming) { }

	public static void CRIWAREAB0EEC6F(IntPtr cbfunc) { }

	private static int CRIWAREAFA61004() { }

	public static void CRIWAREB4EB2291(IntPtr cbfunc, string separator_string) { }

	private static void CRIWAREC3FD9BC1() { }

	private static void CRIWAREC43B8769() { }

	private static void CRIWARED22A3530(bool enable_sonicsync, int num_low_delay_memory_voices, int num_low_delay_streaming_voices, int sound_buffering_time, int sound_start_buffering_time, bool apply_hw_property, int stream_type) { }

	public static void CRIWAREE2069C00() { }

	private static void CRIWAREE4C62158(int max_virtual_voices, int max_voice_limit_groups, int max_categories, byte max_aisacs, byte max_bus_sends, int max_sequence_events_per_frame, int max_beatsync_callbacks_per_frame, int max_cuelink_callbacks_per_frame, int num_standard_memory_voices, int num_standard_streaming_voices, int num_hca_mx_memory_voices, int num_hca_mx_streaming_voices, int output_sampling_rate, int num_asr_output_channels, SpeakerMapping speakerMapping, bool uses_in_game_preview, float server_frequency, int max_parameter_blocks, int categories_per_playback, int max_faders, int num_buses, float max_pitch, SoundRendererType sound_renderer_type, bool enable_sonicsync_for_common, bool enable_atom_sound_disabled_mode) { }

	public static void CRIWAREECDEF110(IntPtr cbfunc) { }

	private static void CRIWAREF256BF30(long buffering_time_pc, bool use_microsoft_spatial_sound) { }

	private static bool CRIWAREF34C7124(IntPtr acbHn, string cue_name, IntPtr decode_lpcm_buffer, long decodeLpcmBufferLength) { }

	private static void CRIWAREF4CEDBF7(bool enable_user_pcm_out_mode) { }

	public static void CRIWAREF5467700(IntPtr acb_hn, CallbackFromNativeDelegate func, IntPtr obj) { }

	private static void CRIWAREFD0A8B7E() { }

	public static void DecryptAcb(IntPtr acb_hn, ulong key, ulong nonce) { }

	public static void ExecuteQueuedBeatSyncCallbacks() { }

	public static void ExecuteQueuedCueLinkCallbacks() { }

	public static void ExecuteQueuedEventCallbacks() { }

	public static void FinalizeLibrary() { }

	public static bool get_isInitialized() { }

	public static bool GetAudioEffectInterfaceList(out List<IntPtr>& effect_interface_list) { }

	public static CpuUsage GetCpuUsage() { }

	public static FileOpenCondition GetFileOpenCondition() { }

	public static ushort GetLoopCountParameterId() { }

	public static int GetOutputChannels() { }

	public static int GetOutputSamplingRate() { }

	public static int GetRequiredMaxVirtualVoices(CriAtomConfig atomConfig) { }

	public static bool GetWaveSamples(CriAtomExAcb acb, string cueName, Int16[] decodeLpcmBuffer) { }

	public static void InitializeLibrary() { }

	public static bool IsInitializedForPcmOutput() { }

	public static bool IsLibraryInitialized() { }

	public static void Log(string log) { }

	public static void Pause(bool pause) { }

	[CompilerGenerated]
	public static void remove_OnBeforeFinalize(Action value) { }

	[CompilerGenerated]
	public static void remove_OnBeforeInitialize(Action value) { }

	[CompilerGenerated]
	public static void remove_OnFinalized(Action value) { }

	[CompilerGenerated]
	public static void remove_OnInitialized(Action value) { }

	public static void SetConfigAdditionalParameters_ANDROID(bool enable_sonicsync, int num_low_delay_memory_voices, int num_low_delay_streaming_voices, int sound_buffering_time, int sound_start_buffering_time, bool use_fast_mixer, bool use_aaudio, int stream_type) { }

	public static void SetConfigAdditionalParameters_EDITOR(bool enable_user_pcm_output, int user_pcm_buffer_length) { }

	public static void SetConfigAdditionalParameters_IOS(bool enable_sonicsync, uint buffering_time_ios, bool override_ipod_music_ios, bool enable_os_notification_handling) { }

	public static void SetConfigAdditionalParameters_LINUX(LinuxOutput output, int pulse_latency_usec) { }

	public static void SetConfigAdditionalParameters_PC(long buffering_time_pc, bool use_microsoft_spatial_sound) { }

	public static void SetConfigAdditionalParameters_PS4(int num_atrac9_memory_voices, int num_atrac9_streaming_voices, bool use_audio3d, int num_audio3d_memory_voices, int num_audio3d_streaming_voices, int num_mp4_streaming_voices) { }

	public static void SetConfigAdditionalParameters_PS5(int max_channel_ports, int max_object_ports, int num_mp4_streaming_voices) { }

	public static void SetConfigAdditionalParameters_SWITCH(bool enable_sonicsync, int num_opus_memory_voices, int num_opus_streaming_voices, bool init_socket) { }

	public static void SetConfigAdditionalParameters_SWITCH2(int num_opus_memory_voices, int num_opus_streaming_voices, bool init_socket) { }

	public static void SetConfigAdditionalParameters_VITA(int num_atrac9_memory_voices, int num_atrac9_streaming_voices, int num_mana_decoders) { }

	public static void SetConfigAdditionalParameters_WEBGL(int num_webaudio_voices, bool use_webaudio_mixer) { }

	public static void SetConfigMonitorParametes(int max_preview_objects, int communication_buffer_size, int playback_position_update_interval) { }

	public static void SetConfigParameters(int max_virtual_voices, int max_voice_limit_groups, int max_categories, byte max_aisacs, byte max_bus_sends, int max_sequence_events_per_frame, int max_beatsync_callbacks_per_frame, int max_cuelink_callbacks_per_frame, int num_standard_memory_voices, int num_standard_streaming_voices, int num_hca_mx_memory_voices, int num_hca_mx_streaming_voices, int output_sampling_rate, int num_asr_output_channels, SpeakerMapping speakerMapping, bool uses_in_game_preview, float server_frequency, int max_parameter_blocks, int categories_per_playback, int max_faders, int num_buses, float max_pitch, SoundRendererType sound_renderer_type, bool enable_sonicsync_for_common, bool enable_atom_sound_disabled_mode) { }

	public static void SetMaxSamplingRateForStandardVoicePool(int sampling_rate_for_memory, int sampling_rate_for_streaming) { }

}

