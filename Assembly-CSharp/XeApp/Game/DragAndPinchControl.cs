namespace XeApp.Game;

public class DragAndPinchControl : MonoBehaviour
{
	internal enum eState
	{
		WAIT = 0,
		DRAG = 1,
		PINCH = 2,
	}

	public class FingerTracker
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Predicate<Finger> <>9__10_0; //Field offset: 0x4
			public static Comparison<Finger> <>9__10_1; //Field offset: 0x8

			private static <>c() { }

			public <>c() { }

			internal bool <Update>b__10_0(Finger f) { }

			internal int <Update>b__10_1(Finger lhs, Finger rhs) { }

		}

		private class Finger
		{
			public readonly int Id; //Field offset: 0x8
			[CompilerGenerated]
			private Touch <Touch>k__BackingField; //Field offset: 0xC
			[CompilerGenerated]
			private float <StartTime>k__BackingField; //Field offset: 0x50
			[CompilerGenerated]
			private bool <IsActiveCheck>k__BackingField; //Field offset: 0x54

			public bool IsActiveCheck
			{
				[CompilerGenerated]
				 get { } //Length: 11
				[CompilerGenerated]
				 set { } //Length: 14
			}

			public private float StartTime
			{
				[CompilerGenerated]
				 get { } //Length: 11
				[CompilerGenerated]
				private set { } //Length: 18
			}

			public private Touch Touch
			{
				[CompilerGenerated]
				 get { } //Length: 48
				[CompilerGenerated]
				private set { } //Length: 46
			}

			public Finger(Touch touch) { }

			[CompilerGenerated]
			public bool get_IsActiveCheck() { }

			[CompilerGenerated]
			public float get_StartTime() { }

			[CompilerGenerated]
			public Touch get_Touch() { }

			[CompilerGenerated]
			public void set_IsActiveCheck(bool value) { }

			[CompilerGenerated]
			private void set_StartTime(float value) { }

			[CompilerGenerated]
			private void set_Touch(Touch value) { }

			public void Update(Touch touch) { }

		}

		private List<Finger> m_fingers; //Field offset: 0x8
		[CompilerGenerated]
		private bool <IsFingerChanged>k__BackingField; //Field offset: 0xC

		public int Count
		{
			 get { } //Length: 52
		}

		public private bool IsFingerChanged
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			private set { } //Length: 14
		}

		public FingerTracker() { }

		public int get_Count() { }

		[CompilerGenerated]
		public bool get_IsFingerChanged() { }

		public Vector2 GetPosition(int index) { }

		private ValueTuple<Int32, Int32> GetTouchIds() { }

		public bool IsBegan() { }

		private void RemoveFinger(int fingerId) { }

		public void Reset() { }

		[CompilerGenerated]
		private void set_IsFingerChanged(bool value) { }

		public void Update() { }

		private void UpdateFinger(Touch touch) { }

	}

	internal class Inertia
	{
		public static float DEF_INER_RATIO; //Field offset: 0x0
		public static int DEF_HISTORY_COUNT_MAX; //Field offset: 0x4
		private List<Vector2> m_posHistory; //Field offset: 0x8
		[CompilerGenerated]
		private Vector2 <InerVec>k__BackingField; //Field offset: 0xC

		public private Vector2 InerVec
		{
			[CompilerGenerated]
			 get { } //Length: 39
			[CompilerGenerated]
			private set { } //Length: 20
		}

		private static Inertia() { }

		public Inertia() { }

		public void Clear() { }

		public void CreateVector() { }

		public void Damp() { }

		[CompilerGenerated]
		public Vector2 get_InerVec() { }

		[CompilerGenerated]
		private void set_InerVec(Vector2 value) { }

		public void SetHistory(Vector2 scrollPos) { }

		public void StopVector(bool resetX, bool resetY) { }

	}

	public class TapCountListener
	{
		private enum State
		{
			None = 0,
			SingleTapping = 1,
			Waiting = 2,
			DoubleTapping = 3,
			Invalid = 4,
		}

		private State m_state; //Field offset: 0x8
		private int m_tapCount; //Field offset: 0xC
		private float m_time; //Field offset: 0x10
		private readonly float TAP_LIMIT_TIME; //Field offset: 0x14
		private readonly float WAIT_LIMIT_TIME; //Field offset: 0x18
		[CompilerGenerated]
		private bool <IsSingleTap>k__BackingField; //Field offset: 0x1C
		[CompilerGenerated]
		private bool <IsSingleLongTap>k__BackingField; //Field offset: 0x1D
		[CompilerGenerated]
		private bool <IsDoubleTap>k__BackingField; //Field offset: 0x1E

		public private bool IsDoubleTap
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			private set { } //Length: 14
		}

		public private bool IsSingleLongTap
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			private set { } //Length: 14
		}

		public private bool IsSingleTap
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			private set { } //Length: 14
		}

		public bool IsTouched
		{
			 get { } //Length: 15
		}

		public TapCountListener() { }

		[CompilerGenerated]
		public bool get_IsDoubleTap() { }

		[CompilerGenerated]
		public bool get_IsSingleLongTap() { }

		[CompilerGenerated]
		public bool get_IsSingleTap() { }

		public bool get_IsTouched() { }

		[CompilerGenerated]
		private void set_IsDoubleTap(bool value) { }

		[CompilerGenerated]
		private void set_IsSingleLongTap(bool value) { }

		[CompilerGenerated]
		private void set_IsSingleTap(bool value) { }

		public void SetInvalid() { }

		private void SetState(State state) { }

		public void Update(int tapCount) { }

	}

	public static float DEF_ZOOM_RATIO; //Field offset: 0x0
	private static readonly float DEF_TOUCH_CANCEL_DRAG_RATIO; //Field offset: 0x4
	private eState m_state; //Field offset: 0x10
	private bool m_isInvoking; //Field offset: 0x14
	private bool m_inputEnable; //Field offset: 0x15
	private bool m_isInputMasked; //Field offset: 0x16
	private float m_pinchSimDistance; //Field offset: 0x18
	public bool m_debugInfoEnable; //Field offset: 0x1C
	private bool m_enableGuiMask; //Field offset: 0x1D
	private List<RaycastResult> m_raycastResults; //Field offset: 0x20
	private PointerEventData m_pointerEvent; //Field offset: 0x24
	private bool m_enableCustomMask; //Field offset: 0x28
	private Func<List`1<RaycastResult>, Boolean> m_customMaskCheck; //Field offset: 0x2C
	private bool m_isUseCanvasScale; //Field offset: 0x30
	private float m_canvasScaling; //Field offset: 0x34
	private Vector2 m_scrollPrevPos; //Field offset: 0x38
	private Vector2 m_scrollPos; //Field offset: 0x40
	private Vector2 m_scrollPosCenter; //Field offset: 0x48
	private Vector2 m_scrollPosMin; //Field offset: 0x50
	private Vector2 m_scrollPosMax; //Field offset: 0x58
	private bool m_isEnableCenter; //Field offset: 0x60
	private Vector3 m_zoomPosition; //Field offset: 0x64
	private float m_zoomRatio; //Field offset: 0x70
	private float m_zoomRatioMin; //Field offset: 0x74
	private float m_zoomRatioMax; //Field offset: 0x78
	private float m_zoomRatioLimit; //Field offset: 0x7C
	private bool m_isAutoZoomOut; //Field offset: 0x80
	private float m_zoomFrom; //Field offset: 0x84
	private float m_zoomTo; //Field offset: 0x88
	private float m_zoomTime; //Field offset: 0x8C
	private float m_zoomTimePassed; //Field offset: 0x90
	private bool m_isEnablePullBackFromEdge; //Field offset: 0x94
	private Vector2 m_pullBackRangeLT; //Field offset: 0x98
	private Vector2 m_pullBackRangeRB; //Field offset: 0xA0
	[CompilerGenerated]
	private float <ReturnForcePos>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private float <ReturnForceZoom>k__BackingField; //Field offset: 0xAC
	private Vector2 m_dragPos0; //Field offset: 0xB0
	private Vector2 m_dragStart; //Field offset: 0xB8
	private Vector2 m_dragLength; //Field offset: 0xC0
	private float m_pinchLength0; //Field offset: 0xC8
	private bool m_isEnableIner; //Field offset: 0xCC
	private Inertia m_inertia; //Field offset: 0xD0
	private Camera m_camera; //Field offset: 0xD4
	private TapCountListener m_tapListener; //Field offset: 0xD8
	private FingerTracker m_fingerTracker; //Field offset: 0xDC
	[CompilerGenerated]
	private Action OnZoomChangedEvent; //Field offset: 0xE0

	public event Action OnZoomChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 118
		[CompilerGenerated]
		 remove { } //Length: 118
	}

	public bool AutoZoomOut
	{
		 set { } //Length: 17
	}

	public Camera Camera
	{
		 get { } //Length: 14
		 set { } //Length: 33
	}

	public bool CustomMask
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public Func<List`1<RaycastResult>, Boolean> CustomMaskCheck
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public Vector2 DragLength
	{
		 get { } //Length: 45
	}

	public bool EnableIner
	{
		 set { } //Length: 17
	}

	public bool GuiMask
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public bool InputEnable
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public bool IsDoubleTap
	{
		 get { } //Length: 26
	}

	public bool IsEnablePullBackFromEdge
	{
		 set { } //Length: 15
	}

	public bool IsFingerTouched
	{
		 get { } //Length: 37
	}

	public bool IsSingleLongTap
	{
		 get { } //Length: 26
	}

	public bool IsSingleTap
	{
		 get { } //Length: 26
	}

	public bool IsTouched
	{
		 get { } //Length: 30
	}

	public bool IsUseCanvasScale
	{
		 set { } //Length: 91
	}

	public float ReturnForcePos
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 21
	}

	public float ReturnForceZoom
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 21
	}

	public Vector2 ScrollPos
	{
		 get { } //Length: 39
	}

	public Vector2 ScrollPosMax
	{
		 get { } //Length: 39
	}

	public Vector2 ScrollPosMin
	{
		 get { } //Length: 39
	}

	public eState State
	{
		 get { } //Length: 11
	}

	public Vector3 ZoomPosition
	{
		 get { } //Length: 26
	}

	public float ZoomRatio
	{
		 get { } //Length: 11
	}

	public float ZoomRatioLimit
	{
		 get { } //Length: 11
	}

	public float ZoomRatioMax
	{
		 get { } //Length: 11
	}

	public float ZoomRatioMin
	{
		 get { } //Length: 11
	}

	private static DragAndPinchControl() { }

	public DragAndPinchControl() { }

	[CompilerGenerated]
	public void add_OnZoomChangedEvent(Action value) { }

	private void AutoReturnFromEdge() { }

	private void AutoReturnZoom() { }

	private void Awake() { }

	private float CalcCanvasScaling() { }

	private void CheckInputMask() { }

	public void ClampScroll() { }

	public void ClampZoom() { }

	public Vector2 ConvertPosReal(Vector2 srcVec) { }

	private bool ExistsAnyInput() { }

	public Camera get_Camera() { }

	public bool get_CustomMask() { }

	public Func<List`1<RaycastResult>, Boolean> get_CustomMaskCheck() { }

	public Vector2 get_DragLength() { }

	public bool get_GuiMask() { }

	public bool get_InputEnable() { }

	public bool get_IsDoubleTap() { }

	public bool get_IsFingerTouched() { }

	public bool get_IsSingleLongTap() { }

	public bool get_IsSingleTap() { }

	public bool get_IsTouched() { }

	[CompilerGenerated]
	public float get_ReturnForcePos() { }

	[CompilerGenerated]
	public float get_ReturnForceZoom() { }

	public Vector2 get_ScrollPos() { }

	public Vector2 get_ScrollPosMax() { }

	public Vector2 get_ScrollPosMin() { }

	public eState get_State() { }

	public Vector3 get_ZoomPosition() { }

	public float get_ZoomRatio() { }

	public float get_ZoomRatioLimit() { }

	public float get_ZoomRatioMax() { }

	public float get_ZoomRatioMin() { }

	private Nullable<Vector2> GetFirstInputPosition() { }

	private ValueTuple<Int32, Vector2, Vector2> GetMousePositions() { }

	private eState GetNewState(int touchCount) { }

	private ValueTuple<Vector2, Vector2, Vector2, Vector2> GetPullBackPositions() { }

	private ValueTuple<Vector2, Vector2> GetRealMinMaxPos() { }

	private ValueTuple<Int32, Vector2, Vector2> GetTouchPoint() { }

	private Vector2 LocalPosFromScreenPos(Vector2 screenPos) { }

	private void OnEnable() { }

	private Vector2 PullBackFromEdge() { }

	private void PullBackZoom() { }

	[CompilerGenerated]
	public void remove_OnZoomChangedEvent(Action value) { }

	public Vector2 ScrollPosReal() { }

	public void set_AutoZoomOut(bool value) { }

	public void set_Camera(Camera value) { }

	public void set_CustomMask(bool value) { }

	public void set_CustomMaskCheck(Func<List`1<RaycastResult>, Boolean> value) { }

	public void set_EnableIner(bool value) { }

	public void set_GuiMask(bool value) { }

	public void set_InputEnable(bool value) { }

	public void set_IsEnablePullBackFromEdge(bool value) { }

	public void set_IsUseCanvasScale(bool value) { }

	[CompilerGenerated]
	public void set_ReturnForcePos(float value) { }

	[CompilerGenerated]
	public void set_ReturnForceZoom(float value) { }

	private void SetDrag(Vector2 screenPos) { }

	private void SetPinch(Vector2 screenPos1, Vector2 screenPos2, bool fromWait) { }

	public void SetPullBackRange(float left, float top, float right, float bottom) { }

	public void SetScrollCenter(Vector2 center) { }

	public void SetScrollPos(Vector2 pos) { }

	public void SetScrollRange(Vector2 minPos, Vector2 maxPos) { }

	private void SetWait() { }

	public void SetZoomLimit(float limitRatio) { }

	public void SetZoomRange(float minRatio, float maxRatio) { }

	public void SetZoomRatio(float zoom) { }

	public void SetZoomTo(float target, float time) { }

	private void StopInerAtEdge() { }

	private void Update() { }

	private void UpdateDrag(Vector2 screenPos) { }

	private void UpdateInput(int numTouch, Vector2 screenPos1, Vector2 screenPos2) { }

	private void UpdateMouseZoomSimuration() { }

	private void UpdatePinch(Vector2 screenPos1, Vector2 screenPos2) { }

	private void UpdateRaycastResult(Vector2 position) { }

	private void UpdateWait() { }

}

