namespace CriWare;

public class CriAtomOutputDeviceObserver : CriMonoBehaviour
{
	internal sealed class DeviceConnectionChangeCallback : MulticastDelegate
	{

		public DeviceConnectionChangeCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool isConnected, OutputDeviceType deviceType, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool isConnected, OutputDeviceType deviceType) { }

	}

	internal enum OutputDeviceType
	{
		BuiltinSpeaker = 0,
		WiredDevice = 1,
		WirelessDevice = 2,
	}

	private static class UnsafeNativeMethods
	{

		internal static bool criAtomUnity_IsOutputDeviceConnected_WASAPI() { }

		internal static void criAtomUnity_StartOutputDeviceObserver_WASAPI() { }

		internal static void criAtomUnity_StopOutputDeviceObserver_WASAPI() { }

	}

	private static CriAtomOutputDeviceObserver instance; //Field offset: 0x0
	[CompilerGenerated]
	private static DeviceConnectionChangeCallback _onDeviceConnectionChanged; //Field offset: 0x4
	[SerializeField]
	private bool dontDestroyOnLoad; //Field offset: 0x20
	private bool lastIsConnected; //Field offset: 0x21
	private bool isConnected; //Field offset: 0x22
	private OutputDeviceType lastDeviceType; //Field offset: 0x24
	private OutputDeviceType deviceType; //Field offset: 0x28

	private static event DeviceConnectionChangeCallback _onDeviceConnectionChanged
	{
		[CompilerGenerated]
		private add { } //Length: 139
		[CompilerGenerated]
		private remove { } //Length: 139
	}

	public static event DeviceConnectionChangeCallback OnDeviceConnectionChanged
	{
		 add { } //Length: 265
		 remove { } //Length: 139
	}

	public static OutputDeviceType DeviceType
	{
		 get { } //Length: 87
	}

	public static bool IsDeviceConnected
	{
		 get { } //Length: 185
	}

	public CriAtomOutputDeviceObserver() { }

	[CompilerGenerated]
	private static void add__onDeviceConnectionChanged(DeviceConnectionChangeCallback value) { }

	public static void add_OnDeviceConnectionChanged(DeviceConnectionChangeCallback value) { }

	private void Awake() { }

	public virtual void CriInternalLateUpdate() { }

	public virtual void CriInternalUpdate() { }

	public static OutputDeviceType get_DeviceType() { }

	public static bool get_IsDeviceConnected() { }

	private void OnDestroy() { }

	[CompilerGenerated]
	private static void remove__onDeviceConnectionChanged(DeviceConnectionChangeCallback value) { }

	public static void remove_OnDeviceConnectionChanged(DeviceConnectionChangeCallback value) { }

}

