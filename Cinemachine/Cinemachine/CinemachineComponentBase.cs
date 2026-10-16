namespace Cinemachine;

[DocumentationSorting(Level::API (1))]
public abstract class CinemachineComponentBase : MonoBehaviour
{
	protected const float Epsilon = 0.0001; //Field offset: 0x0
	private CinemachineVirtualCameraBase m_vcamOwner; //Field offset: 0x10

	public ICinemachineTargetGroup AbstractFollowTargetGroup
	{
		 get { } //Length: 105
	}

	public ICinemachineTargetGroup AbstractLookAtTargetGroup
	{
		 get { } //Length: 30
	}

	public override bool BodyAppliesAfterAim
	{
		 get { } //Length: 3
	}

	public Transform FollowTarget
	{
		 get { } //Length: 131
	}

	public CinemachineTargetGroup FollowTargetGroup
	{
		 get { } //Length: 200
	}

	public Vector3 FollowTargetPosition
	{
		 get { } //Length: 394
	}

	public Quaternion FollowTargetRotation
	{
		 get { } //Length: 355
	}

	public abstract bool IsValid
	{
		 get { } //Length: 0
	}

	public Transform LookAtTarget
	{
		 get { } //Length: 131
	}

	public CinemachineTargetGroup LookAtTargetGroup
	{
		 get { } //Length: 131
	}

	public Vector3 LookAtTargetPosition
	{
		 get { } //Length: 394
	}

	public Quaternion LookAtTargetRotation
	{
		 get { } //Length: 355
	}

	public override bool RequiresUserInput
	{
		 get { } //Length: 3
	}

	public abstract Stage Stage
	{
		 get { } //Length: 0
	}

	public CameraState VcamState
	{
		 get { } //Length: 215
	}

	public CinemachineVirtualCameraBase VirtualCamera
	{
		 get { } //Length: 291
	}

	protected CinemachineComponentBase() { }

	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	public ICinemachineTargetGroup get_AbstractFollowTargetGroup() { }

	public ICinemachineTargetGroup get_AbstractLookAtTargetGroup() { }

	public override bool get_BodyAppliesAfterAim() { }

	public Transform get_FollowTarget() { }

	public CinemachineTargetGroup get_FollowTargetGroup() { }

	public Vector3 get_FollowTargetPosition() { }

	public Quaternion get_FollowTargetRotation() { }

	public abstract bool get_IsValid() { }

	public Transform get_LookAtTarget() { }

	public CinemachineTargetGroup get_LookAtTargetGroup() { }

	public Vector3 get_LookAtTargetPosition() { }

	public Quaternion get_LookAtTargetRotation() { }

	public override bool get_RequiresUserInput() { }

	public abstract Stage get_Stage() { }

	public CameraState get_VcamState() { }

	public CinemachineVirtualCameraBase get_VirtualCamera() { }

	public override float GetMaxDampTime() { }

	public abstract void MutateCameraState(ref CameraState curState, float deltaTime) { }

	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref TransitionParams transitionParams) { }

	public override void PrePipelineMutateCameraState(ref CameraState curState, float deltaTime) { }

}

