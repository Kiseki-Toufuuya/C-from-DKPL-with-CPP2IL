namespace XeApp.Game;

public class AdvBgmPlayer
{
	private enum MAIN_STEP
	{
		WAIT = 0,
		FADE_OUT = 1,
	}

	public static AdvBgmPlayer Instance; //Field offset: 0x0
	private MAIN_STEP m_Step; //Field offset: 0x8
	private MAIN_STEP m_StepReq; //Field offset: 0xC
	private float m_countTime; //Field offset: 0x10
	private float m_FadeTime; //Field offset: 0x14
	private int m_Cnt; //Field offset: 0x18

	public AdvBgmPlayer(string eventFileName = null) { }

	public void Continue() { }

	public bool IsPlaying() { }

	public bool IsPrepared() { }

	public void Pause() { }

	public void PlayStart(int bgmNo) { }

	public void Prepare() { }

	public void SetFadeOut(float time = 0) { }

	public void SetVolume(float volume) { }

	public void Shutdown() { }

	public void Stop() { }

	public void Update() { }

}

