namespace UnityEngine.Timeline;

[IgnoreOnPlayableTrack]
public abstract class TrackAsset : PlayableAsset, ISerializationCallbackReceiver, IPropertyPreview, ICurvesOwner
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<TimelineClip> <>9__121_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal int <SortClips>b__121_0(TimelineClip clip1, TimelineClip clip2) { }

	}

	[CompilerGenerated]
	private sealed class <get_outputs>d__65 : IEnumerable<PlayableBinding>, IEnumerable, IEnumerator<PlayableBinding>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private PlayableBinding <>2__current; //Field offset: 0xC
		private int <>l__initialThreadId; //Field offset: 0x1C
		public TrackAsset <>4__this; //Field offset: 0x20

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
		public <get_outputs>d__65(int <>1__state) { }

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

	private static class TrackAssetUpgrade
	{

	}

	private struct TransientBuildData
	{
		public List<TrackAsset> trackList; //Field offset: 0x0
		public List<TimelineClip> clipList; //Field offset: 0x4
		public List<IMarker> markerList; //Field offset: 0x8

		public void Clear() { }

		public static TransientBuildData Create() { }

	}

	public enum Versions
	{
		Initial = 0,
		RotationAsEuler = 1,
		RootMotionUpgrade = 2,
		AnimatedTrackProperties = 3,
	}

	private const int k_LatestVersion = 3; //Field offset: 0x0
	private static TransientBuildData s_BuildData; //Field offset: 0x0
	internal const string kDefaultCurvesName = "Track Parameters"; //Field offset: 0x0
	[CompilerGenerated]
	private static Action<TimelineClip, GameObject, Playable> OnClipPlayableCreate; //Field offset: 0xC
	[CompilerGenerated]
	private static Action<TrackAsset, GameObject, Playable> OnTrackAnimationPlayableCreate; //Field offset: 0x10
	private static TrackAsset[] s_EmptyCache; //Field offset: 0x14
	private static Dictionary<Type, TrackBindingTypeAttribute> s_TrackBindingTypeAttributeCache; //Field offset: 0x18
	[HideInInspector]
	[SerializeField]
	private int m_Version; //Field offset: 0xC
	[FormerlySerializedAs("m_animClip")]
	[HideInInspector]
	[Obsolete("Please use m_InfiniteClip (on AnimationTrack) instead.", False)]
	[SerializeField]
	internal AnimationClip m_AnimClip; //Field offset: 0x10
	[HideInInspector]
	[SerializeField]
	private bool m_Locked; //Field offset: 0x14
	[HideInInspector]
	[SerializeField]
	private bool m_Muted; //Field offset: 0x15
	[HideInInspector]
	[SerializeField]
	private string m_CustomPlayableFullTypename; //Field offset: 0x18
	[HideInInspector]
	[SerializeField]
	private AnimationClip m_Curves; //Field offset: 0x1C
	[HideInInspector]
	[SerializeField]
	private PlayableAsset m_Parent; //Field offset: 0x20
	[HideInInspector]
	[SerializeField]
	private List<ScriptableObject> m_Children; //Field offset: 0x24
	private int m_ItemsHash; //Field offset: 0x28
	private TimelineClip[] m_ClipsCache; //Field offset: 0x2C
	private DiscreteTime m_Start; //Field offset: 0x30
	private DiscreteTime m_End; //Field offset: 0x38
	private bool m_CacheSorted; //Field offset: 0x40
	private Nullable<Boolean> m_SupportsNotifications; //Field offset: 0x41
	private IEnumerable<TrackAsset> m_ChildTrackCache; //Field offset: 0x44
	[HideInInspector]
	[SerializeField]
	protected private List<TimelineClip> m_Clips; //Field offset: 0x48
	[HideInInspector]
	[SerializeField]
	private MarkerList m_Markers; //Field offset: 0x4C

	internal static event Action<TimelineClip, GameObject, Playable> OnClipPlayableCreate
	{
		[CompilerGenerated]
		internal add { } //Length: 196
		[CompilerGenerated]
		internal remove { } //Length: 196
	}

	internal static event Action<TrackAsset, GameObject, Playable> OnTrackAnimationPlayableCreate
	{
		[CompilerGenerated]
		internal add { } //Length: 196
		[CompilerGenerated]
		internal remove { } //Length: 196
	}

	internal TimelineClip[] clips
	{
		internal get { } //Length: 161
	}

	public internal override AnimationClip curves
	{
		 get { } //Length: 11
		internal set { } //Length: 27
	}

	internal string customPlayableTypename
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	public virtual double duration
	{
		 get { } //Length: 173
	}

	public double end
	{
		 get { } //Length: 157
	}

	public bool hasClips
	{
		 get { } //Length: 57
	}

	public override bool hasCurves
	{
		 get { } //Length: 110
	}

	public override bool isEmpty
	{
		 get { } //Length: 136
	}

	public bool isSubTrack
	{
		 get { } //Length: 221
	}

	public bool locked
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public bool lockedInHierarchy
	{
		 get { } //Length: 378
	}

	public bool muted
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public bool mutedInHierarchy
	{
		 get { } //Length: 378
	}

	public virtual IEnumerable<PlayableBinding> outputs
	{
		[IteratorStateMachine(typeof(<get_outputs>d__65))]
		 get { } //Length: 95
	}

	public internal PlayableAsset parent
	{
		 get { } //Length: 11
		internal set { } //Length: 27
	}

	public double start
	{
		 get { } //Length: 157
	}

	internal List<ScriptableObject> subTracksObjects
	{
		internal get { } //Length: 11
	}

	public bool supportsNotifications
	{
		 get { } //Length: 140
	}

	public TimelineAsset timelineAsset
	{
		 get { } //Length: 250
	}

	private override object UnityEngine.Timeline.ICurvesOwner.asset
	{
		private get { } //Length: 8
	}

	private override object UnityEngine.Timeline.ICurvesOwner.assetOwner
	{
		private get { } //Length: 16
	}

	private override string UnityEngine.Timeline.ICurvesOwner.defaultCurvesName
	{
		private get { } //Length: 35
	}

	private override TrackAsset UnityEngine.Timeline.ICurvesOwner.targetTrack
	{
		private get { } //Length: 8
	}

	private void __internalAwake() { }

	private static TrackAsset() { }

	protected TrackAsset() { }

	[CompilerGenerated]
	internal static void add_OnClipPlayableCreate(Action<TimelineClip, GameObject, Playable> value) { }

	[CompilerGenerated]
	internal static void add_OnTrackAnimationPlayableCreate(Action<TrackAsset, GameObject, Playable> value) { }

	internal void AddChild(TrackAsset child) { }

	internal void AddClip(TimelineClip newClip) { }

	internal void AddMarker(ScriptableObject e) { }

	protected private override int CalculateItemsHash() { }

	internal override bool CanCompileClips() { }

	private bool CanCompileNotifications() { }

	private bool CanCreateMixerRecursive() { }

	public override bool CanCreateTrackMixer() { }

	internal void ClearClipsInternal() { }

	internal void ClearMarkers() { }

	internal void ClearSubTracksInternal() { }

	internal override Playable CompileClips(PlayableGraph graph, GameObject go, IList<TimelineClip> timelineClips, IntervalTree<RuntimeElement> tree) { }

	internal void ConfigureTrackAnimation(IntervalTree<RuntimeElement> tree, GameObject go, Playable blend) { }

	internal TimelineClip CreateAndAddNewClipOfType(Type requestedType) { }

	internal TimelineClip CreateClip(Type requestedType) { }

	public TimelineClip CreateClip() { }

	private TimelineClip CreateClipFromAsset(ScriptableObject playableAsset) { }

	internal TimelineClip CreateClipFromPlayableAsset(IPlayableAsset asset) { }

	internal TimelineClip CreateClipOfType(Type requestedType) { }

	public override void CreateCurves(string curvesClipName) { }

	public TimelineClip CreateDefaultClip() { }

	public IMarker CreateMarker(Type type, double time) { }

	public T CreateMarker(double time) { }

	internal override Playable CreateMixerPlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree) { }

	internal TimelineClip CreateNewClipContainerInternal() { }

	private Playable CreateNotificationsPlayable(PlayableGraph graph, Playable mixerPlayable, GameObject go, Playable timelinePlayable) { }

	protected override Playable CreatePlayable(PlayableGraph graph, GameObject gameObject, TimelineClip clip) { }

	public virtual Playable CreatePlayable(PlayableGraph graph, GameObject go) { }

	internal Playable CreatePlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree, Playable timelinePlayable) { }

	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) { }

	public bool DeleteClip(TimelineClip clip) { }

	public bool DeleteMarker(IMarker marker) { }

	internal bool DeleteMarkerRaw(ScriptableObject marker) { }

	private void GatherCompilableTracks(IList<TrackAsset> tracks) { }

	private void GatherNotifications(List<IMarker> markers) { }

	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	internal TimelineClip[] get_clips() { }

	public override AnimationClip get_curves() { }

	internal string get_customPlayableTypename() { }

	public virtual double get_duration() { }

	public double get_end() { }

	public bool get_hasClips() { }

	public override bool get_hasCurves() { }

	public override bool get_isEmpty() { }

	public bool get_isSubTrack() { }

	public bool get_locked() { }

	public bool get_lockedInHierarchy() { }

	public bool get_muted() { }

	public bool get_mutedInHierarchy() { }

	[IteratorStateMachine(typeof(<get_outputs>d__65))]
	public virtual IEnumerable<PlayableBinding> get_outputs() { }

	public PlayableAsset get_parent() { }

	public double get_start() { }

	internal List<ScriptableObject> get_subTracksObjects() { }

	public bool get_supportsNotifications() { }

	public TimelineAsset get_timelineAsset() { }

	protected static int GetAnimationClipHash(AnimationClip clip) { }

	public IEnumerable<TrackAsset> GetChildTracks() { }

	public IEnumerable<TimelineClip> GetClips() { }

	private int GetClipsHash() { }

	internal override void GetEvaluationTime(out double outStart, out double outDuration) { }

	internal GameObject GetGameObjectBinding(PlayableDirector director) { }

	public IMarker GetMarker(int idx) { }

	public int GetMarkerCount() { }

	public IEnumerable<IMarker> GetMarkers() { }

	internal IEnumerable<ScriptableObject> GetMarkersRaw() { }

	internal double GetNotificationDuration() { }

	internal override void GetSequenceTime(out double outStart, out double outDuration) { }

	private int GetTimeRangeHash() { }

	internal override int Hash() { }

	private bool HasNotifications() { }

	internal void Invalidate() { }

	internal bool IsCompilable() { }

	internal void MoveLastTrackBefore(TrackAsset asset) { }

	protected override void OnAfterTrackDeserialize() { }

	protected override void OnBeforeTrackSerialize() { }

	internal void OnClipMove() { }

	protected override void OnCreateClip(TimelineClip clip) { }

	internal override void OnUpgradeFromVersion(int oldVersion) { }

	[CompilerGenerated]
	internal static void remove_OnClipPlayableCreate(Action<TimelineClip, GameObject, Playable> value) { }

	[CompilerGenerated]
	internal static void remove_OnTrackAnimationPlayableCreate(Action<TrackAsset, GameObject, Playable> value) { }

	internal void RemoveClip(TimelineClip clip) { }

	internal bool RemoveSubTrack(TrackAsset child) { }

	internal void set_curves(AnimationClip value) { }

	internal void set_customPlayableTypename(string value) { }

	public void set_locked(bool value) { }

	public void set_muted(bool value) { }

	internal void set_parent(PlayableAsset value) { }

	internal void SortClips() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	private override object UnityEngine.Timeline.ICurvesOwner.get_asset() { }

	private override object UnityEngine.Timeline.ICurvesOwner.get_assetOwner() { }

	private override string UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName() { }

	private override TrackAsset UnityEngine.Timeline.ICurvesOwner.get_targetTrack() { }

	private void UpdateChildTrackCache() { }

	private void UpdateDuration() { }

	private void UpgradeToLatestVersion() { }

	internal bool ValidateClipType(Type clipType) { }

}

