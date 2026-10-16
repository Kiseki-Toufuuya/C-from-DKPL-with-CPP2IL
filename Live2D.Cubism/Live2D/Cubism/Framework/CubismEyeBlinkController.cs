namespace Live2D.Cubism.Framework;

public sealed class CubismEyeBlinkController : MonoBehaviour, ICubismUpdatable
{
	[SerializeField]
	public CubismParameterBlendMode BlendMode; //Field offset: 0x10
	[Range(0, 1)]
	[SerializeField]
	public float EyeOpening; //Field offset: 0x14
	[CompilerGenerated]
	private CubismParameter[] <Destinations>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <HasUpdateController>k__BackingField; //Field offset: 0x1C

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

	public CubismEyeBlinkController() { }

	[CompilerGenerated]
	private CubismParameter[] get_Destinations() { }

	public override int get_ExecutionOrder() { }

	[CompilerGenerated]
	public override bool get_HasUpdateController() { }

	public override bool get_NeedsUpdateOnEditing() { }

	private void LateUpdate() { }

	public override void OnLateUpdate() { }

	public void Refresh() { }

	[CompilerGenerated]
	private void set_Destinations(CubismParameter[] value) { }

	[CompilerGenerated]
	public override void set_HasUpdateController(bool value) { }

	private void Start() { }

}

