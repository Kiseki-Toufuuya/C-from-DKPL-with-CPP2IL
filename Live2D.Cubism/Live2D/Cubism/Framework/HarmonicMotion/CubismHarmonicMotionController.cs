namespace Live2D.Cubism.Framework.HarmonicMotion;

public sealed class CubismHarmonicMotionController : MonoBehaviour, ICubismUpdatable
{
	private const int DefaultChannelCount = 1; //Field offset: 0x0
	[SerializeField]
	public CubismParameterBlendMode BlendMode; //Field offset: 0x10
	[SerializeField]
	public Single[] ChannelTimescales; //Field offset: 0x14
	[CompilerGenerated]
	private CubismHarmonicMotionParameter[] <Sources>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private CubismParameter[] <Destinations>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private bool <HasUpdateController>k__BackingField; //Field offset: 0x20

	private CubismParameter[] Destinations
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public override int ExecutionOrder
	{
		 get { } //Length: 61
	}

	[HideInInspector]
	public override bool HasUpdateController
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public override bool NeedsUpdateOnEditing
	{
		 get { } //Length: 3
	}

	private CubismHarmonicMotionParameter[] Sources
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public CubismHarmonicMotionController() { }

	[CompilerGenerated]
	private CubismParameter[] get_Destinations() { }

	public override int get_ExecutionOrder() { }

	[CompilerGenerated]
	public override bool get_HasUpdateController() { }

	public override bool get_NeedsUpdateOnEditing() { }

	[CompilerGenerated]
	private CubismHarmonicMotionParameter[] get_Sources() { }

	private void LateUpdate() { }

	public override void OnLateUpdate() { }

	public void Refresh() { }

	private void Reset() { }

	[CompilerGenerated]
	private void set_Destinations(CubismParameter[] value) { }

	[CompilerGenerated]
	public override void set_HasUpdateController(bool value) { }

	[CompilerGenerated]
	private void set_Sources(CubismHarmonicMotionParameter[] value) { }

	private void Start() { }

}

