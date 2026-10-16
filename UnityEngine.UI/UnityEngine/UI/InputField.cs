namespace UnityEngine.UI;

[AddComponentMenu("UI/Legacy/Input Field", 103)]
public class InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement
{
	[CompilerGenerated]
	private sealed class <CaretBlink>d__170 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public InputField <>4__this; //Field offset: 0x10

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
		public <CaretBlink>d__170(int <>1__state) { }

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
	private sealed class <MouseDragOutsideRect>d__194 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public PointerEventData eventData; //Field offset: 0x10
		public InputField <>4__this; //Field offset: 0x14

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
		public <MouseDragOutsideRect>d__194(int <>1__state) { }

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
		Integer = 1,
		Decimal = 2,
		Alphanumeric = 3,
		Name = 4,
		EmailAddress = 5,
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

	internal class EndEditEvent : UnityEvent<String>
	{

		public EndEditEvent() { }

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

	internal class SubmitEvent : UnityEvent<String>
	{

		public SubmitEvent() { }

	}

	private const int k_MaxTextLength = 16382; //Field offset: 0x0
	private static readonly Char[] kSeparators; //Field offset: 0x0
	private const string kOculusQuestDeviceModel = "Oculus Quest"; //Field offset: 0x0
	private const string kEmailSpecialCharacters = "!#$%&'*+-/=?^_`{|}~"; //Field offset: 0x0
	private const float kVScrollSpeed = 0.1; //Field offset: 0x0
	private const float kHScrollSpeed = 0.05; //Field offset: 0x0
	private static bool s_IsQuestDevice; //Field offset: 0x4
	protected TouchScreenKeyboard m_Keyboard; //Field offset: 0xB4
	[FormerlySerializedAs("text")]
	[SerializeField]
	protected Text m_TextComponent; //Field offset: 0xB8
	[SerializeField]
	protected Graphic m_Placeholder; //Field offset: 0xBC
	[SerializeField]
	private ContentType m_ContentType; //Field offset: 0xC0
	[FormerlySerializedAs("inputType")]
	[SerializeField]
	private InputType m_InputType; //Field offset: 0xC4
	[FormerlySerializedAs("asteriskChar")]
	[SerializeField]
	private char m_AsteriskChar; //Field offset: 0xC8
	[FormerlySerializedAs("keyboardType")]
	[SerializeField]
	private TouchScreenKeyboardType m_KeyboardType; //Field offset: 0xCC
	[SerializeField]
	private LineType m_LineType; //Field offset: 0xD0
	[FormerlySerializedAs("hideMobileInput")]
	[SerializeField]
	private bool m_HideMobileInput; //Field offset: 0xD4
	[FormerlySerializedAs("validation")]
	[SerializeField]
	private CharacterValidation m_CharacterValidation; //Field offset: 0xD8
	[FormerlySerializedAs("characterLimit")]
	[SerializeField]
	private int m_CharacterLimit; //Field offset: 0xDC
	[FormerlySerializedAs("onSubmit")]
	[FormerlySerializedAs("m_OnSubmit")]
	[FormerlySerializedAs("m_EndEdit")]
	[FormerlySerializedAs("m_OnEndEdit")]
	[SerializeField]
	private SubmitEvent m_OnSubmit; //Field offset: 0xE0
	[SerializeField]
	private EndEditEvent m_OnDidEndEdit; //Field offset: 0xE4
	[FormerlySerializedAs("onValueChange")]
	[FormerlySerializedAs("m_OnValueChange")]
	[SerializeField]
	private OnChangeEvent m_OnValueChanged; //Field offset: 0xE8
	[FormerlySerializedAs("onValidateInput")]
	[SerializeField]
	private OnValidateInput m_OnValidateInput; //Field offset: 0xEC
	[FormerlySerializedAs("selectionColor")]
	[SerializeField]
	private Color m_CaretColor; //Field offset: 0xF0
	[SerializeField]
	private bool m_CustomCaretColor; //Field offset: 0x100
	[SerializeField]
	private Color m_SelectionColor; //Field offset: 0x104
	[FormerlySerializedAs("mValue")]
	[Multiline]
	[SerializeField]
	protected string m_Text; //Field offset: 0x114
	[Range(0, 4)]
	[SerializeField]
	private float m_CaretBlinkRate; //Field offset: 0x118
	[Range(1, 5)]
	[SerializeField]
	private int m_CaretWidth; //Field offset: 0x11C
	[SerializeField]
	private bool m_ReadOnly; //Field offset: 0x120
	[SerializeField]
	private bool m_ShouldActivateOnSelect; //Field offset: 0x121
	protected int m_CaretPosition; //Field offset: 0x124
	protected int m_CaretSelectPosition; //Field offset: 0x128
	private RectTransform caretRectTrans; //Field offset: 0x12C
	protected UIVertex[] m_CursorVerts; //Field offset: 0x130
	private TextGenerator m_InputTextCache; //Field offset: 0x134
	private CanvasRenderer m_CachedInputRenderer; //Field offset: 0x138
	private bool m_PreventFontCallback; //Field offset: 0x13C
	protected Mesh m_Mesh; //Field offset: 0x140
	private bool m_AllowInput; //Field offset: 0x144
	private bool m_ShouldActivateNextUpdate; //Field offset: 0x145
	private bool m_UpdateDrag; //Field offset: 0x146
	private bool m_DragPositionOutOfBounds; //Field offset: 0x147
	protected bool m_CaretVisible; //Field offset: 0x148
	private Coroutine m_BlinkCoroutine; //Field offset: 0x14C
	private float m_BlinkStartTime; //Field offset: 0x150
	protected int m_DrawStart; //Field offset: 0x154
	protected int m_DrawEnd; //Field offset: 0x158
	private Coroutine m_DragCoroutine; //Field offset: 0x15C
	private string m_OriginalText; //Field offset: 0x160
	private bool m_WasCanceled; //Field offset: 0x164
	private bool m_HasDoneFocusTransition; //Field offset: 0x165
	private WaitForSecondsRealtime m_WaitForSecondsRealtime; //Field offset: 0x168
	private bool m_TouchKeyboardAllowsInPlaceEditing; //Field offset: 0x16C
	private bool m_IsCompositionActive; //Field offset: 0x16D
	private Event m_ProcessingEvent; //Field offset: 0x170

