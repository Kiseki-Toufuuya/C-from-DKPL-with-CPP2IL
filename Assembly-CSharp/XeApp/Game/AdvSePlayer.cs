namespace XeApp.Game;

public class AdvSePlayer
{
	private enum MAIN_STEP
	{
		WAIT = 0,
		FADE_OUT = 1,
	}

	public static AdvSePlayer Instance; //Field offset: 0x0
	public CriAtomSource CriSource; //Field offset: 0x8
	public bool SeEnable; //Field offset: 0xC
	private MAIN_STEP m_Step; //Field offset: 0x10
	private MAIN_STEP m_StepReq; //Field offset: 0x14
	private CriAtomExPlayback Playback; //Field offset: 0x18
	private Dictionary<String, CriAtomExPlayback> PlayList; //Field offset: 0x1C
	private string CueName; //Field offset: 0x20
	private CriAtomCueSheet CueSheet; //Field offset: 0x24
	private float m_countTime; //Field offset: 0x28
	private float m_FadeTime; //Field offset: 0x2C
	private float m_volumDefault; //Field offset: 0x30
	public readonly string debug_cue_name; //Field offset: 0x34

	public AdvSePlayer(string eventFileName = null) { }

	public void Continue() { }

	public long GetAdvSeDownLoadSize() { }

	public bool IsCueExists(string cueId) { }

	public bool IsPlaying() { }

	public bool IsPrepared() { }

	public void Pause() { }

	public CriAtomExPlayback PlayStart(string cueId) { }

	public void Prepare() { }

	public void SetFadeOut(float time = 0) { }

	public void SetVolume(float volume) { }

	public void Shutdown() { }

	public void Stop(string cueId) { }

	public void StopAll() { }

	public void Update() { }

}

