namespace Live2D.Cubism.Samples.Raycasting;

public sealed class RaycastHitDisplay : MonoBehaviour
{
	[SerializeField]
	public CubismModel Model; //Field offset: 0x10
	[SerializeField]
	public Text ResultsText; //Field offset: 0x14
	[CompilerGenerated]
	private CubismRaycaster <Raycaster>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private CubismRaycastHit[] <Results>k__BackingField; //Field offset: 0x1C

	private CubismRaycaster Raycaster
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private CubismRaycastHit[] Results
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public RaycastHitDisplay() { }

	private void DoRaycast() { }

	[CompilerGenerated]
	private CubismRaycaster get_Raycaster() { }

	[CompilerGenerated]
	private CubismRaycastHit[] get_Results() { }

	[CompilerGenerated]
	private void set_Raycaster(CubismRaycaster value) { }

	[CompilerGenerated]
	private void set_Results(CubismRaycastHit[] value) { }

	private void Start() { }

	private void Update() { }

}

