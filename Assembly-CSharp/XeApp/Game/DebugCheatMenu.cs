namespace XeApp.Game;

public class DebugCheatMenu : SingletonBehaviour<DebugCheatMenu>
{
	private DebugCheatMenuTrigger MenuTirgger; //Field offset: 0x10
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; //Field offset: 0x14
	private Transform RootObjTransform; //Field offset: 0x18
	private Canvas RootCanvas; //Field offset: 0x1C
	private Transform Header; //Field offset: 0x20
	private Transform Footer; //Field offset: 0x24
	private Transform Menu; //Field offset: 0x28
	[SerializeField]
	private VirtualMouseInput virtualMouseInput; //Field offset: 0x2C

	public private bool IsOpen
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public DebugCheatMenu() { }

	private void Awake() { }

	private void DispOff() { }

	private void DispOn() { }

	[CompilerGenerated]
	public bool get_IsOpen() { }

	[CompilerGenerated]
	private void set_IsOpen(bool value) { }

	private void Update() { }

}