	public char asteriskChar
	{
		 get { } //Length: 15
		 set { } //Length: 78
	}

	protected TextGenerator cachedInputTextGenerator
	{
		 get { } //Length: 99
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
		 get { } //Length: 41
		 set { } //Length: 160
	}

	protected int caretPositionInternal
	{
		 get { } //Length: 41
		 set { } //Length: 62
	}

	protected int caretSelectPositionInternal
	{
		 get { } //Length: 41
		 set { } //Length: 62
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

	private bool hasSelection
	{
		private get { } //Length: 76
	}

	private BaseInput input
	{
		private get { } //Length: 243
	}

	public InputType inputType
	{
		 get { } //Length: 14
		 set { } //Length: 89
	}

	public bool isFocused
	{
		 get { } //Length: 14
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
		 get { } //Length: 7
	}

	public bool multiLine
	{
		 get { } //Length: 31
	}

	public EndEditEvent onEndEdit
	{
		 get { } //Length: 14
		 set { } //Length: 60
	}

	public SubmitEvent onSubmit
	{
		 get { } //Length: 14
		 set { } //Length: 60
	}

	public OnValidateInput onValidateInput
	{
		 get { } //Length: 14
		 set { } //Length: 60
	}

	[Obsolete("onValueChange has been renamed to onValueChanged")]
	public OnChangeEvent onValueChange
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

	public override float preferredHeight
	{
		 get { } //Length: 369
	}

	public override float preferredWidth
	{
		 get { } //Length: 374
	}

	public bool readOnly
	{
		 get { } //Length: 14
		 set { } //Length: 17
	}

	public int selectionAnchorPosition
	{
		 get { } //Length: 41
		 set { } //Length: 86
	}

	public Color selectionColor
	{
		 get { } //Length: 21
		 set { } //Length: 103
	}

	public int selectionFocusPosition
	{
		 get { } //Length: 41
		 set { } //Length: 86
	}

	public override bool shouldActivateOnSelect
	{
		 get { } //Length: 86
		 set { } //Length: 17
	}

	public bool shouldHideMobileInput
	{
		 get { } //Length: 92
		 set { } //Length: 60
	}

	public string text
	{
		 get { } //Length: 14
		 set { } //Length: 23
	}

	public Text textComponent
	{
		 get { } //Length: 14
		 set { } //Length: 553
	}

	public TouchScreenKeyboard touchScreenKeyboard
	{
		 get { } //Length: 14
	}

	public bool wasCanceled
	{
		 get { } //Length: 14
	}

	private static InputField() { }

	protected InputField() { }

	public void ActivateInputField() { }

	private void ActivateInputFieldInternal() { }

	protected override void Append(string input) { }

	protected override void Append(char input) { }

	private void AssignPositioningIfNeeded() { }

	private void Backspace() { }

	public override void CalculateLayoutInputHorizontal() { }

	public override void CalculateLayoutInputVertical() { }

	[IteratorStateMachine(typeof(<CaretBlink>d__170))]
	private IEnumerator CaretBlink() { }

	protected void ClampPos(ref int pos) { }

	private void CreateCursorVerts() { }

	public void DeactivateInputField() { }

	private void Delete() { }

	private int DetermineCharacterLine(int charPos, TextGenerator generator) { }

	protected virtual void DoStateTransition(SelectionState state, bool instant) { }

	private void EnforceContentType() { }

	private void EnforceTextHOverflow() { }

	private int FindtNextWordBegin() { }

	private int FindtPrevWordBegin() { }

	public void ForceLabelUpdate() { }

	private void ForwardSpace() { }

	private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) { }

