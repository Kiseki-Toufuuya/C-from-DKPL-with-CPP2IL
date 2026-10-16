namespace UnityEngine.Timeline;

public class ParticleControlPlayable : PlayableBehaviour
{
	private const float kUnsetTime = 3.4028235E+38; //Field offset: 0x0
	private float m_LastPlayableTime; //Field offset: 0x8
	private float m_LastParticleTime; //Field offset: 0xC
	private uint m_RandomSeed; //Field offset: 0x10
	[CompilerGenerated]
	private ParticleSystem <particleSystem>k__BackingField; //Field offset: 0x14

	public private ParticleSystem particleSystem
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public ParticleControlPlayable() { }

	public static ScriptPlayable<ParticleControlPlayable> Create(PlayableGraph graph, ParticleSystem component, uint randomSeed) { }

	[CompilerGenerated]
	public ParticleSystem get_particleSystem() { }

	public void Initialize(ParticleSystem ps, uint randomSeed) { }

	public virtual void OnBehaviourPause(Playable playable, FrameData info) { }

	public virtual void OnBehaviourPlay(Playable playable, FrameData info) { }

	public virtual void PrepareFrame(Playable playable, FrameData data) { }

	[CompilerGenerated]
	private void set_particleSystem(ParticleSystem value) { }

	private static void SetRandomSeed(ParticleSystem particleSystem, uint randomSeed) { }

	private void Simulate(float time, bool restart) { }

}

