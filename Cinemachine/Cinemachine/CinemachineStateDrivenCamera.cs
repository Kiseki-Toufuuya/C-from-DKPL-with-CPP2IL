namespace Cinemachine;

[AddComponentMenu("Cinemachine/CinemachineStateDrivenCamera")]
[DisallowMultipleComponent]
[DocumentationSorting(Level::UserRef (2))]
[ExcludeFromPreset]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.9/manual/CinemachineStateDrivenCamera.html")]
public class CinemachineStateDrivenCamera : CinemachineVirtualCameraBase
{
	private struct HashPair
	{
		public int parentHash; //Field offset: 0x0
		public int hash; //Field offset: 0x4

	}

	internal struct Instruction
	{
		[Tooltip("The full hash of the animation state")]
		public int m_FullHash; //Field offset: 0x0
		[Tooltip("The virtual camera to activate when the animation state becomes active")]
		public CinemachineVirtualCameraBase m_VirtualCamera; //Field offset: 0x4
		[Tooltip("How long to wait (in seconds) before activating the virtual camera. This filters out very short state durations")]
		public float m_ActivateAfter; //Field offset: 0x8
		[Tooltip("The minimum length of time (in seconds) to keep a virtual camera active")]
		public float m_MinDuration; //Field offset: 0xC

	}

	[DocumentationSorting(Level::Undoc (0))]
	public struct ParentHash
	{
		public int m_Hash; //Field offset: 0x0
		public int m_ParentHash; //Field offset: 0x4

		public ParentHash(int h, int p) { }

	}

	[NoSaveDuringPlay]
	[Tooltip("Default object for the camera children to look at (the aim target), if not specified in a child camera.  May be empty if all of the children define targets of their own.")]
	[VcamTargetProperty]
	public Transform m_LookAt; //Field offset: 0x68
	[NoSaveDuringPlay]
	[Tooltip("Default object for the camera children wants to move with (the body target), if not specified in a child camera.  May be empty if all of the children define targets of their own.")]
	[VcamTargetProperty]
	public Transform m_Follow; //Field offset: 0x6C
	[NoSaveDuringPlay]
	[Space]
	[Tooltip("The state machine whose state changes will drive this camera's choice of active child")]
	public Animator m_AnimatedTarget; //Field offset: 0x70
	[NoSaveDuringPlay]
	[Tooltip("Which layer in the target state machine to observe")]
	public int m_LayerIndex; //Field offset: 0x74
	[Tooltip("When enabled, the current child camera and blend will be indicated in the game window, for debugging")]
	public bool m_ShowDebugText; //Field offset: 0x78
	[HideInInspector]
	[NoSaveDuringPlay]
	[SerializeField]
	internal CinemachineVirtualCameraBase[] m_ChildCameras; //Field offset: 0x7C
	[Tooltip("The set of instructions associating virtual cameras with states.  These instructions are used to choose the live child at any given moment")]
	public Instruction[] m_Instructions; //Field offset: 0x80
	[CinemachineBlendDefinitionProperty]
	[Tooltip("The blend which is used if you don't explicitly define a blend between two Virtual Camera children")]
	public CinemachineBlendDefinition m_DefaultBlend; //Field offset: 0x84
	[Tooltip("This is the asset which contains custom settings for specific child blends")]
	public CinemachineBlenderSettings m_CustomBlends; //Field offset: 0x90
	[HideInInspector]
	[SerializeField]
	internal ParentHash[] m_ParentHash; //Field offset: 0x94
	[CompilerGenerated]
	private ICinemachineCamera <LiveChild>k__BackingField; //Field offset: 0x98
	private ICinemachineCamera m_TransitioningFrom; //Field offset: 0x9C
	private CameraState m_State; //Field offset: 0xA0
	private Dictionary<AnimationClip, List`1<HashPair>> mHashCache; //Field offset: 0x160
	private float mActivationTime; //Field offset: 0x164
	private Instruction mActiveInstruction; //Field offset: 0x168
	private float mPendingActivationTime; //Field offset: 0x178
	private Instruction mPendingInstruction; //Field offset: 0x17C
	private CinemachineBlend mActiveBlend; //Field offset: 0x18C
	private Dictionary<Int32, Int32> mInstructionDictionary; //Field offset: 0x190
	private Dictionary<Int32, Int32> mStateParentLookup; //Field offset: 0x194
	private List<AnimatorClipInfo> m_clipInfoList; //Field offset: 0x198

	public CinemachineBlend ActiveBlend
	{
		 get { } //Length: 14
	}

	public CinemachineVirtualCameraBase[] ChildCameras
	{
		 get { } //Length: 24
	}

	public virtual string Description
	{
		 get { } //Length: 228
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
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
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

	public CinemachineStateDrivenCamera() { }

	private CinemachineVirtualCameraBase ChooseCurrentCamera() { }

	public static int CreateFakeHash(int parentHash, AnimationClip clip) { }

	public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	public CinemachineBlend get_ActiveBlend() { }

	public CinemachineVirtualCameraBase[] get_ChildCameras() { }

	public virtual string get_Description() { }

	public virtual Transform get_Follow() { }

	public bool get_IsBlending() { }

	[CompilerGenerated]
	public ICinemachineCamera get_LiveChild() { }

	public virtual Transform get_LookAt() { }

	public virtual CameraState get_State() { }

	private int GetClipHash(int hash, List<AnimatorClipInfo> clips) { }

	public virtual void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	private void InvalidateListOfChildren() { }

	public virtual bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false) { }

	private CinemachineBlendDefinition LookupBlend(ICinemachineCamera fromKey, ICinemachineCamera toKey) { }

	private int LookupFakeHash(int parentHash, AnimationClip clip) { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	private void OnGuiHandler() { }

	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	public void OnTransformChildrenChanged() { }

	public virtual void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	public virtual void set_Follow(Transform value) { }

	[CompilerGenerated]
	public void set_LiveChild(ICinemachineCamera value) { }

	public virtual void set_LookAt(Transform value) { }

	private void UpdateListOfChildren() { }

	internal void ValidateInstructions() { }

}

