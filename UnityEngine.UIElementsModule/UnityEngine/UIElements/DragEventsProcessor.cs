namespace UnityEngine.UIElements;

internal abstract class DragEventsProcessor
{
	public enum DragState
	{
		None = 0,
		CanStartDrag = 1,
		Dragging = 2,
	}

	private bool m_IsRegistered; //Field offset: 0x8
	private DragState m_DragState; //Field offset: 0xC
	private Vector3 m_Start; //Field offset: 0x10
	private bool m_PendingPerformDrag; //Field offset: 0x1C
	protected readonly VisualElement m_Target; //Field offset: 0x20

	protected IDragAndDrop dragAndDrop
	{
		 get { } //Length: 292
	}

	internal override bool isEditorContext
	{
		internal get { } //Length: 179
	}

	protected override bool supportsDragEvents
	{
		 get { } //Length: 3
	}

	private bool useDragEvents
	{
		private get { } //Length: 72
	}

	internal DragEventsProcessor(VisualElement target) { }

	private void CancelDragAndDrop(int releaseCapturePointerId = -1) { }

	protected abstract bool CanStartDrag(Vector3 pointerPosition) { }

	protected abstract void ClearDragAndDropUI(bool dragCancelled) { }

	protected IDragAndDrop get_dragAndDrop() { }

	internal override bool get_isEditorContext() { }

	protected override bool get_supportsDragEvents() { }

	private bool get_useDragEvents() { }

	private DragEventsProcessor GetDropTarget(Vector2 position) { }

	protected private abstract void OnDrop(Vector3 pointerPosition) { }

	private void OnGeometryChanged(GeometryChangedEvent evt) { }

	private void OnPointerCancelEvent(PointerCancelEvent evt) { }

	private void OnPointerCapturedOut(PointerCaptureOutEvent evt) { }

	private void OnPointerDownEvent(PointerDownEvent evt) { }

	private void OnPointerLeaveEvent(PointerLeaveEvent evt) { }

	private void OnPointerMoveEvent(PointerMoveEvent evt) { }

	private void OnPointerOutEvent(PointerOutEvent evt) { }

	internal void OnPointerUpEvent(PointerUpEvent evt) { }

	private void RegisterCallbacksFromTarget() { }

	private void RegisterCallbacksFromTarget(AttachToPanelEvent evt) { }

	protected private abstract StartDragArgs StartDrag(Vector3 pointerPosition) { }

	private void UnregisterCallbacksFromTarget(DetachFromPanelEvent evt) { }

	internal void UnregisterCallbacksFromTarget(bool unregisterPanelEvents = false) { }

	protected private abstract void UpdateDrag(Vector3 pointerPosition) { }

}

