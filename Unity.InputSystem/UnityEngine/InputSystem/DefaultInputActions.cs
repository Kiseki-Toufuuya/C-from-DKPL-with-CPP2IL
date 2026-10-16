namespace UnityEngine.InputSystem;

public class DefaultInputActions : IInputActionCollection2, IInputActionCollection, IEnumerable<InputAction>, IEnumerable, IDisposable
{
	internal interface IPlayerActions
	{

		public void OnFire(CallbackContext context) { }

		public void OnLook(CallbackContext context) { }

		public void OnMove(CallbackContext context) { }

	}

	internal interface IUIActions
	{

		public void OnCancel(CallbackContext context) { }

		public void OnClick(CallbackContext context) { }

		public void OnMiddleClick(CallbackContext context) { }

		public void OnNavigate(CallbackContext context) { }

		public void OnPoint(CallbackContext context) { }

		public void OnRightClick(CallbackContext context) { }

		public void OnScrollWheel(CallbackContext context) { }

		public void OnSubmit(CallbackContext context) { }

		public void OnTrackedDeviceOrientation(CallbackContext context) { }

		public void OnTrackedDevicePosition(CallbackContext context) { }

	}

	internal struct PlayerActions
	{
		private DefaultInputActions m_Wrapper; //Field offset: 0x0

		public bool enabled
		{
			 get { } //Length: 40
		}

		public InputAction Fire
		{
			 get { } //Length: 22
		}

		public InputAction Look
		{
			 get { } //Length: 22
		}

		public InputAction Move
		{
			 get { } //Length: 22
		}

		public PlayerActions(DefaultInputActions wrapper) { }

		public void Disable() { }

		public void Enable() { }

		public InputActionMap Get() { }

		public bool get_enabled() { }

		public InputAction get_Fire() { }

		public InputAction get_Look() { }

		public InputAction get_Move() { }

		public static InputActionMap op_Implicit(PlayerActions set) { }

		public void SetCallbacks(IPlayerActions instance) { }

	}

	internal struct UIActions
	{
		private DefaultInputActions m_Wrapper; //Field offset: 0x0

		public InputAction Cancel
		{
			 get { } //Length: 22
		}

		public InputAction Click
		{
			 get { } //Length: 22
		}

		public bool enabled
		{
			 get { } //Length: 40
		}

		public InputAction MiddleClick
		{
			 get { } //Length: 22
		}

		public InputAction Navigate
		{
			 get { } //Length: 22
		}

		public InputAction Point
		{
			 get { } //Length: 22
		}

		public InputAction RightClick
		{
			 get { } //Length: 22
		}

		public InputAction ScrollWheel
		{
			 get { } //Length: 22
		}

		public InputAction Submit
		{
			 get { } //Length: 22
		}

		public InputAction TrackedDeviceOrientation
		{
			 get { } //Length: 22
		}

		public InputAction TrackedDevicePosition
		{
			 get { } //Length: 22
		}

		public UIActions(DefaultInputActions wrapper) { }

		public void Disable() { }

		public void Enable() { }

		public InputActionMap Get() { }

		public InputAction get_Cancel() { }

		public InputAction get_Click() { }

		public bool get_enabled() { }

		public InputAction get_MiddleClick() { }

		public InputAction get_Navigate() { }

		public InputAction get_Point() { }

		public InputAction get_RightClick() { }

		public InputAction get_ScrollWheel() { }

		public InputAction get_Submit() { }

		public InputAction get_TrackedDeviceOrientation() { }

		public InputAction get_TrackedDevicePosition() { }

		public static InputActionMap op_Implicit(UIActions set) { }

		public void SetCallbacks(IUIActions instance) { }

	}

