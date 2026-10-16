namespace Cinemachine;

[AddComponentMenu("Cinemachine/CinemachineVirtualCamera")]
[DisallowMultipleComponent]
[DocumentationSorting(Level::UserRef (2))]
[ExcludeFromPreset]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.9/manual/CinemachineVirtualCamera.html")]
public class CinemachineVirtualCamera : CinemachineVirtualCameraBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<CinemachineComponentBase> <>9__37_0; //Field offset: 0x4
		public static Func<CinemachineComponentBase, Boolean> <>9__46_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <RequiresUserInput>b__46_0(CinemachineComponentBase c) { }

		internal int <UpdateComponentPipeline>b__37_0(CinemachineComponentBase c1, CinemachineComponentBase c2) { }

	}

	internal sealed class CreatePipelineDelegate : MulticastDelegate
	{

		public CreatePipelineDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(CinemachineVirtualCamera vcam, string name, CinemachineComponentBase[] copyFrom, AsyncCallback callback, object object) { }

		public override Transform EndInvoke(IAsyncResult result) { }

		public override Transform Invoke(CinemachineVirtualCamera vcam, string name, CinemachineComponentBase[] copyFrom) { }

	}

	internal sealed class DestroyPipelineDelegate : MulticastDelegate
	{

		public DestroyPipelineDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(GameObject pipeline, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(GameObject pipeline) { }

	}

	public const string PipelineName = "cm"; //Field offset: 0x0
	public static CreatePipelineDelegate CreatePipelineOverride; //Field offset: 0x0
	public static DestroyPipelineDelegate DestroyPipelineOverride; //Field offset: 0x4
	[NoSaveDuringPlay]
	[Tooltip("The object that the camera wants to look at (the Aim target).  If this is null, then the vcam's Transform orientation will define the camera's orientation.")]
	[VcamTargetProperty]
	public Transform m_LookAt; //Field offset: 0x68
	[NoSaveDuringPlay]
	[Tooltip("The object that the camera wants to move with (the Body target).  If this is null, then the vcam's Transform position will define the camera's position.")]
	[VcamTargetProperty]
	public Transform m_Follow; //Field offset: 0x6C
	[FormerlySerializedAs("m_LensAttributes")]
	[Tooltip("Specifies the lens properties of this Virtual Camera.  This generally mirrors the Unity Camera's lens settings, and will be used to drive the Unity camera when the vcam is active.")]
	public LensSettings m_Lens; //Field offset: 0x70
	public TransitionParams m_Transitions; //Field offset: 0xA4
	[FormerlySerializedAs("m_BlendHint")]
	[FormerlySerializedAs("m_PositionBlending")]
	[HideInInspector]
	[SerializeField]
	private BlendHint m_LegacyBlendHint; //Field offset: 0xB0
	private CameraState m_State; //Field offset: 0xB4
	private CinemachineComponentBase[] m_ComponentPipeline; //Field offset: 0x174
	[HideInInspector]
	[SerializeField]
	private Transform m_ComponentOwner; //Field offset: 0x178
	private Transform mCachedLookAtTarget; //Field offset: 0x17C
	private CinemachineVirtualCameraBase mCachedLookAtTargetVcam; //Field offset: 0x180

	public virtual Transform Follow
	{
		 get { } //Length: 22
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

	public CinemachineVirtualCamera() { }

	public T AddCinemachineComponent() { }

	private CameraState CalculateNewState(Vector3 worldUp, float deltaTime) { }

	internal Transform CreatePipeline(CinemachineVirtualCamera copyFrom) { }

	public void DestroyCinemachineComponent() { }

	internal void DestroyPipeline() { }

	public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	public virtual Transform get_Follow() { }

	public virtual Transform get_LookAt() { }

	public virtual CameraState get_State() { }

	public T GetCinemachineComponent() { }

	public CinemachineComponentBase GetCinemachineComponent(Stage stage) { }

	public Transform GetComponentOwner() { }

	public CinemachineComponentBase[] GetComponentPipeline() { }

	public virtual float GetMaxDampTime() { }

	public virtual void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	public void InvalidateComponentPipeline() { }

	internal virtual void OnBeforeSerialize() { }

	protected virtual void OnDestroy() { }

	protected virtual void OnEnable() { }

	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	private void OnTransformChildrenChanged() { }

	public virtual void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	protected virtual void OnValidate() { }

	internal virtual bool RequiresUserInput() { }

	private void Reset() { }

	public virtual void set_Follow(Transform value) { }

	public virtual void set_LookAt(Transform value) { }

	internal static void SetFlagsForHiddenChild(GameObject child) { }

	internal void SetStateRawPosition(Vector3 pos) { }

	private void UpdateComponentPipeline() { }

}

