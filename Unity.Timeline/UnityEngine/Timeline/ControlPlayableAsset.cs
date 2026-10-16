namespace UnityEngine.Timeline;

[NotKeyable]
public class ControlPlayableAsset : PlayableAsset, IPropertyPreview, ITimelineClipAsset
{
	[CompilerGenerated]
	private sealed class <GetControlableScripts>d__40 : IEnumerable<MonoBehaviour>, IEnumerable, IEnumerator<MonoBehaviour>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private MonoBehaviour <>2__current; //Field offset: 0xC
		private int <>l__initialThreadId; //Field offset: 0x10
		private GameObject root; //Field offset: 0x14
		public GameObject <>3__root; //Field offset: 0x18
		public ControlPlayableAsset <>4__this; //Field offset: 0x1C
		private MonoBehaviour[] <>7__wrap1; //Field offset: 0x20
		private int <>7__wrap2; //Field offset: 0x24

		private override MonoBehaviour System.Collections.Generic.IEnumerator<UnityEngine.MonoBehaviour>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		[DebuggerHidden]
		public <GetControlableScripts>d__40(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<MonoBehaviour> System.Collections.Generic.IEnumerable<UnityEngine.MonoBehaviour>.GetEnumerator() { }

		[DebuggerHidden]
		private override MonoBehaviour System.Collections.Generic.IEnumerator<UnityEngine.MonoBehaviour>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private const int k_MaxRandInt = 10000; //Field offset: 0x0
	private static readonly List<PlayableDirector> k_EmptyDirectorsList; //Field offset: 0x0
	private static readonly List<ParticleSystem> k_EmptyParticlesList; //Field offset: 0x4
	private static readonly HashSet<ParticleSystem> s_SubEmitterCollector; //Field offset: 0x8
	private static HashSet<PlayableDirector> s_ProcessedDirectors; //Field offset: 0xC
	private static HashSet<GameObject> s_CreatedPrefabs; //Field offset: 0x10
	[SerializeField]
	public ExposedReference<GameObject> sourceGameObject; //Field offset: 0xC
	[SerializeField]
	public GameObject prefabGameObject; //Field offset: 0x14
	[SerializeField]
	public bool updateParticle; //Field offset: 0x18
	[SerializeField]
	public uint particleRandomSeed; //Field offset: 0x1C
	[SerializeField]
	public bool updateDirector; //Field offset: 0x20
	[SerializeField]
	public bool updateITimeControl; //Field offset: 0x21
	[SerializeField]
	public bool searchHierarchy; //Field offset: 0x22
	[SerializeField]
	public bool active; //Field offset: 0x23
	[SerializeField]
	public PostPlaybackState postPlayback; //Field offset: 0x24
	[SerializeField]
	public PauseAction directorOnClipEnd; //Field offset: 0x28
	private PlayableAsset m_ControlDirectorAsset; //Field offset: 0x2C
	private double m_Duration; //Field offset: 0x30
	private bool m_SupportLoop; //Field offset: 0x38
	[CompilerGenerated]
	private bool <controllingDirectors>k__BackingField; //Field offset: 0x39
	[CompilerGenerated]
	private bool <controllingParticles>k__BackingField; //Field offset: 0x3A

	public override ClipCaps clipCaps
	{
		 get { } //Length: 19
	}

	internal bool controllingDirectors
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	internal bool controllingParticles
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public virtual double duration
	{
		 get { } //Length: 11
	}

	private static ControlPlayableAsset() { }

	public ControlPlayableAsset() { }

	private static void CacheSubEmitters(ParticleSystem ps, HashSet<ParticleSystem> subEmitters) { }

	private static void ConnectMixerAndPlayable(PlayableGraph graph, Playable mixer, Playable playable, int portIndex) { }

	private static Playable ConnectPlayablesToMixer(PlayableGraph graph, List<Playable> playables) { }

	private void CreateActivationPlayable(GameObject root, PlayableGraph graph, List<Playable> outplayables) { }

	public virtual Playable CreatePlayable(PlayableGraph graph, GameObject go) { }

	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	public override ClipCaps get_clipCaps() { }

	[CompilerGenerated]
	internal bool get_controllingDirectors() { }

	[CompilerGenerated]
	internal bool get_controllingParticles() { }

	public virtual double get_duration() { }

	internal IList<T> GetComponent(GameObject gameObject) { }

	[IteratorStateMachine(typeof(<GetControlableScripts>d__40))]
	internal IEnumerable<MonoBehaviour> GetControlableScripts(GameObject root) { }

	private IList<ParticleSystem> GetControllableParticleSystems(GameObject go) { }

	private static void GetControllableParticleSystems(Transform t, ICollection<ParticleSystem> roots, HashSet<ParticleSystem> subEmitters) { }

	public void OnEnable() { }

	internal static void PreviewActivation(IPropertyCollector driver, IEnumerable<GameObject> objects) { }

	internal static void PreviewDirectors(IPropertyCollector driver, IEnumerable<PlayableDirector> directors) { }

	internal static void PreviewParticles(IPropertyCollector driver, IEnumerable<ParticleSystem> particles) { }

	internal static void PreviewTimeControl(IPropertyCollector driver, PlayableDirector director, IEnumerable<MonoBehaviour> scripts) { }

	private static void SearchHierarchyAndConnectControlableScripts(IEnumerable<MonoBehaviour> controlableScripts, PlayableGraph graph, List<Playable> outplayables) { }

	private void SearchHierarchyAndConnectDirector(IEnumerable<PlayableDirector> directors, PlayableGraph graph, List<Playable> outplayables, bool disableSelfReferences) { }

	private void SearchHierarchyAndConnectParticleSystem(IEnumerable<ParticleSystem> particleSystems, PlayableGraph graph, List<Playable> outplayables) { }

	[CompilerGenerated]
	private void set_controllingDirectors(bool value) { }

	[CompilerGenerated]
	private void set_controllingParticles(bool value) { }

	internal void UpdateDurationAndLoopFlag(IList<PlayableDirector> directors, IList<ParticleSystem> particleSystems) { }

}