	[CompilerGenerated]
	private readonly InputActionAsset <asset>k__BackingField; //Field offset: 0x8
	private readonly InputActionMap m_Player; //Field offset: 0xC
	private IPlayerActions m_PlayerActionsCallbackInterface; //Field offset: 0x10
	private readonly InputAction m_Player_Move; //Field offset: 0x14
	private readonly InputAction m_Player_Look; //Field offset: 0x18
	private readonly InputAction m_Player_Fire; //Field offset: 0x1C
	private readonly InputActionMap m_UI; //Field offset: 0x20
	private IUIActions m_UIActionsCallbackInterface; //Field offset: 0x24
	private readonly InputAction m_UI_Navigate; //Field offset: 0x28
	private readonly InputAction m_UI_Submit; //Field offset: 0x2C
	private readonly InputAction m_UI_Cancel; //Field offset: 0x30
	private readonly InputAction m_UI_Point; //Field offset: 0x34
	private readonly InputAction m_UI_Click; //Field offset: 0x38
	private readonly InputAction m_UI_ScrollWheel; //Field offset: 0x3C
	private readonly InputAction m_UI_MiddleClick; //Field offset: 0x40
	private readonly InputAction m_UI_RightClick; //Field offset: 0x44
	private readonly InputAction m_UI_TrackedDevicePosition; //Field offset: 0x48
	private readonly InputAction m_UI_TrackedDeviceOrientation; //Field offset: 0x4C
	private int m_KeyboardMouseSchemeIndex; //Field offset: 0x50
	private int m_GamepadSchemeIndex; //Field offset: 0x54
	private int m_TouchSchemeIndex; //Field offset: 0x58
	private int m_JoystickSchemeIndex; //Field offset: 0x5C
	private int m_XRSchemeIndex; //Field offset: 0x60

	public InputActionAsset asset
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public override Nullable<InputBinding> bindingMask
	{
		 get { } //Length: 46
		 set { } //Length: 59
	}

	public override IEnumerable<InputBinding> bindings
	{
		 get { } //Length: 34
	}

	public override ReadOnlyArray<InputControlScheme> controlSchemes
	{
		 get { } //Length: 59
	}

	public override Nullable<ReadOnlyArray`1<InputDevice>> devices
	{
		 get { } //Length: 49
		 set { } //Length: 43
	}

	public InputControlScheme GamepadScheme
	{
		 get { } //Length: 185
	}

	public InputControlScheme JoystickScheme
	{
		 get { } //Length: 185
	}

	public InputControlScheme KeyboardMouseScheme
	{
		 get { } //Length: 185
	}

	public PlayerActions Player
	{
		 get { } //Length: 27
	}

	public InputControlScheme TouchScheme
	{
		 get { } //Length: 185
	}

	public UIActions UI
	{
		 get { } //Length: 27
	}

	public InputControlScheme XRScheme
	{
		 get { } //Length: 185
	}

	public DefaultInputActions() { }

	public override bool Contains(InputAction action) { }

	public override void Disable() { }

	public override void Dispose() { }

	public override void Enable() { }

	public override InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false) { }

	public override int FindBinding(InputBinding bindingMask, out InputAction action) { }

	[CompilerGenerated]
	public InputActionAsset get_asset() { }

	public override Nullable<InputBinding> get_bindingMask() { }

	public override IEnumerable<InputBinding> get_bindings() { }

	public override ReadOnlyArray<InputControlScheme> get_controlSchemes() { }

	public override Nullable<ReadOnlyArray`1<InputDevice>> get_devices() { }

	public InputControlScheme get_GamepadScheme() { }

	public InputControlScheme get_JoystickScheme() { }

	public InputControlScheme get_KeyboardMouseScheme() { }

	public PlayerActions get_Player() { }

	public InputControlScheme get_TouchScheme() { }

	public UIActions get_UI() { }

	public InputControlScheme get_XRScheme() { }

	public override IEnumerator<InputAction> GetEnumerator() { }

	public override void set_bindingMask(Nullable<InputBinding> value) { }

	public override void set_devices(Nullable<ReadOnlyArray`1<InputDevice>> value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

