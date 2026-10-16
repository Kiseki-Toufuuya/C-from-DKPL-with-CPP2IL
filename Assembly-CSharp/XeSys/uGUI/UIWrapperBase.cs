namespace XeSys.uGUI;

public class UIWrapperBase
{
	protected GameObject m_Root; //Field offset: 0x8
	protected GameObject m_GameObject; //Field offset: 0xC
	protected RectTransform m_Transform; //Field offset: 0x10

	public GameObject gameObject
	{
		 get { } //Length: 11
	}

	public GameObject Root
	{
		 get { } //Length: 11
	}

	public RectTransform transform
	{
		 get { } //Length: 11
	}

	public UIWrapperBase() { }

	public void AddChild(GameObject obj, bool worldPositionStays = false) { }

	public void AddChildFit(GameObject obj) { }

	public static UIWrapperBase CreateUIBase(GameObject root, string gameObjectName) { }

	public GameObject get_gameObject() { }

	public GameObject get_Root() { }

	public RectTransform get_transform() { }

	public void InitBase(GameObject root, GameObject gameObject) { }

	public void InitBase(GameObject root, string gameObjectName) { }

}

