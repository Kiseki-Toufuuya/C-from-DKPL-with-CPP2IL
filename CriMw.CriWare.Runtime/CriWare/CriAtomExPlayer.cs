namespace CriWare;

public class CriAtomExPlayer : CriDisposable
{
	public struct Config
	{
		public VoiceAllocationMethod voiceAllocationMethod; //Field offset: 0x0
		public int maxPathStrings; //Field offset: 0x4
		public int maxPath; //Field offset: 0x8
		public int maxAisacs; //Field offset: 0xC
		public bool updatesTime; //Field offset: 0x10
		public bool enableAudioSyncedTimer; //Field offset: 0x11

		public static Config Default
		{
			 get { } //Length: 42
		}

		public static Config get_Default() { }

	}

	internal enum PitchShifterParameterId
	{
		Pitch = 0,
		Formant = 1,
		Mode = 2,
	}

	internal enum Status
	{
		Stop = 0,
		Prep = 1,
		Playing = 2,
		PlayEnd = 3,
		Error = 4,
	}

	internal enum TimeStretchParameterId
	{
		Ratio = 0,
		FrameTime = 1,
		Quality = 2,
	}

	public static readonly uint MaxOutputPorts; //Field offset: 0x0
	[CompilerGenerated]
	private CbFunc _onBeatSyncCallback; //Field offset: 0x18
	[CompilerGenerated]
	private EventCallback _onSequenceCallback; //Field offset: 0x1C
	private bool hasExistingNativeHandle; //Field offset: 0x20
	private IntPtr entryPoolHandle; //Field offset: 0x24
	private int _entryPoolCapacity; //Field offset: 0x28
	private int max_path; //Field offset: 0x2C
	private IntPtr handle; //Field offset: 0x30

	private event CbFunc _onBeatSyncCallback
	{
		[CompilerGenerated]
		private add { } //Length: 116
		[CompilerGenerated]
		private remove { } //Length: 116
	}

	private event EventCallback _onSequenceCallback
	{
		[CompilerGenerated]
		private add { } //Length: 116
		[CompilerGenerated]
		private remove { } //Length: 116
	}

	public event CbFunc OnBeatSyncCallback
	{
		 add { } //Length: 196
		 remove { } //Length: 196
	}

	public event EventCallback OnSequenceCallback
	{
		 add { } //Length: 196
		 remove { } //Length: 196
	}

	public int entryPoolCapacity
	{
		 get { } //Length: 11
	}

	public bool isAvailable
	{
		 get { } //Length: 15
	}

	public IntPtr nativeHandle
	{
		 get { } //Length: 11
	}

	private static CriAtomExPlayer() { }

	public CriAtomExPlayer(int maxPath, int maxPathStrings, bool enableAudioSyncedTimer, IntPtr existingNativeHandle) { }

	public CriAtomExPlayer(IntPtr existingNativeHandle) { }

	public CriAtomExPlayer(int maxPath, int maxPathStrings, bool enableAudioSyncedTimer) { }

	public CriAtomExPlayer(bool enableAudioSyncedTimer) { }

	public CriAtomExPlayer() { }

	public CriAtomExPlayer(int maxPath, int maxPathStrings) { }

	[CompilerGenerated]
	private void add__onBeatSyncCallback(CbFunc value) { }

	[CompilerGenerated]
	private void add__onSequenceCallback(EventCallback value) { }

	public void add_OnBeatSyncCallback(CbFunc value) { }

	public void add_OnSequenceCallback(EventCallback value) { }

	public void AddOutputPort(CriAtomExOutputPort outputPort) { }

	public void AddPreferredOutputPort(CriAtomExOutputPort outputPort) { }

	public void AttachAisac(string globalAisacName) { }

	public void AttachFader() { }

	public void AttachTween(CriAtomExTween tween) { }

	public void ClearOutputPorts() { }

	public void ClearPreferredOutputPorts() { }

	public void ClearSelectorLabels() { }

	private static void criAtomExPlayer_AddOutputPort(IntPtr player, IntPtr outputPort) { }

	private static void criAtomExPlayer_AddPreferredOutputPort(IntPtr player, IntPtr outputPort) { }

	private static void criAtomExPlayer_AttachAisac(IntPtr player, string globalAisacName) { }

	private static void criAtomExPlayer_AttachFader(IntPtr player, IntPtr config, IntPtr work, int work_size) { }

	private static void criAtomExPlayer_AttachTween(IntPtr player, IntPtr tween) { }

	private static void criAtomExPlayer_ClearOutputPorts(IntPtr player) { }

