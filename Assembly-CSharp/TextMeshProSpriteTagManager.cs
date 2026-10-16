//Type is in global namespace

public class TextMeshProSpriteTagManager : SingletonBehaviour<TextMeshProSpriteTagManager>
{
	[SerializeField]
	private InputActionAsset inputActionAsset; //Field offset: 0x10
	[CompilerGenerated]
	private InputDevice <LastestDevice>k__BackingField; //Field offset: 0x14
	public Action<InputDevice> onUpdate; //Field offset: 0x18
	[CompilerGenerated]
	private bool <IsUpdateEnable>k__BackingField; //Field offset: 0x1C

	public private bool IsUpdateEnable
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public private InputDevice LastestDevice
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public TextMeshProSpriteTagManager() { }

	public static void AddActionSpriteTags(StringBuilder sb, InputDevice device, InputAction action, uint indexMask = 0) { }

	public void AddActionSpriteTags(StringBuilder sb, InputAction action) { }

	private static void AddSprite(StringBuilder sb, string controlPath) { }

	private void Awake() { }

	public static InputDevice FirsttDevice() { }

	[CompilerGenerated]
	private bool get_IsUpdateEnable() { }

	[CompilerGenerated]
	public InputDevice get_LastestDevice() { }

	private static bool GetDeviceSpriteTags(StringBuilder sb, InputDevice device, string effectivePath) { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnEvent(InputEventPtr eventPtr, InputDevice device) { }

	[CompilerGenerated]
	public void set_IsUpdateEnable(bool value) { }

	[CompilerGenerated]
	private void set_LastestDevice(InputDevice value) { }

}

