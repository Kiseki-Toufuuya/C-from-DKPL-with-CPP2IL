namespace XeSys.uGUI;

public class UIWrapperTextButton : UIWrapperButton
{
	private string m_TextObjectName; //Field offset: 0x74
	private GameObject m_TextObject; //Field offset: 0x78
	private Text m_Text; //Field offset: 0x7C
	private TextView m_TextView; //Field offset: 0x80

	public UIWrapperTextButton() { }

	public static UIWrapperTextButton CreateAnimatorButton(Animator animator, GameObject root, int btn_id, string hitObjName, string buttonObjName, string textObjName, Action onClick, bool isWaitClick = true, Action<TouchInfo> onTouch = null, bool isDrag = false) { }

	public static UIWrapperTextButton CreateLayoutButton(AbsoluteLayout rootLayout, GameObject root, int btn_id, string hitObjName, string buttonViewName, string textViewName, Action onClick, bool isWaitClick = true, Action<TouchInfo> onTouch = null, bool isDrag = false) { }

	public static UIWrapperTextButton CreateTweenButton(GameObject root, int btn_id, string hitObjName, string buttonObjName, string textObjName, Action onClick, bool isWaitClick = true, Action<TouchInfo> onTouch = null, bool isDrag = false) { }

	private void InitTextObject(string textObjectName) { }

	private void InitTextView(string textViewName) { }

	public void SetText(string text) { }

}