	private static void criAtomExPlayer_ClearPreferredOutputPorts(IntPtr player) { }

	private static void criAtomExPlayer_ClearSelectorLabels(IntPtr player) { }

	private static IntPtr criAtomExPlayer_Create(ref Config config, IntPtr work, int work_size) { }

	private static void criAtomExPlayer_Destroy(IntPtr player) { }

	private static void criAtomExPlayer_DetachAisac(IntPtr player, string globalAisacName) { }

	private static void criAtomExPlayer_DetachFader(IntPtr player) { }

	private static void criAtomExPlayer_DetachTween(IntPtr player, IntPtr tween) { }

	private static void criAtomExPlayer_DetachTweenAll(IntPtr player) { }

	private static bool criAtomExPlayer_GetAttachedAisacInfo(IntPtr player, int aisac_attached_index, IntPtr aisac_info) { }

	private static bool criAtomExPlayer_GetBusSendLevelByName(IntPtr player, string bus_name, out float level) { }

	private static bool criAtomExPlayer_GetBusSendLevelOffsetByName(IntPtr player, string bus_name, out float level_offset) { }

	private static uint criAtomExPlayer_GetLastPlaybackId(IntPtr player) { }

	private static float criAtomExPlayer_GetParameterFloat32(IntPtr player, Parameter id) { }

	private static int criAtomExPlayer_GetParameterSint32(IntPtr player, Parameter id) { }

	private static uint criAtomExPlayer_GetParameterUint32(IntPtr player, Parameter id) { }

	private static IntPtr criAtomExPlayer_GetPlayerParameter(IntPtr player) { }

	private static Status criAtomExPlayer_GetStatus(IntPtr player) { }

	private static long criAtomExPlayer_GetTime(IntPtr player) { }

	private static bool criAtomExPlayer_IsFading(IntPtr player) { }

	private static bool criAtomExPlayer_IsPaused(IntPtr player) { }

	private static int criAtomExPlayer_IsReadyToStartAsync(IntPtr player) { }

	private static void criAtomExPlayer_LimitLoopCount(IntPtr player, int count) { }

	private static void criAtomExPlayer_Pause(IntPtr player, bool sw) { }

	private static uint criAtomExPlayer_Prepare(IntPtr player) { }

	private static void criAtomExPlayer_RemoveOutputPort(IntPtr player, IntPtr outputPort) { }

	private static void criAtomExPlayer_RemovePreferredOutputPort(IntPtr player, IntPtr outputPort) { }

	private static void criAtomExPlayer_RemovePreferredOutputPortByName(IntPtr player, string name) { }

	private static void criAtomExPlayer_ResetFaderParameters(IntPtr player) { }

	private static void criAtomExPlayer_ResetParameters(IntPtr player) { }

	private static void criAtomExPlayer_Resume(IntPtr player, ResumeMode mode) { }

	private static void criAtomExPlayer_Set3dListenerHn(IntPtr player, IntPtr listener) { }

	private static void criAtomExPlayer_Set3dSourceHn(IntPtr player, IntPtr source) { }

	private static void criAtomExPlayer_SetAisacControlById(IntPtr player, ushort control_id, float control_value) { }

	private static void criAtomExPlayer_SetAisacControlByName(IntPtr player, string control_name, float control_value) { }

	private static void criAtomExPlayer_SetAsrRackId(IntPtr player, int asr_rack_id) { }

	private static void criAtomExPlayer_SetBandpassFilterParameters(IntPtr player, float cof_low, float cof_high) { }

	private static void criAtomExPlayer_SetBiquadFilterParameters(IntPtr player, BiquadFilterType type, float frequency, float gain, float q) { }

	private static void criAtomExPlayer_SetBusSendLevel(IntPtr player, int bus_id, float level) { }

	private static void criAtomExPlayer_SetBusSendLevelByName(IntPtr player, string bus_name, float level) { }

	private static void criAtomExPlayer_SetBusSendLevelOffset(IntPtr player, int bus_id, float level_offset) { }

	private static void criAtomExPlayer_SetBusSendLevelOffsetByName(IntPtr player, string bus_name, float level_offset) { }

	private static void criAtomExPlayer_SetCategoryById(IntPtr player, uint category_id) { }

	private static void criAtomExPlayer_SetCategoryByName(IntPtr player, string category_name) { }

	private static void criAtomExPlayer_SetContentId(IntPtr player, IntPtr binder, int id) { }

	private static void criAtomExPlayer_SetCueId(IntPtr player, IntPtr acb_hn, int id) { }

