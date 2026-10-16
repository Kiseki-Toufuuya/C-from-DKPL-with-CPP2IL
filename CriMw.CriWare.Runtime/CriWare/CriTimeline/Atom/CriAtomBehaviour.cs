namespace CriWare.CriTimeline.Atom;

public class CriAtomBehaviour : PlayableBehaviour
{
	private static int cPreviewStopTimeMs; //Field offset: 0x0
	[Range(0, 1)]
	public float volume; //Field offset: 0x8
	[Range(-1200, 1200)]
	public float pitch; //Field offset: 0xC
	[Range(0, 1)]
	public float AISACValue; //Field offset: 0x10
	private CriAtomExAcb m_acb; //Field offset: 0x14
	private string m_lastCueSheetPath; //Field offset: 0x18
	[CompilerGenerated]
	private CriAtomExPlayback <playback>k__BackingField; //Field offset: 0x1C
	private bool _IsClipPlaying; //Field offset: 0x20
	private double _CueLength; //Field offset: 0x28

	public private double CueLength
	{
		 get { } //Length: 11
		private set { } //Length: 18
	}

	public private bool IsClipPlaying
	{
		 get { } //Length: 11
		private set { } //Length: 14
	}

	public private CriAtomExPlayback playback
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	private static CriAtomBehaviour() { }

	public CriAtomBehaviour() { }

	[CompilerGenerated]
	private void <WaitAndStop>b__21_0() { }

	public double get_CueLength() { }

	public bool get_IsClipPlaying() { }

	[CompilerGenerated]
	public CriAtomExPlayback get_playback() { }

	private double GetCueLengthSec(CriAtomExAcb acb, string cueName) { }

	public virtual void OnGraphStop(Playable playable) { }

	public void Play(CriAtomSourceBase atomSource, CriAtomClipPlayConfig config) { }

	public void PreviewPlay(Guid trackId, bool instantStop, CriAtomClipPlayConfig config) { }

	private void set_CueLength(double value) { }

	private void set_IsClipPlaying(bool value) { }

	[CompilerGenerated]
	private void set_playback(CriAtomExPlayback value) { }

	public void Stop(bool noReleaseTime = false, bool flagResetOnly = false) { }

	private void WaitAndStop() { }

}

