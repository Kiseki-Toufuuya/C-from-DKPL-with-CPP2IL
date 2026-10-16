namespace UnityEngine.UIElements;

public class TextElement : BindableElement, INotifyValueChanged<String>, ITextEdition, IExperimentalFeatures, ITextSelection
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlFactory : UxmlFactory<TextElement, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : UxmlTraits
	{
		private UxmlStringAttributeDescription m_Text; //Field offset: 0x48
		private UxmlBoolAttributeDescription m_EnableRichText; //Field offset: 0x4C
		private UxmlBoolAttributeDescription m_EmojiFallbackSupport; //Field offset: 0x50
		private UxmlBoolAttributeDescription m_ParseEscapeSequences; //Field offset: 0x54
		private UxmlBoolAttributeDescription m_Selectable; //Field offset: 0x58
		private UxmlBoolAttributeDescription m_SelectWordByDoubleClick; //Field offset: 0x5C
		private UxmlBoolAttributeDescription m_SelectLineByTripleClick; //Field offset: 0x60
		private UxmlBoolAttributeDescription m_DisplayTooltipWhenElided; //Field offset: 0x64

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	internal static readonly BindingId displayTooltipWhenElidedProperty; //Field offset: 0x0
	private const string ZeroWidthSpace = "​"; //Field offset: 0x0
	internal static readonly BindingId emojiFallbackSupportProperty; //Field offset: 0x4C
	internal static readonly BindingId enableRichTextProperty; //Field offset: 0x98
	internal static readonly BindingId isElidedProperty; //Field offset: 0xE4
	internal static readonly BindingId parseEscapeSequencesProperty; //Field offset: 0x130
	internal static readonly BindingId textProperty; //Field offset: 0x17C
	internal static readonly BindingId valueProperty; //Field offset: 0x1C8
	public static readonly string ussClassName; //Field offset: 0x214
	public static readonly string selectableUssClassName; //Field offset: 0x218
	internal static readonly string k_EllipsisText; //Field offset: 0x21C
	internal static readonly BindingId autoCorrectionProperty; //Field offset: 0x220
	internal static readonly BindingId hideMobileInputProperty; //Field offset: 0x26C
	internal static readonly BindingId keyboardTypeProperty; //Field offset: 0x2B8
	internal static readonly BindingId isReadOnlyProperty; //Field offset: 0x304
	internal static readonly BindingId isPasswordProperty; //Field offset: 0x350
	internal static readonly BindingId maxLengthProperty; //Field offset: 0x39C
	internal static readonly BindingId maskCharProperty; //Field offset: 0x3E8
	internal static readonly BindingId isSelectableProperty; //Field offset: 0x434
	internal static readonly BindingId cursorIndexProperty; //Field offset: 0x480
	internal static readonly BindingId selectIndexProperty; //Field offset: 0x4CC
	internal static readonly BindingId doubleClickSelectsWordProperty; //Field offset: 0x518
	internal static readonly BindingId tripleClickSelectsLineProperty; //Field offset: 0x564
	internal static readonly BindingId cursorPositionProperty; //Field offset: 0x5B0
	internal static readonly BindingId selectAllOnFocusProperty; //Field offset: 0x5FC
	internal static readonly BindingId selectAllOnMouseUpProperty; //Field offset: 0x648
	internal static readonly BindingId selectionProperty; //Field offset: 0x694
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private UITKTextHandle <uitkTextHandle>k__BackingField; //Field offset: 0x370
	private string m_Text; //Field offset: 0x374
	private bool m_EnableRichText; //Field offset: 0x378
	private bool m_EmojiFallbackSupport; //Field offset: 0x379
	private bool m_ParseEscapeSequences; //Field offset: 0x37A
	private bool m_DisplayTooltipWhenElided; //Field offset: 0x37B
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <isElided>k__BackingField; //Field offset: 0x37C
	internal string elidedText; //Field offset: 0x380
	private bool m_WasElided; //Field offset: 0x384
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private TextEditingManipulator <editingManipulator>k__BackingField; //Field offset: 0x388
	internal bool isInputField; //Field offset: 0x38C
	private bool m_Multiline; //Field offset: 0x38D
	internal TouchScreenKeyboard m_TouchScreenKeyboard; //Field offset: 0x390
	internal Action<Boolean> onIsReadOnlyChanged; //Field offset: 0x394
	internal TouchScreenKeyboardType m_KeyboardType; //Field offset: 0x398
	private bool m_HideMobileInput; //Field offset: 0x39C
	private bool m_IsReadOnly; //Field offset: 0x39D
	private int m_MaxLength; //Field offset: 0x3A0
	private string m_PlaceholderText; //Field offset: 0x3A4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <UnityEngine.UIElements.ITextEdition.isDelayed>k__BackingField; //Field offset: 0x3A8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Func<Char, Boolean> <UnityEngine.UIElements.ITextEdition.AcceptCharacter>k__BackingField; //Field offset: 0x3AC
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<Boolean> <UnityEngine.UIElements.ITextEdition.UpdateScrollOffset>k__BackingField; //Field offset: 0x3B0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action <UnityEngine.UIElements.ITextEdition.UpdateValueFromText>k__BackingField; //Field offset: 0x3B4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action <UnityEngine.UIElements.ITextEdition.UpdateTextFromValue>k__BackingField; //Field offset: 0x3B8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action <UnityEngine.UIElements.ITextEdition.MoveFocusToCompositeRoot>k__BackingField; //Field offset: 0x3BC
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action <OnPlaceholderChanged>k__BackingField; //Field offset: 0x3C0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Func<String> <UnityEngine.UIElements.ITextEdition.GetDefaultValueType>k__BackingField; //Field offset: 0x3C4
	private string m_RenderedText; //Field offset: 0x3C8
	private string m_OriginalText; //Field offset: 0x3CC
	private char m_MaskChar; //Field offset: 0x3D0
	private bool m_IsPassword; //Field offset: 0x3D2
	private bool m_HidePlaceholderTextOnFocus; //Field offset: 0x3D3
	private bool m_AutoCorrection; //Field offset: 0x3D4
	private TextSelectingManipulator m_SelectingManipulator; //Field offset: 0x3D8
	private bool m_IsSelectable; //Field offset: 0x3DC
	private bool m_DoubleClickSelectsWord; //Field offset: 0x3DD
	private bool m_TripleClickSelectsLine; //Field offset: 0x3DE
	private bool m_SelectAllOnFocus; //Field offset: 0x3DF
	private bool m_SelectAllOnMouseUp; //Field offset: 0x3E0
	private Color m_SelectionColor; //Field offset: 0x3E4
	private Color m_CursorColor; //Field offset: 0x3F4
	private float m_CursorWidth; //Field offset: 0x404

	[CreateProperty]
	private bool autoCorrection
	{
		private get { } //Length: 63
		private set { } //Length: 66
	}

	internal Color cursorColor
	{
		internal get { } //Length: 21
		internal set { } //Length: 119
	}

	[CreateProperty]
	private int cursorIndex
	{
		private get { } //Length: 63
		private set { } //Length: 66
	}

	[CreateProperty(ReadOnly = True)]
	private Vector2 cursorPosition
	{
		private get { } //Length: 63
	}

	[CreateProperty]
	public bool displayTooltipWhenElided
	{
		 get { } //Length: 14
		 set { } //Length: 114
	}

	[CreateProperty]
	internal bool doubleClickSelectsWord
	{
		internal get { } //Length: 63
		internal set { } //Length: 66
	}

	internal TextEditingManipulator editingManipulator
	{
		[CompilerGenerated]
		internal get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 33
	}

	internal ITextEdition edition
	{
		internal get { } //Length: 8
	}

	private char effectiveMaskChar
	{
		private get { } //Length: 81
	}

	[CreateProperty]
	public bool emojiFallbackSupport
	{
		 get { } //Length: 14
		 set { } //Length: 110
	}

	[CreateProperty]
	public bool enableRichText
	{
		 get { } //Length: 14
		 set { } //Length: 112
	}

	internal bool hasFocus
	{
		internal get { } //Length: 86
	}

	[CreateProperty]
	private bool hideMobileInput
	{
		private get { } //Length: 63
		private set { } //Length: 66
	}

	[CreateProperty(ReadOnly = True)]
	public private bool isElided
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 17
	}

	[CreateProperty]
	private bool isPassword
	{
		private get { } //Length: 63
		private set { } //Length: 66
	}

	[CreateProperty]
	private bool isReadOnly
	{
		private get { } //Length: 63
		private set { } //Length: 66
	}

	[CreateProperty]
	internal bool isSelectable
	{
		internal get { } //Length: 63
		internal set { } //Length: 66
	}

	[CreateProperty]
	private TouchScreenKeyboardType keyboardType
	{
		private get { } //Length: 63
		private set { } //Length: 66
	}

	[CreateProperty]
	private char maskChar
	{
		private get { } //Length: 152
		private set { } //Length: 157
	}

	[CreateProperty]
	private int maxLength
	{
		private get { } //Length: 63
		private set { } //Length: 66
	}

	internal bool needsPlaceholderIfTextIsEmpty
	{
		internal get { } //Length: 170
	}

	internal Action OnPlaceholderChanged
	{
		[CompilerGenerated]
		internal get { } //Length: 14
		[CompilerGenerated]
		internal set { } //Length: 33
	}

	internal string originalText
	{
		internal get { } //Length: 14
	}

	[CreateProperty]
	public bool parseEscapeSequences
	{
		 get { } //Length: 14
		 set { } //Length: 112
	}

	internal RenderedText renderedText
	{
		internal get { } //Length: 893
	}

	[CreateProperty]
	private bool selectAllOnFocus
	{
		private get { } //Length: 63
		private set { } //Length: 66
	}

	[CreateProperty]
	private bool selectAllOnMouseUp
	{
		private get { } //Length: 63
		private set { } //Length: 66
	}

	[CreateProperty]
	private int selectIndex
	{
		private get { } //Length: 63
		private set { } //Length: 66
	}

	internal TextSelectingManipulator selectingManipulator
	{
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 97
	}

	[CreateProperty(ReadOnly = True)]
	public ITextSelection selection
	{
		 get { } //Length: 8
	}

	internal Color selectionColor
	{
		internal get { } //Length: 21
		internal set { } //Length: 119
	}

	internal bool showPlaceholderText
	{
		internal get { } //Length: 209
	}

	[CreateProperty]
	public override string text
	{
		 get { } //Length: 53
		 set { } //Length: 56
	}

	[CreateProperty]
	internal bool tripleClickSelectsLine
	{
		internal get { } //Length: 63
		internal set { } //Length: 66
	}

	internal UITKTextHandle uitkTextHandle
	{
		[CompilerGenerated]
		internal get { } //Length: 14
		[CompilerGenerated]
		internal set { } //Length: 33
	}

	private override string UnityEngine.UIElements.INotifyValueChanged<System.String>.value
	{
		private get { } //Length: 28
		private set { } //Length: 506
	}

	private override Func<Char, Boolean> UnityEngine.UIElements.ITextEdition.AcceptCharacter
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 33
	}

	private override bool UnityEngine.UIElements.ITextEdition.autoCorrection
	{
		private get { } //Length: 14
		private set { } //Length: 101
	}

	private override Func<String> UnityEngine.UIElements.ITextEdition.GetDefaultValueType
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 33
	}

	private override bool UnityEngine.UIElements.ITextEdition.hideMobileInput
	{
		private get { } //Length: 42
		private set { } //Length: 115
	}

	private override bool UnityEngine.UIElements.ITextEdition.hidePlaceholderOnFocus
	{
		private get { } //Length: 14
		private set { } //Length: 17
	}

	private override bool UnityEngine.UIElements.ITextEdition.isDelayed
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 17
	}

	private override bool UnityEngine.UIElements.ITextEdition.isPassword
	{
		private get { } //Length: 14
		private set { } //Length: 117
	}

	private override bool UnityEngine.UIElements.ITextEdition.isReadOnly
	{
		private get { } //Length: 34
		private set { } //Length: 220
	}

	private override TouchScreenKeyboardType UnityEngine.UIElements.ITextEdition.keyboardType
	{
		private get { } //Length: 14
		private set { } //Length: 101
	}

	private override char UnityEngine.UIElements.ITextEdition.maskChar
	{
		private get { } //Length: 15
		private set { } //Length: 151
	}

	private override int UnityEngine.UIElements.ITextEdition.maxLength
	{
		private get { } //Length: 14
		private set { } //Length: 164
	}

	private override Action UnityEngine.UIElements.ITextEdition.MoveFocusToCompositeRoot
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 33
	}

	private override bool UnityEngine.UIElements.ITextEdition.multiline
	{
		private get { } //Length: 14
		private set { } //Length: 104
	}

	private override string UnityEngine.UIElements.ITextEdition.placeholder
	{
		private get { } //Length: 14
		private set { } //Length: 406
	}

	private override TouchScreenKeyboard UnityEngine.UIElements.ITextEdition.touchScreenKeyboard
	{
		private get { } //Length: 14
	}

	private override Action<Boolean> UnityEngine.UIElements.ITextEdition.UpdateScrollOffset
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 33
	}

	private override Action UnityEngine.UIElements.ITextEdition.UpdateTextFromValue
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 33
	}

	private override Action UnityEngine.UIElements.ITextEdition.UpdateValueFromText
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 33
	}

	private override int UnityEngine.UIElements.ITextSelection.cursorIndex
	{
		private get { } //Length: 104
		private set { } //Length: 196
	}

	private override Vector2 UnityEngine.UIElements.ITextSelection.cursorPosition
	{
		private get { } //Length: 180
	}

	private override float UnityEngine.UIElements.ITextSelection.cursorWidth
	{
		private get { } //Length: 14
	}

	private override bool UnityEngine.UIElements.ITextSelection.doubleClickSelectsWord
	{
		private get { } //Length: 14
		private set { } //Length: 101
	}

	private override bool UnityEngine.UIElements.ITextSelection.isSelectable
	{
		private get { } //Length: 54
		private set { } //Length: 147
	}

	private override float UnityEngine.UIElements.ITextSelection.lineHeightAtCursorPosition
	{
		private get { } //Length: 112
	}

	private override bool UnityEngine.UIElements.ITextSelection.selectAllOnFocus
	{
		private get { } //Length: 14
		private set { } //Length: 101
	}

	private override bool UnityEngine.UIElements.ITextSelection.selectAllOnMouseUp
	{
		private get { } //Length: 14
		private set { } //Length: 101
	}

	private override int UnityEngine.UIElements.ITextSelection.selectIndex
	{
		private get { } //Length: 104
		private set { } //Length: 196
	}

	private override bool UnityEngine.UIElements.ITextSelection.tripleClickSelectsLine
	{
		private get { } //Length: 14
		private set { } //Length: 101
	}

	[CreateProperty]
	private string value
	{
		private get { } //Length: 53
		private set { } //Length: 56
	}

	private static TextElement() { }

	public TextElement() { }

	private void BuildContextualMenu(ContextualMenuPopulateEvent evt) { }

	private void Copy(DropdownMenuAction a) { }

	private Status CopyActionStatus(DropdownMenuAction a) { }

	private void Cut(DropdownMenuAction a) { }

	private Status CutActionStatus(DropdownMenuAction a) { }

	protected private virtual Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	internal void DrawCaret(MeshGenerationContext mgc) { }

	private void DrawHighlighting(MeshGenerationContext mgc) { }

	private void DrawNativeHighlighting(MeshGenerationContext mgc) { }

	private void EditionHandleEvent(EventBase evt) { }

	internal string ElideText(string drawText, string ellipsisText, float width, TextOverflowPosition textOverflowPosition) { }

	private bool get_autoCorrection() { }

	internal Color get_cursorColor() { }

	private int get_cursorIndex() { }

	private Vector2 get_cursorPosition() { }

	public bool get_displayTooltipWhenElided() { }

	internal bool get_doubleClickSelectsWord() { }

	[CompilerGenerated]
	internal TextEditingManipulator get_editingManipulator() { }

	internal ITextEdition get_edition() { }

	private char get_effectiveMaskChar() { }

	public bool get_emojiFallbackSupport() { }

	public bool get_enableRichText() { }

	internal bool get_hasFocus() { }

	private bool get_hideMobileInput() { }

	[CompilerGenerated]
	public bool get_isElided() { }

	private bool get_isPassword() { }

	private bool get_isReadOnly() { }

	internal bool get_isSelectable() { }

	private TouchScreenKeyboardType get_keyboardType() { }

	private char get_maskChar() { }

	private int get_maxLength() { }

	internal bool get_needsPlaceholderIfTextIsEmpty() { }

	[CompilerGenerated]
	internal Action get_OnPlaceholderChanged() { }

	internal string get_originalText() { }

	public bool get_parseEscapeSequences() { }

	internal RenderedText get_renderedText() { }

	private bool get_selectAllOnFocus() { }

	private bool get_selectAllOnMouseUp() { }

	private int get_selectIndex() { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal TextSelectingManipulator get_selectingManipulator() { }

	public ITextSelection get_selection() { }

	internal Color get_selectionColor() { }

	internal bool get_showPlaceholderText() { }

	public override string get_text() { }

	internal bool get_tripleClickSelectsLine() { }

	[CompilerGenerated]
	internal UITKTextHandle get_uitkTextHandle() { }

	private string get_value() { }

	private string GetDefaultValueType() { }

	private int GetLastCharacterAt(int lineIndex) { }

	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(ContextualMenuPopulateEvent), typeof(KeyDownEvent), typeof(KeyUpEvent), typeof(ValidateCommandEvent), typeof(ExecuteCommandEvent), typeof(FocusEvent), typeof(BlurEvent), typeof(FocusInEvent), typeof(FocusOutEvent), typeof(PointerDownEvent), typeof(PointerUpEvent), typeof(PointerMoveEvent), typeof(NavigationMoveEvent), typeof(NavigationSubmitEvent), typeof(NavigationCancelEvent), typeof(IMEEvent), typeof(GeometryChangedEvent), typeof(AttachToPanelEvent), typeof(DetachFromPanelEvent)})]
	protected virtual void HandleEventBubbleUp(EventBase evt) { }

	public Vector2 MeasureTextSize(string textToMeasure, float width, MeasureMode widthMode, float height, MeasureMode heightMode) { }

	private void OnDetachFromPanel(DetachFromPanelEvent detachEvent) { }

	internal void OnGenerateTextOver(MeshGenerationContext mgc) { }

	internal void OnGenerateTextOverNative(MeshGenerationContext mgc) { }

	internal static void OnGenerateVisualContent(MeshGenerationContext mgc) { }

	private void OnGeometryChanged(GeometryChangedEvent e) { }

	private void Paste(DropdownMenuAction a) { }

	private Status PasteActionStatus(DropdownMenuAction a) { }

	private void ProcessMenuCommand(string command) { }

	private void set_autoCorrection(bool value) { }

	internal void set_cursorColor(Color value) { }

	private void set_cursorIndex(int value) { }

	public void set_displayTooltipWhenElided(bool value) { }

	internal void set_doubleClickSelectsWord(bool value) { }

	[CompilerGenerated]
	private void set_editingManipulator(TextEditingManipulator value) { }

	public void set_emojiFallbackSupport(bool value) { }

	public void set_enableRichText(bool value) { }

	private void set_hideMobileInput(bool value) { }

	[CompilerGenerated]
	private void set_isElided(bool value) { }

	private void set_isPassword(bool value) { }

	private void set_isReadOnly(bool value) { }

	internal void set_isSelectable(bool value) { }

	private void set_keyboardType(TouchScreenKeyboardType value) { }

	private void set_maskChar(char value) { }

	private void set_maxLength(int value) { }

	[CompilerGenerated]
	internal void set_OnPlaceholderChanged(Action value) { }

	public void set_parseEscapeSequences(bool value) { }

	private void set_selectAllOnFocus(bool value) { }

	private void set_selectAllOnMouseUp(bool value) { }

	private void set_selectIndex(int value) { }

	internal void set_selectionColor(Color value) { }

	public override void set_text(string value) { }

	internal void set_tripleClickSelectsLine(bool value) { }

	[CompilerGenerated]
	internal void set_uitkTextHandle(UITKTextHandle value) { }

	private void set_value(string value) { }

	private void SetRenderedText(string value) { }

	private bool ShouldElide() { }

	private override string UnityEngine.UIElements.INotifyValueChanged<System.String>.get_value() { }

	private override void UnityEngine.UIElements.INotifyValueChanged<System.String>.set_value(string value) { }

	private override void UnityEngine.UIElements.INotifyValueChanged<System.String>.SetValueWithoutNotify(string newValue) { }

	private override string UnityEngine.UIElements.ITextEdition.CullString(string s) { }

	[CompilerGenerated]
	private override Func<Char, Boolean> UnityEngine.UIElements.ITextEdition.get_AcceptCharacter() { }

	private override bool UnityEngine.UIElements.ITextEdition.get_autoCorrection() { }

	[CompilerGenerated]
	private override Func<String> UnityEngine.UIElements.ITextEdition.get_GetDefaultValueType() { }

	private override bool UnityEngine.UIElements.ITextEdition.get_hideMobileInput() { }

	private override bool UnityEngine.UIElements.ITextEdition.get_hidePlaceholderOnFocus() { }

	[CompilerGenerated]
	private override bool UnityEngine.UIElements.ITextEdition.get_isDelayed() { }

	private override bool UnityEngine.UIElements.ITextEdition.get_isPassword() { }

	private override bool UnityEngine.UIElements.ITextEdition.get_isReadOnly() { }

	private override TouchScreenKeyboardType UnityEngine.UIElements.ITextEdition.get_keyboardType() { }

	private override char UnityEngine.UIElements.ITextEdition.get_maskChar() { }

	private override int UnityEngine.UIElements.ITextEdition.get_maxLength() { }

	[CompilerGenerated]
	private override Action UnityEngine.UIElements.ITextEdition.get_MoveFocusToCompositeRoot() { }

	private override bool UnityEngine.UIElements.ITextEdition.get_multiline() { }

	private override string UnityEngine.UIElements.ITextEdition.get_placeholder() { }

	private override TouchScreenKeyboard UnityEngine.UIElements.ITextEdition.get_touchScreenKeyboard() { }

	[CompilerGenerated]
	private override Action<Boolean> UnityEngine.UIElements.ITextEdition.get_UpdateScrollOffset() { }

	[CompilerGenerated]
	private override Action UnityEngine.UIElements.ITextEdition.get_UpdateTextFromValue() { }

	[CompilerGenerated]
	private override Action UnityEngine.UIElements.ITextEdition.get_UpdateValueFromText() { }

	private override void UnityEngine.UIElements.ITextEdition.RestoreValueAndText() { }

	private override void UnityEngine.UIElements.ITextEdition.SaveValueAndText() { }

	[CompilerGenerated]
	private override void UnityEngine.UIElements.ITextEdition.set_AcceptCharacter(Func<Char, Boolean> value) { }

	private override void UnityEngine.UIElements.ITextEdition.set_autoCorrection(bool value) { }

	[CompilerGenerated]
	private override void UnityEngine.UIElements.ITextEdition.set_GetDefaultValueType(Func<String> value) { }

	private override void UnityEngine.UIElements.ITextEdition.set_hideMobileInput(bool value) { }

	private override void UnityEngine.UIElements.ITextEdition.set_hidePlaceholderOnFocus(bool value) { }

	[CompilerGenerated]
	private override void UnityEngine.UIElements.ITextEdition.set_isDelayed(bool value) { }

	private override void UnityEngine.UIElements.ITextEdition.set_isPassword(bool value) { }

	private override void UnityEngine.UIElements.ITextEdition.set_isReadOnly(bool value) { }

	private override void UnityEngine.UIElements.ITextEdition.set_keyboardType(TouchScreenKeyboardType value) { }

	private override void UnityEngine.UIElements.ITextEdition.set_maskChar(char value) { }

	private override void UnityEngine.UIElements.ITextEdition.set_maxLength(int value) { }

	[CompilerGenerated]
	private override void UnityEngine.UIElements.ITextEdition.set_MoveFocusToCompositeRoot(Action value) { }

	private override void UnityEngine.UIElements.ITextEdition.set_multiline(bool value) { }

	private override void UnityEngine.UIElements.ITextEdition.set_placeholder(string value) { }

	[CompilerGenerated]
	private override void UnityEngine.UIElements.ITextEdition.set_UpdateScrollOffset(Action<Boolean> value) { }

	[CompilerGenerated]
	private override void UnityEngine.UIElements.ITextEdition.set_UpdateTextFromValue(Action value) { }

	[CompilerGenerated]
	private override void UnityEngine.UIElements.ITextEdition.set_UpdateValueFromText(Action value) { }

	private override void UnityEngine.UIElements.ITextEdition.UpdateText(string value) { }

	private override int UnityEngine.UIElements.ITextSelection.get_cursorIndex() { }

	private override Vector2 UnityEngine.UIElements.ITextSelection.get_cursorPosition() { }

	private override float UnityEngine.UIElements.ITextSelection.get_cursorWidth() { }

	private override bool UnityEngine.UIElements.ITextSelection.get_doubleClickSelectsWord() { }

	private override bool UnityEngine.UIElements.ITextSelection.get_isSelectable() { }

	private override float UnityEngine.UIElements.ITextSelection.get_lineHeightAtCursorPosition() { }

	private override bool UnityEngine.UIElements.ITextSelection.get_selectAllOnFocus() { }

	private override bool UnityEngine.UIElements.ITextSelection.get_selectAllOnMouseUp() { }

	private override int UnityEngine.UIElements.ITextSelection.get_selectIndex() { }

	private override bool UnityEngine.UIElements.ITextSelection.get_tripleClickSelectsLine() { }

	private override bool UnityEngine.UIElements.ITextSelection.HasSelection() { }

	private override void UnityEngine.UIElements.ITextSelection.SelectAll() { }

	private override void UnityEngine.UIElements.ITextSelection.SelectNone() { }

	private override void UnityEngine.UIElements.ITextSelection.set_cursorIndex(int value) { }

	private override void UnityEngine.UIElements.ITextSelection.set_doubleClickSelectsWord(bool value) { }

	private override void UnityEngine.UIElements.ITextSelection.set_isSelectable(bool value) { }

	private override void UnityEngine.UIElements.ITextSelection.set_selectAllOnFocus(bool value) { }

	private override void UnityEngine.UIElements.ITextSelection.set_selectAllOnMouseUp(bool value) { }

	private override void UnityEngine.UIElements.ITextSelection.set_selectIndex(int value) { }

	private override void UnityEngine.UIElements.ITextSelection.set_tripleClickSelectsLine(bool value) { }

	private void UpdateTooltip() { }

	private void UpdateVisibleText() { }

}

