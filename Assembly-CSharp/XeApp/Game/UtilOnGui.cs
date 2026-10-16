namespace XeApp.Game;

public class UtilOnGui
{
	private const int DISP_MIN_FRM = 4; //Field offset: 0x0
	private const int BUTTON_MAX = 256; //Field offset: 0x0
	private const int SCROLL_MAX = 3; //Field offset: 0x0
	private static UtilOnGui m_Instance; //Field offset: 0x0

	public static UtilOnGui Instance
	{
		 get { } //Length: 40
	}

	public UtilOnGui() { }

	public static void Create() { }

	public void DispOnGui() { }

	public static UtilOnGui get_Instance() { }

	public void SetButton(string name, Rect rect, string text, Action<String> callback = null) { }

	public void SetLabel(string name, Rect rect, string text) { }

	public void SetScroll(string name, Rect rect1, Rect rect2) { }

	public void SetScrollButton(string scr_name, string name, Rect rect, string text, Action<String> callback = null) { }

}

