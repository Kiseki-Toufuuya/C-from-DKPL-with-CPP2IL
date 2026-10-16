namespace Live2D.Cubism.Framework.Pose;

public sealed class CubismPoseController : MonoBehaviour, ICubismUpdatable
{
	private const float BackOpacityThreshold = 0.15; //Field offset: 0x0
	[SerializeField]
	public int defaultPoseIndex; //Field offset: 0x10
	private CubismModel _model; //Field offset: 0x14
	[CompilerGenerated]
	private bool <HasUpdateController>k__BackingField; //Field offset: 0x18
	private CubismPoseData[][] _poseData; //Field offset: 0x1C

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

	public CubismPoseController() { }

	private void CopyPartOpacities() { }

	private void DoFade() { }

	public override int get_ExecutionOrder() { }

	[CompilerGenerated]
	public override bool get_HasUpdateController() { }

	public override bool get_NeedsUpdateOnEditing() { }

	private void LateUpdate() { }

	private void OnEnable() { }

	public override void OnLateUpdate() { }

	public void Refresh() { }

	private void SavePartOpacities() { }

	[CompilerGenerated]
	public override void set_HasUpdateController(bool value) { }

}

