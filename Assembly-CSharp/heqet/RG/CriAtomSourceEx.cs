namespace Heqet.RG;

public class CriAtomSourceEx : CriAtomSource
{
	private CriAtomExPlayback playback; //Field offset: 0x78
	private bool internalExInitialize; //Field offset: 0x7C
	private float musicLength; //Field offset: 0x80
	private float prevElapsedTime; //Field offset: 0x84
	private float elapsedTime; //Field offset: 0x88

	public float ElapsedTime
	{
		 get { } //Length: 14
	}

	public float MusicLength
	{
		 get { } //Length: 14
	}

	public CriAtomSourceEx() { }

	public void Clear() { }

	public float get_ElapsedTime() { }

	public float get_MusicLength() { }

	private static long GetAudioSourceLength(string cueSheetName_, string cueName_) { }

	private float GetElapsedTime() { }

	private float GetMusicLength() { }

	protected void InitializeAtomPlayer() { }

	protected void InitializeAtomWavePlayer() { }

	protected virtual void InternalInitialize() { }

	public bool IsPlayEnd() { }

	private void OnDestroy() { }

	public bool PlayEx(string filePath) { }

	public void SetVolume(float volume) { }

	public void Update() { }

}

