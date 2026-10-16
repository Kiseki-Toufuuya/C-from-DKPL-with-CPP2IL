namespace UnityEngine.Rendering.PostProcessing;

[AddComponentMenu("Rendering/Post-process Volume", 1001)]
[ExecuteAlways]
public sealed class PostProcessVolume : MonoBehaviour
{
	public PostProcessProfile sharedProfile; //Field offset: 0x10
	[Tooltip("Check this box to mark this volume as global. This volume's Profile will be applied to the whole Scene.")]
	public bool isGlobal; //Field offset: 0x14
	[Min(0)]
	[Tooltip("The distance (from the attached Collider) to start blending from. A value of 0 means there will be no blending and the Volume overrides will be applied immediatly upon entry to the attached Collider.")]
	public float blendDistance; //Field offset: 0x18
	[Range(0, 1)]
	[Tooltip("The total weight of this Volume in the Scene. A value of 0 signifies that it will have no effect, 1 signifies full effect.")]
	public float weight; //Field offset: 0x1C
	[Tooltip("The volume priority in the stack. A higher value means higher priority. Negative values are supported.")]
	public float priority; //Field offset: 0x20
	private int m_PreviousLayer; //Field offset: 0x24
	private float m_PreviousPriority; //Field offset: 0x28
	private List<Collider> m_TempColliders; //Field offset: 0x2C
	private PostProcessProfile m_InternalProfile; //Field offset: 0x30

	internal int previousLayer
	{
		internal get { } //Length: 11
	}

	public PostProcessProfile profile
	{
		 get { } //Length: 562
		 set { } //Length: 27
	}

	internal PostProcessProfile profileRef
	{
		internal get { } //Length: 91
	}

	public PostProcessVolume() { }

	internal int get_previousLayer() { }

	public PostProcessProfile get_profile() { }

	internal PostProcessProfile get_profileRef() { }

	public bool HasInstantiatedProfile() { }

	private void OnDisable() { }

	private void OnDrawGizmos() { }

	private void OnEnable() { }

	public void set_profile(PostProcessProfile value) { }

	private void Update() { }

}

