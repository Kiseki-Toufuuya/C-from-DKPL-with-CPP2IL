namespace UnityEngine.UIElements.Internal;

internal class ColumnResizer : PointerManipulator
{
	private Vector2 m_Start; //Field offset: 0x14
	protected bool m_Active; //Field offset: 0x1C
	private bool m_Resizing; //Field offset: 0x1D
	private MultiColumnCollectionHeader m_Header; //Field offset: 0x20
	private Column m_Column; //Field offset: 0x24
	private VisualElement m_PreviewElement; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ColumnLayout <columnLayout>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <preview>k__BackingField; //Field offset: 0x30

	public ColumnLayout columnLayout
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public bool preview
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public ColumnResizer(Column column) { }

	private void BeginDragResize(float pos) { }

	private void DragResize(float pos) { }

	private void EndDragResize(float pos, bool cancelled) { }

	[CompilerGenerated]
	public ColumnLayout get_columnLayout() { }

	[CompilerGenerated]
	public bool get_preview() { }

	private void OnKeyDown(KeyDownEvent e) { }

	private void OnPointerDown(PointerDownEvent e) { }

	private void OnPointerMove(PointerMoveEvent e) { }

	private void OnPointerUp(PointerUpEvent e) { }

	protected virtual void RegisterCallbacksOnTarget() { }

	[CompilerGenerated]
	public void set_columnLayout(ColumnLayout value) { }

	[CompilerGenerated]
	public void set_preview(bool value) { }

	protected virtual void UnregisterCallbacksFromTarget() { }

	private void UpdatePreviewPosition() { }

}

