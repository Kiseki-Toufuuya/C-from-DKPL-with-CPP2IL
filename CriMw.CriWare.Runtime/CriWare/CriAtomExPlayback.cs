namespace CriWare;

public struct CriAtomExPlayback
{
	internal enum Status
	{
		Prep = 1,
		Playing = 2,
		Removed = 3,
	}

	internal struct TrackInfo
	{
		public uint id; //Field offset: 0x0
		public CueType sequenceType; //Field offset: 0x4
		public IntPtr playerHn; //Field offset: 0x8
		public ushort trackNo; //Field offset: 0xC
		public ushort reserved; //Field offset: 0xE

	}

	public const uint invalidId = 4294967295; //Field offset: 0x0
	[CompilerGenerated]
	private uint <id>k__BackingField; //Field offset: 0x0

	public private uint id
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 10
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public Status status
	{
		 get { } //Length: 16
	}

	public long time
	{
		 get { } //Length: 16
	}

	public long timeSyncedWithAudio
	{
		 get { } //Length: 16
	}

	public CriAtomExPlayback(uint id) { }

	private static bool criAtomExPlayback_GetBeatSyncInfo(uint id, out Info info) { }

	private static int criAtomExPlayback_GetCurrentBlockIndex(uint id) { }

	private static bool criAtomExPlayback_GetFormatInfo(uint id, out FormatInfo info) { }

	private static bool criAtomExPlayback_GetNumPlayedSamples(uint id, out long num_samples, out int sampling_rate) { }

	private static bool criAtomExPlayback_GetPlaybackTrackInfo(uint id, out TrackInfo info) { }

	private static long criAtomExPlayback_GetSequencePosition(uint id) { }

	private static Status criAtomExPlayback_GetStatus(uint id) { }

	private static long criAtomExPlayback_GetTime(uint id) { }

	private static long criAtomExPlayback_GetTimeSyncedWithAudio(uint id) { }

	private static bool criAtomExPlayback_IsPaused(uint id) { }

	private static void criAtomExPlayback_Pause(uint id, bool sw) { }

	private static void criAtomExPlayback_Resume(uint id, ResumeMode mode) { }

	private static bool criAtomExPlayback_SetBeatSyncOffset(uint id, short timeMs) { }

	private static void criAtomExPlayback_SetNextBlockIndex(uint id, int index) { }

	private static void criAtomExPlayback_Stop(uint id) { }

	private static void criAtomExPlayback_StopWithoutReleaseTime(uint id) { }

	[CompilerGenerated]
	[IsReadOnly]
	public uint get_id() { }

	public Status get_status() { }

	public long get_time() { }

	public long get_timeSyncedWithAudio() { }

	public bool GetBeatSyncInfo(out Info info) { }

	public int GetCurrentBlockIndex() { }

	public bool GetFormatInfo(out FormatInfo info) { }

	public bool GetNumPlayedSamples(out long numSamples, out int samplingRate) { }

	public long GetSequencePosition() { }

	public Status GetStatus() { }

	public long GetTime() { }

	public long GetTimeSyncedWithAudio() { }

	public bool GetTrackInfo(out TrackInfo info) { }

	public bool IsPaused() { }

	public void Pause() { }

	public void Pause(bool sw) { }

	public void Resume(ResumeMode mode) { }

	[CompilerGenerated]
	private void set_id(uint value) { }

	public bool SetBeatSyncOffset(short timeMs) { }

	public void SetNextBlockIndex(int index) { }

	public void Stop() { }

	public void Stop(bool ignoresReleaseTime) { }

	public void StopWithoutReleaseTime() { }

}

