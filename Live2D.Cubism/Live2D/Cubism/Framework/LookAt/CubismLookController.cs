namespace Live2D.Cubism.Framework.LookAt;

public sealed class CubismLookController : MonoBehaviour, ICubismUpdatable
{
	[SerializeField]
	public CubismParameterBlendMode BlendMode; //Field offset: 0x10
	[HideInInspector]
	[SerializeField]
	private object _target; //Field offset: 0x14
	private ICubismLookTarget _targetInterface; //Field offset: 0x18
	public Transform Center; //Field offset: 0x1C
	public float Damping; //Field offset: 0x20
	[CompilerGenerated]
	private CubismLookParameter[] <Sources>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private CubismParameter[] <Destinations>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private Vector3 <LastPosition>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private Vector3 <GoalPosition>k__BackingField; //Field offset: 0x38
	private Vector3 VelocityBuffer; //Field offset: 0x44
	[CompilerGenerated]
	private bool <HasUpdateController>k__BackingField; //Field offset: 0x50

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

	private Vector3 GoalPosition
	{
		[CompilerGenerated]
		private get { } //Length: 26
		[CompilerGenerated]
		private set { } //Length: 24
	}

	[HideInInspector]
	public override bool HasUpdateController
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	private Vector3 LastPosition
	{
		[CompilerGenerated]
		private get { } //Length: 26
		[CompilerGenerated]
		private set { } //Length: 24
	}

	public override bool NeedsUpdateOnEditing
	{
		 get { } //Length: 3
	}

	private CubismLookParameter[] Sources
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public object Target
	{
		 get { } //Length: 11
		 set { } //Length: 67
	}

	private ICubismLookTarget TargetInterface
	{
		private get { } //Length: 78
	}

	public CubismLookController() { }

	[CompilerGenerated]
	private CubismParameter[] get_Destinations() { }

	public override int get_ExecutionOrder() { }

	[CompilerGenerated]
	private Vector3 get_GoalPosition() { }

	[CompilerGenerated]
	public override bool get_HasUpdateController() { }

	[CompilerGenerated]
	private Vector3 get_LastPosition() { }

	public override bool get_NeedsUpdateOnEditing() { }

	[CompilerGenerated]
	private CubismLookParameter[] get_Sources() { }

	public object get_Target() { }

	private ICubismLookTarget get_TargetInterface() { }

	private void LateUpdate() { }

	public override void OnLateUpdate() { }

	public void Refresh() { }

	[CompilerGenerated]
	private void set_Destinations(CubismParameter[] value) { }

	[CompilerGenerated]
	private void set_GoalPosition(Vector3 value) { }

	[CompilerGenerated]
	public override void set_HasUpdateController(bool value) { }

	[CompilerGenerated]
	private void set_LastPosition(Vector3 value) { }

	[CompilerGenerated]
	private void set_Sources(CubismLookParameter[] value) { }

	public void set_Target(object value) { }

	private void Start() { }

}

