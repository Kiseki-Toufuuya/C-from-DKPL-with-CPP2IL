namespace UnityEngine.UIElements;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class TextSelectingManipulator
{
	private const int k_DragThresholdSqr = 16; //Field offset: 0x0
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal TextSelectingUtilities m_SelectingUtilities; //Field offset: 0x8
	private bool selectAllOnMouseUp; //Field offset: 0xC
	private TextElement m_TextElement; //Field offset: 0x10
	private Vector2 m_ClickStartPosition; //Field offset: 0x14
	private bool m_Dragged; //Field offset: 0x1C
	private bool m_IsClicking; //Field offset: 0x1D
	private int m_ConsecutiveMouseDownCount; //Field offset: 0x20
	private long m_LastMouseDownTimeStamp; //Field offset: 0x28
	private readonly Event m_ImguiEvent; //Field offset: 0x30

	internal int cursorIndex
	{
		internal get { } //Length: 34
		internal set { } //Length: 34
	}

	internal bool isClicking
	{
		internal get { } //Length: 11
		private set { } //Length: 19
	}

	internal int selectIndex
	{
		internal get { } //Length: 34
		internal set { } //Length: 34
	}

	public TextSelectingManipulator(TextElement textElement) { }

	internal int get_cursorIndex() { }

	internal bool get_isClicking() { }

	internal int get_selectIndex() { }

	internal void HandleEventBubbleUp(EventBase evt) { }

	internal bool HasFocus() { }

	internal bool HasSelection() { }

	private bool MoveDistanceQualifiesForDrag(Vector2 start, Vector2 current) { }

	private void OnBlurEvent() { }

	private void OnCursorIndexChange() { }

	private void OnExecuteCommandEvent(ExecuteCommandEvent evt) { }

	private void OnFocusEvent() { }

	private void OnKeyDown(KeyDownEvent evt) { }

	private void OnPointerDownEvent(PointerDownEvent evt) { }

	private void OnPointerMoveEvent(PointerMoveEvent evt) { }

	private void OnPointerUpEvent(PointerUpEvent evt) { }

	private void OnRevealCursor() { }

	private void OnSelectIndexChange() { }

	private void OnValidateCommandEvent(ValidateCommandEvent evt) { }

	internal bool RevealCursor() { }

	internal void set_cursorIndex(int value) { }

	private void set_isClicking(bool value) { }

	internal void set_selectIndex(int value) { }

}

