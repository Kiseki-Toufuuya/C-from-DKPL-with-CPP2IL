namespace UnityEngine;

[NativeClass("TextRenderingPrivate::TextMesh")]
[NativeHeader("Modules/TextRendering/Public/TextMesh.h")]
[RequireComponent(typeof(Transform), typeof(MeshRenderer))]
public sealed class TextMesh : Component
{

	public TextAlignment alignment
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public TextAnchor anchor
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public float characterSize
	{
		 get { } //Length: 102
		 set { } //Length: 109
	}

	public Color color
	{
		 get { } //Length: 112
		 set { } //Length: 102
	}

	public Font font
	{
		 get { } //Length: 120
		 set { } //Length: 145
	}

	public int fontSize
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public FontStyle fontStyle
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public float lineSpacing
	{
		 get { } //Length: 102
		 set { } //Length: 109
	}

	public float offsetZ
	{
		 get { } //Length: 102
		 set { } //Length: 109
	}

	public bool richText
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public float tabSize
	{
		 get { } //Length: 102
		 set { } //Length: 109
	}

	public string text
	{
		 get { } //Length: 279
		 set { } //Length: 420
	}

	public TextMesh() { }

	public TextAlignment get_alignment() { }

	private static TextAlignment get_alignment_Injected(IntPtr _unity_self) { }

	public TextAnchor get_anchor() { }

	private static TextAnchor get_anchor_Injected(IntPtr _unity_self) { }

	public float get_characterSize() { }

	private static float get_characterSize_Injected(IntPtr _unity_self) { }

	public Color get_color() { }

	private static void get_color_Injected(IntPtr _unity_self, out Color ret) { }

	public Font get_font() { }

	private static IntPtr get_font_Injected(IntPtr _unity_self) { }

	public int get_fontSize() { }

	private static int get_fontSize_Injected(IntPtr _unity_self) { }

	public FontStyle get_fontStyle() { }

	private static FontStyle get_fontStyle_Injected(IntPtr _unity_self) { }

	public float get_lineSpacing() { }

	private static float get_lineSpacing_Injected(IntPtr _unity_self) { }

	public float get_offsetZ() { }

	private static float get_offsetZ_Injected(IntPtr _unity_self) { }

	public bool get_richText() { }

	private static bool get_richText_Injected(IntPtr _unity_self) { }

	public float get_tabSize() { }

	private static float get_tabSize_Injected(IntPtr _unity_self) { }

	public string get_text() { }

	private static void get_text_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	public void set_alignment(TextAlignment value) { }

	private static void set_alignment_Injected(IntPtr _unity_self, TextAlignment value) { }

	public void set_anchor(TextAnchor value) { }

	private static void set_anchor_Injected(IntPtr _unity_self, TextAnchor value) { }

	public void set_characterSize(float value) { }

	private static void set_characterSize_Injected(IntPtr _unity_self, float value) { }

	public void set_color(Color value) { }

	private static void set_color_Injected(IntPtr _unity_self, in Color value) { }

	public void set_font(Font value) { }

	private static void set_font_Injected(IntPtr _unity_self, IntPtr value) { }

	public void set_fontSize(int value) { }

	private static void set_fontSize_Injected(IntPtr _unity_self, int value) { }

	public void set_fontStyle(FontStyle value) { }

	private static void set_fontStyle_Injected(IntPtr _unity_self, FontStyle value) { }

	public void set_lineSpacing(float value) { }

	private static void set_lineSpacing_Injected(IntPtr _unity_self, float value) { }

	public void set_offsetZ(float value) { }

	private static void set_offsetZ_Injected(IntPtr _unity_self, float value) { }

	public void set_richText(bool value) { }

	private static void set_richText_Injected(IntPtr _unity_self, bool value) { }

	public void set_tabSize(float value) { }

	private static void set_tabSize_Injected(IntPtr _unity_self, float value) { }

	public void set_text(string value) { }

	private static void set_text_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

}

