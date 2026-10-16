namespace XeApp.Core;

public class VibrationControl : MonoBehaviour
{
	[CompilerGenerated]
	private static VibrationControl <Instance>k__BackingField; //Field offset: 0x0
	private AndroidVibrationSupport vibrationSupport; //Field offset: 0x10
	private FeedbackSupport feedbackSupport; //Field offset: 0x14

	public private static VibrationControl Instance
	{
		[CompilerGenerated]
		 get { } //Length: 40
		[CompilerGenerated]
		private set { } //Length: 64
	}

	public VibrationControl() { }

	private void Awake() { }

	public void Call(int methodID) { }

	public void CallByEvenntID(int eventID) { }

	public void CallDefault() { }

	[CompilerGenerated]
	public static VibrationControl get_Instance() { }

	private void Haptics(int methodID) { }

	private void InitAndroidVibrations() { }

	private void OnDestroy() { }

	[CompilerGenerated]
	private static void set_Instance(VibrationControl value) { }

}

