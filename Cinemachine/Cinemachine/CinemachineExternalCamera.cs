namespace Cinemachine;

[AddComponentMenu("Cinemachine/CinemachineExternalCamera")]
[DisallowMultipleComponent]
[DocumentationSorting(Level::UserRef (2))]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.9/manual/CinemachineExternalCamera.html")]
[RequireComponent(typeof(Camera))]
public class CinemachineExternalCamera : CinemachineVirtualCameraBase
{
	[NoSaveDuringPlay]
	[Tooltip("The object that the camera is looking at.  Setting this will improve the quality of the blends to and from this camera")]
	[VcamTargetProperty]
	public Transform m_LookAt; //Field offset: 0x68
	private Camera m_Camera; //Field offset: 0x6C
	private CameraState m_State; //Field offset: 0x70
	[CompilerGenerated]
	private Transform <Follow>k__BackingField; //Field offset: 0x130
	[FormerlySerializedAs("m_PositionBlending")]
	[Tooltip("Hint for blending positions to and from this virtual camera")]
	public BlendHint m_BlendHint; //Field offset: 0x134

	public virtual Transform Follow
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public virtual Transform LookAt
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public virtual CameraState State
	{
		 get { } //Length: 27
	}

	public CinemachineExternalCamera() { }

	[CompilerGenerated]
	public virtual Transform get_Follow() { }

	public virtual Transform get_LookAt() { }

	public virtual CameraState get_State() { }

	public virtual void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	[CompilerGenerated]
	public virtual void set_Follow(Transform value) { }

	public virtual void set_LookAt(Transform value) { }

}

