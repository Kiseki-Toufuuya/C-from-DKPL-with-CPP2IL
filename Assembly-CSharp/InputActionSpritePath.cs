//Type is in global namespace

public static class InputActionSpritePath
{
	private static readonly StringBuilder TempStringBuilder; //Field offset: 0x0
	private static string PlatformPrefix; //Field offset: 0x4

	private static InputActionSpritePath() { }

	public static string GetAction(InputAction action) { }

	public static void GetBind(StringBuilder builder, InputBinding bind) { }

	public static void GetControlSpritePath(StringBuilder builder, string controlPath) { }

	public static bool GetInputActionSpriteName(StringBuilder builder, InputAction action, InputDevice device) { }

	private static string GetLayoutIconGroup(string layout) { }

}

