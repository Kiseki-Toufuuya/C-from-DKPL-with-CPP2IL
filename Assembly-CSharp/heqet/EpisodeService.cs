namespace Heqet;

public class EpisodeService
{
	internal class EpisodeViewModel
	{
		public EpisodeStatus Episode; //Field offset: 0x8

		public EpisodeViewModel() { }

	}

	internal enum Result
	{
		Success = 0,
		Cancel = 1,
		ErrorToTitle = 2,
	}

	private static EpisodeService instance; //Field offset: 0x0
	private EpisodeViewModel ViewModel; //Field offset: 0x8
	public string SessionId; //Field offset: 0xC
	public long SesssioStart; //Field offset: 0x10
	private bool IsRunning; //Field offset: 0x18

	public static EpisodeService Instance
	{
		 get { } //Length: 167
	}

	public EpisodeService() { }

	public static EpisodeService get_Instance() { }

	public bool IsLockMusic(int musicId) { }

	public void ReadEnd(bool autoFlag, bool skipFlag) { }

	public Result ReadEpisode(int episode_id, bool voicePlay, bool continuePlay, Action<EpisodeViewModel> onSuccess, Action onErrorToTitle) { }

	public void TryBackwardEpisodeUnlock() { }

}

