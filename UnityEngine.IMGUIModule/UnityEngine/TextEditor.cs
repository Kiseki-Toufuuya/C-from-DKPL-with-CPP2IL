namespace UnityEngine;

public class TextEditor
{
	internal enum DblClickSnapping
	{
		WORDS = 0,
		PARAGRAPHS = 1,
	}

	private readonly GUIContent m_Content; //Field offset: 0x8
	private TextSelectingUtilities m_TextSelecting; //Field offset: 0xC
	internal TextEditingUtilities m_TextEditing; //Field offset: 0x10
	internal IMGUITextHandle m_TextHandle; //Field offset: 0x14
	public TouchScreenKeyboard keyboardOnScreen; //Field offset: 0x18
	public int controlID; //Field offset: 0x1C
	public GUIStyle style; //Field offset: 0x20
	[Obsolete("'hasHorizontalCursorPos' has been deprecated. Changes to this member will not be observed. Use 'hasHorizontalCursor' instead.", True)]
	public bool hasHorizontalCursorPos; //Field offset: 0x24
	public bool isPasswordField; //Field offset: 0x25
	public Vector2 scrollOffset; //Field offset: 0x28
	private bool focus; //Field offset: 0x30
	private string m_TextWithWhitespace; //Field offset: 0x34
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Rect <position>k__BackingField; //Field offset: 0x38
	public Vector2 graphicalCursorPos; //Field offset: 0x48
	private Vector2 lastCursorPos; //Field offset: 0x50
	private Vector2 previousContentSize; //Field offset: 0x58
	private string oldText; //Field offset: 0x60
	private int oldPos; //Field offset: 0x64
	private int oldSelectPos; //Field offset: 0x68

	public int cursorIndex
	{
		 get { } //Length: 87
	}

	public bool isMultiline
	{
		 set { } //Length: 26
	}

	internal bool m_HasFocus
	{
		internal get { } //Length: 11
		internal set { } //Length: 14
	}

	public Rect position
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public int selectIndex
	{
		 get { } //Length: 87
	}

	public bool showCursor
	{
		 get { } //Length: 23
	}

	public string text
	{
		 get { } //Length: 23
		 set { } //Length: 144
	}

	internal string textWithWhitespace
	{
		internal get { } //Length: 93
		internal set { } //Length: 94
	}

	[RequiredByNativeCode]
	public TextEditor() { }

	public void DblClickSnap(DblClickSnapping snapping) { }

	public void DetectFocusChange() { }

	public void DrawCursor(string newText) { }

	public int get_cursorIndex() { }

	internal bool get_m_HasFocus() { }

	[CompilerGenerated]
	public Rect get_position() { }

	public int get_selectIndex() { }

	public bool get_showCursor() { }

	public string get_text() { }

	internal string get_textWithWhitespace() { }

	private Vector2 GetLocalCursorPosition(Vector2 cursorPosition) { }

	public bool HandleKeyEvent(Event e) { }

	public void Insert(char c) { }

	public void MouseDragSelectsWholeWords(bool on) { }

	public void MoveCursorToPosition(Vector2 cursorPosition) { }

	protected private void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift) { }

	private void OnContentTextChangedHandle() { }

	internal override void OnCursorIndexChange() { }

	internal override void OnDetectFocusChange() { }

	public void OnFocus() { }

	public void OnLostFocus() { }

	internal override void OnSelectIndexChange() { }

	private void OnTextChangedHandle() { }

	public void ReplaceSelection(string replace) { }

	public void SaveBackup() { }

	public void SelectCurrentParagraph() { }

	public void SelectCurrentWord() { }

	public void SelectToPosition(Vector2 cursorPosition) { }

	public void set_isMultiline(bool value) { }

	internal void set_m_HasFocus(bool value) { }

	[CompilerGenerated]
	public void set_position(Rect value) { }

	public void set_text(string value) { }

	internal void set_textWithWhitespace(string value) { }

	[VisibleToOtherModules]
	internal void UpdateScrollOffset() { }

	public void UpdateScrollOffsetIfNeeded(Event evt) { }

	internal void UpdateTextHandle() { }

}

