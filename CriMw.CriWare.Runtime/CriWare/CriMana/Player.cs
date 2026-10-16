namespace CriWare.CriMana;

public class Player : CriDisposable
{
	[CompilerGenerated]
	private sealed class <IssuePluginUpdatesForFrames>d__157 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Player <>4__this; //Field offset: 0x10
		public int playerId; //Field offset: 0x14
		public int frameCount; //Field offset: 0x18
		public bool destroy; //Field offset: 0x1C
		public MonoBehaviour playerHolder; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		[DebuggerHidden]
		public <IssuePluginUpdatesForFrames>d__157(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal enum AudioTrack
	{
		Off = 0,
		Auto = 1,
	}

	internal enum CriManaUnityPlayer_RenderEventAction
	{
		UPDATE = 0,
		INITIALIZE = 256,
		RENDER = 512,
		DESTROY = 768,
	}

	internal sealed class CuePointCallback : MulticastDelegate
	{

		public CuePointCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ref EventPoint eventPoint, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref EventPoint eventPoint, IAsyncResult result) { }

		public override void Invoke(ref EventPoint eventPoint) { }

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class CuePointCallbackFromNativeDelegate : MulticastDelegate
	{

		public CuePointCallbackFromNativeDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IntPtr ptr1, IntPtr ptr2, in EventPoint eventPoint, AsyncCallback callback, object object) { }

		public override void EndInvoke(in EventPoint eventPoint, IAsyncResult result) { }

		public override void Invoke(IntPtr ptr1, IntPtr ptr2, in EventPoint eventPoint) { }

	}

	internal enum MovieEventSyncMode
	{
		FrameTime = 0,
		PlayBackTime = 1,
	}

	internal enum SetMode
	{
		New = 0,
		Append = 1,
		AppendRepeatedly = 2,
	}

	internal sealed class ShaderDispatchCallback : MulticastDelegate
	{

		public ShaderDispatchCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(MovieInfo movieInfo, bool additiveMode, AsyncCallback callback, object object) { }

		public override Shader EndInvoke(IAsyncResult result) { }

		public override Shader Invoke(MovieInfo movieInfo, bool additiveMode) { }

	}

	internal enum Status
	{
		Stop = 0,
		Dechead = 1,
		WaitPrep = 2,
		Prep = 3,
		Ready = 4,
		Playing = 5,
		PlayEnd = 6,
		Error = 7,
		StopProcessing = 8,
		ReadyForRendering = 9,
	}

	internal sealed class StatusChangeCallback : MulticastDelegate
	{

