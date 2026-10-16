//Type is in global namespace

[DisallowMultipleComponent]
public class SteamManager : MonoBehaviour
{
	public const uint SteamAppId = 2190220; //Field offset: 0x0
	protected static bool s_EverInitialized; //Field offset: 0x0
	protected static SteamManager s_instance; //Field offset: 0x4
	protected bool m_bInitialized; //Field offset: 0x10
	protected SteamAPIWarningMessageHook_t m_SteamAPIWarningMessageHook; //Field offset: 0x14

	public static bool Initialized
	{
		 get { } //Length: 194
	}

	protected static SteamManager Instance
	{
		 get { } //Length: 187
	}

	public SteamManager() { }

	protected override void Awake() { }

	public static bool get_Initialized() { }

	protected static SteamManager get_Instance() { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::SubsystemRegistration (4))]
	private static void InitOnPlayMode() { }

	protected override void OnDestroy() { }

	protected override void OnEnable() { }

	[MonoPInvokeCallback(typeof(SteamAPIWarningMessageHook_t))]
	protected static void SteamAPIDebugTextHook(int nSeverity, StringBuilder pchDebugText) { }

	protected override void Update() { }

}

