namespace UnityEngine.UIElements;

internal class KeyboardTextEditorEventHandler : TextEditorEventHandler
{
	private readonly Event m_ImguiEvent; //Field offset: 0x10
	internal bool m_Changed; //Field offset: 0x14
	internal bool m_ShouldInvokeUpdateValue; //Field offset: 0x15

	public KeyboardTextEditorEventHandler(TextElement textElement, TextEditingUtilities editingUtilities) { }

	private void ApplyTextIfNeeded() { }

	public virtual void HandleEventBubbleUp(EventBase evt) { }

	private void OnBlur(BlurEvent _) { }

	private void OnExecuteCommandEvent(ExecuteCommandEvent evt) { }

	private void OnFocus(FocusEvent _) { }

	private void OnIMEInput(IMEEvent _) { }

	private void OnKeyDown(KeyDownEvent evt) { }

	private void OnNavigationEvent(NavigationEventBase<TEvent> evt) { }

	private void OnValidateCommandEvent(ValidateCommandEvent evt) { }

	private void UpdateLabel(bool generatePreview) { }

}

