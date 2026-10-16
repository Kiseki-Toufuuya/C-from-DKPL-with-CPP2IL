namespace XeSys.uGUI;

public class uGUISubmitControl : Singleton<uGUISubmitControl>, IDisposable
{
	private enum Phase
	{
		None = 0,
		Press = 1,
	}

	private TouchInfo dummyBeganInfo; //Field offset: 0x8
	private TouchInfo dummyMoveInfo; //Field offset: 0xC
	private TouchInfo dummyEndedInfo; //Field offset: 0x10
	private EventSystem eventSystem; //Field offset: 0x14
	private InputSystemUIInputModule module; //Field offset: 0x18
	private InputActionReference submit; //Field offset: 0x1C
	private GameObject pressedGameObject; //Field offset: 0x20
	private GameObject systemCurrentSelectGameObject; //Field offset: 0x24
	private INestedSelectable nestedSelectable; //Field offset: 0x28
	private Phase phase; //Field offset: 0x2C

	public uGUISubmitControl() { }

	public override void Dispose() { }

	private GameObject GetCurrentSelectGameObject() { }

	private void TouchUpdate() { }

	public void Update() { }

}

