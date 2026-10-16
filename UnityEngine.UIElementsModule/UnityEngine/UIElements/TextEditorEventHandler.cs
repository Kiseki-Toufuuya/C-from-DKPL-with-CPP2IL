namespace UnityEngine.UIElements;

internal class TextEditorEventHandler
{
	protected TextElement textElement; //Field offset: 0x8
	protected TextEditingUtilities editingUtilities; //Field offset: 0xC

	protected TextEditorEventHandler(TextElement textElement, TextEditingUtilities editingUtilities) { }

	public override void HandleEventBubbleUp(EventBase evt) { }

	public override void RegisterCallbacksOnTarget(VisualElement target) { }

	public override void UnregisterCallbacksFromTarget(VisualElement target) { }

}

