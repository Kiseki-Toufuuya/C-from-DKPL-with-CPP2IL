namespace UnityEngine;

[NativeHeader("Modules/IMGUI/GUIContent.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
public class GUIContent
{
	private static readonly GUIContent s_Text; //Field offset: 0x0
	private static readonly GUIContent s_Image; //Field offset: 0x4
	private static readonly GUIContent s_TextImage; //Field offset: 0x8
	internal static string k_ZeroWidthSpace; //Field offset: 0xC
	public static GUIContent none; //Field offset: 0x10
	[SerializeField]
	private string m_Text; //Field offset: 0x8
	[SerializeField]
	private Texture m_Image; //Field offset: 0xC
	[SerializeField]
	private string m_Tooltip; //Field offset: 0x10
	[SerializeField]
	private string m_TextWithWhitespace; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action OnTextChanged; //Field offset: 0x18

	internal event Action OnTextChanged
	{
		[CompilerGenerated]
		internal add { } //Length: 116
		[CompilerGenerated]
		internal remove { } //Length: 116
	}

	public Texture image
	{
		 set { } //Length: 27
	}

	public string text
	{
		 get { } //Length: 11
		 set { } //Length: 79
	}

	internal string textWithWhitespace
	{
		internal get { } //Length: 93
		internal set { } //Length: 94
	}

	public string tooltip
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	private static GUIContent() { }

	public GUIContent(GUIContent src) { }

	public GUIContent(string text, Texture image, string tooltip) { }

	public GUIContent(string text) { }

	public GUIContent() { }

	[CompilerGenerated]
	internal void add_OnTextChanged(Action value) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void ClearStaticCache() { }

	public string get_text() { }

	internal string get_textWithWhitespace() { }

	public string get_tooltip() { }

	[CompilerGenerated]
	internal void remove_OnTextChanged(Action value) { }

	public void set_image(Texture value) { }

	public void set_text(string value) { }

	internal void set_textWithWhitespace(string value) { }

	public void set_tooltip(string value) { }

	internal void SetTextWithoutNotify(string value) { }

	internal static GUIContent Temp(string t) { }

	internal static GUIContent Temp(Texture i) { }

	public virtual string ToString() { }

}

