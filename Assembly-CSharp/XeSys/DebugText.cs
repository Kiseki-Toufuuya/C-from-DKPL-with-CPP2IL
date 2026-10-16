namespace XeSys;

public static class DebugText
{

	public static bool shadow
	{
		 get { } //Length: 3
		 set { } //Length: 3
	}

	public static Color shadowColor
	{
		 get { } //Length: 18
		 set { } //Length: 3
	}

	public static Color textColor
	{
		 get { } //Length: 72
		 set { } //Length: 70
	}

	[Conditional("XESYS_DEBUG")]
	public static void Draw(Vector2 position, string str, Color color) { }

	[Conditional("XESYS_DEBUG")]
	public static void Draw(float x, float y, string str) { }

	[Conditional("XESYS_DEBUG")]
	public static void Draw(float x, float y, string str, Color color) { }

	[Conditional("XESYS_DEBUG")]
	public static void DrawLL(string str, Color color) { }

	[Conditional("XESYS_DEBUG")]
	public static void DrawLL(string str) { }

	[Conditional("XESYS_DEBUG")]
	public static void DrawLR(string str, Color color) { }

	[Conditional("XESYS_DEBUG")]
	public static void DrawLR(string str) { }

	[Conditional("XESYS_DEBUG")]
	public static void DrawUL(string str, Color color) { }

	[Conditional("XESYS_DEBUG")]
	public static void DrawUL(string str) { }

	[Conditional("XESYS_DEBUG")]
	public static void DrawUR(string str) { }

	[Conditional("XESYS_DEBUG")]
	public static void DrawUR(string str, Color color) { }

	public static bool get_shadow() { }

	public static Color get_shadowColor() { }

	public static Color get_textColor() { }

	public static void set_shadow(bool value) { }

	public static void set_shadowColor(Color value) { }

	public static void set_textColor(Color value) { }

}

