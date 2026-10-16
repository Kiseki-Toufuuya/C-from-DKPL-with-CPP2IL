namespace Live2D.Cubism.Framework.Physics;

[CubismMoveOnReimportCopyComponentsOnly]
public class CubismPhysicsController : MonoBehaviour, ICubismUpdatable
{
	[SerializeField]
	private CubismPhysicsRig _rig; //Field offset: 0x10
	[CompilerGenerated]
	private CubismParameter[] <Parameters>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private bool <HasUpdateController>k__BackingField; //Field offset: 0x18

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

	public private CubismParameter[] Parameters
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private CubismPhysicsRig Rig
	{
		private get { } //Length: 11
		private set { } //Length: 27
	}

	public CubismPhysicsController() { }

	public void Awake() { }

	public override int get_ExecutionOrder() { }

	[CompilerGenerated]
	public override bool get_HasUpdateController() { }

	public override bool get_NeedsUpdateOnEditing() { }

	[CompilerGenerated]
	public CubismParameter[] get_Parameters() { }

	private CubismPhysicsRig get_Rig() { }

	public void Initialize(CubismPhysicsRig rig) { }

	private void LateUpdate() { }

	public override void OnLateUpdate() { }

	[CompilerGenerated]
	public override void set_HasUpdateController(bool value) { }

	[CompilerGenerated]
	private void set_Parameters(CubismParameter[] value) { }

	private void set_Rig(CubismPhysicsRig value) { }

	public void SetPhysicsSubRigOutputAngleScaleRatio(CubismPhysicsSubRig subRig, float ratio) { }

	public void SetPhysicsSubRigOutputIsInverted(CubismPhysicsSubRig subRig, bool isInvert) { }

	public void Stabilization() { }

	public void Start() { }

}

