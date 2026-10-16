namespace Cinemachine;

[AddComponentMenu("Cinemachine/CinemachineFreeLook")]
[DisallowMultipleComponent]
[DocumentationSorting(Level::UserRef (2))]
[ExcludeFromPreset]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.9/manual/CinemachineFreeLook.html")]
public class CinemachineFreeLook : CinemachineVirtualCameraBase
{
	[CompilerGenerated]
	private struct <>c__DisplayClass47_0
	{
		public CinemachineFreeLook <>4__this; //Field offset: 0x0
		public Vector3 cameraOffset; //Field offset: 0x4

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass47_1
	{
		public float bestAngle; //Field offset: 0x0
		public float best; //Field offset: 0x4

	}

	internal sealed class CreateRigDelegate : MulticastDelegate
	{

		public CreateRigDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(CinemachineFreeLook vcam, string name, CinemachineVirtualCamera copyFrom, AsyncCallback callback, object object) { }

		public override CinemachineVirtualCamera EndInvoke(IAsyncResult result) { }

		public override CinemachineVirtualCamera Invoke(CinemachineFreeLook vcam, string name, CinemachineVirtualCamera copyFrom) { }

	}

	internal sealed class DestroyRigDelegate : MulticastDelegate
	{

		public DestroyRigDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(GameObject rig, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(GameObject rig) { }

	}

	internal struct Orbit
	{
		public float m_Height; //Field offset: 0x0
		public float m_Radius; //Field offset: 0x4

		public Orbit(float h, float r) { }

	}

	public static CreateRigDelegate CreateRigOverride; //Field offset: 0x0
	public static DestroyRigDelegate DestroyRigOverride; //Field offset: 0x4
	[NoSaveDuringPlay]
	[Tooltip("Object for the camera children to look at (the aim target).")]
	[VcamTargetProperty]
	public Transform m_LookAt; //Field offset: 0x68
	[NoSaveDuringPlay]
	[Tooltip("Object for the camera children wants to move with (the body target).")]
	[VcamTargetProperty]
	public Transform m_Follow; //Field offset: 0x6C
	[FormerlySerializedAs("m_UseCommonLensSetting")]
	[Tooltip("If enabled, this lens setting will apply to all three child rigs, otherwise the child rig lens settings will be used")]
	public bool m_CommonLens; //Field offset: 0x70
	[FormerlySerializedAs("m_LensAttributes")]
	[Tooltip("Specifies the lens properties of this Virtual Camera.  This generally mirrors the Unity Camera's lens settings, and will be used to drive the Unity camera when the vcam is active")]
	public LensSettings m_Lens; //Field offset: 0x74
	public TransitionParams m_Transitions; //Field offset: 0xA8
	[FormerlySerializedAs("m_BlendHint")]
	[FormerlySerializedAs("m_PositionBlending")]
	[HideInInspector]
	[SerializeField]
	private BlendHint m_LegacyBlendHint; //Field offset: 0xB4
	[AxisStateProperty]
	[Header("Axis Control")]
	[Tooltip("The Vertical axis.  Value is 0..1.  Chooses how to blend the child rigs")]
	public AxisState m_YAxis; //Field offset: 0xB8
	[Tooltip("Controls how automatic recentering of the Y axis is accomplished")]
	public Recentering m_YAxisRecentering; //Field offset: 0x11C
	[AxisStateProperty]
	[Tooltip("The Horizontal axis.  Value is -180...180.  This is passed on to the rigs' OrbitalTransposer component")]
	public AxisState m_XAxis; //Field offset: 0x13C
	[OrbitalTransposerHeadingProperty]
	[Tooltip("The definition of Forward.  Camera will follow behind.")]
	public Heading m_Heading; //Field offset: 0x1A0
	[Tooltip("Controls how automatic recentering of the X axis is accomplished")]
	public Recentering m_RecenterToTargetHeading; //Field offset: 0x1AC
	[Header("Orbits")]
	[Tooltip("The coordinate space to use when interpreting the offset from the target.  This is also used to set the camera's Up vector, which will be maintained when aiming the camera.")]
	public BindingMode m_BindingMode; //Field offset: 0x1CC
	[FormerlySerializedAs("m_SplineTension")]
	[Range(0, 1)]
	[Tooltip("Controls how taut is the line that connects the rigs' orbits, which determines final placement on the Y axis")]
	public float m_SplineCurvature; //Field offset: 0x1D0
	[Tooltip("The radius and height of the three orbiting rigs.")]
	public Orbit[] m_Orbits; //Field offset: 0x1D4
	[FormerlySerializedAs("m_HeadingBias")]
	[HideInInspector]
	[SerializeField]
	private float m_LegacyHeadingBias; //Field offset: 0x1D8
	private bool mUseLegacyRigDefinitions; //Field offset: 0x1DC
	private bool mIsDestroyed; //Field offset: 0x1DD
	private CameraState m_State; //Field offset: 0x1E0
	[HideInInspector]
	[NoSaveDuringPlay]
	[SerializeField]
	private CinemachineVirtualCamera[] m_Rigs; //Field offset: 0x2A0
	private CinemachineOrbitalTransposer[] mOrbitals; //Field offset: 0x2A4
	private CinemachineBlend mBlendA; //Field offset: 0x2A8
	private CinemachineBlend mBlendB; //Field offset: 0x2AC
	private float m_CachedXAxisHeading; //Field offset: 0x2B0
	private float m_LastHeadingUpdateFrame; //Field offset: 0x2B4
	private Orbit[] m_CachedOrbits; //Field offset: 0x2B8
	private float m_CachedTension; //Field offset: 0x2BC
	private Vector4[] m_CachedKnots; //Field offset: 0x2C0
	private Vector4[] m_CachedCtrl1; //Field offset: 0x2C4
	private Vector4[] m_CachedCtrl2; //Field offset: 0x2C8

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

