namespace XeSys;

public class TouchInfo
{
	private Vector3 mAppPosition; //Field offset: 0x8
	[CompilerGenerated]
	private int <id>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private Vector3 <position>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Vector3 <prevPosition>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private Vector3 <delta>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private Vector3 <nativePosition>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	private Vector3 <nativePrevPosition>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private TouchState <state>k__BackingField; //Field offset: 0x54
	[CompilerGenerated]
	private float <startTime>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private Vector3 <startPosition>k__BackingField; //Field offset: 0x5C
	[CompilerGenerated]
	private float <touchedTime>k__BackingField; //Field offset: 0x68

	public Vector3 appPosition
	{
		 get { } //Length: 26
	}

	public private Vector3 delta
	{
		[CompilerGenerated]
		 get { } //Length: 26
		[CompilerGenerated]
		private set { } //Length: 24
	}

	public private int id
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public bool isBegan
	{
		 get { } //Length: 15
	}

	public bool isEnded
	{
		 get { } //Length: 15
	}

	public bool isMoved
	{
		 get { } //Length: 15
	}

	public private Vector3 nativePosition
	{
		[CompilerGenerated]
		 get { } //Length: 26
		[CompilerGenerated]
		private set { } //Length: 24
	}

	public private Vector3 nativePrevPosition
	{
		[CompilerGenerated]
		 get { } //Length: 26
		[CompilerGenerated]
		private set { } //Length: 24
	}

	public private Vector3 position
	{
		[CompilerGenerated]
		 get { } //Length: 26
		[CompilerGenerated]
		private set { } //Length: 24
	}

	public private Vector3 prevPosition
	{
		[CompilerGenerated]
		 get { } //Length: 26
		[CompilerGenerated]
		private set { } //Length: 24
	}

	public private Vector3 startPosition
	{
		[CompilerGenerated]
		 get { } //Length: 26
		[CompilerGenerated]
		private set { } //Length: 24
	}

	public private float startTime
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 18
	}

	public TouchState state
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public private float touchedTime
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 18
	}

	public float x
	{
		 get { } //Length: 26
	}

	public float y
	{
		 get { } //Length: 26
	}

	internal TouchInfo(TouchInfo info) { }

	private TouchInfo() { }

	internal static TouchInfo CreateBegan(int _id, Vector3 _newPosi) { }

	internal static TouchInfo CreateEnded(int _id, TouchInfo prevInfo) { }

	internal static TouchInfo CreateMoved(int _id, Vector3 _newPosi, TouchInfo prevInfo) { }

	public Vector3 get_appPosition() { }

	[CompilerGenerated]
	public Vector3 get_delta() { }

	[CompilerGenerated]
	public int get_id() { }

	public bool get_isBegan() { }

	public bool get_isEnded() { }

	public bool get_isMoved() { }

	[CompilerGenerated]
	public Vector3 get_nativePosition() { }

	[CompilerGenerated]
	public Vector3 get_nativePrevPosition() { }

	[CompilerGenerated]
	public Vector3 get_position() { }

	[CompilerGenerated]
	public Vector3 get_prevPosition() { }

	[CompilerGenerated]
	public Vector3 get_startPosition() { }

	[CompilerGenerated]
	public float get_startTime() { }

	[CompilerGenerated]
	public TouchState get_state() { }

	[CompilerGenerated]
	public float get_touchedTime() { }

	public float get_x() { }

	public float get_y() { }

	public TouchSwipeDirection GetSwipeDirection() { }

	[CompilerGenerated]
	private void set_delta(Vector3 value) { }

	[CompilerGenerated]
	private void set_id(int value) { }

	[CompilerGenerated]
	private void set_nativePosition(Vector3 value) { }

	[CompilerGenerated]
	private void set_nativePrevPosition(Vector3 value) { }

	[CompilerGenerated]
	private void set_position(Vector3 value) { }

	[CompilerGenerated]
	private void set_prevPosition(Vector3 value) { }

	[CompilerGenerated]
	private void set_startPosition(Vector3 value) { }

	[CompilerGenerated]
	private void set_startTime(float value) { }

	[CompilerGenerated]
	public void set_state(TouchState value) { }

	[CompilerGenerated]
	private void set_touchedTime(float value) { }

}

