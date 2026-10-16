namespace Unity.Services.Analytics;

internal class AnalyticsContainer : MonoBehaviour, IAnalyticsContainer, IContainerDebug
{
	private const float k_AutoFlushPeriod = 60; //Field offset: 0x0
	private const float k_GameRunningPeriod = 60; //Field offset: 0x0
	private static bool s_Created; //Field offset: 0x0
	private static GameObject s_Container; //Field offset: 0x4
	private static AnalyticsContainer m_Instance; //Field offset: 0x8
	private float m_AutoFlushTime; //Field offset: 0x10
	private float m_GameRunningTime; //Field offset: 0x14
	private AnalyticsServiceInstance m_Service; //Field offset: 0x18

	private float AutoFlushPeriod
	{
		private get { } //Length: 121
	}

	internal static IContainerDebug ContainerDebug
	{
		internal get { } //Length: 41
	}

	public override float TimeUntilNextHeartbeat
	{
		 get { } //Length: 30
	}

	public AnalyticsContainer() { }

	private void CleanUp() { }

	internal static AnalyticsContainer CreateContainer() { }

	public override void Disable() { }

	public override void Enable() { }

	private float get_AutoFlushPeriod() { }

	internal static IContainerDebug get_ContainerDebug() { }

	public override float get_TimeUntilNextHeartbeat() { }

	public override void Initialize(AnalyticsServiceInstance service) { }

	private void OnApplicationPause(bool paused) { }

	private void Update() { }

}