	private void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset) { }

	public char get_asteriskChar() { }

	protected TextGenerator get_cachedInputTextGenerator() { }

	public float get_caretBlinkRate() { }

	public Color get_caretColor() { }

	public int get_caretPosition() { }

	protected int get_caretPositionInternal() { }

	protected int get_caretSelectPositionInternal() { }

	public int get_caretWidth() { }

	public int get_characterLimit() { }

	public CharacterValidation get_characterValidation() { }

	private static string get_clipboard() { }

	private string get_compositionString() { }

	public ContentType get_contentType() { }

	public bool get_customCaretColor() { }

	public override float get_flexibleHeight() { }

	public override float get_flexibleWidth() { }

	private bool get_hasSelection() { }

	private BaseInput get_input() { }

	public InputType get_inputType() { }

	public bool get_isFocused() { }

	public TouchScreenKeyboardType get_keyboardType() { }

	public override int get_layoutPriority() { }

	public LineType get_lineType() { }

	protected Mesh get_mesh() { }

	public override float get_minHeight() { }

	public override float get_minWidth() { }

	public bool get_multiLine() { }

	public EndEditEvent get_onEndEdit() { }

	public SubmitEvent get_onSubmit() { }

	public OnValidateInput get_onValidateInput() { }

	public OnChangeEvent get_onValueChange() { }

	public OnChangeEvent get_onValueChanged() { }

	public Graphic get_placeholder() { }

	public override float get_preferredHeight() { }

	public override float get_preferredWidth() { }

	public bool get_readOnly() { }

	public int get_selectionAnchorPosition() { }

	public Color get_selectionColor() { }

	public int get_selectionFocusPosition() { }

	public override bool get_shouldActivateOnSelect() { }

	public bool get_shouldHideMobileInput() { }

	public string get_text() { }

	public Text get_textComponent() { }

	public TouchScreenKeyboard get_touchScreenKeyboard() { }

	public bool get_wasCanceled() { }

	protected int GetCharacterIndexFromPosition(Vector2 pos) { }

	private RangeInt GetInternalSelection() { }

	private static int GetLineEndPosition(TextGenerator gen, int line) { }

	private static int GetLineStartPosition(TextGenerator gen, int line) { }

	private string GetSelectedString() { }

	private int GetUnclampedCharacterLineFromPosition(Vector2 pos, TextGenerator generator) { }

	public override void GraphicUpdateComplete() { }

	private bool InPlaceEditing() { }

