//Type is in global namespace

public class VibrationTestScene : MonoBehaviour
{
	[CompilerGenerated]
	private static VibrationTestScene <Instance>k__BackingField; //Field offset: 0x0
	private AndroidVibrationSupport androidVibrationSupport; //Field offset: 0x10
	private FeedbackSupport feedbackSupport; //Field offset: 0x14
	public GameObject AndroidPage; //Field offset: 0x18
	public GameObject iOSPage; //Field offset: 0x1C
	public InputField OneshotTime; //Field offset: 0x20
	public InputField OneshotAmp; //Field offset: 0x24
	public InputField Timings; //Field offset: 0x28
	public InputField Amplituds; //Field offset: 0x2C
	public InputField Free; //Field offset: 0x30

	public private static VibrationTestScene Instance
	{
		[CompilerGenerated]
		 get { } //Length: 40
		[CompilerGenerated]
		private set { } //Length: 64
	}

	public VibrationTestScene() { }

	[CompilerGenerated]
	private void <Start>b__13_0(string s) { }

	[CompilerGenerated]
	private void <Start>b__13_1(string s) { }

	[CompilerGenerated]
	private void <Start>b__13_2(string s) { }

	[CompilerGenerated]
	private void <Start>b__13_3(string s) { }

	[CompilerGenerated]
	public static VibrationTestScene get_Instance() { }

	public void OnAndroidRegisterdVibration(int id) { }

	public void OnAndroidRegistOneshot() { }

	public void OnDestroy() { }

	public void OniOSVibration(int id) { }

	public void OniOSVibrationFree() { }

	[CompilerGenerated]
	private static void set_Instance(VibrationTestScene value) { }

	private void Start() { }

	private void Update() { }

}

