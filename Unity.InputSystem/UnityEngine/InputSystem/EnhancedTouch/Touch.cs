namespace UnityEngine.InputSystem.EnhancedTouch;

public struct Touch : IEquatable<Touch>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static TypedRestore<GlobalState> <>9__80_0; //Field offset: 0x4
		public static Action <>9__80_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <SaveAndResetState>b__80_0(ref GlobalState state) { }

		internal void <SaveAndResetState>b__80_1() { }

	}

	public struct ExtraDataPerTouchState
	{
		public Vector2 accumulatedDelta; //Field offset: 0x0
		public uint uniqueId; //Field offset: 0x8

	}

	public struct FingerAndTouchState
	{
		public InputUpdateType updateMask; //Field offset: 0x0
		public Finger[] fingers; //Field offset: 0x4
		public Finger[] activeFingers; //Field offset: 0x8
		public Touch[] activeTouches; //Field offset: 0xC
		public int activeFingerCount; //Field offset: 0x10
		public int activeTouchCount; //Field offset: 0x14
		public int totalFingerCount; //Field offset: 0x18
		public uint lastId; //Field offset: 0x1C
		public bool haveBuiltActiveTouches; //Field offset: 0x20
		public bool haveActiveTouchesNeedingRefreshNextUpdate; //Field offset: 0x21
		public InputStateHistory<TouchState> activeTouchState; //Field offset: 0x24

		public void AddFingers(Touchscreen screen) { }

		public void Destroy() { }

		public void RemoveFingers(Touchscreen screen) { }

		public void UpdateActiveFingers() { }

		public void UpdateActiveTouches() { }

	}

	public struct GlobalState
	{
		internal InlinedArray<Touchscreen> touchscreens; //Field offset: 0x0
		internal int historyLengthPerFinger; //Field offset: 0xC
		internal CallbackArray<Action`1<Finger>> onFingerDown; //Field offset: 0x10
		internal CallbackArray<Action`1<Finger>> onFingerMove; //Field offset: 0x38
		internal CallbackArray<Action`1<Finger>> onFingerUp; //Field offset: 0x60
		internal FingerAndTouchState playerState; //Field offset: 0x88

	}

	internal static GlobalState s_GlobalState; //Field offset: 0x0
	private readonly Finger m_Finger; //Field offset: 0x0
	internal Record<TouchState> m_TouchRecord; //Field offset: 0x4

	public static event Action<Finger> onFingerDown
	{
		 add { } //Length: 163
		 remove { } //Length: 163
	}

	public static event Action<Finger> onFingerMove
	{
		 add { } //Length: 163
		 remove { } //Length: 163
	}

	public static event Action<Finger> onFingerUp
	{
		 add { } //Length: 163
		 remove { } //Length: 163
	}

	public static ReadOnlyArray<Finger> activeFingers
	{
		 get { } //Length: 146
	}

	public static ReadOnlyArray<Touch> activeTouches
	{
		 get { } //Length: 146
	}

	public bool began
	{
		 get { } //Length: 73
	}

	public Vector2 delta
	{
		 get { } //Length: 135
	}

	public int displayIndex
	{
		 get { } //Length: 108
	}

	public bool ended
	{
		 get { } //Length: 115
	}

	private ExtraDataPerTouchState extraData
	{
		private get { } //Length: 55
	}

	public Finger finger
	{
		 get { } //Length: 10
	}

	public static ReadOnlyArray<Finger> fingers
	{
		 get { } //Length: 126
	}

	public TouchHistory history
	{
		 get { } //Length: 252
	}

	public bool inProgress
	{
		 get { } //Length: 153
	}

	public bool isInProgress
	{
		 get { } //Length: 85
	}

	public bool isTap
	{
		 get { } //Length: 111
	}

	public static int maxHistoryLengthPerFinger
	{
		 get { } //Length: 61
	}

	public TouchPhase phase
	{
		 get { } //Length: 108
	}

	public float pressure
	{
		 get { } //Length: 107
	}

	public Vector2 radius
	{
		 get { } //Length: 135
	}

	public Touchscreen screen
	{
		 get { } //Length: 71
	}

	public Vector2 screenPosition
	{
		 get { } //Length: 135
	}

	public static IEnumerable<Touchscreen> screens
	{
		 get { } //Length: 110
	}

	public Vector2 startScreenPosition
	{
		 get { } //Length: 135
	}

	public double startTime
	{
		 get { } //Length: 107
	}

	private TouchState state
	{
		private get { } //Length: 55
	}

	public int tapCount
	{
		 get { } //Length: 108
	}

	public double time
	{
		 get { } //Length: 55
	}

	public int touchId
	{
		 get { } //Length: 106
	}

	internal uint uniqueId
	{
		internal get { } //Length: 107
	}

	internal uint updateStepCount
	{
		internal get { } //Length: 107
	}

	public bool valid
	{
		 get { } //Length: 55
	}

	private static Touch() { }

	internal Touch(Finger finger, Record<TouchState> touchRecord) { }

	public static void add_onFingerDown(Action<Finger> value) { }

	public static void add_onFingerMove(Action<Finger> value) { }

	public static void add_onFingerUp(Action<Finger> value) { }

	internal static void AddTouchscreen(Touchscreen screen) { }

	internal static void BeginUpdate() { }

	private static GlobalState CreateGlobalState() { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(Touch other) { }

	public static ReadOnlyArray<Finger> get_activeFingers() { }

	public static ReadOnlyArray<Touch> get_activeTouches() { }

	public bool get_began() { }

	public Vector2 get_delta() { }

	public int get_displayIndex() { }

	public bool get_ended() { }

	private ExtraDataPerTouchState get_extraData() { }

	public Finger get_finger() { }

	public static ReadOnlyArray<Finger> get_fingers() { }

	public TouchHistory get_history() { }

	public bool get_inProgress() { }

	public bool get_isInProgress() { }

	public bool get_isTap() { }

	public static int get_maxHistoryLengthPerFinger() { }

	public TouchPhase get_phase() { }

	public float get_pressure() { }

	public Vector2 get_radius() { }

	public Touchscreen get_screen() { }

	public Vector2 get_screenPosition() { }

	public static IEnumerable<Touchscreen> get_screens() { }

	public Vector2 get_startScreenPosition() { }

	public double get_startTime() { }

	private TouchState get_state() { }

	public int get_tapCount() { }

	public double get_time() { }

	public int get_touchId() { }

	internal uint get_uniqueId() { }

	internal uint get_updateStepCount() { }

	public bool get_valid() { }

	public virtual int GetHashCode() { }

	public static void remove_onFingerDown(Action<Finger> value) { }

	public static void remove_onFingerMove(Action<Finger> value) { }

	public static void remove_onFingerUp(Action<Finger> value) { }

	internal static void RemoveTouchscreen(Touchscreen screen) { }

	internal static ISavedState SaveAndResetState() { }

	public virtual string ToString() { }

}

