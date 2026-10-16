namespace CriWare.CriTimeline.Atom;

public class CriAtomMixerBehaviour : PlayableBehaviour
{
	private const int cScratchTimeIntervalMs = 200; //Field offset: 0x0
	private const double cFrameSkipTolerance = 5E-324; //Field offset: 0x0
	internal PlayableDirector m_Director; //Field offset: 0x8
	internal TimelineClip[] m_Clips; //Field offset: 0xC
	internal CriAtomSourceBase m_Bind; //Field offset: 0x10
	internal string m_AisacControls; //Field offset: 0x14
	internal bool m_StopOnWrapping; //Field offset: 0x18
	internal bool m_StopAtGraphEnd; //Field offset: 0x19
	internal bool m_ApplyPlayableSpeed; //Field offset: 0x1A
	internal bool m_CheckPosWithinClip; //Field offset: 0x1B
	[CompilerGenerated]
	private Guid <m_Guid>k__BackingField; //Field offset: 0x1C
	private DateTime m_lastScrubTime; //Field offset: 0x30
	private double m_lastDirectorTime; //Field offset: 0x38
	private CriAtomListener previewSelectedListenerObj; //Field offset: 0x40

	private static bool IsEditor
	{
		private get { } //Length: 3
	}

	public private Guid m_Guid
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		private set { } //Length: 16
	}

	public CriAtomMixerBehaviour() { }

	private static bool get_IsEditor() { }

	[CompilerGenerated]
	public Guid get_m_Guid() { }

	public virtual void OnGraphStop(Playable playable) { }

	public virtual void OnPlayableCreate(Playable playable) { }

	public virtual void OnPlayableDestroy(Playable playable) { }

	public virtual void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	[CompilerGenerated]
	private void set_m_Guid(Guid value) { }

}

