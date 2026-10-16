namespace UnityEngine.InputSystem.UI;

[AddComponentMenu("Input/Virtual Mouse")]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.18/manual/UISupport.html#virtual-mouse-cursor-control")]
public class VirtualMouseInput : MonoBehaviour
{
	internal enum CursorMode
	{
		SoftwareCursor = 0,
		HardwareCursorIfAvailable = 1,
	}

	[Header("Cursor")]
	[SerializeField]
	[Tooltip("Whether the component should set the cursor position of the hardware mouse cursor, if one is available. If so, the software cursor pointed (to by 'Cursor Graphic') will be hidden.")]
	private CursorMode m_CursorMode; //Field offset: 0x10
	[SerializeField]
	[Tooltip("The graphic that represents the software cursor. This is hidden if a hardware cursor (see 'Cursor Mode') is used.")]
	private Graphic m_CursorGraphic; //Field offset: 0x14
	[SerializeField]
	[Tooltip("The transform for the software cursor. Will only be set if a software cursor is used (see 'Cursor Mode'). Moving the cursor updates the anchored position of the transform.")]
	private RectTransform m_CursorTransform; //Field offset: 0x18
	[Header("Motion")]
	[SerializeField]
	[Tooltip("Speed in pixels per second with which to move the cursor. Scaled by the input from 'Stick Action'.")]
	private float m_CursorSpeed; //Field offset: 0x1C
	[SerializeField]
	[Tooltip("Scale factor to apply to 'Scroll Wheel Action' when setting the mouse 'scrollWheel' control.")]
	private float m_ScrollSpeed; //Field offset: 0x20
	[SerializeField]
	[Space(10)]
	[Tooltip("Vector2 action that moves the cursor left/right (X) and up/down (Y) on screen.")]
	private InputActionProperty m_StickAction; //Field offset: 0x24
	[SerializeField]
	[Tooltip("Button action that triggers a left-click on the mouse.")]
	private InputActionProperty m_LeftButtonAction; //Field offset: 0x30
	[SerializeField]
	[Tooltip("Button action that triggers a middle-click on the mouse.")]
	private InputActionProperty m_MiddleButtonAction; //Field offset: 0x3C
	[SerializeField]
	[Tooltip("Button action that triggers a right-click on the mouse.")]
	private InputActionProperty m_RightButtonAction; //Field offset: 0x48
	[SerializeField]
	[Tooltip("Button action that triggers a forward button (button #4) click on the mouse.")]
	private InputActionProperty m_ForwardButtonAction; //Field offset: 0x54
	[SerializeField]
	[Tooltip("Button action that triggers a back button (button #5) click on the mouse.")]
	private InputActionProperty m_BackButtonAction; //Field offset: 0x60
	[SerializeField]
	[Tooltip("Vector2 action that feeds into the mouse 'scrollWheel' action (scaled by 'Scroll Speed').")]
	private InputActionProperty m_ScrollWheelAction; //Field offset: 0x6C
	private Canvas m_Canvas; //Field offset: 0x78
	private Mouse m_VirtualMouse; //Field offset: 0x7C
	private Mouse m_SystemMouse; //Field offset: 0x80
	private Action m_AfterInputUpdateDelegate; //Field offset: 0x84
	private Action<CallbackContext> m_ButtonActionTriggeredDelegate; //Field offset: 0x88
	private double m_LastTime; //Field offset: 0x90
	private Vector2 m_LastStickValue; //Field offset: 0x98

	public InputActionProperty backButtonAction
	{
		 get { } //Length: 26
		 set { } //Length: 197
	}

	public Graphic cursorGraphic
	{
		 get { } //Length: 11
		 set { } //Length: 117
	}

	public CursorMode cursorMode
	{
		 get { } //Length: 11
		 set { } //Length: 237
	}

	public float cursorSpeed
	{
		 get { } //Length: 11
		 set { } //Length: 18
	}

	public RectTransform cursorTransform
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public InputActionProperty forwardButtonAction
	{
		 get { } //Length: 26
		 set { } //Length: 197
	}

	public InputActionProperty leftButtonAction
	{
		 get { } //Length: 26
		 set { } //Length: 197
	}

	public InputActionProperty middleButtonAction
	{
		 get { } //Length: 26
		 set { } //Length: 197
	}

	public InputActionProperty rightButtonAction
	{
		 get { } //Length: 26
		 set { } //Length: 197
	}

	public float scrollSpeed
	{
		 get { } //Length: 11
		 set { } //Length: 18
	}

	public InputActionProperty scrollWheelAction
	{
		 get { } //Length: 26
		 set { } //Length: 42
	}

	public InputActionProperty stickAction
	{
		 get { } //Length: 26
		 set { } //Length: 42
	}

	public Mouse virtualMouse
	{
		 get { } //Length: 11
	}

	public VirtualMouseInput() { }

	public InputActionProperty get_backButtonAction() { }

	public Graphic get_cursorGraphic() { }

	public CursorMode get_cursorMode() { }

	public float get_cursorSpeed() { }

	public RectTransform get_cursorTransform() { }

	public InputActionProperty get_forwardButtonAction() { }

	public InputActionProperty get_leftButtonAction() { }

	public InputActionProperty get_middleButtonAction() { }

	public InputActionProperty get_rightButtonAction() { }

	public float get_scrollSpeed() { }

	public InputActionProperty get_scrollWheelAction() { }

	public InputActionProperty get_stickAction() { }

	public Mouse get_virtualMouse() { }

	private void OnAfterInputUpdate() { }

	private void OnButtonActionTriggered(CallbackContext context) { }

	protected void OnDisable() { }

	protected void OnEnable() { }

	public void set_backButtonAction(InputActionProperty value) { }

	public void set_cursorGraphic(Graphic value) { }

	public void set_cursorMode(CursorMode value) { }

	public void set_cursorSpeed(float value) { }

	public void set_cursorTransform(RectTransform value) { }

	public void set_forwardButtonAction(InputActionProperty value) { }

	public void set_leftButtonAction(InputActionProperty value) { }

	public void set_middleButtonAction(InputActionProperty value) { }

	public void set_rightButtonAction(InputActionProperty value) { }

	public void set_scrollSpeed(float value) { }

	public void set_scrollWheelAction(InputActionProperty value) { }

	public void set_stickAction(InputActionProperty value) { }

	private static void SetAction(ref InputActionProperty field, InputActionProperty value) { }

	private static void SetActionCallback(InputActionProperty field, Action<CallbackContext> callback, bool install = true) { }

	private void TryEnableHardwareCursor() { }

	private void TryFindCanvas() { }

	private void UpdateMotion() { }

}

