namespace XeApp.Game.Common;

public class EpisodeVoicePlayer : VoicePlayerBase
{
	private float VOICE_PAR; //Field offset: 0x20
	[CompilerGenerated]
	private string <csName>k__BackingField; //Field offset: 0x24

	public string csName
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public EpisodeVoicePlayer() { }

	public static long CalcDownloadSize(string eventFileName) { }

	[CompilerGenerated]
	public string get_csName() { }

	public bool IsCueExists(string cue) { }

	public bool IsStopVoice() { }

	public void Load(string eventFileName) { }

	public CriAtomExPlayback PlayVoice(string cueName, float vol = 1) { }

	[CompilerGenerated]
	public void set_csName(string value) { }

	public void StopVoice() { }

	public static void TryInstall(string eventFileName) { }

	public void Unload() { }

}

