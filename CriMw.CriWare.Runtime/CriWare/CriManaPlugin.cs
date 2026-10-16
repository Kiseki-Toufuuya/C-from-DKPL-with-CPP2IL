namespace CriWare;

public class CriManaPlugin
{
	private static int initializationCount; //Field offset: 0x0
	private static bool isConfigured; //Field offset: 0x4
	private static bool enabledMultithreadedRendering; //Field offset: 0x5
	public static int renderingEventOffset; //Field offset: 0x8
	[CompilerGenerated]
	private static Action OnBeforeInitialize; //Field offset: 0xC
	[CompilerGenerated]
	private static Action OnInitialized; //Field offset: 0x10
	[CompilerGenerated]
	private static Action OnBeforeFinalize; //Field offset: 0x14
	[CompilerGenerated]
	private static Action OnFinalized; //Field offset: 0x18

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

	public static bool isMultithreadedRenderingEnabled
	{
		 get { } //Length: 61
	}

	private static CriManaPlugin() { }

	public CriManaPlugin() { }

	[CompilerGenerated]
	public static void add_OnBeforeFinalize(Action value) { }

	[CompilerGenerated]
	public static void add_OnBeforeInitialize(Action value) { }

	[CompilerGenerated]
	public static void add_OnFinalized(Action value) { }

	[CompilerGenerated]
	public static void add_OnInitialized(Action value) { }

	public static bool AnalyzeMovieHeader(IntPtr data, out MovieInfo movieInfo) { }

	public static bool criMana_IsStreamerManagerUsed() { }

	public static void criMana_UseStreamerManager(bool flag) { }

	public static bool criManaUnity_IsLegacyDecoderUsed_PC() { }

	public static void criManaUnity_UseLegacyDecoder_PC(bool enable) { }

	public static void CRIWARE06C53AD8() { }

	public static uint CRIWARE393DE8F4() { }

	public static bool CRIWARE854C3DC8() { }

	private static void CRIWARE96689E52() { }

	public static void CRIWAREC259DDC2(bool enable) { }

	private static void CRIWAREC64D36F5(int graphics_api, bool graphics_multi_threaded, int num_decoders, int num_of_max_entries) { }

	private static uint CRIWARED06908BC() { }

	public static void CRIWARED48DB415() { }

	public static bool CRIWARED495EAD7(IntPtr movie_header_ptr, out MovieInfo mvinf) { }

	public static void CRIWAREDD7B3066(bool flag) { }

	private static void CRIWAREDDFA80BC() { }

	public static void FinalizeLibrary() { }

	public static bool get_isInitialized() { }

	public static bool get_isMultithreadedRenderingEnabled() { }

	private static Type GetAV1ExpansionClass() { }

	public static uint GetPrimeBufferAlignmentSize() { }

	private static Type GetVp9ExpansionClass() { }

	public static void InitializeLibrary() { }

	private static bool IsAV1CodecSupported() { }

	public static bool IsCodecSupported(CodecType codecType) { }

	private static bool IsH264CodecSupported() { }

	public static bool IsLegacyDecoderUsed_PC() { }

	public static bool IsLibraryInitialized() { }

	public static bool IsStreamerManagerUsed() { }

	private static bool IsVp9CodecSupported() { }

	public static void Lock() { }

	[CompilerGenerated]
	public static void remove_OnBeforeFinalize(Action value) { }

	[CompilerGenerated]
	public static void remove_OnBeforeInitialize(Action value) { }

	[CompilerGenerated]
	public static void remove_OnFinalized(Action value) { }

	[CompilerGenerated]
	public static void remove_OnInitialized(Action value) { }

	public static void SetConfigAdditonalParameters_ANDROID(bool enable_buffer_output_for_h264, bool enable_buffer_output_for_vp9) { }

	public static void SetConfigAdditonalParameters_PC(bool use_h264_playback) { }

	[Obsolete("Use CriWareVITA.EnableH264Playback and CriWareVITA.SetH264DecoderMaxSize instead.")]
	public static void SetConfigAdditonalParameters_VITA(bool use_h264_playback, int width, int height) { }

	public static void SetConfigAdditonalParameters_WEBGL(string webworkerPath, uint heapSize) { }

	public static void SetConfigParameters(bool graphicsMultiThreaded, int num_decoders, int max_num_of_entries) { }

	public static void SetDecodeThreadPriorityAndroidExperimental(int prio) { }

	private static void SetupAV1() { }

	private static void SetupVp9() { }

	public static bool ShouldSampleRed(GraphicsDeviceType type, IntPtr tex_ptr) { }

	public static void Unlock() { }

	public static void UseLegacyDecoder_PC(bool useLegacyDecoder) { }

	public static void UseStreamerManager(bool flag) { }

}

