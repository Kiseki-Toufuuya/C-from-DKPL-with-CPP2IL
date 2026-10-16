namespace UnityEngine.Timeline;

[ExcludeFromPreset]
[TrackBindingType(typeof(Animator))]
[TrackClipType(typeof(AnimationPlayableAsset), False)]
public class AnimationTrack : TrackAsset, ILayerable
{
	[CompilerGenerated]
	private sealed class <get_outputs>d__49 : IEnumerable<PlayableBinding>, IEnumerable, IEnumerator<PlayableBinding>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private PlayableBinding <>2__current; //Field offset: 0xC
		private int <>l__initialThreadId; //Field offset: 0x1C
		public AnimationTrack <>4__this; //Field offset: 0x20

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
		public <get_outputs>d__49(int <>1__state) { }

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

	private static class AnimationTrackUpgrade
	{

		public static void ConvertInfiniteTrack(AnimationTrack track) { }

		public static void ConvertRootMotion(AnimationTrack track) { }

		public static void ConvertRotationsToEuler(AnimationTrack track) { }

	}

	private const string k_DefaultInfiniteClipName = "Recorded"; //Field offset: 0x0
	private const string k_DefaultRecordableClipName = "Recorded"; //Field offset: 0x0
	private static readonly Queue<Transform> s_CachedQueue; //Field offset: 0x0
	[FormerlySerializedAs("m_OpenClipPreExtrapolation")]
	[SerializeField]
	private ClipExtrapolation m_InfiniteClipPreExtrapolation; //Field offset: 0x58
	[FormerlySerializedAs("m_OpenClipPostExtrapolation")]
	[SerializeField]
	private ClipExtrapolation m_InfiniteClipPostExtrapolation; //Field offset: 0x5C
	[FormerlySerializedAs("m_OpenClipOffsetPosition")]
	[SerializeField]
	private Vector3 m_InfiniteClipOffsetPosition; //Field offset: 0x60
	[FormerlySerializedAs("m_OpenClipOffsetEulerAngles")]
	[SerializeField]
	private Vector3 m_InfiniteClipOffsetEulerAngles; //Field offset: 0x6C
	[FormerlySerializedAs("m_OpenClipTimeOffset")]
	[SerializeField]
	private double m_InfiniteClipTimeOffset; //Field offset: 0x78
	[FormerlySerializedAs("m_OpenClipRemoveOffset")]
	[SerializeField]
	private bool m_InfiniteClipRemoveOffset; //Field offset: 0x80
	[SerializeField]
	private bool m_InfiniteClipApplyFootIK; //Field offset: 0x81
	[HideInInspector]
	[SerializeField]
	private LoopMode mInfiniteClipLoop; //Field offset: 0x84
	[SerializeField]
	private MatchTargetFields m_MatchTargetFields; //Field offset: 0x88
	[SerializeField]
	private Vector3 m_Position; //Field offset: 0x8C
	[SerializeField]
	private Vector3 m_EulerAngles; //Field offset: 0x98
	[SerializeField]
	private AvatarMask m_AvatarMask; //Field offset: 0xA4
	[SerializeField]
	private bool m_ApplyAvatarMask; //Field offset: 0xA8
	[SerializeField]
	private TrackOffset m_TrackOffset; //Field offset: 0xAC
	[HideInInspector]
	[SerializeField]
	private AnimationClip m_InfiniteClip; //Field offset: 0xB0
	[HideInInspector]
	[Obsolete("Use m_InfiniteClipOffsetEulerAngles Instead", False)]
	[SerializeField]
	private Quaternion m_OpenClipOffsetRotation; //Field offset: 0xB4
	[HideInInspector]
	[Obsolete("Use m_RotationEuler Instead", False)]
	[SerializeField]
	private Quaternion m_Rotation; //Field offset: 0xC4
	[HideInInspector]
	[Obsolete("Use m_RootTransformOffsetMode", False)]
	[SerializeField]
	private bool m_ApplyOffsets; //Field offset: 0xD4

	public bool applyAvatarMask
	{
		 get { } //Length: 14
		 set { } //Length: 17
	}

	[Obsolete("applyOffset is deprecated. Use trackOffset instead", True)]
	public bool applyOffsets
	{
		 get { } //Length: 3
		 set { } //Length: 3
	}

	public AvatarMask avatarMask
	{
		 get { } //Length: 14
		 set { } //Length: 33
	}

	public Vector3 eulerAngles
	{
		 get { } //Length: 32
		 set { } //Length: 30
	}

