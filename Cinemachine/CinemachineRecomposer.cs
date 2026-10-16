//Type is in global namespace

[AddComponentMenu(null)]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.9/manual/CinemachineRecomposer.html")]
[SaveDuringPlay]
public class CinemachineRecomposer : CinemachineExtension
{
	[Tooltip("When to apply the adjustment")]
	public Stage m_ApplyAfter; //Field offset: 0x18
	[Tooltip("Tilt the camera by this much")]
	public float m_Tilt; //Field offset: 0x1C
	[Tooltip("Pan the camera by this much")]
	public float m_Pan; //Field offset: 0x20
	[Tooltip("Roll the camera by this much")]
	public float m_Dutch; //Field offset: 0x24
	[Tooltip("Scale the zoom by this amount (normal = 1)")]
	public float m_ZoomScale; //Field offset: 0x28
	[Range(0, 1)]
	[Tooltip("Lowering this value relaxes the camera's attention to the Follow target (normal = 1)")]
	public float m_FollowAttachment; //Field offset: 0x2C
	[Range(0, 1)]
	[Tooltip("Lowering this value relaxes the camera's attention to the LookAt target (normal = 1)")]
	public float m_LookAtAttachment; //Field offset: 0x30

	public CinemachineRecomposer() { }

	private void OnValidate() { }

	protected virtual void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, Stage stage, ref CameraState state, float deltaTime) { }

	public virtual void PrePipelineMutateCameraStateCallback(CinemachineVirtualCameraBase vcam, ref CameraState curState, float deltaTime) { }

	private void Reset() { }

}