	private static void criAtomExPlayer_SetCueIndex(IntPtr player, IntPtr acb_hn, int index) { }

	private static void criAtomExPlayer_SetCueName(IntPtr player, IntPtr acb_hn, string cue_name) { }

	private static void criAtomExPlayer_SetCuePriority(IntPtr player, int cue_priority) { }

	private static void criAtomExPlayer_SetData(IntPtr player, Byte[] buffer, int size) { }

	private static void criAtomExPlayer_SetData(IntPtr player, IntPtr buffer, int size) { }

	private static void criAtomExPlayer_SetDspParameter(IntPtr player, int id, float value) { }

	private static void criAtomExPlayer_SetEnvelopeAttackCurve(IntPtr player, CurveType curve_type, float strength) { }

	private static void criAtomExPlayer_SetEnvelopeAttackTime(IntPtr player, float attack_time_ms) { }

	private static void criAtomExPlayer_SetEnvelopeDecayCurve(IntPtr player, CurveType curve_type, float strength) { }

	private static void criAtomExPlayer_SetEnvelopeDecayTime(IntPtr player, float decay_time_ms) { }

	private static void criAtomExPlayer_SetEnvelopeHoldTime(IntPtr player, float hold_time_ms) { }

	private static void criAtomExPlayer_SetEnvelopeReleaseCurve(IntPtr player, CurveType curve_type, float strength) { }

	private static void criAtomExPlayer_SetEnvelopeReleaseTime(IntPtr player, float release_time_ms) { }

	private static void criAtomExPlayer_SetEnvelopeSustainLevel(IntPtr player, float susutain_level) { }

	private static void criAtomExPlayer_SetFadeInStartOffset(IntPtr player, int ms) { }

	private static void criAtomExPlayer_SetFadeInTime(IntPtr player, int ms) { }

	private static void criAtomExPlayer_SetFadeOutEndDelay(IntPtr player, int ms) { }

	private static void criAtomExPlayer_SetFadeOutTime(IntPtr player, int ms) { }

	private static void criAtomExPlayer_SetFile(IntPtr player, IntPtr binder, string path) { }

	private static void criAtomExPlayer_SetFirstBlockIndex(IntPtr player, int index) { }

	private static void criAtomExPlayer_SetFormat(IntPtr player, Format format) { }

	private static void criAtomExPlayer_SetGroupNumber(IntPtr player, int group_no) { }

	private static void criAtomExPlayer_SetNumChannels(IntPtr player, int num_channels) { }

	private static void criAtomExPlayer_SetPan3dAngle(IntPtr player, float pan3d_angle) { }

	private static void criAtomExPlayer_SetPan3dInteriorDistance(IntPtr player, float pan3d_interior_distance) { }

	private static void criAtomExPlayer_SetPan3dVolume(IntPtr player, float pan3d_volume) { }

	private static void criAtomExPlayer_SetPanType(IntPtr player, PanType panType) { }

	private static void criAtomExPlayer_SetPitch(IntPtr player, float pitch) { }

	private static void criAtomExPlayer_SetPlaybackRatio(IntPtr player, float playback_ratio) { }

	private static void criAtomExPlayer_SetPreDelayTime(IntPtr player, float predelay_time_ms) { }

	private static void criAtomExPlayer_SetRandomSeed(IntPtr player, uint seed) { }

	private static void criAtomExPlayer_SetSamplingRate(IntPtr player, int sampling_rate) { }

	private static void criAtomExPlayer_SetScheduleTime(IntPtr player, long schedule_time) { }

	private static void criAtomExPlayer_SetSelectorLabel(IntPtr player, string selector, string label) { }

	private static void criAtomExPlayer_SetSendLevel(IntPtr player, int channel, Speaker id, float level) { }

	private static void criAtomExPlayer_SetSequencePrepareTime(IntPtr player, uint seq_prep_time_ms) { }

	private static void criAtomExPlayer_SetSoundRendererType(IntPtr player, SoundRendererType type) { }

	private static void criAtomExPlayer_SetStartTime(IntPtr player, long start_time_ms) { }

	private static void criAtomExPlayer_SetStartTimeMicro(IntPtr player, long startTimeUs) { }

	private static void criAtomExPlayer_SetVoiceControlMethod(IntPtr player, VoiceControlMethod method) { }

	private static void criAtomExPlayer_SetVoicePoolIdentifier(IntPtr player, uint identifier) { }

	private static void criAtomExPlayer_SetVoicePriority(IntPtr player, int priority) { }

	private static void criAtomExPlayer_SetVolume(IntPtr player, float volume) { }

