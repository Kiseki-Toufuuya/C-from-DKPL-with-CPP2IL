namespace XeSys.uGUI;

public class uGUILayoutManager : Singleton<uGUILayoutManager>, IDisposable
{
	internal interface IInitializable
	{

		public bool uGUIInitialize() { }

	}

	internal interface IUpdateable
	{

		public void uGUIUpdate() { }

	}

	private List<IInitializable> m_InitializablesList; //Field offset: 0x8
	private List<IInitializable> m_DeregisterinitializeableList; //Field offset: 0xC
	private List<IUpdateable> m_UpdateableList; //Field offset: 0x10
	private List<IUpdateable> m_DeregisterUpdateableList; //Field offset: 0x14
	private Dictionary<GameObject, IuGUIButton> m_uGUILayoutButtonDic; //Field offset: 0x18
	private List<IuGUIButton> m_RegisteruGUILayoutButtonList; //Field offset: 0x1C
	private List<GameObject> m_DeregisteruGUILayoutButtonList; //Field offset: 0x20
	private IuGUIButton m_DragButton; //Field offset: 0x24

	public uGUILayoutManager() { }

	public void Clear() { }

	public void DeregisterButton(IuGUIButton button) { }

	public void DeregisterButton(GameObject buttonObject) { }

	public void DeregisterUpdateable(IUpdateable updateable) { }

	public override void Dispose() { }

	public int Drag(InputManager input) { }

	public IuGUIButton GetGUIButton(GameObject btnObj) { }

	public uGUIAnimatorButton RegisterAnimatorButton(Animator animator, GameObject buttonHitObject, IChgImageSlice chgImage, Action onClick, bool IsWaitClickAnim, Action<TouchInfo> onTouch, bool isDrag) { }

	public void RegisterButton(IuGUIButton button) { }

	public void RegisterInitializable(IInitializable initializable) { }

	public uGUITweenButton RegisterTweenButton(LayoutuGUITweenAnimBehaviour tweenAnim, GameObject buttonHitObject, IChgImageSlice chgImage, Action onClick, bool IsWaitClickAnim, Action<TouchInfo> onTouch, bool isDrag) { }

	public void RegisterUpdateable(IUpdateable updateable) { }

	public uGUILayoutButton RegisterViewButton(GameObject buttonHitObject, ViewBase buttonView, Action onClick, bool IsWaitClickAnim, Action<TouchInfo> onTouch, bool isDrag) { }

	public void SetDragButton(int touchId, IuGUIButton dragButton) { }

	public void Touch(TouchInfo touchInfo, GameObject gameObject) { }

	public void Update() { }

}