		public StatusChangeCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Status status, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Status status) { }

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class SubtitleCallbackFromNativeDelegate : MulticastDelegate
	{

		public SubtitleCallbackFromNativeDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IntPtr ptr1, IntPtr ptr2, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IntPtr ptr1, IntPtr ptr2) { }

	}

	internal sealed class SubtitleChangeCallback : MulticastDelegate
	{

		public SubtitleChangeCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IntPtr subtitleBuffer, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IntPtr subtitleBuffer) { }

	}

	internal enum TimerType
	{
		None = 0,
		System = 1,
		Audio = 2,
		User = 3,
		Manual = 4,
	}

	private const int InvalidPlayerId = -1; //Field offset: 0x0
	private static Player updatingPlayer; //Field offset: 0x0
	private int playerId; //Field offset: 0x18
	private bool isDisposed; //Field offset: 0x1C
	private Status internalrequiredStatus; //Field offset: 0x20
	private Status _nativeStatus; //Field offset: 0x24
	private Nullable<Status> lastNativeStatus; //Field offset: 0x28
	private Nullable<Status> lastPlayerStatus; //Field offset: 0x30
	private bool wasStopping; //Field offset: 0x38
	private bool isPreparingForRendering; //Field offset: 0x39
	private bool isNativeStartInvoked; //Field offset: 0x3A
	private bool isNativeInitialized; //Field offset: 0x3B
	private RendererResource rendererResource; //Field offset: 0x3C
	private MovieInfo _movieInfo; //Field offset: 0x40
	private FrameInfo _frameInfo; //Field offset: 0x44
	private bool isMovieInfoAvailable; //Field offset: 0x48
	private bool isFrameInfoAvailable; //Field offset: 0x49
	private ShaderDispatchCallback _shaderDispatchCallback; //Field offset: 0x4C
	private bool enableSubtitle; //Field offset: 0x50
	private int subtitleBufferSize; //Field offset: 0x54
	private uint droppedFrameCount; //Field offset: 0x58
	private CriAtomExPlayer _atomExPlayer; //Field offset: 0x5C
	private CriAtomExPlayer _subAtomExPlayer; //Field offset: 0x60
	private CriAtomExPlayer _extraAtomExPlayer; //Field offset: 0x64
	private CriAtomEx3dSource _atomEx3Dsource; //Field offset: 0x68
	private TimerType _timerType; //Field offset: 0x6C
	private bool isStoppingForSeek; //Field offset: 0x70
	public CuePointCallback cuePointCallback; //Field offset: 0x74
	public StatusChangeCallback statusChangeCallback; //Field offset: 0x78
	[CompilerGenerated]
	private SubtitleChangeCallback OnSubtitleChanged; //Field offset: 0x7C
	[CompilerGenerated]
	private bool <additiveMode>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private int <maxFrameDrop>k__BackingField; //Field offset: 0x84
	[CompilerGenerated]
	private bool <applyTargetAlpha>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private bool <uiRenderMode>k__BackingField; //Field offset: 0x89
	[CompilerGenerated]
	private IntPtr <subtitleBuffer>k__BackingField; //Field offset: 0x8C
	[CompilerGenerated]
	private int <subtitleSize>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private CriManaMoviePlayerHolder <playerHolder>k__BackingField; //Field offset: 0x94

	public event SubtitleChangeCallback OnSubtitleChanged
	{
		[CompilerGenerated]
		 add { } //Length: 116
		[CompilerGenerated]
		 remove { } //Length: 116
	}

	public bool additiveMode
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public bool applyTargetAlpha
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public CriAtomEx3dSource atomEx3DsourceForAmbisonics
	{
		 get { } //Length: 11
	}

	public CriAtomExPlayer atomExPlayer
	{
		 get { } //Length: 11
	}

	public CriAtomExPlayer extraAtomExPlayer
	{
		 get { } //Length: 11
	}

	public FrameInfo frameInfo
	{
		 get { } //Length: 21
	}

	public bool isAlive
	{
		 get { } //Length: 15
	}

	public bool isFrameAvailable
	{
		 get { } //Length: 11
	}

	public int maxFrameDrop
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public MovieInfo movieInfo
	{
		 get { } //Length: 21
	}

	public Status nativeStatus
	{
		 get { } //Length: 11
	}

	public int numberOfEntries
	{
		 get { } //Length: 21
	}

	public CriManaMoviePlayerHolder playerHolder
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	private Status requiredStatus
	{
		private get { } //Length: 11
		private set { } //Length: 54
	}

	public Status status
	{
		 get { } //Length: 120
	}

	public CriAtomExPlayer subAtomExPlayer
	{
		 get { } //Length: 11
	}

	public private IntPtr subtitleBuffer
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 17
	}

	public private int subtitleSize
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 17
	}

	public TimerType timerType
	{
		 get { } //Length: 11
	}

	public bool uiRenderMode
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public Player() { }

	public Player(bool advanced_audio_mode, bool ambisonics_mode, uint max_path_length) { }

	[CompilerGenerated]
	public void add_OnSubtitleChanged(SubtitleChangeCallback value) { }

	private void AllocateSubtitleBuffer(int size) { }

	public void CreateRendererResource(int width, int height, bool alpha) { }

	internal static void CRIWARE05AF8628(int player_id, int sw) { }

	internal static void CRIWARE0AED83BB(int player_id, CuePointCallbackFromNativeDelegate cbfunc) { }

	internal static void CRIWARE0B8EC11D(int player_id, int channel) { }

	internal static int CRIWARE0E6FE0FF() { }

	internal static int CRIWARE0FDF6CD1(bool useAtomExPlayer, uint maxPathLength) { }

	internal static void CRIWARE13BD9E57(int player_id, float vol) { }

	internal static void CRIWARE1A07981D(int player_id, bool flag) { }

	internal static int CRIWARE1CE362AA(int player_id) { }

	internal static float CRIWARE21EEB3F1(int player_id) { }

	internal static void CRIWARE22C1FBBB(int player_id, int seek_frame_no) { }

	internal static void CRIWARE2333E702(int player_id, int asr_rack_id) { }

	internal static void CRIWARE2896606F(int player_id, IntPtr binder, string path) { }

	internal static bool CRIWARE289EBCA3(int player_id) { }

	internal static void CRIWARE2AE226CB(int player_id) { }

	internal static float CRIWARE355C2B4D(int player_id) { }

	internal static long CRIWARE36A61960(int player_id) { }

	internal static bool CRIWARE4CFE4282(int player_id, IntPtr binder, int content_id, bool repeat) { }

	internal static IntPtr CRIWARE5030B454(int player_id, uint track_id) { }

	internal static void CRIWARE53977CAE(int player_id, ulong user_count, ulong user_unit) { }

	internal static void CRIWARE598F159A(int player_id, IntPtr binder, int content_id) { }

	internal static void CRIWARE62E793BE(int player_id, int track) { }

	internal static void CRIWARE6A5ACBF2(int player_id, int track) { }

	internal static void CRIWARE6B9B07E4(int player_id) { }

	internal static bool CRIWARE6DFCA962(int player_id, IntPtr binder, string path, bool repeat) { }

	internal static void CRIWARE7716226D(int player_id, float speed) { }

	internal static void CRIWARE7B551ECF(int player_id, ulong timer_unit_n, ulong timer_unit_d) { }

	internal static float CRIWARE83642D09(int player_id) { }

	internal static void CRIWARE8FCB5553(int player_id) { }

	internal static bool CRIWARE94DC7EEA(int player_id, Byte[] data, long datasize, bool repeat) { }

	internal static bool CRIWARE94DC7EEA(int player_id, IntPtr data, long datasize, bool repeat) { }

	internal static void CRIWARE9655DF62(int player_id, ulong key) { }

	internal static void CRIWARE9831938B(int player_id) { }

	internal static void CRIWAREA2B7D9E6(int player_id) { }

	internal static void CRIWAREA813C526(int player_id, out MovieInfo movie_info) { }

	internal static void CRIWAREA920BD55(int player_id, string bus_name, float level) { }

	internal static int CRIWAREAB17D2D4(int player_id) { }

	internal static void CRIWAREAB18F5B8(int player_id, float vol) { }

	internal static void CRIWAREAC7BE179(int player_id, float sec) { }

	internal static void CRIWAREADC2439E(int player_id, string path, ulong offset, long range) { }

	internal static void CRIWAREB7FC020A(int player_id, uint max_data_size) { }

	internal static void CRIWAREC4DA8089(int player_id) { }

	internal static void CRIWAREC5F92567(int player_id, string bus_name, float level) { }

	internal static void CRIWARED74177AF(int player_id, string bus_name, float level) { }

	internal static int CRIWARED7AE33CC(int player_id, IntPtr subtitle_buffer, int subtitle_buffer_size) { }

	internal static void CRIWARED8BE0A91(int player_id) { }

	internal static int CRIWARED905FF07() { }

	internal static void CRIWAREDB70E643(int player_id, SubtitleCallbackFromNativeDelegate cbfunc) { }

	internal static void CRIWAREDE5EC14B(int player_id, float vol) { }

	internal static int CRIWAREDF4FD5E0(int player_id) { }

	internal static void CRIWAREE8BEE129(int player_id, MovieEventSyncMode mode) { }

	internal static void CRIWAREF065484B(int player_id, int min_buffer_size) { }

	internal static void CRIWAREF2D657C1(int player_id, TimerType timer_type) { }

	internal static bool CRIWAREF39F2630(int player_id, string path, ulong offset, long range, bool repeat) { }

	internal static void CRIWAREF53CF2C2(int player_id, int track) { }

	internal static void CRIWAREF6F23ACB(int player_id, IntPtr data, long datasize) { }

	internal static void CRIWAREF6F23ACB(int player_id, Byte[] data, long datasize) { }

	internal static void CRIWAREF9CED43F(int player_id, float quality) { }

	internal static void CRIWAREF9D457EA(int player_id) { }

	internal static void CRIWAREFD2A0F98(int player_id, int sw) { }

	internal static int CRIWAREFFA5BF7F(int player_id) { }

	internal static IntPtr criWareUnity_GetRenderEventFunc() { }

	[MonoPInvokeCallback(typeof(CuePointCallbackFromNativeDelegate))]
	private static void CuePointCallbackFromNative(IntPtr ptr1, IntPtr ptr2, in EventPoint eventPoint) { }

	private void DeallocateSubtitleBuffer() { }

	private void DisableInfos(bool keepFrameInfo = false) { }

	public virtual void Dispose() { }

	private void Dispose(bool disposing) { }

	public void DisposeRendererResource() { }

	protected virtual void Finalize() { }

	[CompilerGenerated]
	public bool get_additiveMode() { }

	[CompilerGenerated]
	public bool get_applyTargetAlpha() { }

	public CriAtomEx3dSource get_atomEx3DsourceForAmbisonics() { }

	public CriAtomExPlayer get_atomExPlayer() { }

	public CriAtomExPlayer get_extraAtomExPlayer() { }

	public FrameInfo get_frameInfo() { }

	public bool get_isAlive() { }

	public bool get_isFrameAvailable() { }

	[CompilerGenerated]
	public int get_maxFrameDrop() { }

	public MovieInfo get_movieInfo() { }

	public Status get_nativeStatus() { }

	public int get_numberOfEntries() { }

	[CompilerGenerated]
	public CriManaMoviePlayerHolder get_playerHolder() { }

	private Status get_requiredStatus() { }

	public Status get_status() { }

	public CriAtomExPlayer get_subAtomExPlayer() { }

	[CompilerGenerated]
	public IntPtr get_subtitleBuffer() { }

	[CompilerGenerated]
	public int get_subtitleSize() { }

	public TimerType get_timerType() { }

	[CompilerGenerated]
	public bool get_uiRenderMode() { }

	public int GetDisplayedFrameNo() { }

	public float GetExtraAudioVolume() { }

	public float GetSubAudioVolume() { }

	public long GetTime() { }

	public float GetVolume() { }

	public bool HasRenderedNewFrame() { }

	private void InternalUpdate() { }

	private void InvokePlayerStatusCheck() { }

	public bool IsPaused() { }

	public void IssuePluginEvent(CriManaUnityPlayer_RenderEventAction renderEventAction) { }

	[IteratorStateMachine(typeof(<IssuePluginUpdatesForFrames>d__157))]
	private IEnumerator IssuePluginUpdatesForFrames(int frameCount, MonoBehaviour playerHolder, bool destroy, int playerId) { }

	public void Loop(bool sw) { }

	internal static void NativeMethods_AdvanceManualTimer(int player_id) { }

	internal static int NativeMethods_Create() { }

	internal static int NativeMethods_CreateWithParameters(bool useAtomExPlayer, uint maxPathLength) { }

	internal static void NativeMethods_Destroy(int player_id) { }

	internal static bool NativeMethods_EntryContentId(int player_id, IntPtr binder, int content_id, bool repeat) { }

	internal static bool NativeMethods_EntryData(int player_id, Byte[] data, long datasize, bool repeat) { }

	internal static bool NativeMethods_EntryData(int player_id, IntPtr data, long datasize, bool repeat) { }

	internal static bool NativeMethods_EntryFile(int player_id, IntPtr binder, string path, bool repeat) { }

	internal static bool NativeMethods_EntryFileRange(int player_id, string path, ulong offset, long range, bool repeat) { }

	internal static IntPtr NativeMethods_GetAtomExPlayerByTrackId(int player_id, uint track_id) { }

	internal static int NativeMethods_GetDisplayedFrameNo(int player_id) { }

	internal static float NativeMethods_GetExtraAudioVolume(int player_id) { }

	internal static void NativeMethods_GetMovieInfo(int player_id, out MovieInfo movie_info) { }

	internal static int NativeMethods_GetNumberOfEntry(int playerId) { }

	internal static IntPtr NativeMethods_GetRenderEventFunc() { }

	internal static float NativeMethods_GetSubAudioVolume(int player_id) { }

	internal static int NativeMethods_GetSubtitleOnTime(int player_id, IntPtr subtitle_buffer, int subtitle_buffer_size) { }

	internal static long NativeMethods_GetTime(int player_id) { }

	internal static float NativeMethods_GetVolume(int player_id) { }

	internal static bool NativeMethods_IsPaused(int player_id) { }

	internal void NativeMethods_Loop(int player_id, int sw) { }

	internal void NativeMethods_Pause(int player_id, int sw) { }

	internal void NativeMethods_Prepare(int player_id) { }

	internal static void NativeMethods_SetAsrRackId(int player_id, int asr_rack_id) { }

	internal static void NativeMethods_SetAudioBaseConcatenation(int player_id, bool flag) { }

	internal static void NativeMethods_SetAudioTrack(int player_id, int track) { }

	internal static void NativeMethods_SetBufferingTime(int player_id, float sec) { }

	internal static void NativeMethods_SetBusSendLevelByName(int player_id, string bus_name, float level) { }

	internal static void NativeMethods_SetContentId(int player_id, IntPtr binder, int content_id) { }

	internal static void NativeMethods_SetCuePointCallback(int player_id, CuePointCallbackFromNativeDelegate cbfunc) { }

	internal static void NativeMethods_SetData(int player_id, Byte[] data, long datasize) { }

	internal static void NativeMethods_SetData(int player_id, IntPtr data, long datasize) { }

	internal static void NativeMethods_SetDecryptionKey(int player_id, ulong key) { }

	internal static void NativeMethods_SetExtraAudioBusSendLevelByName(int player_id, string bus_name, float level) { }

	internal static void NativeMethods_SetExtraAudioTrack(int player_id, int track) { }

	internal static void NativeMethods_SetExtraAudioVolume(int player_id, float vol) { }

	internal static void NativeMethods_SetFile(int player_id, IntPtr binder, string path) { }

	internal static void NativeMethods_SetFileRange(int player_id, string path, ulong offset, long range) { }

	internal static void NativeMethods_SetManualTimerUnit(int player_id, ulong timer_unit_n, ulong timer_unit_d) { }

	internal static void NativeMethods_SetMasterTimerType(int player_id, TimerType timer_type) { }

	internal static void NativeMethods_SetMaxPictureDataSize(int player_id, uint max_data_size) { }

	internal static void NativeMethods_SetMinBufferSize(int player_id, int min_buffer_size) { }

	internal static void NativeMethods_SetMovieEventSyncMode(int player_id, MovieEventSyncMode mode) { }

	internal static void NativeMethods_SetSeekPosition(int player_id, int seek_frame_no) { }

	internal static void NativeMethods_SetSpeed(int player_id, float speed) { }

	internal static void NativeMethods_SetSubAudioBusSendLevelByName(int player_id, string bus_name, float level) { }

	internal static void NativeMethods_SetSubAudioTrack(int player_id, int track) { }

	internal static void NativeMethods_SetSubAudioVolume(int player_id, float vol) { }

	internal static void NativeMethods_SetSubtitleCallback(int player_id, SubtitleCallbackFromNativeDelegate cbfunc) { }

	internal static void NativeMethods_SetSubtitleChannel(int player_id, int channel) { }

	internal static void NativeMethods_SetTimeStretchQuality(int player_id, float quality) { }

	internal static void NativeMethods_SetUserTime(int player_id, ulong user_count, ulong user_unit) { }

	internal static void NativeMethods_SetVolume(int player_id, float vol) { }

	internal void NativeMethods_Start(int player_id) { }

	internal void NativeMethods_Stop(int player_id) { }

	internal static void NativeMethods_SyncMasterTimer(int player_id) { }

	internal static void NativeMethods_SyncUpdate(int player_id) { }

	internal static int NativeMethods_Update(int player_id) { }

	public void OnWillRenderObject(CriManaMovieMaterialBase sender) { }

	public void Pause(bool sw) { }

	public void PauseOnApplicationPause(bool sw) { }

	public void Prepare() { }

	public void PrepareForRendering() { }

	private void PrepareNativePlayer() { }

	[CompilerGenerated]
	public void remove_OnSubtitleChanged(SubtitleChangeCallback value) { }

	[CompilerGenerated]
	public void set_additiveMode(bool value) { }

	[CompilerGenerated]
	public void set_applyTargetAlpha(bool value) { }

	[CompilerGenerated]
	public void set_maxFrameDrop(int value) { }

	[CompilerGenerated]
	public void set_playerHolder(CriManaMoviePlayerHolder value) { }

	private void set_requiredStatus(Status value) { }

	[CompilerGenerated]
	private void set_subtitleBuffer(IntPtr value) { }

	[CompilerGenerated]
	private void set_subtitleSize(int value) { }

	[CompilerGenerated]
	public void set_uiRenderMode(bool value) { }

	public void SetAsrRackId(int asrRackId) { }

	public void SetAudioBaseConcatenation(bool enabled) { }

	public void SetAudioTrack(AudioTrack track) { }

	public void SetAudioTrack(int track) { }

	public void SetBufferingTime(float sec) { }

	public void SetBusSendLevel(string bus_name, float level) { }

	public bool SetContentId(CriFsBinder binder, int contentId, SetMode setMode = 0) { }

	public bool SetData(IntPtr data, long dataSize, SetMode setMode = 0) { }

	[Obsolete("Use SetData(IntPtr, Int64, SetMode) instead")]
	public bool SetData(Byte[] data, long datasize, SetMode setMode = 0) { }

	public void SetDecryptionKey(ulong key) { }

	public void SetExtraAudioBusSendLevel(string bus_name, float volume) { }

	public void SetExtraAudioTrack(AudioTrack track) { }

	public void SetExtraAudioTrack(int track) { }

	public void SetExtraAudioVolume(float volume) { }

	public bool SetFile(CriFsBinder binder, string moviePath, SetMode setMode = 0) { }

	public bool SetFileRange(string filePath, ulong offset, long range, SetMode setMode = 0) { }

	public void SetManualTimerUnit(ulong timeUnitN, ulong timeUnitD) { }

	public void SetMasterTimerType(TimerType timerType) { }

	public void SetMaxPictureDataSize(uint maxDataSize) { }

	public void SetMinBufferSize(int min_buffer_size) { }

	public void SetMovieEventSyncMode(MovieEventSyncMode mode) { }

	public void SetSeekPosition(int frameNumber) { }

	public void SetShaderDispatchCallback(ShaderDispatchCallback shaderDispatchCallback) { }

	public void SetSpeed(float speed) { }

	public void SetSubAudioBusSendLevel(string bus_name, float volume) { }

	public void SetSubAudioTrack(int track) { }

	public void SetSubAudioTrack(AudioTrack track) { }

	public void SetSubAudioVolume(float volume) { }

	public void SetSubtitleChannel(int channel) { }

	public void SetTimeStretchQuality(float quality) { }

	internal void SetupPlayerHolder() { }

	public void SetVolume(float volume) { }

	public void Start() { }

	public void Stop() { }

	public void StopForSeek() { }

	[MonoPInvokeCallback(typeof(SubtitleCallbackFromNativeDelegate))]
	private static void SubtitleCallbackFromNative(IntPtr ptr1, IntPtr ptr2) { }

	public void SyncMasterTimer() { }

	public void Update() { }

	public bool UpdateMaterial(Material material) { }

	private void UpdateNativePlayer() { }

	public void UpdateWithManualTimeAdvanced() { }

	public void UpdateWithUserTime(ulong timeCount, ulong timeUnit) { }

}

