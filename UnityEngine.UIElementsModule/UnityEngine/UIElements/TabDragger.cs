namespace UnityEngine.UIElements;

internal class TabDragger : PointerManipulator
{
	private float m_StartPos; //Field offset: 0x14
	private float m_LastPos; //Field offset: 0x18
	private bool m_Moving; //Field offset: 0x1C
	private bool m_Cancelled; //Field offset: 0x1D
	private VisualElement m_Header; //Field offset: 0x20
	private TabView m_TabView; //Field offset: 0x24
	private VisualElement m_PreviewElement; //Field offset: 0x28
	private TabDragLocationPreview m_LocationPreviewElement; //Field offset: 0x2C
	private VisualElement m_TabToMove; //Field offset: 0x30
	private float m_TabToMovePos; //Field offset: 0x34
	private VisualElement m_DestinationTab; //Field offset: 0x38
	private bool m_MoveBeforeDestination; //Field offset: 0x3C
	private int m_DraggingPointerId; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private TabLayout <tabLayout>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <active>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <isVertical>k__BackingField; //Field offset: 0x49

	internal bool active
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 14
	}

	internal bool isVertical
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 14
	}

	internal bool moving
	{
		internal get { } //Length: 11
		private set { } //Length: 116
	}

	private TabLayout tabLayout
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public TabDragger() { }

	private void BeginDragMove(float pos) { }

	private void DragMove(float pos) { }

	private void EndDragMove(bool cancelled) { }

	[CompilerGenerated]
	internal bool get_active() { }

	[CompilerGenerated]
	internal bool get_isVertical() { }

	internal bool get_moving() { }

	[CompilerGenerated]
	private TabLayout get_tabLayout() { }

	private void OnKeyDown(KeyDownEvent e) { }

	private void OnPointerCancel(PointerCancelEvent evt) { }

	private void OnPointerCaptureOut(PointerCaptureOutEvent evt) { }

	private void OnPointerDown(PointerDownEvent evt) { }

	private void OnPointerMove(PointerMoveEvent evt) { }

	private void OnPointerUp(PointerUpEvent evt) { }

	private void ProcessCancelEvent(EventBase evt, int pointerId) { }

	private void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	private void ProcessMoveEvent(EventBase e, Vector2 localPosition) { }

	private void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	protected virtual void RegisterCallbacksOnTarget() { }

	[CompilerGenerated]
	internal void set_active(bool value) { }

	[CompilerGenerated]
	internal void set_isVertical(bool value) { }

	private void set_moving(bool value) { }

	[CompilerGenerated]
	private void set_tabLayout(TabLayout value) { }

	protected virtual void UnregisterCallbacksFromTarget() { }

	private void UpdateMoveLocation() { }

	private void UpdatePreviewPosition() { }

}

