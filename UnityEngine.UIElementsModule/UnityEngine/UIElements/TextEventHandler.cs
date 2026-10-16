namespace UnityEngine.UIElements;

internal class TextEventHandler
{
	private TextElement m_TextElement; //Field offset: 0x8
	private EventCallback<PointerDownEvent> m_LinkTagOnPointerDown; //Field offset: 0xC
	private EventCallback<PointerUpEvent> m_LinkTagOnPointerUp; //Field offset: 0x10
	private EventCallback<PointerMoveEvent> m_LinkTagOnPointerMove; //Field offset: 0x14
	private EventCallback<PointerOutEvent> m_LinkTagOnPointerOut; //Field offset: 0x18
	private EventCallback<PointerUpEvent> m_ATagOnPointerUp; //Field offset: 0x1C
	private EventCallback<PointerMoveEvent> m_ATagOnPointerMove; //Field offset: 0x20
	private EventCallback<PointerOverEvent> m_ATagOnPointerOver; //Field offset: 0x24
	private EventCallback<PointerOutEvent> m_ATagOnPointerOut; //Field offset: 0x28
	internal bool isOverridingCursor; //Field offset: 0x2C
	internal int currentLinkIDHash; //Field offset: 0x30
	internal bool hasLinkTag; //Field offset: 0x34
	internal bool hasATag; //Field offset: 0x35

	private TextInfo textInfo
	{
		private get { } //Length: 44
	}

	public TextEventHandler(TextElement textElement) { }

	private void AllocateATagCallbacks() { }

	private void AllocateLinkCallbacks() { }

	private void ATagOnPointerMove(PointerMoveEvent pme) { }

	private void ATagOnPointerOut(PointerOutEvent evt) { }

	private void ATagOnPointerOver(PointerOverEvent _) { }

	private void ATagOnPointerUp(PointerUpEvent pue) { }

	private TextInfo get_textInfo() { }

	internal void HandleATag() { }

	internal void HandleLinkAndATagCallbacks() { }

	internal void HandleLinkTag() { }

	private bool HasAllocatedATagCallbacks() { }

	private bool HasAllocatedLinkCallbacks() { }

	private void LinkTagOnPointerDown(PointerDownEvent pde) { }

	private void LinkTagOnPointerMove(PointerMoveEvent pme) { }

	private void LinkTagOnPointerOut(PointerOutEvent poe) { }

	private void LinkTagOnPointerUp(PointerUpEvent pue) { }

	public void OnDestroy() { }

}

