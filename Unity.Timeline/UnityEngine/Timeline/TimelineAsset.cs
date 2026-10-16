namespace UnityEngine.Timeline;

[ExcludeFromPreset]
public class TimelineAsset : PlayableAsset, ISerializationCallbackReceiver, ITimelineClipAsset, IPropertyPreview
{
	[CompilerGenerated]
	private sealed class <get_outputs>d__27 : IEnumerable<PlayableBinding>, IEnumerable, IEnumerator<PlayableBinding>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private PlayableBinding <>2__current; //Field offset: 0xC
		private int <>l__initialThreadId; //Field offset: 0x1C
		public TimelineAsset <>4__this; //Field offset: 0x20
		private IEnumerator<TrackAsset> <>7__wrap1; //Field offset: 0x24
		private IEnumerator<PlayableBinding> <>7__wrap2; //Field offset: 0x28

		private override PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 18
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 68
		}

		[DebuggerHidden]
		public <get_outputs>d__27(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator() { }

		[DebuggerHidden]
		private override PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal enum DurationMode
	{
		BasedOnClips = 0,
		FixedLength = 1,
	}

	internal class EditorSettings
	{
		internal static readonly double kMinFrameRate; //Field offset: 0x0
		internal static readonly double kMaxFrameRate; //Field offset: 0x8
		internal static readonly double kDefaultFrameRate; //Field offset: 0x10
		[FrameRateField]
		[HideInInspector]
		[SerializeField]
		private double m_Framerate; //Field offset: 0x8
		[HideInInspector]
		[SerializeField]
		private bool m_ScenePreview; //Field offset: 0x10

		[Obsolete("EditorSettings.fps has been deprecated. Use editorSettings.frameRate instead.", False)]
		public float fps
		{
			 get { } //Length: 17
			 set { } //Length: 126
		}

		public double frameRate
		{
			 get { } //Length: 11
			 set { } //Length: 34
		}

		public bool scenePreview
		{
			 get { } //Length: 11
			 set { } //Length: 14
		}

		private static EditorSettings() { }

		public EditorSettings() { }

		public float get_fps() { }

		public double get_frameRate() { }

		public bool get_scenePreview() { }

		public void set_fps(float value) { }

		public void set_frameRate(double value) { }

		public void set_scenePreview(bool value) { }

		public void SetStandardFrameRate(StandardFrameRates enumValue) { }

	}

	[Obsolete("MediaType has been deprecated. It is no longer required, and will be removed in a future release.", False)]
	internal enum MediaType
	{
		Animation = 0,
		Audio = 1,
		Texture = 2,
		Video = 2,
		Script = 3,
		Hybrid = 4,
		Group = 5,
	}

	private static class TimelineAssetUpgrade
	{

	}

	private enum Versions
	{
		Initial = 0,
	}

	private const int k_LatestVersion = 0; //Field offset: 0x0
	[HideInInspector]
	[SerializeField]
	private int m_Version; //Field offset: 0xC
	[HideInInspector]
	[SerializeField]
	private List<ScriptableObject> m_Tracks; //Field offset: 0x10
	[HideInInspector]
	[SerializeField]
	private double m_FixedDuration; //Field offset: 0x18
	[HideInInspector]
	private TrackAsset[] m_CacheOutputTracks; //Field offset: 0x20
	[HideInInspector]
	private List<TrackAsset> m_CacheRootTracks; //Field offset: 0x24
	[HideInInspector]
	private TrackAsset[] m_CacheFlattenedTracks; //Field offset: 0x28
	[HideInInspector]
	[SerializeField]
	private EditorSettings m_EditorSettings; //Field offset: 0x2C
	[SerializeField]
	private DurationMode m_DurationMode; //Field offset: 0x30
	[HideInInspector]
	[SerializeField]
	private MarkerTrack m_MarkerTrack; //Field offset: 0x34

	public override ClipCaps clipCaps
	{
		 get { } //Length: 401
	}

	public virtual double duration
	{
		 get { } //Length: 177
	}

	public DurationMode durationMode
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public EditorSettings editorSettings
	{
		 get { } //Length: 11
	}

	public double fixedDuration
	{
		 get { } //Length: 258
		 set { } //Length: 92
	}

	internal TrackAsset[] flattenedTracks
	{
		internal get { } //Length: 309
	}

	public MarkerTrack markerTrack
	{
		 get { } //Length: 11
	}

	public virtual IEnumerable<PlayableBinding> outputs
	{
		[IteratorStateMachine(typeof(<get_outputs>d__27))]
		 get { } //Length: 95
	}

	public int outputTrackCount
	{
		 get { } //Length: 36
	}

	public int rootTrackCount
	{
		 get { } //Length: 65
	}

	internal List<ScriptableObject> trackObjects
	{
		internal get { } //Length: 11
	}

	private void __internalAwake() { }

	public TimelineAsset() { }

	private static void AddSubTracksRecursive(TrackAsset track, ref List<TrackAsset>& allTracks) { }

	internal void AddTrackInternal(TrackAsset track) { }

	private TrackAsset AllocateTrack(TrackAsset trackAssetParent, string trackName, Type trackType) { }

	private DiscreteTime CalculateItemsDuration() { }

	public void CreateMarkerTrack() { }

	public virtual Playable CreatePlayable(PlayableGraph graph, GameObject go) { }

	public T CreateTrack(TrackAsset parent, string trackName) { }

	public TrackAsset CreateTrack(Type type, TrackAsset parent, string name) { }

	public T CreateTrack(string trackName) { }

	public T CreateTrack() { }

	public bool DeleteClip(TimelineClip clip) { }

	private void DeleteRecordedAnimation(TrackAsset track) { }

	private void DeleteRecordedAnimation(TimelineClip clip) { }

	public bool DeleteTrack(TrackAsset track) { }

	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	public override ClipCaps get_clipCaps() { }

	public virtual double get_duration() { }

	public DurationMode get_durationMode() { }

	public EditorSettings get_editorSettings() { }

	public double get_fixedDuration() { }

	internal TrackAsset[] get_flattenedTracks() { }

	public MarkerTrack get_markerTrack() { }

	[IteratorStateMachine(typeof(<get_outputs>d__27))]
	public virtual IEnumerable<PlayableBinding> get_outputs() { }

	public int get_outputTrackCount() { }

	public int get_rootTrackCount() { }

	internal List<ScriptableObject> get_trackObjects() { }

	public TrackAsset GetOutputTrack(int index) { }

	public IEnumerable<TrackAsset> GetOutputTracks() { }

	public TrackAsset GetRootTrack(int index) { }

	public IEnumerable<TrackAsset> GetRootTracks() { }

	private static double GetValidFrameRate(double frameRate) { }

	internal void Invalidate() { }

	internal void MoveLastTrackBefore(TrackAsset asset) { }

	private void OnValidate() { }

	internal void RemoveMarkerTrack() { }

	internal void RemoveTrack(TrackAsset track) { }

	public void set_durationMode(DurationMode value) { }

	public void set_fixedDuration(double value) { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	internal void UpdateFixedDurationWithItemsDuration() { }

	private void UpdateOutputTrackCache() { }

	private void UpdateRootTrackCache() { }

	private void UpgradeToLatestVersion() { }

}