	public virtual bool PreviousStateIsValid
	{
		 get { } //Length: 11
		 set { } //Length: 197
	}

	public static String[] RigNames
	{
		 get { } //Length: 177
	}

	internal bool RigsAreCreated
	{
		internal get { } //Length: 34
	}

	public virtual CameraState State
	{
		 get { } //Length: 30
	}

	public CinemachineFreeLook() { }

	[CompilerGenerated]
	private float <SteepestDescent>g__AngleFunction|47_0(float input, ref <>c__DisplayClass47_0 unnamed_param_1) { }

	[CompilerGenerated]
	private void <SteepestDescent>g__ChooseBestAngle|47_3(float referenceAngle, ref <>c__DisplayClass47_0 unnamed_param_1, ref <>c__DisplayClass47_1 unnamed_param_2) { }

	[CompilerGenerated]
	private float <SteepestDescent>g__InitialGuess|47_2(ref <>c__DisplayClass47_0 unnamed_param_0) { }

	[CompilerGenerated]
	private float <SteepestDescent>g__SlopeOfAngleFunction|47_1(float input, ref <>c__DisplayClass47_0 unnamed_param_1) { }

	private CameraState CalculateNewState(Vector3 worldUp, float deltaTime) { }

	private CinemachineVirtualCamera[] CreateRigs(CinemachineVirtualCamera[] copyFrom) { }

	private void DestroyRigs() { }

	public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	public virtual Transform get_Follow() { }

	public virtual Transform get_LookAt() { }

	public virtual bool get_PreviousStateIsValid() { }

	public static String[] get_RigNames() { }

	internal bool get_RigsAreCreated() { }

	public virtual CameraState get_State() { }

	public Vector3 GetLocalPositionForCameraFromInput(float t) { }

	public CinemachineVirtualCamera GetRig(int i) { }

	private float GetYAxisClosestValue(Vector3 cameraPos, Vector3 up) { }

	private float GetYAxisValue() { }

	public virtual void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	private void InvalidateRigCache() { }

	public virtual bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false) { }

	private List<CinemachineVirtualCamera> LocateExistingRigs(bool forceOrbital) { }

	internal virtual void OnBeforeSerialize() { }

	protected virtual void OnDestroy() { }

	protected virtual void OnEnable() { }

	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	private void OnTransformChildrenChanged() { }

	public virtual void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	protected virtual void OnValidate() { }

	private void PushSettingsToRigs() { }

	internal virtual bool RequiresUserInput() { }

	private void Reset() { }

	public virtual void set_Follow(Transform value) { }

	public virtual void set_LookAt(Transform value) { }

	public virtual void set_PreviousStateIsValid(bool value) { }

	private float SteepestDescent(Vector3 cameraOffset) { }

	private void UpdateCachedSpline() { }

	public void UpdateInputAxisProvider() { }

	private bool UpdateRigCache() { }

	private float UpdateXAxisHeading(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up) { }

}

