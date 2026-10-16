namespace UnityEngine.InputSystem;

[AddComponentMenu("Input/Player Input")]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.18/manual/PlayerInput.html")]
public class PlayerInput : MonoBehaviour
{
	internal class ActionEvent : UnityEvent<CallbackContext>
	{
		[SerializeField]
		private string m_ActionId; //Field offset: 0x18
		[SerializeField]
		private string m_ActionName; //Field offset: 0x1C

		public string actionId
		{
			 get { } //Length: 11
		}

		public string actionName
		{
			 get { } //Length: 11
		}

		public ActionEvent() { }

		public ActionEvent(InputAction action) { }

		public ActionEvent(Guid actionGUID, string name = null) { }

		public string get_actionId() { }

		public string get_actionName() { }

	}

	internal class ControlsChangedEvent : UnityEvent<PlayerInput>
	{

		public ControlsChangedEvent() { }

	}

	internal class DeviceLostEvent : UnityEvent<PlayerInput>
	{

		public DeviceLostEvent() { }

	}

	internal class DeviceRegainedEvent : UnityEvent<PlayerInput>
	{

		public DeviceRegainedEvent() { }

	}

	public const string DeviceLostMessage = "OnDeviceLost"; //Field offset: 0x0
	public const string DeviceRegainedMessage = "OnDeviceRegained"; //Field offset: 0x0
	public const string ControlsChangedMessage = "OnControlsChanged"; //Field offset: 0x0
	internal static int s_AllActivePlayersCount; //Field offset: 0x0
	internal static PlayerInput[] s_AllActivePlayers; //Field offset: 0x4
	private static Action<InputUser, InputUserChange, InputDevice> s_UserChangeDelegate; //Field offset: 0x8
	private static int s_InitPairWithDevicesCount; //Field offset: 0xC
	private static InputDevice[] s_InitPairWithDevices; //Field offset: 0x10
	private static int s_InitPlayerIndex; //Field offset: 0x14
	private static int s_InitSplitScreenIndex; //Field offset: 0x18
	private static string s_InitControlScheme; //Field offset: 0x1C
	internal static bool s_DestroyIfDeviceSetupUnsuccessful; //Field offset: 0x20
	private int m_AllMapsHashCode; //Field offset: 0x10
	[SerializeField]
	[Tooltip("Input actions associated with the player.")]
	internal InputActionAsset m_Actions; //Field offset: 0x14
	[SerializeField]
	[Tooltip("Determine how notifications should be sent when an input-related event associated with the player happens.")]
	internal PlayerNotifications m_NotificationBehavior; //Field offset: 0x18
	[SerializeField]
	[Tooltip("UI InputModule that should have it's input actions synchronized to this PlayerInput's actions.")]
	internal InputSystemUIInputModule m_UIInputModule; //Field offset: 0x1C
	[SerializeField]
	[Tooltip("Event that is triggered when the PlayerInput loses a paired device (e.g. its battery runs out).")]
	internal DeviceLostEvent m_DeviceLostEvent; //Field offset: 0x20
	[SerializeField]
	internal DeviceRegainedEvent m_DeviceRegainedEvent; //Field offset: 0x24
	[SerializeField]
	internal ControlsChangedEvent m_ControlsChangedEvent; //Field offset: 0x28
	[SerializeField]
	internal ActionEvent[] m_ActionEvents; //Field offset: 0x2C
	[SerializeField]
	internal bool m_NeverAutoSwitchControlSchemes; //Field offset: 0x30
	[SerializeField]
	internal string m_DefaultControlScheme; //Field offset: 0x34
	[SerializeField]
	internal string m_DefaultActionMap; //Field offset: 0x38
	[SerializeField]
	internal int m_SplitScreenIndex; //Field offset: 0x3C
	[SerializeField]
	[Tooltip("Reference to the player's view camera. Note that this is only required when using split-screen and/or per-player UIs. Otherwise it is safe to leave this property uninitialized.")]
	internal Camera m_Camera; //Field offset: 0x40
	private InputValue m_InputValueObject; //Field offset: 0x44
	internal InputActionMap m_CurrentActionMap; //Field offset: 0x48
	private int m_PlayerIndex; //Field offset: 0x4C
	private bool m_InputActive; //Field offset: 0x50
	private bool m_Enabled; //Field offset: 0x51
	internal bool m_ActionsInitialized; //Field offset: 0x52
	private Dictionary<String, String> m_ActionMessageNames; //Field offset: 0x54
	private InputUser m_InputUser; //Field offset: 0x58
	private Action<CallbackContext> m_ActionTriggeredDelegate; //Field offset: 0x5C
	private CallbackArray<Action`1<PlayerInput>> m_DeviceLostCallbacks; //Field offset: 0x60
	private CallbackArray<Action`1<PlayerInput>> m_DeviceRegainedCallbacks; //Field offset: 0x88
	private CallbackArray<Action`1<PlayerInput>> m_ControlsChangedCallbacks; //Field offset: 0xB0
	private CallbackArray<Action`1<CallbackContext>> m_ActionTriggeredCallbacks; //Field offset: 0xD8
	private Action<InputControl, InputEventPtr> m_UnpairedDeviceUsedDelegate; //Field offset: 0x100
	private Func<InputDevice, InputEventPtr, Boolean> m_PreFilterUnpairedDeviceUsedDelegate; //Field offset: 0x104
	private bool m_OnUnpairedDeviceUsedHooked; //Field offset: 0x108
	private Action<InputDevice, InputDeviceChange> m_DeviceChangeDelegate; //Field offset: 0x10C
	private bool m_OnDeviceChangeHooked; //Field offset: 0x110

