namespace UnityEngine.Timeline;

public class PrefabControlPlayable : PlayableBehaviour
{
	private GameObject m_Instance; //Field offset: 0x8

	public GameObject prefabInstance
	{
		 get { } //Length: 11
	}

	public PrefabControlPlayable() { }

	public static ScriptPlayable<PrefabControlPlayable> Create(PlayableGraph graph, GameObject prefabGameObject, Transform parentTransform) { }

	public GameObject get_prefabInstance() { }

	public GameObject Initialize(GameObject prefabGameObject, Transform parentTransform) { }

	public virtual void OnBehaviourPause(Playable playable, FrameData info) { }

	public virtual void OnBehaviourPlay(Playable playable, FrameData info) { }

	public virtual void OnPlayableDestroy(Playable playable) { }

	private static void SetHideFlagsRecursive(GameObject gameObject) { }

}