	public bool inClipMode
	{
		 get { } //Length: 55
	}

	public internal AnimationClip infiniteClip
	{
		 get { } //Length: 14
		internal set { } //Length: 33
	}

	internal bool infiniteClipApplyFootIK
	{
		internal get { } //Length: 14
		internal set { } //Length: 17
	}

	internal LoopMode infiniteClipLoop
	{
		internal get { } //Length: 14
		internal set { } //Length: 17
	}

	public Vector3 infiniteClipOffsetEulerAngles
	{
		 get { } //Length: 26
		 set { } //Length: 24
	}

	public Vector3 infiniteClipOffsetPosition
	{
		 get { } //Length: 26
		 set { } //Length: 24
	}

	public Quaternion infiniteClipOffsetRotation
	{
		 get { } //Length: 110
		 set { } //Length: 46
	}

	public ClipExtrapolation infiniteClipPostExtrapolation
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public ClipExtrapolation infiniteClipPreExtrapolation
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	internal bool infiniteClipRemoveOffset
	{
		internal get { } //Length: 14
		internal set { } //Length: 17
	}

	internal double infiniteClipTimeOffset
	{
		internal get { } //Length: 11
		internal set { } //Length: 18
	}

	public MatchTargetFields matchTargetFields
	{
		 get { } //Length: 14
		 set { } //Length: 76
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("openClipOffsetEulerAngles has been deprecated. Use infiniteClipOffsetEulerAngles instead. (UnityUpgradable) -> infiniteClipOffsetEulerAngles", True)]
	public Vector3 openClipOffsetEulerAngles
	{
		 get { } //Length: 26
		 set { } //Length: 24
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("openClipOffsetPosition has been deprecated. Use infiniteClipOffsetPosition instead. (UnityUpgradable) -> infiniteClipOffsetPosition", True)]
	public Vector3 openClipOffsetPosition
	{
		 get { } //Length: 26
		 set { } //Length: 24
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("openClipOffsetRotation has been deprecated. Use infiniteClipOffsetRotation instead. (UnityUpgradable) -> infiniteClipOffsetRotation", True)]
	public Quaternion openClipOffsetRotation
	{
		 get { } //Length: 110
		 set { } //Length: 54
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("openClipPostExtrapolation has been deprecated. Use infiniteClipPostExtrapolation instead. (UnityUpgradable) -> infiniteClipPostExtrapolation", True)]
	public ClipExtrapolation openClipPostExtrapolation
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("openClipPreExtrapolation has been deprecated. Use infiniteClipPreExtrapolation instead. (UnityUpgradable) -> infiniteClipPreExtrapolation", True)]
	public ClipExtrapolation openClipPreExtrapolation
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public virtual IEnumerable<PlayableBinding> outputs
	{
		[IteratorStateMachine(typeof(<get_outputs>d__49))]
		 get { } //Length: 95
	}

	public Vector3 position
	{
		 get { } //Length: 32
		 set { } //Length: 30
	}

	public Quaternion rotation
	{
		 get { } //Length: 116
		 set { } //Length: 52
	}

	public TrackOffset trackOffset
	{
		 get { } //Length: 14
		 set { } //Length: 17
	}

	private static AnimationTrack() { }

	public AnimationTrack() { }

	internal bool AnimatesRootTransform() { }

	private Playable ApplyTrackOffset(PlayableGraph graph, Playable root, GameObject go, AppliedOffsetMode mode) { }

	private void AssignAnimationClip(TimelineClip clip, AnimationClip animClip) { }

	private void AttachDefaultBlend(PlayableGraph graph, AnimationLayerMixerPlayable mixer, bool requireOffset) { }

	private Playable AttachOffsetPlayable(PlayableGraph graph, Playable playable, Vector3 pos, Quaternion rot) { }

	protected private virtual int CalculateItemsHash() { }

	internal virtual bool CanCompileClips() { }

	private Playable CompileTrackPlayable(PlayableGraph graph, AnimationTrack track, GameObject go, IntervalTree<RuntimeElement> tree, AppliedOffsetMode mode) { }

	public TimelineClip CreateClip(AnimationClip clip) { }

	private static AnimationLayerMixerPlayable CreateGroupMixer(PlayableGraph graph, GameObject go, int inputCount) { }

	public void CreateInfiniteClip(string infiniteClipName) { }

	private Playable CreateInfiniteTrackPlayable(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree, AppliedOffsetMode mode) { }

	internal virtual Playable CreateMixerPlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree) { }

	public TimelineClip CreateRecordableClip(string animClipName) { }

	private static Transform FindInHierarchyBreadthFirst(Transform t, string name) { }

	public virtual void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	public bool get_applyAvatarMask() { }

	public bool get_applyOffsets() { }

	public AvatarMask get_avatarMask() { }

	public Vector3 get_eulerAngles() { }

	public bool get_inClipMode() { }

	public AnimationClip get_infiniteClip() { }

	internal bool get_infiniteClipApplyFootIK() { }

	internal LoopMode get_infiniteClipLoop() { }

	public Vector3 get_infiniteClipOffsetEulerAngles() { }

	public Vector3 get_infiniteClipOffsetPosition() { }

	public Quaternion get_infiniteClipOffsetRotation() { }

	public ClipExtrapolation get_infiniteClipPostExtrapolation() { }

	public ClipExtrapolation get_infiniteClipPreExtrapolation() { }

	internal bool get_infiniteClipRemoveOffset() { }

	internal double get_infiniteClipTimeOffset() { }

	public MatchTargetFields get_matchTargetFields() { }

	public Vector3 get_openClipOffsetEulerAngles() { }

	public Vector3 get_openClipOffsetPosition() { }

	public Quaternion get_openClipOffsetRotation() { }

	public ClipExtrapolation get_openClipPostExtrapolation() { }

	public ClipExtrapolation get_openClipPreExtrapolation() { }

	[IteratorStateMachine(typeof(<get_outputs>d__49))]
	public virtual IEnumerable<PlayableBinding> get_outputs() { }

	public Vector3 get_position() { }

	public Quaternion get_rotation() { }

	public TrackOffset get_trackOffset() { }

	private void GetAnimationClips(List<AnimationClip> animClips) { }

	internal Animator GetBinding(PlayableDirector director) { }

	private int GetDefaultBlendCount() { }

	internal virtual void GetEvaluationTime(out double outStart, out double outDuration) { }

	private Transform GetGenericRootNode(GameObject gameObject) { }

	private AppliedOffsetMode GetOffsetMode(GameObject go, bool animatesRootTransform) { }

	internal virtual void GetSequenceTime(out double outStart, out double outDuration) { }

	private bool HasController(GameObject gameObject) { }

	private bool IsRootTransformDisabledByMask(GameObject gameObject, Transform genericRootNode) { }

	protected virtual void OnCreateClip(TimelineClip clip) { }

	internal virtual void OnUpgradeFromVersion(int oldVersion) { }

	private bool RequiresMotionXPlayable(AppliedOffsetMode mode, GameObject gameObject) { }

	[ContextMenu("Reset Offsets")]
	private void ResetOffsets() { }

	public void set_applyAvatarMask(bool value) { }

	public void set_applyOffsets(bool value) { }

	public void set_avatarMask(AvatarMask value) { }

	public void set_eulerAngles(Vector3 value) { }

	internal void set_infiniteClip(AnimationClip value) { }

	internal void set_infiniteClipApplyFootIK(bool value) { }

	internal void set_infiniteClipLoop(LoopMode value) { }

	public void set_infiniteClipOffsetEulerAngles(Vector3 value) { }

	public void set_infiniteClipOffsetPosition(Vector3 value) { }

	public void set_infiniteClipOffsetRotation(Quaternion value) { }

	public void set_infiniteClipPostExtrapolation(ClipExtrapolation value) { }

	public void set_infiniteClipPreExtrapolation(ClipExtrapolation value) { }

	internal void set_infiniteClipRemoveOffset(bool value) { }

	internal void set_infiniteClipTimeOffset(double value) { }

	public void set_matchTargetFields(MatchTargetFields value) { }

	public void set_openClipOffsetEulerAngles(Vector3 value) { }

	public void set_openClipOffsetPosition(Vector3 value) { }

	public void set_openClipOffsetRotation(Quaternion value) { }

	public void set_openClipPostExtrapolation(ClipExtrapolation value) { }

	public void set_openClipPreExtrapolation(ClipExtrapolation value) { }

	public void set_position(Vector3 value) { }

	public void set_rotation(Quaternion value) { }

	public void set_trackOffset(TrackOffset value) { }

	private override Playable UnityEngine.Timeline.ILayerable.CreateLayerMixer(PlayableGraph graph, GameObject go, int inputCount) { }

	internal void UpdateClipOffsets() { }

	private static bool UsesAbsoluteMotion(AppliedOffsetMode mode) { }

}

