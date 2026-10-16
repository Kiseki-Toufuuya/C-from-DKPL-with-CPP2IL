namespace UnityEngine;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal class TextEditingUtilities
{
	private static Dictionary<Event, TextEditOp> s_KeyEditOps; //Field offset: 0x0
	private TextSelectingUtilities m_TextSelectingUtility; //Field offset: 0x8
	internal TextHandle textHandle; //Field offset: 0xC
	private int m_CursorIndexSavedState; //Field offset: 0x10
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal bool isCompositionActive; //Field offset: 0x14
	private bool m_UpdateImeWindowPosition; //Field offset: 0x15
	internal Action OnTextChanged; //Field offset: 0x18
	public bool multiline; //Field offset: 0x1C
	private string m_Text; //Field offset: 0x20
	private char m_HighSurrogate; //Field offset: 0x24

	private int cursorIndex
	{
		private get { } //Length: 87
		private set { } //Length: 52
	}

	private int cursorIndexNoValidation
	{
		private get { } //Length: 23
		private set { } //Length: 52
	}

	private bool hasSelection
	{
		private get { } //Length: 165
	}

	internal bool revealCursor
	{
		internal set { } //Length: 52
	}

	private int selectIndex
	{
		private get { } //Length: 87
		private set { } //Length: 52
	}

	private int selectIndexNoValidation
	{
		private set { } //Length: 52
	}

	internal int stringCursorIndex
	{
		internal get { } //Length: 104
	}

	internal int stringSelectIndex
	{
		internal get { } //Length: 104
	}

	public string text
	{
		 get { } //Length: 11
		 set { } //Length: 84
	}

	public TextEditingUtilities(TextSelectingUtilities selectingUtilities, TextHandle textHandle, string text) { }

	public bool Backspace() { }

	public bool CanPaste() { }

	public bool Cut() { }

	public bool Delete() { }

	public bool DeleteLineBack() { }

	public bool DeleteSelection() { }

	public bool DeleteWordBack() { }

	public bool DeleteWordForward() { }

	public void EnableCursorPreviewState() { }

	public string GeneratePreviewString(bool richText) { }

	private int get_cursorIndex() { }

	private int get_cursorIndexNoValidation() { }

	private bool get_hasSelection() { }

	private int get_selectIndex() { }

	internal int get_stringCursorIndex() { }

	internal int get_stringSelectIndex() { }

	public string get_text() { }

	[VisibleToOtherModules]
	internal bool HandleKeyEvent(Event e) { }

	private void InitKeyActions() { }

	public bool Insert(char c) { }

	private static void MapKey(string key, TextEditOp action) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal void OnBlur() { }

	public bool Paste() { }

	private void PerformOperation(TextEditOp operation) { }

	private static string ReplaceNewlinesWithSpaces(string value) { }

	public void ReplaceSelection(string replace) { }

	public void RestoreCursorState() { }

	private void set_cursorIndex(int value) { }

	private void set_cursorIndexNoValidation(int value) { }

	internal void set_revealCursor(bool value) { }

	private void set_selectIndex(int value) { }

	private void set_selectIndexNoValidation(int value) { }

	public void set_text(string value) { }

	public void SetImeWindowPosition(Vector2 worldPosition) { }

	internal void SetTextWithoutNotify(string value) { }

	public bool ShouldUpdateImeWindowPosition() { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal bool TouchScreenKeyboardShouldBeUsed() { }

	public bool UpdateImeState() { }

}

