namespace UnityEngine.Localization.PropertyVariants.TrackedObjects;

[CustomTrackedObject(typeof(MonoBehaviour), True)]
public class TrackedMonoBehaviourObject : JsonSerializerTrackedObject
{
	[SerializeField]
	private UnityEvent m_Changed; //Field offset: 0x18

	public UnityEvent Changed
	{
		 get { } //Length: 11
	}

	public TrackedMonoBehaviourObject() { }

	public UnityEvent get_Changed() { }

	protected virtual void PostApplyTrackedProperties() { }

}

