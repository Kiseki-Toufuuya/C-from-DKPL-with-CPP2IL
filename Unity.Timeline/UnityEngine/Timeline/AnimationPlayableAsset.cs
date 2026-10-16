namespace UnityEngine.Timeline;

[NotKeyable]
public class AnimationPlayableAsset : PlayableAsset, ITimelineClipAsset, IPropertyPreview, ISerializationCallbackReceiver
{
	[CompilerGenerated]
	private sealed class <get_outputs>d__45 : IEnumerable<PlayableBinding>, IEnumerable, IEnumerator<PlayableBinding>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private PlayableBinding <>2__current; //Field offset: 0xC
		private int <>l__initialThreadId; //Field offset: 0x1C
		public AnimationPlayableAsset <>4__this; //Field offset: 0x20

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
		public <get_outputs>d__45(int <>1__state) { }

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

	private static class AnimationPlayableAssetUpgrade
	{

		public static void ConvertRotationToEuler(AnimationPlayableAsset asset) { }

	}

	internal enum LoopMode
	{
		UseSourceAsset = 0,
		On = 1,
		Off = 2,
	}

	private enum Versions
	{
		Initial = 0,
		RotationAsEuler = 1,
	}

	private static readonly int k_LatestVersion; //Field offset: 0x0
	[SerializeField]
	private AnimationClip m_Clip; //Field offset: 0xC
	[SerializeField]
	private Vector3 m_Position; //Field offset: 0x10
	[SerializeField]
	private Vector3 m_EulerAngles; //Field offset: 0x1C
	[SerializeField]
	private bool m_UseTrackMatchFields; //Field offset: 0x28
	[SerializeField]
	private MatchTargetFields m_MatchTargetFields; //Field offset: 0x2C
	[SerializeField]
	private bool m_RemoveStartOffset; //Field offset: 0x30
	[SerializeField]
	private bool m_ApplyFootIK; //Field offset: 0x31
	[SerializeField]
	private LoopMode m_Loop; //Field offset: 0x34
	[CompilerGenerated]
	private AppliedOffsetMode <appliedOffsetMode>k__BackingField; //Field offset: 0x38
	[HideInInspector]
	[SerializeField]
	private int m_Version; //Field offset: 0x3C
	[HideInInspector]
	[Obsolete("Use m_RotationEuler Instead", False)]
	[SerializeField]
	private Quaternion m_Rotation; //Field offset: 0x40

	internal AppliedOffsetMode appliedOffsetMode
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 14
	}

	public bool applyFootIK
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public AnimationClip clip
	{
		 get { } //Length: 11
		 set { } //Length: 150
	}

	public override ClipCaps clipCaps
	{
		 get { } //Length: 199
	}

	public virtual double duration
	{
		 get { } //Length: 111
	}

	public Vector3 eulerAngles
	{
		 get { } //Length: 26
		 set { } //Length: 24
	}

	internal bool hasRootTransforms
	{
		internal get { } //Length: 129
	}

	public LoopMode loop
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public MatchTargetFields matchTargetFields
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public virtual IEnumerable<PlayableBinding> outputs
	{
		[IteratorStateMachine(typeof(<get_outputs>d__45))]
		 get { } //Length: 95
	}

	public Vector3 position
	{
		 get { } //Length: 26
		 set { } //Length: 24
	}

	public bool removeStartOffset
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public Quaternion rotation
	{
		 get { } //Length: 110
		 set { } //Length: 46
	}

	public bool useTrackMatchFields
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static AnimationPlayableAsset() { }

	public AnimationPlayableAsset() { }

	internal static Playable CreatePlayable(PlayableGraph graph, AnimationClip clip, Vector3 positionOffset, Vector3 eulerOffset, bool removeStartOffset, AppliedOffsetMode mode, bool applyFootIK, LoopMode loop) { }

	public virtual Playable CreatePlayable(PlayableGraph graph, GameObject go) { }

	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	[CompilerGenerated]
	internal AppliedOffsetMode get_appliedOffsetMode() { }

	public bool get_applyFootIK() { }

	public AnimationClip get_clip() { }

	public override ClipCaps get_clipCaps() { }

	public virtual double get_duration() { }

	public Vector3 get_eulerAngles() { }

	internal bool get_hasRootTransforms() { }

	public LoopMode get_loop() { }

	public MatchTargetFields get_matchTargetFields() { }

	[IteratorStateMachine(typeof(<get_outputs>d__45))]
	public virtual IEnumerable<PlayableBinding> get_outputs() { }

	public Vector3 get_position() { }

	public bool get_removeStartOffset() { }

	public Quaternion get_rotation() { }

	public bool get_useTrackMatchFields() { }

	internal static bool HasRootTransforms(AnimationClip clip) { }

	private void OnUpgradeFromVersion(int oldVersion) { }

	public void ResetOffsets() { }

	[CompilerGenerated]
	internal void set_appliedOffsetMode(AppliedOffsetMode value) { }

	public void set_applyFootIK(bool value) { }

	public void set_clip(AnimationClip value) { }

	public void set_eulerAngles(Vector3 value) { }

	public void set_loop(LoopMode value) { }

	public void set_matchTargetFields(MatchTargetFields value) { }

	public void set_position(Vector3 value) { }

	public void set_removeStartOffset(bool value) { }

	public void set_rotation(Quaternion value) { }

	public void set_useTrackMatchFields(bool value) { }

	private static bool ShouldApplyOffset(AppliedOffsetMode mode, AnimationClip clip) { }

	private static bool ShouldApplyScaleRemove(AppliedOffsetMode mode) { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

}