	private bool InPlaceEditingChanged() { }

	private void Insert(char c) { }

	private bool IsSelectionVisible() { }

	private bool IsValidChar(char c) { }

	protected EditState KeyPressed(Event evt) { }

	protected override void LateUpdate() { }

	public override void LayoutComplete() { }

	private int LineDownCharacterPosition(int originalPos, bool goToLastChar) { }

	private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	private void MarkGeometryAsDirty() { }

	private bool MayDrag(PointerEventData eventData) { }

	[IteratorStateMachine(typeof(<MouseDragOutsideRect>d__194))]
	private IEnumerator MouseDragOutsideRect(PointerEventData eventData) { }

	private void MoveDown(bool shift, bool goToLastChar) { }

	private void MoveDown(bool shift) { }

	private void MoveLeft(bool shift, bool ctrl) { }

	private void MoveRight(bool shift, bool ctrl) { }

	public void MoveTextEnd(bool shift) { }

	public void MoveTextStart(bool shift) { }

	private void MoveUp(bool shift) { }

	private void MoveUp(bool shift, bool goToFirstChar) { }

	public override void OnBeginDrag(PointerEventData eventData) { }

	public virtual void OnDeselect(BaseEventData eventData) { }

	protected virtual void OnDestroy() { }

	protected virtual void OnDisable() { }

	public override void OnDrag(PointerEventData eventData) { }

	protected virtual void OnEnable() { }

	public override void OnEndDrag(PointerEventData eventData) { }

	private void OnFillVBO(Mesh vbo) { }

	protected void OnFocus() { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public virtual void OnPointerDown(PointerEventData eventData) { }

	public virtual void OnSelect(BaseEventData eventData) { }

	public override void OnSubmit(BaseEventData eventData) { }

	public override void OnUpdateSelected(BaseEventData eventData) { }

	public void ProcessEvent(Event e) { }

	public override void Rebuild(CanvasUpdate update) { }

	[Obsolete("This function is no longer used. Please use RectTransformUtility.ScreenPointToLocalPointInRectangle() instead.")]
	public Vector2 ScreenToLocal(Vector2 screen) { }

	protected void SelectAll() { }

	protected void SendOnEndEdit() { }

	protected void SendOnSubmit() { }

	private void SendOnValueChanged() { }

	private void SendOnValueChangedAndUpdateLabel() { }

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

	public void set_inputType(InputType value) { }

	public void set_keyboardType(TouchScreenKeyboardType value) { }

	public void set_lineType(LineType value) { }

	public void set_onEndEdit(EndEditEvent value) { }

	public void set_onSubmit(SubmitEvent value) { }

	public void set_onValidateInput(OnValidateInput value) { }

	public void set_onValueChange(OnChangeEvent value) { }

	public void set_onValueChanged(OnChangeEvent value) { }

	public void set_placeholder(Graphic value) { }

	public void set_readOnly(bool value) { }

	public void set_selectionAnchorPosition(int value) { }

	public void set_selectionColor(Color value) { }

	public void set_selectionFocusPosition(int value) { }

	public override void set_shouldActivateOnSelect(bool value) { }

	public void set_shouldHideMobileInput(bool value) { }

	public void set_text(string value) { }

	public void set_textComponent(Text value) { }

	private void SetCaretActive() { }

	private void SetCaretVisible() { }

	private void SetDrawRangeToContainCaretPosition(int caretPos) { }

	private void SetText(string value, bool sendCallback = true) { }

	public void SetTextWithoutNotify(string input) { }

	private void SetToCustom() { }

	private void SetToCustomIfContentTypeIsNot(ContentType[] allowedContentTypes) { }

	private bool TouchScreenKeyboardShouldBeUsed() { }

	private override Transform UnityEngine.UI.ICanvasElement.get_transform() { }

	private void UpdateCaretFromKeyboard() { }

	private void UpdateCaretMaterial() { }

	private void UpdateGeometry() { }

	private void UpdateKeyboardCaret() { }

	protected void UpdateLabel() { }

	private void UpdateTouchKeyboardFromEditChanges() { }

	protected char Validate(string text, int pos, char ch) { }

}

