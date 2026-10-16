namespace CriWare.CriTimeline.Atom;

[TrackBindingType(typeof(CriAtomSourceBase))]
[TrackClipType(typeof(CriAtomClipBase))]
[TrackColor(0.3317462, 0.6611561, 0.990566)]
public class CriAtomTrack : TrackAsset
{
	public string m_AisacControls; //Field offset: 0x58
	public bool m_StopOnWrapping; //Field offset: 0x5C
	public bool m_StopAtGraphEnd; //Field offset: 0x5D
	public bool m_ApplyPlayableSpeed; //Field offset: 0x5E
	public bool m_CheckPosWithinClip; //Field offset: 0x5F

	public CriAtomTrack() { }

	public virtual Playable CreateTrackMixer(PlayableGraph graph, GameObject owner, int inputCount) { }

}

