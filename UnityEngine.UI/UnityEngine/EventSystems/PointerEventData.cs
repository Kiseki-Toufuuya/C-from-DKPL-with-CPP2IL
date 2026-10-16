namespace UnityEngine.EventSystems;

public class PointerEventData : BaseEventData
{
	internal enum FramePressState
	{
		Pressed = 0,
		Released = 1,
		PressedAndReleased = 2,
		NotChanged = 3,
	}

	internal enum InputButton
	{
		Left = 0,
		Right = 1,
		Middle = 2,
	}

	[CompilerGenerated]
	private GameObject <pointerEnter>k__BackingField; //Field offset: 0x10
	private GameObject m_PointerPress; //Field offset: 0x14
	[CompilerGenerated]
	private GameObject <lastPress>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private GameObject <rawPointerPress>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private GameObject <pointerDrag>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private GameObject <pointerClick>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private RaycastResult <pointerCurrentRaycast>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private RaycastResult <pointerPressRaycast>k__BackingField; //Field offset: 0x70
	public List<GameObject> hovered; //Field offset: 0xB8
	[CompilerGenerated]
	private bool <eligibleForClick>k__BackingField; //Field offset: 0xBC
	[CompilerGenerated]
	private int <displayIndex>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private int <pointerId>k__BackingField; //Field offset: 0xC4
	[CompilerGenerated]
	private Vector2 <position>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	private Vector2 <delta>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	private Vector2 <pressPosition>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	private Vector3 <worldPosition>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private Vector3 <worldNormal>k__BackingField; //Field offset: 0xEC
	[CompilerGenerated]
	private float <clickTime>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	private int <clickCount>k__BackingField; //Field offset: 0xFC
	[CompilerGenerated]
	private Vector2 <scrollDelta>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	private bool <useDragThreshold>k__BackingField; //Field offset: 0x108
	[CompilerGenerated]
	private bool <dragging>k__BackingField; //Field offset: 0x109
	[CompilerGenerated]
	private InputButton <button>k__BackingField; //Field offset: 0x10C
	[CompilerGenerated]
	private float <pressure>k__BackingField; //Field offset: 0x110
	[CompilerGenerated]
	private float <tangentialPressure>k__BackingField; //Field offset: 0x114
	[CompilerGenerated]
	private float <altitudeAngle>k__BackingField; //Field offset: 0x118
	[CompilerGenerated]
	private float <azimuthAngle>k__BackingField; //Field offset: 0x11C
	[CompilerGenerated]
	private float <twist>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	private Vector2 <tilt>k__BackingField; //Field offset: 0x124
	[CompilerGenerated]
	private PenStatus <penStatus>k__BackingField; //Field offset: 0x12C
	[CompilerGenerated]
	private Vector2 <radius>k__BackingField; //Field offset: 0x130
	[CompilerGenerated]
	private Vector2 <radiusVariance>k__BackingField; //Field offset: 0x138
	[CompilerGenerated]
	private bool <fullyExited>k__BackingField; //Field offset: 0x140
	[CompilerGenerated]
	private bool <reentered>k__BackingField; //Field offset: 0x141