	public event Action<CallbackContext> onActionTriggered
	{
		 add { } //Length: 130
		 remove { } //Length: 130
	}

	public event Action<PlayerInput> onControlsChanged
	{
		 add { } //Length: 130
		 remove { } //Length: 130
	}

	public event Action<PlayerInput> onDeviceLost
	{
		 add { } //Length: 128
		 remove { } //Length: 128
	}

	public event Action<PlayerInput> onDeviceRegained
	{
		 add { } //Length: 130
		 remove { } //Length: 130
	}

	public ReadOnlyArray<ActionEvent> actionEvents
	{
		 get { } //Length: 82
		 set { } //Length: 104
	}

	public InputActionAsset actions
	{
		 get { } //Length: 65
		 set { } //Length: 283
	}

	[Obsolete("Use inputIsActive instead.")]
	public bool active
	{
		 get { } //Length: 11
	}

	public static ReadOnlyArray<PlayerInput> all
	{
		 get { } //Length: 119
	}

	public Camera camera
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public ControlsChangedEvent controlsChangedEvent
	{
		 get { } //Length: 123
	}

	public InputActionMap currentActionMap
	{
		 get { } //Length: 11
		 set { } //Length: 88
	}

	public string currentControlScheme
	{
		 get { } //Length: 168
	}

	public string defaultActionMap
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public string defaultControlScheme
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public DeviceLostEvent deviceLostEvent
	{
		 get { } //Length: 123
	}

	public DeviceRegainedEvent deviceRegainedEvent
	{
		 get { } //Length: 123
	}

	public ReadOnlyArray<InputDevice> devices
	{
		 get { } //Length: 164
	}

	public bool hasMissingRequiredDevices
	{
		 get { } //Length: 126
	}

	public bool inputIsActive
	{
		 get { } //Length: 11
	}

	public static bool isSinglePlayer
	{
		 get { } //Length: 212
	}

	public bool neverAutoSwitchControlSchemes
	{
		 get { } //Length: 11
		 set { } //Length: 70
	}

	public PlayerNotifications notificationBehavior
	{
		 get { } //Length: 11
		 set { } //Length: 57
	}

	public int playerIndex
	{
		 get { } //Length: 11
	}

	public int splitScreenIndex
	{
		 get { } //Length: 11
	}

	public InputSystemUIInputModule uiInputModule
	{
		 get { } //Length: 11
		 set { } //Length: 333
	}

	public InputUser user
	{
		 get { } //Length: 11
	}

	private static PlayerInput() { }

	public PlayerInput() { }

	public void ActivateInput() { }

	public void add_onActionTriggered(Action<CallbackContext> value) { }

	public void add_onControlsChanged(Action<PlayerInput> value) { }

	public void add_onDeviceLost(Action<PlayerInput> value) { }

	public void add_onDeviceRegained(Action<PlayerInput> value) { }

	private void AssignPlayerIndex() { }

	private void AssignUserAndDevices() { }

	private void CacheMessageNames() { }

	private void ClearCaches() { }

	private void CopyActionAssetAndApplyBindingOverrides() { }

