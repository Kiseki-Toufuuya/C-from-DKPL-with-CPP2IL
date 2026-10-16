namespace Cinemachine;

[AddComponentMenu("Cinemachine/CinemachineBlendListCamera")]
[DisallowMultipleComponent]
[DocumentationSorting(Level::UserRef (2))]
[ExcludeFromPreset]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.9/manual/CinemachineBlendListCamera.html")]
public class CinemachineBlendListCamera : CinemachineVirtualCameraBase
{
	internal struct Instruction
	{
		[Tooltip("The virtual camera to activate when this instruction becomes active")]
		public CinemachineVirtualCameraBase m_VirtualCamera; //Field offset: 0x0
		[Tooltip("How long to wait (in seconds) before activating the next virtual camera in the list (if any)")]
		public float m_Hold; //Field offset: 0x4
		[CinemachineBlendDefinitionProperty]
		[Tooltip("How to blend to the next virtual camera in the list (if any)")]
		public CinemachineBlendDefinition m_Blend; //Field offset: 0x8

	}

	[NoSaveDuringPlay]
	[Tooltip("Default object for the camera children to look at (the aim target), if not specified in a child camera.  May be empty if all of the children define targets of their own.")]
	[VcamTargetProperty]
	public Transform m_LookAt; //Field offset: 0x68
	[NoSaveDuringPlay]
	[Tooltip("Default object for the camera children wants to move with (the body target), if not specified in a child camera.  May be empty if all of the children define targets of their own.")]
	[VcamTargetProperty]
	public Transform m_Follow; //Field offset: 0x6C
	[Tooltip("When enabled, the current child camera and blend will be indicated in the game window, for debugging")]
	public bool m_ShowDebugText; //Field offset: 0x70
	[Tooltip("When enabled, the child vcams will cycle indefinitely instead of just stopping at the last one")]
	public bool m_Loop; //Field offset: 0x71
	[HideInInspector]
	[NoSaveDuringPlay]
	[SerializeField]
	internal CinemachineVirtualCameraBase[] m_ChildCameras; //Field offset: 0x74
	[Tooltip("The set of instructions for enabling child cameras.")]
	public Instruction[] m_Instructions; //Field offset: 0x78
	[CompilerGenerated]
	private ICinemachineCamera <LiveChild>k__BackingField; //Field offset: 0x7C
	private ICinemachineCamera m_TransitioningFrom; //Field offset: 0x80
	private CameraState m_State; //Field offset: 0x84
	private float mActivationTime; //Field offset: 0x144
	private int mCurrentInstruction; //Field offset: 0x148
	private CinemachineBlend mActiveBlend; //Field offset: 0x14C

	public CinemachineVirtualCameraBase[] ChildCameras
	{
		 get { } //Length: 24
	}

	public virtual string Description
	{
		 get { } //Length: 225
	}

	public virtual Transform Follow
	{
		 get { } //Length: 22
		 set { } //Length: 27
	}

	public bool IsBlending
	{
		 get { } //Length: 18
	}

	public ICinemachineCamera LiveChild
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public virtual Transform LookAt
	{
		 get { } //Length: 22
		 set { } //Length: 27
	}

	public virtual CameraState State
	{
		 get { } //Length: 30
	}

	public CinemachineBlendListCamera() { }

	private void AdvanceCurrentInstruction(float deltaTime) { }

	public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	public CinemachineVirtualCameraBase[] get_ChildCameras() { }

	public virtual string get_Description() { }

	public virtual Transform get_Follow() { }

	public bool get_IsBlending() { }

	[CompilerGenerated]
	public ICinemachineCamera get_LiveChild() { }

	public virtual Transform get_LookAt() { }

	public virtual CameraState get_State() { }

	public virtual void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	private void InvalidateListOfChildren() { }

	public virtual bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false) { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	private void OnGuiHandler() { }

	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	private void OnTransformChildrenChanged() { }

	public virtual void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	private void Reset() { }

	public virtual void set_Follow(Transform value) { }

	[CompilerGenerated]
	public void set_LiveChild(ICinemachineCamera value) { }

	public virtual void set_LookAt(Transform value) { }

	private void UpdateListOfChildren() { }

	internal void ValidateInstructions() { }

}

