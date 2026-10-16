//Type is in global namespace

public class FeedbackSupport : IDisposable
{
	internal enum FeedbackDeviceType
	{
		iOSLegacy = 0,
		iOSHaptics = 1,
		AndroidNative = 2,
	}

	internal enum FeedbackType
	{
		None = 0,
		Selection = 1,
		Notfication = 2,
		Impact = 3,
	}

	internal enum ImpactType
	{
		Soft = 0,
		Light = 1,
		Middium = 2,
		Heavy = 3,
		Rigid = 4,
	}

	internal enum NotificationType
	{
		Success = 0,
		Error = 1,
		Warning = 2,
	}

	public const int IOS_VIBRATION_SOFT_1 = 1519; //Field offset: 0x0
	public const int IOS_VIBRATION_SOFT_2 = 1520; //Field offset: 0x0
	private static int hapticsState; //Field offset: 0x0
	private bool _disposed; //Field offset: 0x8
	private IntPtr m_ptr; //Field offset: 0xC
	private FeedbackType m_feedbackType; //Field offset: 0x10
	private ImpactType m_impactType; //Field offset: 0x14

	public FeedbackSupport() { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	public void EventOccured(NotificationType notificationType = 0) { }

	public void Generate(FeedbackType type, ImpactType impactType = 0) { }

	public static FeedbackDeviceType GetDeviceFeedbackDeviceType() { }

	public static void HapticsPlayOneshot(float intensity, float sharpness) { }

	public static void HapticsStart(float intensity, float sharpness) { }

	public static bool IsSupportHaptics() { }

	public void VibrateForAndroid(int millsec, int power) { }

	public static void VibrateForiOS(int n) { }

}

