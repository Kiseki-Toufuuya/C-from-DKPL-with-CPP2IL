namespace Heqet;

public class ControlMouseCursor : MonoBehaviour
{
	private const float DefaultAutoHideCursorTimer = 1.5; //Field offset: 0x0
	private static ControlMouseCursor instance; //Field offset: 0x0
	[CompilerGenerated]
	private bool <IsInitialized>k__BackingField; //Field offset: 0x10
	private Vector3 prevMousePos; //Field offset: 0x14
	[CompilerGenerated]
	private bool <IsAutoHideCursor>k__BackingField; //Field offset: 0x20
	private float autoHideCursorSetTime; //Field offset: 0x24
	private float autoHideCursorTimer; //Field offset: 0x28

	public Vector3 CurrentPosition
	{
		 get { } //Length: 26
	}

	public static ControlMouseCursor Instance
	{
		 get { } //Length: 40
	}

	public private bool IsAutoHideCursor
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public private bool IsInitialized
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public ControlMouseCursor() { }

	private void Awake() { }

	private void FixedUpdate() { }

	public Vector3 get_CurrentPosition() { }

	public static ControlMouseCursor get_Instance() { }

	[CompilerGenerated]
	public bool get_IsAutoHideCursor() { }

	[CompilerGenerated]
	public bool get_IsInitialized() { }

	public void Initialize() { }

	[CompilerGenerated]
	private void set_IsAutoHideCursor(bool value) { }

	[CompilerGenerated]
	private void set_IsInitialized(bool value) { }

	public void SetAutoHideCursor(bool enable, float hideTimer = 1.5) { }

	private void ShowCursor(bool enable) { }

}

