namespace CriWare;

public class CriAtomServer : CriMonoBehaviour
{
	private static CriAtomServer _instance; //Field offset: 0x0
	private static CriWareProfilerReporter profilerReporterInstance; //Field offset: 0x4
	public static bool KeepPlayingSoundOnPause; //Field offset: 0x8
	public static bool EnableAutoConsumePcmOutput; //Field offset: 0x9
	public static bool EnableBackgroundPlayback_ANDROID; //Field offset: 0xA
	public Action<Boolean> onApplicationPausePreProcess; //Field offset: 0x20
	public Action<Boolean> onApplicationPausePostProcess; //Field offset: 0x24

	public static CriAtomServer instance
	{
		 get { } //Length: 70
	}

	private static CriAtomServer() { }

	public CriAtomServer() { }

	private void Awake() { }

	private void ConsumePcmOutput() { }

	public static void CreateInstance() { }

	public virtual void CriInternalLateUpdate() { }

	public virtual void CriInternalUpdate() { }

	public static void DestroyInstance() { }

	public static CriAtomServer get_instance() { }

	private void OnApplicationPause(bool appPause) { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	private void ProcessApplicationPause(bool appPause) { }

}