	public float altitudeAngle
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 21
	}

	public float azimuthAngle
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 21
	}

	public InputButton button
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public int clickCount
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public float clickTime
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 21
	}

	public Vector2 delta
	{
		[CompilerGenerated]
		 get { } //Length: 45
		[CompilerGenerated]
		 set { } //Length: 26
	}

	public int displayIndex
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public bool dragging
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public bool eligibleForClick
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public Camera enterEventCamera
	{
		 get { } //Length: 208
	}

	public bool fullyExited
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public private GameObject lastPress
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public PenStatus penStatus
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public GameObject pointerClick
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public RaycastResult pointerCurrentRaycast
	{
		[CompilerGenerated]
		 get { } //Length: 52
		[CompilerGenerated]
		 set { } //Length: 64
	}

	public GameObject pointerDrag
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public GameObject pointerEnter
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public int pointerId
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public GameObject pointerPress
	{
		 get { } //Length: 11
		 set { } //Length: 117
	}

	public RaycastResult pointerPressRaycast
	{
		[CompilerGenerated]
		 get { } //Length: 64
		[CompilerGenerated]
		 set { } //Length: 265
	}

	public Vector2 position
	{
		[CompilerGenerated]
		 get { } //Length: 45
		[CompilerGenerated]
		 set { } //Length: 26
	}

	public Camera pressEventCamera
	{
		 get { } //Length: 232
	}

	public Vector2 pressPosition
	{
		[CompilerGenerated]
		 get { } //Length: 45
		[CompilerGenerated]
		 set { } //Length: 26
	}

	public float pressure
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 21
	}

	public Vector2 radius
	{
		[CompilerGenerated]
		 get { } //Length: 45
		[CompilerGenerated]
		 set { } //Length: 26
	}

	public Vector2 radiusVariance
	{
		[CompilerGenerated]
		 get { } //Length: 45
		[CompilerGenerated]
		 set { } //Length: 26
	}

	public GameObject rawPointerPress
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public bool reentered
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public Vector2 scrollDelta
	{
		[CompilerGenerated]
		 get { } //Length: 45
		[CompilerGenerated]
		 set { } //Length: 26
	}

	public float tangentialPressure
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 21
	}

	public Vector2 tilt
	{
		[CompilerGenerated]
		 get { } //Length: 45
		[CompilerGenerated]
		 set { } //Length: 26
	}

	public float twist
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 21
	}

	public bool useDragThreshold
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	[Obsolete("Use either pointerCurrentRaycast.worldNormal or pointerPressRaycast.worldNormal")]
	public Vector3 worldNormal
	{
		[CompilerGenerated]
		 get { } //Length: 32
		[CompilerGenerated]
		 set { } //Length: 30
	}

	[Obsolete("Use either pointerCurrentRaycast.worldPosition or pointerPressRaycast.worldPosition")]
	public Vector3 worldPosition
	{
		[CompilerGenerated]
		 get { } //Length: 32
		[CompilerGenerated]
		 set { } //Length: 30
	}

	public PointerEventData(EventSystem eventSystem) { }

	[CompilerGenerated]
	public float get_altitudeAngle() { }

	[CompilerGenerated]
	public float get_azimuthAngle() { }

	[CompilerGenerated]
	public InputButton get_button() { }

	[CompilerGenerated]
	public int get_clickCount() { }

	[CompilerGenerated]
	public float get_clickTime() { }

	[CompilerGenerated]
	public Vector2 get_delta() { }

	[CompilerGenerated]
	public int get_displayIndex() { }

	[CompilerGenerated]
	public bool get_dragging() { }

	[CompilerGenerated]
	public bool get_eligibleForClick() { }

	public Camera get_enterEventCamera() { }

	[CompilerGenerated]
	public bool get_fullyExited() { }

	[CompilerGenerated]
	public GameObject get_lastPress() { }

	[CompilerGenerated]
	public PenStatus get_penStatus() { }

	[CompilerGenerated]
	public GameObject get_pointerClick() { }

	[CompilerGenerated]
	public RaycastResult get_pointerCurrentRaycast() { }

	[CompilerGenerated]
	public GameObject get_pointerDrag() { }

	[CompilerGenerated]
	public GameObject get_pointerEnter() { }

	[CompilerGenerated]
	public int get_pointerId() { }

	public GameObject get_pointerPress() { }

	[CompilerGenerated]
	public RaycastResult get_pointerPressRaycast() { }

	[CompilerGenerated]
	public Vector2 get_position() { }

	public Camera get_pressEventCamera() { }

	[CompilerGenerated]
	public Vector2 get_pressPosition() { }

	[CompilerGenerated]
	public float get_pressure() { }

	[CompilerGenerated]
	public Vector2 get_radius() { }

	[CompilerGenerated]
	public Vector2 get_radiusVariance() { }

	[CompilerGenerated]
	public GameObject get_rawPointerPress() { }

	[CompilerGenerated]
	public bool get_reentered() { }

	[CompilerGenerated]
	public Vector2 get_scrollDelta() { }

	[CompilerGenerated]
	public float get_tangentialPressure() { }

	[CompilerGenerated]
	public Vector2 get_tilt() { }

	[CompilerGenerated]
	public float get_twist() { }

	[CompilerGenerated]
	public bool get_useDragThreshold() { }

	[CompilerGenerated]
	public Vector3 get_worldNormal() { }

	[CompilerGenerated]
	public Vector3 get_worldPosition() { }

	public bool IsPointerMoving() { }

	public bool IsScrolling() { }

	[CompilerGenerated]
	public void set_altitudeAngle(float value) { }

	[CompilerGenerated]
	public void set_azimuthAngle(float value) { }

	[CompilerGenerated]
	public void set_button(InputButton value) { }

	[CompilerGenerated]
	public void set_clickCount(int value) { }

	[CompilerGenerated]
	public void set_clickTime(float value) { }

	[CompilerGenerated]
	public void set_delta(Vector2 value) { }

	[CompilerGenerated]
	public void set_displayIndex(int value) { }

	[CompilerGenerated]
	public void set_dragging(bool value) { }

	[CompilerGenerated]
	public void set_eligibleForClick(bool value) { }

	[CompilerGenerated]
	public void set_fullyExited(bool value) { }

	[CompilerGenerated]
	private void set_lastPress(GameObject value) { }

	[CompilerGenerated]
	public void set_penStatus(PenStatus value) { }

	[CompilerGenerated]
	public void set_pointerClick(GameObject value) { }

	[CompilerGenerated]
	public void set_pointerCurrentRaycast(RaycastResult value) { }

	[CompilerGenerated]
	public void set_pointerDrag(GameObject value) { }

	[CompilerGenerated]
	public void set_pointerEnter(GameObject value) { }

	[CompilerGenerated]
	public void set_pointerId(int value) { }

	public void set_pointerPress(GameObject value) { }

	[CompilerGenerated]
	public void set_pointerPressRaycast(RaycastResult value) { }

	[CompilerGenerated]
	public void set_position(Vector2 value) { }

	[CompilerGenerated]
	public void set_pressPosition(Vector2 value) { }

	[CompilerGenerated]
	public void set_pressure(float value) { }

	[CompilerGenerated]
	public void set_radius(Vector2 value) { }

	[CompilerGenerated]
	public void set_radiusVariance(Vector2 value) { }

	[CompilerGenerated]
	public void set_rawPointerPress(GameObject value) { }

	[CompilerGenerated]
	public void set_reentered(bool value) { }

	[CompilerGenerated]
	public void set_scrollDelta(Vector2 value) { }

	[CompilerGenerated]
	public void set_tangentialPressure(float value) { }

	[CompilerGenerated]
	public void set_tilt(Vector2 value) { }

	[CompilerGenerated]
	public void set_twist(float value) { }

	[CompilerGenerated]
	public void set_useDragThreshold(bool value) { }

	[CompilerGenerated]
	public void set_worldNormal(Vector3 value) { }

	[CompilerGenerated]
	public void set_worldPosition(Vector3 value) { }

	public virtual string ToString() { }

}

