namespace XeApp.Game;

public class AdvVoicePlayer
{
	public static AdvVoicePlayer Instance; //Field offset: 0x0
	public CriAtomSource CriSource; //Field offset: 0x8
	public bool VoiceEnable; //Field offset: 0xC
	private CriAtomExPlayback Playback; //Field offset: 0x10
	private string CueName; //Field offset: 0x14
	private CriAtomCueSheet CueSheet; //Field offset: 0x18
	public int m_VoiceVolumeCheckWaitFrame; //Field offset: 0x1C
	public float m_VoiceBusVolumeLimitStart; //Field offset: 0x20
	public float m_VoiceBusVolumeLimitEnd; //Field offset: 0x24
	private bool OneCheckSkip; //Field offset: 0x28

	public AdvVoicePlayer(string eventFileName, bool enable) { }

	public void Continue() { }

	public void DebugLoadVoiceReq() { }

	public bool IsCueExists(int cue) { }

	public bool IsCueExists(string cue) { }

	public bool IsPlaying() { }

	public bool IsPlayingVoiceVolume(bool nowStart = false) { }

	public bool IsPrepared() { }

	public bool IsStopVoice() { }

	public void Pause() { }

	public CriAtomExPlayback PlayStart(int cueId) { }

	public CriAtomExPlayback PlayStart(string cueId) { }

	public void Prepare() { }

	public void Shutdown() { }

	public void Stop() { }

}

