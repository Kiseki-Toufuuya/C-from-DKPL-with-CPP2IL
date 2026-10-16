namespace UnityEngine.Timeline;

public class TimelinePlayable : PlayableBehaviour
{
	internal static bool muteAudioScrubbing; //Field offset: 0x0
	private IntervalTree<RuntimeElement> m_IntervalTree; //Field offset: 0x8
	private List<RuntimeElement> m_ActiveClips; //Field offset: 0xC
	private List<RuntimeElement> m_CurrentListOfActiveClips; //Field offset: 0x10
	private int m_ActiveBit; //Field offset: 0x14
	private List<ITimelineEvaluateCallback> m_EvaluateCallbacks; //Field offset: 0x18
	private Dictionary<TrackAsset, Playable> m_PlayableCache; //Field offset: 0x1C

	private static TimelinePlayable() { }

	public TimelinePlayable() { }

	private void CacheTrack(TrackAsset track, Playable playable, int port, Playable parent) { }

	public void Compile(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs) { }

	private void CompileTrackList(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool createOutputs) { }

	public static ScriptPlayable<TimelinePlayable> Create(PlayableGraph graph, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs) { }

	private void CreateTrackOutput(PlayableGraph graph, TrackAsset track, GameObject go, Playable playable, int port) { }

	private Playable CreateTrackPlayable(PlayableGraph graph, Playable timelinePlayable, TrackAsset track, GameObject go, bool createOutputs) { }

	private void Evaluate(Playable playable, FrameData frameData) { }

	private void EvaluateAnimationPreviewUpdateCallback(TrackAsset track, AnimationPlayableOutput animOutput) { }

	private void EvaluateWeightsForAnimationPlayableOutput(TrackAsset track, AnimationPlayableOutput animOutput) { }

	private static void ForAOTCompilationOnly() { }

	public virtual void PrepareFrame(Playable playable, FrameData info) { }

}

