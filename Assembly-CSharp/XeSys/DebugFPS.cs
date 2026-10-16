namespace XeSys;

public class DebugFPS : MonoBehaviour
{
	public static bool isDisable; //Field offset: 0x0
	private const float UPDATE_INTERVAL = 0.5; //Field offset: 0x0
	private static bool isPrevDisable; //Field offset: 0x1
	private static DebugFPS mInstance; //Field offset: 0x4
	[CompilerGenerated]
	private static bool <minFpsMillSec>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private static bool <forceReset>k__BackingField; //Field offset: 0x9
	public static int averageSpan; //Field offset: 0xC
	private float mLastInterval; //Field offset: 0x10
	private int mFrames; //Field offset: 0x14
	private float mFps; //Field offset: 0x18
	private Recorder mPlayerLoopRecorder; //Field offset: 0x1C
	private Recorder mWaitForTargetFPSRecorder; //Field offset: 0x20
	[SerializeField]
	private Text m_Label; //Field offset: 0x24
	[SerializeField]
	private RectTransform m_baseRect; //Field offset: 0x28
	[SerializeField]
	private Image m_BaseImage; //Field offset: 0x2C
	[CompilerGenerated]
	private long <stressNanoTime>k__BackingField; //Field offset: 0x30
	private float mMinFps; //Field offset: 0x38
	private float mMaxFps; //Field offset: 0x3C
	private double mTotalFps; //Field offset: 0x40
	private long mTotalFrames; //Field offset: 0x48
	private float mTotalStartTime; //Field offset: 0x50
	private int firstReset; //Field offset: 0x54
	public bool showVerbose; //Field offset: 0x58
	private StringBuilder sb; //Field offset: 0x5C

	public static bool forceReset
	{
		[CompilerGenerated]
		 get { } //Length: 61
		[CompilerGenerated]
		 set { } //Length: 80
	}

	public float fps
	{
		 get { } //Length: 11
	}

	public static DebugFPS Instance
	{
		 get { } //Length: 61
	}

	public static bool minFpsMillSec
	{
		[CompilerGenerated]
		 get { } //Length: 61
		[CompilerGenerated]
		 set { } //Length: 80
	}

	public long stressNanoTime
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	private static DebugFPS() { }

	public DebugFPS() { }

	private void Awake() { }

	private void BuildText(float fps, float t, float avgfps) { }

	public static DebugFPS Create(DebugFPS prefab) { }

	[CompilerGenerated]
	public static bool get_forceReset() { }

	public float get_fps() { }

	public static DebugFPS get_Instance() { }

	[CompilerGenerated]
	public static bool get_minFpsMillSec() { }

	[CompilerGenerated]
	public long get_stressNanoTime() { }

	private void OnDestroy() { }

	[CompilerGenerated]
	public static void set_forceReset(bool value) { }

	[CompilerGenerated]
	public static void set_minFpsMillSec(bool value) { }

	[CompilerGenerated]
	public void set_stressNanoTime(long value) { }

	public void SetActiveBaseImage(bool enabled) { }

	public void SetAnchor(Vector2 v) { }

	public void SetAnchor(float x, float y) { }

	public void SetAnchorLL() { }

	public void SetAnchorLR() { }

	public void SetAnchorUL() { }

	public void SetAnchorUR() { }

	public void SetColor(Color color) { }

	private void SetFontSize(int size) { }

	private void Start() { }

	private void Update() { }

}