	public void DeactivateInput() { }

	public void DebugLogAction(CallbackContext context) { }

	private static PlayerInput DoInstantiate(GameObject prefab) { }

	public static PlayerInput FindFirstPairedToDevice(InputDevice device) { }

	public ReadOnlyArray<ActionEvent> get_actionEvents() { }

	public InputActionAsset get_actions() { }

	public bool get_active() { }

	public static ReadOnlyArray<PlayerInput> get_all() { }

	public Camera get_camera() { }

	public ControlsChangedEvent get_controlsChangedEvent() { }

	public InputActionMap get_currentActionMap() { }

	public string get_currentControlScheme() { }

	public string get_defaultActionMap() { }

	public string get_defaultControlScheme() { }

	public DeviceLostEvent get_deviceLostEvent() { }

	public DeviceRegainedEvent get_deviceRegainedEvent() { }

	public ReadOnlyArray<InputDevice> get_devices() { }

	public bool get_hasMissingRequiredDevices() { }

	public bool get_inputIsActive() { }

	public static bool get_isSinglePlayer() { }

	public bool get_neverAutoSwitchControlSchemes() { }

	public PlayerNotifications get_notificationBehavior() { }

	public int get_playerIndex() { }

	public int get_splitScreenIndex() { }

	public InputSystemUIInputModule get_uiInputModule() { }

	public InputUser get_user() { }

	public TDevice GetDevice() { }

	public static PlayerInput GetPlayerByIndex(int playerIndex) { }

	private void HandleControlsChanged() { }

	private void HandleDeviceLost() { }

	private void HandleDeviceRegained() { }

	private bool HaveBindingForDevice(InputDevice device) { }

	private void InitializeActions() { }

	private void InstallOnActionTriggeredHook() { }

	public static PlayerInput Instantiate(GameObject prefab, int playerIndex = -1, string controlScheme = null, int splitScreenIndex = -1, InputDevice[] pairWithDevices) { }

	public static PlayerInput Instantiate(GameObject prefab, int playerIndex = -1, string controlScheme = null, int splitScreenIndex = -1, InputDevice pairWithDevice = null) { }

	private void OnActionTriggered(CallbackContext context) { }

	private void OnDeviceChange(InputDevice device, InputDeviceChange change) { }

	private void OnDisable() { }

	private void OnEnable() { }

	private static bool OnPreFilterUnpairedDeviceUsed(InputDevice device, InputEventPtr eventPtr) { }

	private void OnUnpairedDeviceUsed(InputControl control, InputEventPtr eventPtr) { }

	private static void OnUserChange(InputUser user, InputUserChange change, InputDevice device) { }

	[Obsolete("Use DeactivateInput instead.")]
	public void PassivateInput() { }

	public void remove_onActionTriggered(Action<CallbackContext> value) { }

	public void remove_onControlsChanged(Action<PlayerInput> value) { }

	public void remove_onDeviceLost(Action<PlayerInput> value) { }

	public void remove_onDeviceRegained(Action<PlayerInput> value) { }

	public void set_actionEvents(ReadOnlyArray<ActionEvent> value) { }

	public void set_actions(InputActionAsset value) { }

	public void set_camera(Camera value) { }

	public void set_currentActionMap(InputActionMap value) { }

	public void set_defaultActionMap(string value) { }

	public void set_defaultControlScheme(string value) { }

	public void set_neverAutoSwitchControlSchemes(bool value) { }

	public void set_notificationBehavior(PlayerNotifications value) { }

	public void set_uiInputModule(InputSystemUIInputModule value) { }

	private void StartListeningForDeviceChanges() { }

	private void StartListeningForUnpairedDeviceActivity() { }

	private void StopListeningForDeviceChanges() { }

	private void StopListeningForUnpairedDeviceActivity() { }

	private void SwitchControlSchemeInternal(ref InputControlScheme controlScheme, InputDevice[] devices) { }

	public void SwitchCurrentActionMap(string mapNameOrId) { }

	public void SwitchCurrentControlScheme(string controlScheme, InputDevice[] devices) { }

	public bool SwitchCurrentControlScheme(InputDevice[] devices) { }

	private bool TryToActivateControlScheme(InputControlScheme controlScheme) { }

	private void UnassignUserAndDevices() { }

	private void UninitializeActions() { }

	private void UninstallOnActionTriggeredHook() { }

	private void UpdateDelegates() { }

}

