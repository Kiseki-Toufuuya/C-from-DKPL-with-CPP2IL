namespace UnityEngine.InputForUI;

internal class InputEventPartialProvider : IEventProviderImpl
{
	private Event _ev; //Field offset: 0x8
	private OperatingSystemFamily _operatingSystemFamily; //Field offset: 0xC
	private ButtonsState _keyboardButtonsState; //Field offset: 0x10
	internal EventModifiers _eventModifiers; //Field offset: 0x38
	internal bool _sendNavigationEventOnTabKey; //Field offset: 0x3C
	private IDictionary<String, Command> _IMGUICommandToInputForUICommandType; //Field offset: 0x40

	public InputEventPartialProvider() { }

	private DiscreteTime GetTimestamp(in Event ev) { }

	public override void Initialize() { }

	public override void OnFocusChanged(bool focus) { }

	private void SendNextOrPreviousNavigationEventOnTabKeyDownEvent(in Event ev) { }

	public override void Shutdown() { }

	private CommandEvent ToCommandEvent(in Event ev) { }

	private KeyEvent ToKeyEvent(in Event ev) { }

	private TextInputEvent ToTextInputEvent(in Event ev) { }

	public override void Update() { }

	private void UpdateEventModifiers(in Event ev) { }

}

