namespace XeSys;

public class InputManager : MonoBehaviour
{
	private static InputManager mInstance; //Field offset: 0x0
	private const float LowPassFilterFactor = 0.016666668; //Field offset: 0x0
	private const float LowPassKernelWidthInSeconds = 1; //Field offset: 0x0
	private const float AccelerometerUpdateInterval = 0.016666668; //Field offset: 0x0
	[CompilerGenerated]
	private static float <swipeVelocity>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	private static float <swipeDistance>k__BackingField; //Field offset: 0x8
	private Dictionary<Int32, TouchInfo> mDicTouchInfo; //Field offset: 0x10
	private List<TouchInfo> mTouchArray; //Field offset: 0x14
	private List<TouchInfo> mPrevTouchArray; //Field offset: 0x18
	private bool mPinch; //Field offset: 0x1C
	private float mPinchRatio; //Field offset: 0x20
	private float mPinchDelta; //Field offset: 0x24
	private float mPinchStartLength; //Field offset: 0x28
	private float mPinchCurrentLength; //Field offset: 0x2C
	private Vector3 mLowPassValue; //Field offset: 0x30
	private Vector3 mMousePositionLeft; //Field offset: 0x3C
	public Func<Boolean> m_TouchEnableCheck; //Field offset: 0x48

	public static InputManager Instance
	{
		 get { } //Length: 40
	}

	public bool isPinch
	{
		 get { } //Length: 11
	}

	public static bool isTouchEmpty
	{
		 get { } //Length: 94
	}

	public float PinchDelta
	{
		 get { } //Length: 11
	}

	public float PinchRatio
	{
		 get { } //Length: 11
	}

	public static float swipeDistance
	{
		[CompilerGenerated]
		 get { } //Length: 41
		[CompilerGenerated]
		 set { } //Length: 52
	}

	public static float swipeVelocity
	{
		[CompilerGenerated]
		 get { } //Length: 41
		[CompilerGenerated]
		 set { } //Length: 52
	}

	public static int touchCount
	{
		 get { } //Length: 151
	}

	public int TouchCount
	{
		 get { } //Length: 52
	}

	public InputManager() { }

	private void AddTouchInfo(TouchInfo newInfo) { }

	private void Awake() { }

	public static GameObject Create(InputManager prefab) { }

	public void Debug() { }

	public bool ExistOnlyTouchID(int targetId = 0) { }

	public TouchInfo FindPrevTouchInfo(int fingerId) { }

	public static TouchInfo FindTouch(int touchId) { }

	public TouchInfo FindTouchInfo(int touchId) { }

	public static InputManager get_Instance() { }

	public bool get_isPinch() { }

	public static bool get_isTouchEmpty() { }

	public float get_PinchDelta() { }

	public float get_PinchRatio() { }

	[CompilerGenerated]
	public static float get_swipeDistance() { }

	[CompilerGenerated]
	public static float get_swipeVelocity() { }

	public static int get_touchCount() { }

	public int get_TouchCount() { }

	public Vector3 GetLowPassAcceleration() { }

	public Vector3 GetMoveDelta(int index) { }

	public static TouchInfo GetTouch(int touchIndex = 0) { }

	public TouchInfo GetTouchInfo(int index) { }

	public Vector3 GetTrueAcceleration() { }

	private void MobileAction() { }

	private void MobilePinchAction() { }

	private void MouseAction() { }

	private void MousePinchAction() { }

	public TouchInfo SearchTouchInfo(int fingerId) { }

	[CompilerGenerated]
	public static void set_swipeDistance(float value) { }

	[CompilerGenerated]
	public static void set_swipeVelocity(float value) { }

	private void Start() { }

	private void Update() { }

	private void UpdateAcceleration() { }

}

