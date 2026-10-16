namespace UnityEngine;

[NativeConditional("ENABLE_ONSCREEN_KEYBOARD")]
[NativeHeader("Runtime/Input/KeyboardOnScreen.h")]
[NativeHeader("Runtime/Export/TouchScreenKeyboard/TouchScreenKeyboard.bindings.h")]
public class TouchScreenKeyboard
{
	public static class BindingsMarshaller
	{

		public static IntPtr ConvertToNative(TouchScreenKeyboard touchScreenKeyboard) { }

	}

	internal enum InputFieldAppearance
	{
		Customizable = 0,
		AlwaysVisible = 1,
		AlwaysHidden = 2,
	}

	internal enum Status
	{
		Visible = 0,
		Done = 1,
		Canceled = 2,
		LostFocus = 3,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static bool <disableInPlaceEditing>k__BackingField; //Field offset: 0x0
	internal IntPtr m_Ptr; //Field offset: 0x8

	public bool active
	{
		[NativeName("IsActive")]
		 get { } //Length: 69
		[NativeName("SetActive")]
		 set { } //Length: 72
	}

	public bool canGetSelection
	{
		[NativeName("CanGetSelection")]
		 get { } //Length: 69
	}

	public bool canSetSelection
	{
		[NativeName("CanSetSelection")]
		 get { } //Length: 69
	}

	public int characterLimit
	{
		[NativeName("SetCharacterLimit")]
		 set { } //Length: 72
	}

	internal static bool disableInPlaceEditing
	{
		[CompilerGenerated]
		internal get { } //Length: 40
	}

	public static bool hideInput
	{
		[NativeName("SetInputHidden")]
		 set { } //Length: 40
	}

	public static InputFieldAppearance inputFieldAppearance
	{
		[NativeName("GetInputFieldAppearance")]
		 get { } //Length: 29
	}

	public static bool isInPlaceEditingAllowed
	{
		 get { } //Length: 74
	}

	public static bool isSupported
	{
		 get { } //Length: 122
	}

	public RangeInt selection
	{
		 get { } //Length: 64
		 set { } //Length: 220
	}

	public Status status
	{
		[NativeName("GetKeyboardStatus")]
		 get { } //Length: 69
	}

	public string text
	{
		[NativeName("GetText")]
		 get { } //Length: 250
		[NativeName("SetText")]
		 set { } //Length: 410
	}

	public static bool visible
	{
		[NativeName("IsVisible")]
		 get { } //Length: 29
	}

	public TouchScreenKeyboard(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	private void Destroy() { }

	protected virtual void Finalize() { }

	[NativeName("IsActive")]
	public bool get_active() { }

	private static bool get_active_Injected(IntPtr _unity_self) { }

	[NativeName("CanGetSelection")]
	public bool get_canGetSelection() { }

	private static bool get_canGetSelection_Injected(IntPtr _unity_self) { }

	[NativeName("CanSetSelection")]
	public bool get_canSetSelection() { }

	private static bool get_canSetSelection_Injected(IntPtr _unity_self) { }

	[CompilerGenerated]
	internal static bool get_disableInPlaceEditing() { }

	[NativeName("GetInputFieldAppearance")]
	public static InputFieldAppearance get_inputFieldAppearance() { }

	public static bool get_isInPlaceEditingAllowed() { }

	public static bool get_isSupported() { }

	public RangeInt get_selection() { }

	[NativeName("GetKeyboardStatus")]
	public Status get_status() { }

	private static Status get_status_Injected(IntPtr _unity_self) { }

	[NativeName("GetText")]
	public string get_text() { }

	private static void get_text_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	[NativeName("IsVisible")]
	public static bool get_visible() { }

	private static void GetSelection(out int start, out int length) { }

	[FreeFunction("TouchScreenKeyboard_Destroy", IsThreadSafe = True)]
	private static void Internal_Destroy(IntPtr ptr) { }

	private static bool IsInPlaceEditingAllowed() { }

	[ExcludeFromDocs]
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure) { }

	[ExcludeFromDocs]
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder) { }

	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	[NativeName("SetActive")]
	public void set_active(bool value) { }

	private static void set_active_Injected(IntPtr _unity_self, bool value) { }

	[NativeName("SetCharacterLimit")]
	public void set_characterLimit(int value) { }

	private static void set_characterLimit_Injected(IntPtr _unity_self, int value) { }

	[NativeName("SetInputHidden")]
	public static void set_hideInput(bool value) { }

	public void set_selection(RangeInt value) { }

	[NativeName("SetText")]
	public void set_text(string value) { }

	private static void set_text_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	private static void SetSelection(int start, int length) { }

	[FreeFunction("TouchScreenKeyboard_InternalConstructorHelper")]
	private static IntPtr TouchScreenKeyboard_InternalConstructorHelper(ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder) { }

	private static IntPtr TouchScreenKeyboard_InternalConstructorHelper_Injected(ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments, ref ManagedSpanWrapper text, ref ManagedSpanWrapper textPlaceholder) { }

}

