namespace UnityEngine.UIElements;

internal class TouchScreenTextEditorEventHandler : TextEditorEventHandler
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static long <Frame>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static TouchScreenKeyboard <activeTouchScreenKeyboard>k__BackingField; //Field offset: 0x8
	private IVisualElementScheduledItem m_TouchKeyboardPoller; //Field offset: 0x10
	private bool m_TouchKeyboardAllowsInPlaceEditing; //Field offset: 0x14
	private bool m_IsClicking; //Field offset: 0x15

	private static TouchScreenKeyboard activeTouchScreenKeyboard
	{
		[CompilerGenerated]
		private set { } //Length: 69
	}

	internal static long Frame
	{
		[CompilerGenerated]
		internal get { } //Length: 43
		[CompilerGenerated]
		private set { } //Length: 53
	}

	public TouchScreenTextEditorEventHandler(TextElement textElement, TextEditingUtilities editingUtilities) { }

	private void CloseTouchScreenKeyboard() { }

	private void DoPollTouchScreenKeyboard() { }

	[CompilerGenerated]
	internal static long get_Frame() { }

	public virtual void HandleEventBubbleUp(EventBase evt) { }

	private void OnFocusInEvent() { }

	private void OnFocusOutEvent(FocusOutEvent evt) { }

	private void OnPointerDownEvent() { }

	private void OnPointerUpEvent(PointerUpEvent evt) { }

	private void OpenTouchScreenKeyboard() { }

	private void PollTouchScreenKeyboard() { }

	[CompilerGenerated]
	private static void set_activeTouchScreenKeyboard(TouchScreenKeyboard value) { }

	[CompilerGenerated]
	private static void set_Frame(long value) { }

	private void UpdateStringPositionFromKeyboard() { }

}

