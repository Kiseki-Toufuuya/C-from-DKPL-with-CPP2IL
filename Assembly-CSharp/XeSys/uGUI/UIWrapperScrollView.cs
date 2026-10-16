namespace XeSys.uGUI;

public class UIWrapperScrollView : UIWrapperBase
{
	private ScrollRect m_ScrollRect; //Field offset: 0x14

	public ScrollRect scrollRect
	{
		 get { } //Length: 11
	}

	public UIWrapperScrollView() { }

	public void AddContent(GameObject gameObject) { }

	public static UIWrapperScrollView CreateScrollView(GameObject root, string scrollviewName) { }

	public ScrollRect get_scrollRect() { }

	public void InitScrollView(GameObject root, string scrollName) { }

}

