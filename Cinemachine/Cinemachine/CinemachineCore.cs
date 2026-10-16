namespace Cinemachine;

public sealed class CinemachineCore
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<CinemachineVirtualCameraBase> <>9__30_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal int <GetVirtualCamera>b__30_0(CinemachineVirtualCameraBase x, CinemachineVirtualCameraBase y) { }

	}

	internal sealed class AxisInputDelegate : MulticastDelegate
	{

		public AxisInputDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string axisName, AsyncCallback callback, object object) { }

		public override float EndInvoke(IAsyncResult result) { }

		public override float Invoke(string axisName) { }

	}

	internal sealed class GetBlendOverrideDelegate : MulticastDelegate
	{

		public GetBlendOverrideDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ICinemachineCamera fromVcam, ICinemachineCamera toVcam, CinemachineBlendDefinition defaultBlend, MonoBehaviour owner, AsyncCallback callback, object object) { }

		public override CinemachineBlendDefinition EndInvoke(IAsyncResult result) { }

		public override CinemachineBlendDefinition Invoke(ICinemachineCamera fromVcam, ICinemachineCamera toVcam, CinemachineBlendDefinition defaultBlend, MonoBehaviour owner) { }

	}

	internal enum Stage
	{
		Body = 0,
		Aim = 1,
		Noise = 2,
		Finalize = 3,
	}

	public enum UpdateFilter
	{
		Fixed = 0,
		Late = 1,
		Smart = 8,
		SmartFixed = 8,
		SmartLate = 9,
	}

	private class UpdateStatus
	{
		public int lastUpdateFrame; //Field offset: 0x8
		public int lastUpdateFixedFrame; //Field offset: 0xC
		public UpdateClock lastUpdateMode; //Field offset: 0x10
		public float lastUpdateDeltaTime; //Field offset: 0x14

		public UpdateStatus() { }

	}

	public static readonly int kStreamingVersion; //Field offset: 0x0
	private static CinemachineCore sInstance; //Field offset: 0x4
	public static bool sShowHiddenObjects; //Field offset: 0x8
	public static AxisInputDelegate GetInputAxis; //Field offset: 0xC
	public static float UniformDeltaTimeOverride; //Field offset: 0x10
	public static float CurrentTimeOverride; //Field offset: 0x14
	public static GetBlendOverrideDelegate GetBlendOverride; //Field offset: 0x18
	public static BrainEvent CameraUpdatedEvent; //Field offset: 0x1C
	public static BrainEvent CameraCutEvent; //Field offset: 0x20
	internal static bool FrameDeltaCompensationEnabled; //Field offset: 0x24
	private static float s_LastUpdateTime; //Field offset: 0x28
	private static int s_FixedFrameCount; //Field offset: 0x2C
	private List<CinemachineBrain> mActiveBrains; //Field offset: 0x8
	private List<CinemachineVirtualCameraBase> mActiveCameras; //Field offset: 0xC
	private bool m_ActiveCamerasAreSorted; //Field offset: 0x10
	private int m_ActivationSequence; //Field offset: 0x14
	private List<List`1<CinemachineVirtualCameraBase>> mAllCameras; //Field offset: 0x18
	private CinemachineVirtualCameraBase mRoundRobinVcamLastFrame; //Field offset: 0x1C
	private Dictionary<CinemachineVirtualCameraBase, UpdateStatus> mUpdateStatus; //Field offset: 0x20
	internal UpdateFilter m_CurrentUpdateFilter; //Field offset: 0x24

	public int BrainCount
	{
		 get { } //Length: 52
	}

	public static float CurrentTime
	{
		 get { } //Length: 112
	}

	public static float DeltaTime
	{
		 get { } //Length: 112
	}

	public static CinemachineCore Instance
	{
		 get { } //Length: 380
	}

	public int VirtualCameraCount
	{
		 get { } //Length: 52
	}

	private static CinemachineCore() { }

	public CinemachineCore() { }

	internal void AddActiveBrain(CinemachineBrain brain) { }

	internal void AddActiveCamera(CinemachineVirtualCameraBase vcam) { }

	internal void CameraDestroyed(CinemachineVirtualCameraBase vcam) { }

	internal void CameraDisabled(CinemachineVirtualCameraBase vcam) { }

	internal void CameraEnabled(CinemachineVirtualCameraBase vcam) { }

	public CinemachineBrain FindPotentialTargetBrain(CinemachineVirtualCameraBase vcam) { }

	public void GenerateCameraActivationEvent(ICinemachineCamera vcam, ICinemachineCamera vcamFrom) { }

	public void GenerateCameraCutEvent(ICinemachineCamera vcam) { }

	public int get_BrainCount() { }

	public static float get_CurrentTime() { }

	public static float get_DeltaTime() { }

	public static CinemachineCore get_Instance() { }

	public int get_VirtualCameraCount() { }

	public CinemachineBrain GetActiveBrain(int index) { }

	private static Transform GetUpdateTarget(CinemachineVirtualCameraBase vcam) { }

	internal UpdateClock GetVcamUpdateStatus(CinemachineVirtualCameraBase vcam) { }

	public CinemachineVirtualCameraBase GetVirtualCamera(int index) { }

	[RuntimeInitializeOnLoadMethod]
	private static void InitializeModule() { }

	public bool IsLive(ICinemachineCamera vcam) { }

	public bool IsLiveInBlend(ICinemachineCamera vcam) { }

	public void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	internal void RemoveActiveBrain(CinemachineBrain brain) { }

	internal void RemoveActiveCamera(CinemachineVirtualCameraBase vcam) { }

	internal void UpdateAllActiveVirtualCameras(int layerMask, Vector3 worldUp, float deltaTime) { }

	internal void UpdateVirtualCamera(CinemachineVirtualCameraBase vcam, Vector3 worldUp, float deltaTime) { }

}

