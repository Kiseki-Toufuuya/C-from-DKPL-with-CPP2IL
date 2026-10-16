namespace UnityEngine.Localization;

internal class LocalizationBehaviour : ComponentSingleton<LocalizationBehaviour>
{
	private const long k_MaxMsPerUpdate = 10; //Field offset: 0x0
	private const bool k_DisableThrottling = False; //Field offset: 0x0
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"frame", "handle"})]
	private Queue<ValueTuple`2<Int32, AsyncOperationHandle>> m_ReleaseQueue; //Field offset: 0x10

	public LocalizationBehaviour() { }

	private void DoReleaseNextFrame(AsyncOperationHandle handle) { }

	public static void ForceRelease() { }

	protected virtual string GetGameObjectName() { }

	private void LateUpdate() { }

	public static void ReleaseNextFrame(AsyncOperationHandle handle) { }

	private static long TimeSinceStartupMs() { }

}

