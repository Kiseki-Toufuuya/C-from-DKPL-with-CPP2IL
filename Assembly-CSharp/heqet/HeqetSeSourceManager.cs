namespace Heqet;

public class HeqetSeSourceManager
{
	private static HeqetSeSourceManager instance; //Field offset: 0x0
	private Dictionary<CueSheetID, CriSeSource> instanceDictionary; //Field offset: 0x8

	public HeqetSeSourceManager() { }

	public CriSeSource Add(CueSheetID cueSheetID) { }

	public void AddBoot() { }

	public void AddInGame() { }

	protected virtual void Finalize() { }

	public CriSeSource GetCriSeSource(CueSheetID cueSheetID) { }

	public static HeqetSeSourceManager GetInstance() { }

	public bool IsCreateCriSeSource(CueSheetID cueSheetID) { }

	public CriAtomExPlayback PlayStart(CueSheetID cueSheetID, int cueId, bool managedLoop = false) { }

	public CriAtomExPlayback PlayStart(ALL_SE allSeID, bool managedLoop = false) { }

	public void Remove(CueSheetID cueSheetID) { }

	public void RemoveInGame() { }

	public void SetBgmVolume() { }

	public void SetBgmVolume(float volume) { }

	public void SetDanmakuVolume(int BtNo = 0) { }

	public void SetDanmakuVolume(float volume) { }

	public void SetDirectionVolume(int BtNo = 0) { }

	public void SetDirectionVolume(float volume) { }

	public void SetMusicVolume(int BtNo = 0) { }

	public void SetMusicVolume(float volume) { }

	public void SetSeVolume() { }

	public void SetSeVolume(float volume) { }

	public void SetTapVolume(int BtNo = 0) { }

	public void SetTapVolume(float volume) { }

	public void SetVoiceVolume() { }

	public void SetVoiceVolume(float volume) { }

	public void Stop(CueSheetID cueSheetID) { }

	public void StopManagedSE(ALL_SE allSeID) { }

}

