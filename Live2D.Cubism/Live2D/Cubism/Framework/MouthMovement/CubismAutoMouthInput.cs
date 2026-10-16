namespace Live2D.Cubism.Framework.MouthMovement;

public sealed class CubismAutoMouthInput : MonoBehaviour
{
	[SerializeField]
	public float Timescale; //Field offset: 0x10
	[CompilerGenerated]
	private CubismMouthController <Controller>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private float <T>k__BackingField; //Field offset: 0x18

	private CubismMouthController Controller
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private float T
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 18
	}

	public CubismAutoMouthInput() { }

	[CompilerGenerated]
	private CubismMouthController get_Controller() { }

	[CompilerGenerated]
	private float get_T() { }

	private void LateUpdate() { }

	public void Reset() { }

	[CompilerGenerated]
	private void set_Controller(CubismMouthController value) { }

	[CompilerGenerated]
	private void set_T(float value) { }

	private void Start() { }

}

