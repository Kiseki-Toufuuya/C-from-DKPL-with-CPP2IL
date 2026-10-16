namespace TMPro;

[AddComponentMenu("UI/TextMeshPro - Input Field", 11)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.ugui@2.0/manual/TextMeshPro/index.html")]
public class TMP_InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICancelHandler, ICanvasElement, ILayoutElement, IScrollHandler
{
	[CompilerGenerated]
	private sealed class <CaretBlink>d__293 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public TMP_InputField <>4__this; //Field offset: 0x10

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		[DebuggerHidden]
		public <CaretBlink>d__293(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <MouseDragOutsideRect>d__314 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public TMP_InputField <>4__this; //Field offset: 0x10
		public PointerEventData eventData; //Field offset: 0x14

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		[DebuggerHidden]
		public <MouseDragOutsideRect>d__314(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal enum CharacterValidation
	{
		None = 0,
		Digit = 1,
		Integer = 2,
		Decimal = 3,
		Alphanumeric = 4,
		Name = 5,
		Regex = 6,
		EmailAddress = 7,
		CustomValidator = 8,
	}

	internal enum ContentType
	{
		Standard = 0,
		Autocorrected = 1,
		IntegerNumber = 2,
		DecimalNumber = 3,
		Alphanumeric = 4,
		Name = 5,
		EmailAddress = 6,
		Password = 7,
		Pin = 8,
		Custom = 9,
	}

	internal enum EditState
	{
		Continue = 0,
		Finish = 1,
	}

	internal enum InputType
	{
		Standard = 0,
		AutoCorrect = 1,
		Password = 2,
	}

	internal enum LineType
	{
		SingleLine = 0,
		MultiLineSubmit = 1,
		MultiLineNewline = 2,
	}

	internal class OnChangeEvent : UnityEvent<String>
	{

		public OnChangeEvent() { }

	}

	internal sealed class OnValidateInput : MulticastDelegate
	{

		public OnValidateInput(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, AsyncCallback callback, object object) { }

		public override char EndInvoke(IAsyncResult result) { }

		public override char Invoke(string text, int charIndex, char addedChar) { }

	}

	internal class SelectionEvent : UnityEvent<String>
	{

		public SelectionEvent() { }

	}

	internal class SubmitEvent : UnityEvent<String>
	{

		public SubmitEvent() { }

	}

	internal class TextSelectionEvent : UnityEvent<String, Int32, Int32>
	{

		public TextSelectionEvent() { }

	}

	internal class TouchScreenKeyboardEvent : UnityEvent<Status>
	{

		public TouchScreenKeyboardEvent() { }

	}

	private const float kHScrollSpeed = 0.05; //Field offset: 0x0
	private static readonly Char[] kSeparators; //Field offset: 0x0
	private const string kEmailSpecialCharacters = "!#$%&'*+-/=?^_`{|}~"; //Field offset: 0x0
	private const string kOculusQuestDeviceModel = "Oculus Quest"; //Field offset: 0x0
	private const float kVScrollSpeed = 0.1; //Field offset: 0x0
	private static bool s_IsQuestDevice; //Field offset: 0x4
	protected TouchScreenKeyboard m_SoftKeyboard; //Field offset: 0xB4
	protected RectTransform m_RectTransform; //Field offset: 0xB8
	[SerializeField]
	protected RectTransform m_TextViewport; //Field offset: 0xBC
	protected RectMask2D m_TextComponentRectMask; //Field offset: 0xC0
	protected RectMask2D m_TextViewportRectMask; //Field offset: 0xC4
	[SerializeField]
	protected TMP_Text m_TextComponent; //Field offset: 0xC8
	protected RectTransform m_TextComponentRectTransform; //Field offset: 0xCC
	[SerializeField]
	protected Graphic m_Placeholder; //Field offset: 0xD0
	[SerializeField]
	protected Scrollbar m_VerticalScrollbar; //Field offset: 0xD4
	[SerializeField]
	protected TMP_ScrollbarEventHandler m_VerticalScrollbarEventHandler; //Field offset: 0xD8
	private bool m_IsDrivenByLayoutComponents; //Field offset: 0xDC
	[SerializeField]
	private LayoutGroup m_LayoutGroup; //Field offset: 0xE0
	private IScrollHandler m_IScrollHandlerParent; //Field offset: 0xE4
	private float m_ScrollPosition; //Field offset: 0xE8
	[SerializeField]
	protected float m_ScrollSensitivity; //Field offset: 0xEC
	[SerializeField]
	private ContentType m_ContentType; //Field offset: 0xF0
	[SerializeField]
	private InputType m_InputType; //Field offset: 0xF4
	[SerializeField]
	private char m_AsteriskChar; //Field offset: 0xF8
	[SerializeField]
	private TouchScreenKeyboardType m_KeyboardType; //Field offset: 0xFC
	[SerializeField]
	private LineType m_LineType; //Field offset: 0x100
	[SerializeField]
	private bool m_HideMobileInput; //Field offset: 0x104
	[SerializeField]
	private bool m_HideSoftKeyboard; //Field offset: 0x105
	[SerializeField]
	private CharacterValidation m_CharacterValidation; //Field offset: 0x108
	[SerializeField]
	private string m_RegexValue; //Field offset: 0x10C
	[SerializeField]
	private float m_GlobalPointSize; //Field offset: 0x110
	[SerializeField]
	private int m_CharacterLimit; //Field offset: 0x114
	[SerializeField]
	private SubmitEvent m_OnEndEdit; //Field offset: 0x118
	[SerializeField]
	private SubmitEvent m_OnSubmit; //Field offset: 0x11C
	[SerializeField]
	private SelectionEvent m_OnSelect; //Field offset: 0x120
	[SerializeField]
	private SelectionEvent m_OnDeselect; //Field offset: 0x124
	[SerializeField]
	private TextSelectionEvent m_OnTextSelection; //Field offset: 0x128
	[SerializeField]
	private TextSelectionEvent m_OnEndTextSelection; //Field offset: 0x12C
	[SerializeField]
	private OnChangeEvent m_OnValueChanged; //Field offset: 0x130
	[SerializeField]
	private TouchScreenKeyboardEvent m_OnTouchScreenKeyboardStatusChanged; //Field offset: 0x134
	[SerializeField]
	private OnValidateInput m_OnValidateInput; //Field offset: 0x138
	[SerializeField]
	private Color m_CaretColor; //Field offset: 0x13C
	[SerializeField]
	private bool m_CustomCaretColor; //Field offset: 0x14C
	[SerializeField]
	private Color m_SelectionColor; //Field offset: 0x150
	[SerializeField]
	[TextArea(5, 10)]
	protected string m_Text; //Field offset: 0x160
	[Range(0, 4)]
	[SerializeField]
	private float m_CaretBlinkRate; //Field offset: 0x164
	[Range(1, 5)]
	[SerializeField]
	private int m_CaretWidth; //Field offset: 0x168
	[SerializeField]
	private bool m_ReadOnly; //Field offset: 0x16C
	[SerializeField]
	private bool m_RichText; //Field offset: 0x16D
	protected int m_StringPosition; //Field offset: 0x170
	protected int m_StringSelectPosition; //Field offset: 0x174
	protected int m_CaretPosition; //Field offset: 0x178
	protected int m_CaretSelectPosition; //Field offset: 0x17C
	private RectTransform caretRectTrans; //Field offset: 0x180
	protected UIVertex[] m_CursorVerts; //Field offset: 0x184
	private CanvasRenderer m_CachedInputRenderer; //Field offset: 0x188
	private Vector2 m_LastPosition; //Field offset: 0x18C
	protected Mesh m_Mesh; //Field offset: 0x194
	private bool m_AllowInput; //Field offset: 0x198
	private bool m_ShouldActivateNextUpdate; //Field offset: 0x199
	private bool m_UpdateDrag; //Field offset: 0x19A
	private bool m_DragPositionOutOfBounds; //Field offset: 0x19B
	protected bool m_CaretVisible; //Field offset: 0x19C
	private Coroutine m_BlinkCoroutine; //Field offset: 0x1A0
	private float m_BlinkStartTime; //Field offset: 0x1A4
	private Coroutine m_DragCoroutine; //Field offset: 0x1A8
	private string m_OriginalText; //Field offset: 0x1AC
	private bool m_WasCanceled; //Field offset: 0x1B0
	private bool m_HasDoneFocusTransition; //Field offset: 0x1B1
	private WaitForSecondsRealtime m_WaitForSecondsRealtime; //Field offset: 0x1B4
	private bool m_PreventCallback; //Field offset: 0x1B8
	private bool m_TouchKeyboardAllowsInPlaceEditing; //Field offset: 0x1B9
	private bool m_IsTextComponentUpdateRequired; //Field offset: 0x1BA
	private bool m_HasTextBeenRemoved; //Field offset: 0x1BB
	private float m_PointerDownClickStartTime; //Field offset: 0x1BC
	private float m_KeyDownStartTime; //Field offset: 0x1C0
	private float m_DoubleClickDelay; //Field offset: 0x1C4
	private bool m_IsApplePlatform; //Field offset: 0x1C8
	private bool m_IsCompositionActive; //Field offset: 0x1C9
	private bool m_ShouldUpdateIMEWindowPosition; //Field offset: 0x1CA
	private int m_PreviousIMEInsertionLine; //Field offset: 0x1CC
	[SerializeField]
	protected TMP_FontAsset m_GlobalFontAsset; //Field offset: 0x1D0
	[SerializeField]
	protected bool m_OnFocusSelectAll; //Field offset: 0x1D4
	protected bool m_isSelectAll; //Field offset: 0x1D5
	[SerializeField]
	protected bool m_ResetOnDeActivation; //Field offset: 0x1D6
	private bool m_SelectionStillActive; //Field offset: 0x1D7
	private bool m_ReleaseSelection; //Field offset: 0x1D8
	private KeyCode m_LastKeyCode; //Field offset: 0x1DC
	private GameObject m_PreviouslySelectedObject; //Field offset: 0x1E0
	[SerializeField]
	private bool m_KeepTextSelectionVisible; //Field offset: 0x1E4
	[SerializeField]
	private bool m_RestoreOriginalTextOnEscape; //Field offset: 0x1E5
	[SerializeField]
	protected bool m_isRichTextEditingAllowed; //Field offset: 0x1E6
	[SerializeField]
	protected int m_LineLimit; //Field offset: 0x1E8
	public bool isAlert; //Field offset: 0x1EC
	[SerializeField]
	protected TMP_InputValidator m_InputValidator; //Field offset: 0x1F0
	[SerializeField]
	private bool m_ShouldActivateOnSelect; //Field offset: 0x1F4
	private bool m_isSelected; //Field offset: 0x1F5
	private bool m_IsStringPositionDirty; //Field offset: 0x1F6
	private bool m_IsCaretPositionDirty; //Field offset: 0x1F7
	private bool m_forceRectTransformAdjustment; //Field offset: 0x1F8
	private bool m_IsKeyboardBeingClosedInHoloLens; //Field offset: 0x1F9
	private Event m_ProcessingEvent; //Field offset: 0x1FC

	public char asteriskChar
	{
		 get { } //Length: 15
		 set { } //Length: 78
	}

	public float caretBlinkRate
	{
		 get { } //Length: 14
		 set { } //Length: 95
	}

	public Color caretColor
	{
		 get { } //Length: 87
		 set { } //Length: 103
	}

	public int caretPosition
	{
		 get { } //Length: 57
		 set { } //Length: 153
	}

	protected int caretPositionInternal
	{
		 get { } //Length: 57
		 set { } //Length: 40
	}

	protected int caretSelectPositionInternal
	{
		 get { } //Length: 57
		 set { } //Length: 40
	}

	public int caretWidth
	{
		 get { } //Length: 14
		 set { } //Length: 127
	}

	public int characterLimit
	{
		 get { } //Length: 14
		 set { } //Length: 148
	}

	public CharacterValidation characterValidation
	{
		 get { } //Length: 14
		 set { } //Length: 89
	}

	private static string clipboard
	{
		private get { } //Length: 60
		private set { } //Length: 65
	}

	private int compositionLength
	{
		private get { } //Length: 44
	}

	private string compositionString
	{
		private get { } //Length: 141
	}

	public ContentType contentType
	{
		 get { } //Length: 14
		 set { } //Length: 588
	}

	public bool customCaretColor
	{
		 get { } //Length: 14
		 set { } //Length: 87
	}

	public override float flexibleHeight
	{
		 get { } //Length: 7
	}

	public override float flexibleWidth
	{
		 get { } //Length: 7
	}

	public TMP_FontAsset fontAsset
	{
		 get { } //Length: 14
		 set { } //Length: 275
	}

	private bool hasSelection
	{
		private get { } //Length: 112
	}

	private BaseInput inputSystem
	{
		private get { } //Length: 243
	}

	public InputType inputType
	{
		 get { } //Length: 14
		 set { } //Length: 89
	}

	public TMP_InputValidator inputValidator
	{
		 get { } //Length: 14
		 set { } //Length: 89
	}

	public bool isFocused
	{
		 get { } //Length: 14
	}

	public bool isRichTextEditingAllowed
	{
		 get { } //Length: 14
		 set { } //Length: 17
	}

	public bool keepTextSelectionVisible
	{
		 get { } //Length: 14
		 set { } //Length: 17
	}

	public TouchScreenKeyboardType keyboardType
	{
		 get { } //Length: 14
		 set { } //Length: 89
	}

	public override int layoutPriority
	{
		 get { } //Length: 6
	}

	public int lineLimit
	{
		 get { } //Length: 14
		 set { } //Length: 78
	}

	public LineType lineType
	{
		 get { } //Length: 14
		 set { } //Length: 194
	}

	protected Mesh mesh
	{
		 get { } //Length: 143
	}

	public override float minHeight
	{
		 get { } //Length: 3
	}

	public override float minWidth
	{
		 get { } //Length: 3
	}

	public bool multiLine
	{
		 get { } //Length: 31
	}

	public SelectionEvent onDeselect
	{
		 get { } //Length: 14
		 set { } //Length: 60
	}

	public SubmitEvent onEndEdit
	{
		 get { } //Length: 14
		 set { } //Length: 60
	}

	public TextSelectionEvent onEndTextSelection
	{
		 get { } //Length: 14
		 set { } //Length: 60
	}

	public bool onFocusSelectAll
	{
		 get { } //Length: 14
		 set { } //Length: 17
	}

	public SelectionEvent onSelect
	{
		 get { } //Length: 14
		 set { } //Length: 60
	}

	public SubmitEvent onSubmit
	{
		 get { } //Length: 14
		 set { } //Length: 60
	}

	public TextSelectionEvent onTextSelection
	{
		 get { } //Length: 14
		 set { } //Length: 60
	}

	public TouchScreenKeyboardEvent onTouchScreenKeyboardStatusChanged
	{
		 get { } //Length: 14
		 set { } //Length: 60
	}

	public OnValidateInput onValidateInput
	{
		 get { } //Length: 14
		 set { } //Length: 60
	}

	public OnChangeEvent onValueChanged
	{
		 get { } //Length: 14
		 set { } //Length: 60
	}

	public Graphic placeholder
	{
		 get { } //Length: 14
		 set { } //Length: 60
	}

	public float pointSize
	{
		 get { } //Length: 14
		 set { } //Length: 372
	}

	public override float preferredHeight
	{
		 get { } //Length: 363
	}

	public override float preferredWidth
	{
		 get { } //Length: 363
	}

	public bool readOnly
	{
		 get { } //Length: 14
		 set { } //Length: 17
	}

	public bool resetOnDeActivation
	{
		 get { } //Length: 14
		 set { } //Length: 17
	}

	public bool restoreOriginalTextOnEscape
	{
		 get { } //Length: 14
		 set { } //Length: 17
	}

	public bool richText
	{
		 get { } //Length: 14
		 set { } //Length: 127
	}

	public float scrollSensitivity
	{
		 get { } //Length: 14
		 set { } //Length: 135
	}

	public int selectionAnchorPosition
	{
		 get { } //Length: 57
		 set { } //Length: 79
	}

	public Color selectionColor
	{
		 get { } //Length: 21
		 set { } //Length: 103
	}

	public int selectionFocusPosition
	{
		 get { } //Length: 57
		 set { } //Length: 79
	}

	public int selectionStringAnchorPosition
	{
		 get { } //Length: 57
		 set { } //Length: 109
	}

	public int selectionStringFocusPosition
	{
		 get { } //Length: 57
		 set { } //Length: 109
	}

	public override bool shouldActivateOnSelect
	{
		 get { } //Length: 86
		 set { } //Length: 17
	}

	public bool shouldHideMobileInput
	{
		 get { } //Length: 102
		 set { } //Length: 137
	}

	public bool shouldHideSoftKeyboard
	{
		 get { } //Length: 134
		 set { } //Length: 312
	}

	public int stringPosition
	{
		 get { } //Length: 57
		 set { } //Length: 205
	}

	protected int stringPositionInternal
	{
		 get { } //Length: 57
		 set { } //Length: 62
	}

	protected int stringSelectPositionInternal
	{
		 get { } //Length: 57
		 set { } //Length: 62
	}

	public string text
	{
		 get { } //Length: 14
		 set { } //Length: 23
	}

	public TMP_Text textComponent
	{
		 get { } //Length: 14
		 set { } //Length: 78
	}

	public RectTransform textViewport
	{
		 get { } //Length: 14
		 set { } //Length: 60
	}

	public TouchScreenKeyboard touchScreenKeyboard
	{
		 get { } //Length: 14
	}

	public Scrollbar verticalScrollbar
	{
		 get { } //Length: 14
		 set { } //Length: 348
	}

	public bool wasCanceled
	{
		 get { } //Length: 14
	}

	private static TMP_InputField() { }

	protected TMP_InputField() { }

	public void ActivateInputField() { }

	private void ActivateInputFieldInternal() { }

	private void AdjustRectTransformRelativeToViewport(Vector2 startPosition, float height, bool isCharVisible) { }

	private void AdjustTextPositionRelativeToViewport(float relativePosition) { }

	protected override void Append(char input) { }

	protected override void Append(string input) { }

	private void AssignPositioningIfNeeded() { }

	private void Backspace() { }

	public override void CalculateLayoutInputHorizontal() { }

	public override void CalculateLayoutInputVertical() { }

	[IteratorStateMachine(typeof(<CaretBlink>d__293))]
	private IEnumerator CaretBlink() { }

	private int ClampArrayIndex(int index) { }

	protected void ClampCaretPos(ref int pos) { }

	protected void ClampStringPos(ref int pos) { }

	private void CreateCursorVerts() { }

	public void DeactivateInputField(bool clearSelection = false) { }

	private void Delete() { }

	private void DeleteKey() { }

	protected virtual void DoStateTransition(SelectionState state, bool instant) { }

	private void EnforceContentType() { }

	private int FindNextWordBegin() { }

	private int FindPrevWordBegin() { }

	public void ForceLabelUpdate() { }

	private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) { }

	private void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset) { }

	public char get_asteriskChar() { }

	public float get_caretBlinkRate() { }

	public Color get_caretColor() { }

	public int get_caretPosition() { }

	protected int get_caretPositionInternal() { }

	protected int get_caretSelectPositionInternal() { }

	public int get_caretWidth() { }

	public int get_characterLimit() { }

	public CharacterValidation get_characterValidation() { }

	private static string get_clipboard() { }

	private int get_compositionLength() { }

	private string get_compositionString() { }

	public ContentType get_contentType() { }

	public bool get_customCaretColor() { }

	public override float get_flexibleHeight() { }

	public override float get_flexibleWidth() { }

	public TMP_FontAsset get_fontAsset() { }

	private bool get_hasSelection() { }

	private BaseInput get_inputSystem() { }

	public InputType get_inputType() { }

	public TMP_InputValidator get_inputValidator() { }

	public bool get_isFocused() { }

	public bool get_isRichTextEditingAllowed() { }

	public bool get_keepTextSelectionVisible() { }

	public TouchScreenKeyboardType get_keyboardType() { }

	public override int get_layoutPriority() { }

	public int get_lineLimit() { }

	public LineType get_lineType() { }

	protected Mesh get_mesh() { }

	public override float get_minHeight() { }

	public override float get_minWidth() { }

	public bool get_multiLine() { }

	public SelectionEvent get_onDeselect() { }

	public SubmitEvent get_onEndEdit() { }

	public TextSelectionEvent get_onEndTextSelection() { }

	public bool get_onFocusSelectAll() { }

	public SelectionEvent get_onSelect() { }

	public SubmitEvent get_onSubmit() { }

	public TextSelectionEvent get_onTextSelection() { }

	public TouchScreenKeyboardEvent get_onTouchScreenKeyboardStatusChanged() { }

	public OnValidateInput get_onValidateInput() { }

	public OnChangeEvent get_onValueChanged() { }

	public Graphic get_placeholder() { }

	public float get_pointSize() { }

	public override float get_preferredHeight() { }

	public override float get_preferredWidth() { }

	public bool get_readOnly() { }

	public bool get_resetOnDeActivation() { }

	public bool get_restoreOriginalTextOnEscape() { }

	public bool get_richText() { }

	public float get_scrollSensitivity() { }

	public int get_selectionAnchorPosition() { }

	public Color get_selectionColor() { }

	public int get_selectionFocusPosition() { }

	public int get_selectionStringAnchorPosition() { }

	public int get_selectionStringFocusPosition() { }

	public override bool get_shouldActivateOnSelect() { }

	public bool get_shouldHideMobileInput() { }

	public bool get_shouldHideSoftKeyboard() { }

	public int get_stringPosition() { }

	protected int get_stringPositionInternal() { }

	protected int get_stringSelectPositionInternal() { }

	public string get_text() { }

	public TMP_Text get_textComponent() { }

	public RectTransform get_textViewport() { }

	public TouchScreenKeyboard get_touchScreenKeyboard() { }

	public Scrollbar get_verticalScrollbar() { }

	public bool get_wasCanceled() { }

	private int GetCaretPositionFromStringIndex(int stringIndex) { }

	private int GetMaxCaretPositionFromStringIndex(int stringIndex) { }

	private int GetMinCaretPositionFromStringIndex(int stringIndex) { }

	private float GetScrollPositionRelativeToViewport() { }

	private string GetSelectedString() { }

	private int GetStringIndexFromCaretPosition(int caretPosition) { }

	public override void GraphicUpdateComplete() { }

	private bool InPlaceEditing() { }

	private bool InPlaceEditingChanged() { }

	private void Insert(char c) { }

	private bool isKeyboardUsingEvents() { }

	private bool isUWP() { }

	protected override bool IsValidChar(char c) { }

	protected EditState KeyPressed(Event evt) { }

	protected override void LateUpdate() { }

	public override void LayoutComplete() { }

	private int LineDownCharacterPosition(int originalPos, bool goToLastChar) { }

	private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	private void MarkGeometryAsDirty() { }

	private bool MayDrag(PointerEventData eventData) { }

	[IteratorStateMachine(typeof(<MouseDragOutsideRect>d__314))]
	private IEnumerator MouseDragOutsideRect(PointerEventData eventData) { }

	private void MoveDown(bool shift, bool goToLastChar) { }

	private void MoveDown(bool shift) { }

	private void MoveLeft(bool shift, bool ctrl) { }

	private void MovePageDown(bool shift, bool goToLastChar) { }

	private void MovePageDown(bool shift) { }

	private void MovePageUp(bool shift) { }

	private void MovePageUp(bool shift, bool goToFirstChar) { }

	private void MoveRight(bool shift, bool ctrl) { }

	public void MoveTextEnd(bool shift) { }

	public void MoveTextStart(bool shift) { }

	public void MoveToEndOfLine(bool shift, bool ctrl) { }

	public void MoveToStartOfLine(bool shift, bool ctrl) { }

	private void MoveUp(bool shift, bool goToFirstChar) { }

	private void MoveUp(bool shift) { }

	private void ON_TEXT_CHANGED(object obj) { }

	public override void OnBeginDrag(PointerEventData eventData) { }

	public override void OnCancel(BaseEventData eventData) { }

	public void OnControlClick() { }

	public virtual void OnDeselect(BaseEventData eventData) { }

	protected virtual void OnDisable() { }

	public override void OnDrag(PointerEventData eventData) { }

	protected virtual void OnEnable() { }

	public override void OnEndDrag(PointerEventData eventData) { }

	private void OnFillVBO(Mesh vbo) { }

	protected void OnFocus() { }

	public virtual void OnMove(AxisEventData eventData) { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public virtual void OnPointerDown(PointerEventData eventData) { }

	public override void OnScroll(PointerEventData eventData) { }

	private void OnScrollbarValueChange(float value) { }

	public virtual void OnSelect(BaseEventData eventData) { }

	public override void OnSubmit(BaseEventData eventData) { }

	public override void OnUpdateSelected(BaseEventData eventData) { }

	private int PageDownCharacterPosition(int originalPos, bool goToLastChar) { }

	private int PageUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	public void ProcessEvent(Event e) { }

	public override void Rebuild(CanvasUpdate update) { }

	public void ReleaseSelection() { }

	protected void SelectAll() { }

	protected void SendOnEndEdit() { }

	protected void SendOnEndTextSelection() { }

	protected void SendOnFocus() { }

	protected void SendOnFocusLost() { }

	protected void SendOnSubmit() { }

	protected void SendOnTextSelection() { }

	private void SendOnValueChanged() { }

	private void SendOnValueChangedAndUpdateLabel() { }

	protected void SendTouchScreenKeyboardStatusChanged() { }

	public void set_asteriskChar(char value) { }

	public void set_caretBlinkRate(float value) { }

	public void set_caretColor(Color value) { }

	public void set_caretPosition(int value) { }

	protected void set_caretPositionInternal(int value) { }

	protected void set_caretSelectPositionInternal(int value) { }

	public void set_caretWidth(int value) { }

	public void set_characterLimit(int value) { }

	public void set_characterValidation(CharacterValidation value) { }

	private static void set_clipboard(string value) { }

	public void set_contentType(ContentType value) { }

	public void set_customCaretColor(bool value) { }

	public void set_fontAsset(TMP_FontAsset value) { }

	public void set_inputType(InputType value) { }

	public void set_inputValidator(TMP_InputValidator value) { }

	public void set_isRichTextEditingAllowed(bool value) { }

	public void set_keepTextSelectionVisible(bool value) { }

	public void set_keyboardType(TouchScreenKeyboardType value) { }

	public void set_lineLimit(int value) { }

	public void set_lineType(LineType value) { }

	public void set_onDeselect(SelectionEvent value) { }

	public void set_onEndEdit(SubmitEvent value) { }

	public void set_onEndTextSelection(TextSelectionEvent value) { }

	public void set_onFocusSelectAll(bool value) { }

	public void set_onSelect(SelectionEvent value) { }

	public void set_onSubmit(SubmitEvent value) { }

	public void set_onTextSelection(TextSelectionEvent value) { }

	public void set_onTouchScreenKeyboardStatusChanged(TouchScreenKeyboardEvent value) { }

	public void set_onValidateInput(OnValidateInput value) { }

	public void set_onValueChanged(OnChangeEvent value) { }

	public void set_placeholder(Graphic value) { }

	public void set_pointSize(float value) { }

	public void set_readOnly(bool value) { }

	public void set_resetOnDeActivation(bool value) { }

	public void set_restoreOriginalTextOnEscape(bool value) { }

	public void set_richText(bool value) { }

	public void set_scrollSensitivity(float value) { }

	public void set_selectionAnchorPosition(int value) { }

	public void set_selectionColor(Color value) { }

	public void set_selectionFocusPosition(int value) { }

	public void set_selectionStringAnchorPosition(int value) { }

	public void set_selectionStringFocusPosition(int value) { }

	public override void set_shouldActivateOnSelect(bool value) { }

	public void set_shouldHideMobileInput(bool value) { }

	public void set_shouldHideSoftKeyboard(bool value) { }

	public void set_stringPosition(int value) { }

	protected void set_stringPositionInternal(int value) { }

	protected void set_stringSelectPositionInternal(int value) { }

	public void set_text(string value) { }

	public void set_textComponent(TMP_Text value) { }

	public void set_textViewport(RectTransform value) { }

	public void set_verticalScrollbar(Scrollbar value) { }

	private void SetCaretActive() { }

	private void SetCaretVisible() { }

	public void SetGlobalFontAsset(TMP_FontAsset fontAsset) { }

	public void SetGlobalPointSize(float pointSize) { }

	private void SetText(string value, bool sendCallback = true) { }

	private void SetTextComponentRichTextMode() { }

	private void SetTextComponentWrapMode() { }

	public void SetTextWithoutNotify(string input) { }

	private void SetToCustom() { }

	private void SetToCustom(CharacterValidation characterValidation) { }

	private void SetToCustomIfContentTypeIsNot(ContentType[] allowedContentTypes) { }

	private bool TouchScreenKeyboardShouldBeUsed() { }

	private override Transform UnityEngine.UI.ICanvasElement.get_transform() { }

	private void UpdateCaretPositionFromStringIndex() { }

	private void UpdateGeometry() { }

	private void UpdateKeyboardStringPosition() { }

	protected void UpdateLabel() { }

	private void UpdateMaskRegions() { }

	private void UpdateScrollbar() { }

	private void UpdateStringIndexFromCaretPosition() { }

	private void UpdateStringPositionFromKeyboard() { }

	private void UpdateTouchKeyboardFromEditChanges() { }

	protected char Validate(string text, int pos, char ch) { }

}