	private static uint criAtomExPlayer_Start(IntPtr player) { }

	private static int criAtomExPlayer_StartAsync(IntPtr player, IntPtr playback_id) { }

	private static void criAtomExPlayer_Stop(IntPtr player) { }

	private static void criAtomExPlayer_StopAsync(IntPtr player) { }

	private static void criAtomExPlayer_StopWithoutReleaseTime(IntPtr player) { }

	private static void criAtomExPlayer_UnsetCategory(IntPtr player) { }

	private static void criAtomExPlayer_UnsetSelectorLabel(IntPtr player, string selector) { }

	private static void criAtomExPlayer_Update(IntPtr player, uint id) { }

	private static void criAtomExPlayer_UpdateAll(IntPtr player) { }

	private static void criAtomExPlayerParameter_RemoveParameter(IntPtr player_parameter, uint id) { }

	private static void CRIWARE0C58291D(IntPtr player, bool sw) { }

	private static void CRIWARE3530A6C4(IntPtr pool) { }

	private static void CRIWARE43CC4F14(IntPtr pool) { }

	private static int CRIWARE47A85EC6(IntPtr pool) { }

	private static bool CRIWARE4A153350(IntPtr pool, IntPtr binder, string path, bool repeat, int max_path) { }

	private static bool CRIWARE645F7B19(IntPtr pool, Byte[] buffer, int size, bool repeat) { }

	private static bool CRIWARE645F7B19(IntPtr pool, IntPtr buffer, int size, bool repeat) { }

	private static void CRIWARE87C8F275(IntPtr pool) { }

	private static bool CRIWAREA4C476BD(IntPtr pool, IntPtr acbhn, string name, bool repeat) { }

	private static IntPtr CRIWARED0E9D16D(IntPtr player, int capacity, int max_path, bool stopOnEmpty) { }

	private static bool CRIWARED4E9E1C6(IntPtr pool, IntPtr binder, int id, bool repeat) { }

	private static int CRIWAREDCD46024(IntPtr pool) { }

	public void DetachAisac(string globalAisacName) { }

	public void DetachFader() { }

	public void DetachTween(CriAtomExTween tween) { }

	public void DetachTweenAll() { }

	public virtual void Dispose() { }

	public bool EntryContentId(CriFsBinder binder, int contentId, bool repeat) { }

	public bool EntryCue(CriAtomExAcb acb, string name, bool repeat) { }

	public bool EntryData(Byte[] buffer, int size, bool repeat) { }

	public bool EntryData(IntPtr buffer, int size, bool repeat) { }

	public bool EntryFile(CriFsBinder binder, string path, bool repeat) { }

	protected virtual void Finalize() { }

	public int get_entryPoolCapacity() { }

	public bool get_isAvailable() { }

	public IntPtr get_nativeHandle() { }

	public bool GetAttachedAisacInfo(int aisacAttachedIndex, out AisacInfo aisacInfo) { }

	public bool GetBusSendLevel(string busName, out float level) { }

	public bool GetBusSendLevelOffset(string busName, out float level) { }

	public CriAtomExPlayback GetLastPlaybackId() { }

	public int GetNumConsumedEntries() { }

	public int GetNumEntries() { }

	public float GetParameterFloat32(Parameter id) { }

	public int GetParameterSint32(Parameter id) { }

	public uint GetParameterUint32(Parameter id) { }

	public Status GetStatus() { }

	public long GetTime() { }

	public bool IsFading() { }

	public bool IsPaused() { }

	public bool IsReadyToStartAsync() { }

	public void Loop(bool sw) { }

	private void OnBeatSyncCallbackChainInternal(ref Info info) { }

	private void OnSequenceCallbackChainInternal(ref CriAtomExSequenceEventInfo info) { }

	public void Pause() { }

	public void Pause(bool sw) { }

	public CriAtomExPlayback Prepare() { }

	public void PrepareEntryPool(int capacity, bool stopOnEmpty) { }

	[CompilerGenerated]
	private void remove__onBeatSyncCallback(CbFunc value) { }

	[CompilerGenerated]
	private void remove__onSequenceCallback(EventCallback value) { }

	public void remove_OnBeatSyncCallback(CbFunc value) { }

	public void remove_OnSequenceCallback(EventCallback value) { }

	public void RemoveOutputPort(CriAtomExOutputPort outputPort) { }

	public void RemovePreferredOutputPort(CriAtomExOutputPort outputPort) { }

	public void RemovePreferredOutputPort(string name) { }

	public void ResetFaderParameters() { }

