namespace Cinemachine;

[DocumentationSorting(Level::API (1))]
public abstract class CinemachineExtension : MonoBehaviour
{
	protected const float Epsilon = 0.0001; //Field offset: 0x0
	private CinemachineVirtualCameraBase m_vcamOwner; //Field offset: 0x10
	private Dictionary<ICinemachineCamera, Object> mExtraState; //Field offset: 0x14

	public override bool RequiresUserInput
	{
		 get { } //Length: 3
	}

	public CinemachineVirtualCameraBase VirtualCamera
	{
		 get { } //Length: 122
	}

	protected CinemachineExtension() { }

	protected override void Awake() { }

	protected override void ConnectToVcam(bool connect) { }

	internal void EnsureStarted() { }

	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	public override bool get_RequiresUserInput() { }

	public CinemachineVirtualCameraBase get_VirtualCamera() { }

	protected List<T> GetAllExtraStates() { }

	protected T GetExtraState(ICinemachineCamera vcam) { }

	public override float GetMaxDampTime() { }

	public void InvokePostPipelineStageCallback(CinemachineVirtualCameraBase vcam, Stage stage, ref CameraState state, float deltaTime) { }

	protected override void OnDestroy() { }

	protected override void OnEnable() { }

	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	protected abstract void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, Stage stage, ref CameraState state, float deltaTime) { }

	public override void PrePipelineMutateCameraStateCallback(CinemachineVirtualCameraBase vcam, ref CameraState curState, float deltaTime) { }

}

