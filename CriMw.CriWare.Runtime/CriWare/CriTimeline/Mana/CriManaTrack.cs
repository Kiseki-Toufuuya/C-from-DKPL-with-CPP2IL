namespace CriWare.CriTimeline.Mana;

[TrackBindingType(typeof(CriManaMovieMaterialBase))]
[TrackClipType(typeof(CriManaClipBase))]
[TrackColor(0.15, 0.5, 1)]
public class CriManaTrack : TrackAsset
{
	private static Dictionary<Int32, Guid> bindDict; //Field offset: 0x0
	public bool frameSync; //Field offset: 0x58
	public bool checkPosWithinClip; //Field offset: 0x59
	public readonly Guid guid; //Field offset: 0x5C

	private static CriManaTrack() { }

	public CriManaTrack() { }

	public virtual Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) { }

	private void OnDestroy() { }

	private static void RemoveTrackFromBindDict(CriManaTrack trackAsset) { }

}

