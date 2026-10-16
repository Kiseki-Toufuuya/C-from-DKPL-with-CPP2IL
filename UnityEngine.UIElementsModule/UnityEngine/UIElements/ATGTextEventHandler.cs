namespace UnityEngine.UIElements;

internal class ATGTextEventHandler
{
	private TextElement m_TextElement; //Field offset: 0x8
	private EventCallback<PointerDownEvent> m_LinkTagOnPointerDown; //Field offset: 0xC
	private EventCallback<PointerUpEvent> m_LinkTagOnPointerUp; //Field offset: 0x10
	private EventCallback<PointerMoveEvent> m_LinkTagOnPointerMove; //Field offset: 0x14
	private EventCallback<PointerOutEvent> m_LinkTagOnPointerOut; //Field offset: 0x18
	private EventCallback<PointerUpEvent> m_HyperlinkOnPointerUp; //Field offset: 0x1C
	private EventCallback<PointerMoveEvent> m_HyperlinkOnPointerMove; //Field offset: 0x20
	private EventCallback<PointerOverEvent> m_HyperlinkOnPointerOver; //Field offset: 0x24
	private EventCallback<PointerOutEvent> m_HyperlinkOnPointerOut; //Field offset: 0x28
	internal bool isOverridingCursor; //Field offset: 0x2C
	internal int currentLinkIDHash; //Field offset: 0x30

	public ATGTextEventHandler(TextElement textElement) { }

	private void AllocateHyperlinkCallbacks() { }

	private void AllocateLinkCallbacks() { }

	private bool HasAllocatedHyperlinkCallbacks() { }

	private bool HasAllocatedLinkCallbacks() { }

	private void HyperlinkOnPointerMove(PointerMoveEvent pme) { }

	private void HyperlinkOnPointerOut(PointerOutEvent evt) { }

	private void HyperlinkOnPointerOver(PointerOverEvent _) { }

	private void HyperlinkOnPointerUp(PointerUpEvent pue) { }

	private void LinkTagOnPointerDown(PointerDownEvent pde) { }

	private void LinkTagOnPointerMove(PointerMoveEvent pme) { }

	private void LinkTagOnPointerOut(PointerOutEvent poe) { }

	private void LinkTagOnPointerUp(PointerUpEvent pue) { }

	public void OnDestroy() { }

	internal void RegisterHyperlinkCallbacks() { }

	internal void RegisterLinkTagCallbacks() { }

	internal void UnRegisterHyperlinkCallbacks() { }

	internal void UnRegisterLinkTagCallbacks() { }

}

