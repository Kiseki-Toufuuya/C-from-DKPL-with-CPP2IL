namespace Heqet;

public class InputActionManager
{
	internal enum eAction
	{
		Submit = 0,
		Cancel = 1,
		Function1 = 2,
		Function2 = 3,
		Function7 = 4,
		Function9 = 5,
		Function10 = 6,
		TabLeft = 7,
		TabRight = 8,
		AdvSkip = 9,
		AdvAuto = 10,
		AdvLog = 11,
		AdvUiOff = 12,
		AdvCardNext = 13,
		AdvCardPrev = 14,
		Navigate = 15,
		RightStickNavigate = 16,
		KaguraLane1 = 17,
		KaguraLane2 = 18,
		KaguraLane3 = 19,
		KaguraLane4 = 20,
		KaguraLane5 = 21,
		KaguraLane6 = 22,
		DanmakuLane1 = 23,
		DanmakuLane2 = 24,
		DanmakuLane3 = 25,
		DanmakuLane4 = 26,
		PlayerMove = 27,
		Bomb = 28,
		InGameFunction1 = 29,
		InGameFunction2 = 30,
		InGameFunction3 = 31,
		Point = 32,
		Click = 33,
		OpenCheatMenu = 34,
		DebugSkip = 35,
	}

	[CompilerGenerated]
	private static InputActionManager <Instance>k__BackingField; //Field offset: 0x0
	private String[2] m_action_name_list; //Field offset: 0x8
	private InputActionAsset _inputActionAsset; //Field offset: 0xC

	public static InputActionManager Instance
	{
		[CompilerGenerated]
		 get { } //Length: 40
		[CompilerGenerated]
		 set { } //Length: 64
	}

	public InputActionManager() { }

	public void Create(InputActionAsset inputActionAsset) { }

	public void Disalbe() { }

	public void Enable() { }

	public string ExportJson() { }

	[CompilerGenerated]
	public static InputActionManager get_Instance() { }

	private InputAction GetAction(string map_name, string action_name) { }

	public InputActionReference GetActionReference(eAction actionType) { }

	public void LoadJson(string json) { }

	public static void OverrideUISubmitButtons() { }

	[CompilerGenerated]
	public static void set_Instance(InputActionManager value) { }

	public string ToJson() { }

}

