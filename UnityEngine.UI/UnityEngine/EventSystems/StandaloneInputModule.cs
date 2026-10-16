namespace UnityEngine.EventSystems;

[AddComponentMenu("Event/Standalone Input Module")]
public class StandaloneInputModule : PointerInputModule
{
	[Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", False)]
	internal enum InputMode
	{
		Mouse = 0,
		Buttons = 1,
	}

	private const float doubleClickTime = 0.3; //Field offset: 0x0
	private float m_PrevActionTime; //Field offset: 0x34
	private Vector2 m_LastMoveVector; //Field offset: 0x38
	private int m_ConsecutiveMoveCount; //Field offset: 0x40
	private Vector2 m_LastMousePosition; //Field offset: 0x44
	private Vector2 m_MousePosition; //Field offset: 0x4C
	private GameObject m_CurrentFocusedGameObject; //Field offset: 0x54
	private readonly Dictionary<Int32, PointerEventData> m_InputPointerEvents; //Field offset: 0x58
	[SerializeField]
	private string m_HorizontalAxis; //Field offset: 0x5C
	[SerializeField]
	private string m_VerticalAxis; //Field offset: 0x60
	[SerializeField]
	private string m_SubmitButton; //Field offset: 0x64
	[SerializeField]
	private string m_CancelButton; //Field offset: 0x68
	[SerializeField]
	private float m_InputActionsPerSecond; //Field offset: 0x6C
	[SerializeField]
	private float m_RepeatDelay; //Field offset: 0x70
	[FormerlySerializedAs("m_AllowActivationOnMobileDevice")]
	[HideInInspector]
	[SerializeField]
	private bool m_ForceModuleActive; //Field offset: 0x74

	[Obsolete("allowActivationOnMobileDevice has been deprecated. Use forceModuleActive instead (UnityUpgradable) -> forceModuleActive")]
	public bool allowActivationOnMobileDevice
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public string cancelButton
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	[Obsolete("forceModuleActive has been deprecated. There is no need to force the module awake as StandaloneInputModule works for all platforms")]
	public bool forceModuleActive
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public string horizontalAxis
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public float inputActionsPerSecond
	{
		 get { } //Length: 11
		 set { } //Length: 18
	}

	[Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", False)]
	public InputMode inputMode
	{
		 get { } //Length: 3
	}

	public float repeatDelay
	{
		 get { } //Length: 11
		 set { } //Length: 18
	}

	public string submitButton
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public string verticalAxis
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	protected StandaloneInputModule() { }

	public virtual void ActivateModule() { }

	public virtual void DeactivateModule() { }

	[Obsolete("This method is no longer checked, overriding it with return true does nothing!")]
	protected override bool ForceAutoSelect() { }

	public bool get_allowActivationOnMobileDevice() { }

	public string get_cancelButton() { }

	public bool get_forceModuleActive() { }

	public string get_horizontalAxis() { }

	public float get_inputActionsPerSecond() { }

	public InputMode get_inputMode() { }

	public float get_repeatDelay() { }

	public string get_submitButton() { }

	public string get_verticalAxis() { }

	protected GameObject GetCurrentFocusedGameObject() { }

	private Vector2 GetRawMoveVector() { }

	public virtual void Process() { }

	protected void ProcessMouseEvent(int id) { }

	protected void ProcessMouseEvent() { }

	protected void ProcessMousePress(MouseButtonEventData data) { }

	private bool ProcessTouchEvents() { }

	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	private void ReleaseMouse(PointerEventData pointerEvent, GameObject currentOverGo) { }

	private void ReleasePointerDrags() { }

	protected bool SendMoveEventToSelectedObject() { }

	protected bool SendSubmitEventToSelectedObject() { }

	protected bool SendUpdateEventToSelectedObject() { }

	public void set_allowActivationOnMobileDevice(bool value) { }

	public void set_cancelButton(string value) { }

	public void set_forceModuleActive(bool value) { }

	public void set_horizontalAxis(string value) { }

	public void set_inputActionsPerSecond(float value) { }

	public void set_repeatDelay(float value) { }

	public void set_submitButton(string value) { }

	public void set_verticalAxis(string value) { }

	public virtual bool ShouldActivateModule() { }

	private bool ShouldIgnoreEventsOnNoFocus() { }

	public virtual void UpdateModule() { }

}

