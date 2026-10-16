namespace XeSys.uGUI;

public class UIWrapperInputField : UIWrapperBase
{
	private InputField m_InputField; //Field offset: 0x14
	private Action<String> m_onEndEdit; //Field offset: 0x18

	public InputField inputField
	{
		 get { } //Length: 11
	}

	public bool interactable
	{
		 get { } //Length: 105
		 set { } //Length: 111
	}

	public string text
	{
		 get { } //Length: 119
		 set { } //Length: 111
	}

	public UIWrapperInputField() { }

	public void ActivateInputField() { }

	public static UIWrapperInputField CreateInputField(GameObject root, string inputFieldName, Action<String> onEndEdit = null) { }

	public InputField get_inputField() { }

	public bool get_interactable() { }

	public string get_text() { }

	public void InitInputField(GameObject root, string inputFieldName, Action<String> onEndEdit = null) { }

	private void onEndEditProc(string input) { }

	public void set_interactable(bool value) { }

	public void set_text(string value) { }

	public void SetOnEndEdit(Action<String> onEndEdit) { }

}

