namespace Cinemachine;

[AddComponentMenu(null)]
[DisallowMultipleComponent]
[DocumentationSorting(Level::UserRef (2))]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.9/manual/CinemachineFollowZoom.html")]
[SaveDuringPlay]
public class CinemachineFollowZoom : CinemachineExtension
{
	private class VcamExtraState
	{
		public float m_previousFrameZoom; //Field offset: 0x8

		public VcamExtraState() { }

	}

	[Tooltip("The shot width to maintain, in world units, at target distance.")]
	public float m_Width; //Field offset: 0x18
	[Range(0, 20)]
	[Tooltip("Increase this value to soften the aggressiveness of the follow-zoom.  Small numbers are more responsive, larger numbers give a more heavy slowly responding camera.")]
	public float m_Damping; //Field offset: 0x1C
	[Range(1, 179)]
	[Tooltip("Lower limit for the FOV that this behaviour will generate.")]
	public float m_MinFOV; //Field offset: 0x20
	[Range(1, 179)]
	[Tooltip("Upper limit for the FOV that this behaviour will generate.")]
	public float m_MaxFOV; //Field offset: 0x24

	public CinemachineFollowZoom() { }

	public virtual float GetMaxDampTime() { }

	private void OnValidate() { }

	protected virtual void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, Stage stage, ref CameraState state, float deltaTime) { }

}

