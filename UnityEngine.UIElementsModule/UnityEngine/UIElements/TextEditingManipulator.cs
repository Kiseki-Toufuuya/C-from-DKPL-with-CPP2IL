namespace UnityEngine.UIElements;

internal class TextEditingManipulator
{
	private readonly TextElement m_TextElement; //Field offset: 0x8
	private TextEditorEventHandler m_EditingEventHandler; //Field offset: 0xC
	internal TextEditingUtilities editingUtilities; //Field offset: 0x10
	private bool m_TouchScreenTextFieldInitialized; //Field offset: 0x14
	private IVisualElementScheduledItem m_HardwareKeyboardPoller; //Field offset: 0x18

	internal TextEditorEventHandler editingEventHandler
	{
		internal get { } //Length: 11
		internal set { } //Length: 96
	}

	private bool touchScreenTextFieldChanged
	{
		private get { } //Length: 138
	}

	public TextEditingManipulator(TextElement textElement) { }

	[CompilerGenerated]
	private void <OnFocusInEvent>b__14_0() { }

	internal TextEditorEventHandler get_editingEventHandler() { }

	private bool get_touchScreenTextFieldChanged() { }

	internal void HandleEventBubbleUp(EventBase evt) { }

	private void InitTextEditorEventHandler() { }

	private void OnFocusInEvent() { }

	private void OnFocusOutEvent() { }

	public void Reset() { }

	internal void set_editingEventHandler(TextEditorEventHandler value) { }

}