	public void ResetParameters() { }

	public void Resume(ResumeMode mode) { }

	public void Set3dListener(CriAtomEx3dListener listener) { }

	public void Set3dSource(CriAtomEx3dSource source) { }

	[Obsolete("Use CriAtomExPlayer.SetAisacControl")]
	public void SetAisac(string controlName, float value) { }

	[Obsolete("Use SetAisacControl")]
	public void SetAisac(uint controlId, float value) { }

	public void SetAisacControl(string controlName, float value) { }

	public void SetAisacControl(uint controlId, float value) { }

	public void SetAsrRackId(int asr_rack_id) { }

	public void SetBandpassFilterParameters(float cofLow, float cofHigh) { }

	public void SetBiquadFilterParameters(BiquadFilterType type, float frequency, float gain, float q) { }

	[Obsolete("Use CriAtomExPlayer.SetBusSendLevel(string busName, float level)")]
	public void SetBusSendLevel(int busId, float level) { }

	public void SetBusSendLevel(string busName, float level) { }

	public void SetBusSendLevelOffset(string busName, float levelOffset) { }

	[Obsolete("Use CriAtomExPlayer.SetBusSendLevelOffset(int busId, float levelOffset)")]
	public void SetBusSendLevelOffset(int busId, float levelOffset) { }

	public void SetCategory(string categoryName) { }

	public void SetCategory(int categoryId) { }

	public void SetContentId(CriFsBinder binder, int contentId) { }

	public void SetCue(CriAtomExAcb acb, int id) { }

	public void SetCue(CriAtomExAcb acb, string name) { }

	public void SetCueIndex(CriAtomExAcb acb, int index) { }

	public void SetCuePriority(int priority) { }

	public void SetData(Byte[] buffer, int size) { }

	public void SetData(IntPtr buffer, int size) { }

	public void SetDspParameter(int id, float value) { }

	public void SetDspPitchShifterPitch(float pitch) { }

	public void SetDspTimeStretchRatio(float ratio) { }

	public void SetEnvelopeAttackCurve(CurveType curveType, float strength) { }

	public void SetEnvelopeAttackTime(float time) { }

	public void SetEnvelopeDecayCurve(CurveType curveType, float strength) { }

	public void SetEnvelopeDecayTime(float time) { }

	public void SetEnvelopeHoldTime(float time) { }

	public void SetEnvelopeReleaseCurve(CurveType curveType, float strength) { }

	public void SetEnvelopeReleaseTime(float time) { }

	public void SetEnvelopeSustainLevel(float level) { }

	public void SetFadeInStartOffset(int ms) { }

	public void SetFadeInTime(int ms) { }

	public void SetFadeOutEndDelay(int ms) { }

	public void SetFadeOutTime(int ms) { }

	public void SetFile(CriFsBinder binder, string path) { }

	public void SetFirstBlockIndex(int index) { }

	public void SetFormat(Format format) { }

	public void SetGroupNumber(int group_no) { }

	public void SetNumChannels(int numChannels) { }

	public void SetPan3dAngle(float angle) { }

	public void SetPan3dInteriorDistance(float distance) { }

	public void SetPan3dVolume(float volume) { }

	public void SetPanType(PanType panType) { }

	public void SetPitch(float pitch) { }

	public void SetPlaybackRatio(float ratio) { }

	public void SetPreDelayTime(float time) { }

	public void SetRandomSeed(uint seed) { }

	public void SetSamplingRate(int samplingRate) { }

	public void SetScheduleTime(long scheduleTime) { }

	public void SetSelectorLabel(string selector, string label) { }

	public void SetSendLevel(int channel, Speaker id, float level) { }

	public void SetSequencePrepareTime(uint ms) { }

	public void SetSoundRendererType(SoundRendererType type) { }

	public void SetStartTime(long startTimeMs) { }

	public void SetStartTimeMicro(long startTimeUs) { }

	public void SetVoiceControlMethod(VoiceControlMethod method) { }

	public void SetVoicePoolIdentifier(uint identifier) { }

	public void SetVoicePriority(int priority) { }

	public void SetVolume(float volume) { }

	public CriAtomExPlayback Start() { }

	public bool StartAsync(IntPtr playbackId = null) { }

	public void Stop(bool ignoresReleaseTime) { }

	public void Stop() { }

	public void StopAsync() { }

	public void StopWithoutReleaseTime() { }

	public void UnsetCategory() { }

	public void UnsetSelectorLabel(string selector) { }

	public void Update(CriAtomExPlayback playback) { }

	public void UpdateAll() { }

}

