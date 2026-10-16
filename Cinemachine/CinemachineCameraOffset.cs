//Type is in global namespace

[AddComponentMenu(null)]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.9/api/Cinemachine.CinemachineCameraOffset.html")]
[SaveDuringPlay]
public class CinemachineCameraOffset : CinemachineExtension
{
	[Tooltip("Offset the camera's position by this much (camera space)")]
	public Vector3 m_Offset; //Field offset: 0x18
	[Tooltip("When to apply the offset")]
	public Stage m_ApplyAfter; //Field offset: 0x24
	[Tooltip("If applying offset after aim, re-adjust the aim to preserve the screen position of the LookAt target as much as possible")]
	public bool m_PreserveComposition; //Field offset: 0x28

	public CinemachineCameraOffset() { }

	protected virtual void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, Stage stage, ref CameraState state, float deltaTime) { }

}

