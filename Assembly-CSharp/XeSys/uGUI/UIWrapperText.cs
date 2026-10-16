namespace XeSys.uGUI;

public class UIWrapperText : UIWrapperBase
{
	private Text m_Text; //Field offset: 0x14

	public string text
	{
		 get { } //Length: 135
		 set { } //Length: 116
	}

	public Text textComponent
	{
		 get { } //Length: 11
	}

	public UIWrapperText() { }

	public static UIWrapperText CreateText(GameObject root, string textName) { }

	public string get_text() { }

	public Text get_textComponent() { }

	public void InitText(GameObject root, string textName) { }

	public void set_text(string value) { }

}

