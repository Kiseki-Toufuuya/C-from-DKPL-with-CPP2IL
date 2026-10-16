namespace XeSys.uGUI;

public class UIWrapperTextMeshPro : UIWrapperBase
{
	private TextMeshProUGUI m_Text; //Field offset: 0x14

	public string text
	{
		 get { } //Length: 135
		 set { } //Length: 116
	}

	public TextMeshProUGUI textComponent
	{
		 get { } //Length: 11
	}

	public UIWrapperTextMeshPro() { }

	public static UIWrapperTextMeshPro CreateText(GameObject root, string textName) { }

	public string get_text() { }

	public TextMeshProUGUI get_textComponent() { }

	public void InitText(GameObject root, string textName) { }

	public void set_text(string value) { }

}

