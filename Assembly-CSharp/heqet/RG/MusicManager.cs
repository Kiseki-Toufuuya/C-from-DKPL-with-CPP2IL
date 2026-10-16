namespace Heqet.RG;

public class MusicManager : MonoBehaviour
{
	private string songName; //Field offset: 0x10
	[SerializeField]
	private CriAtomSourceEx source; //Field offset: 0x14
	public CriAtomSourceEx sourceSE; //Field offset: 0x18

	public MusicManager() { }

	public float GetElapsedTime() { }

	public float GetLength() { }

	public float GetNormalizeCurrentTime() { }

	public bool IsMuteBGM() { }

	public bool IsPlayEnd() { }

	public void MuteBGM(bool enable) { }

	public void OnDestroy() { }

	public void Pause(bool enable) { }

	private void Play(string songName_) { }

	public void PlayBGM(string key) { }

	public void PlaySE(string key) { }

	public void SetStartTime(float time) { }

	public void Stop() { }

}

