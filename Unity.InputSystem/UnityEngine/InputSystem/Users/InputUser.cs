namespace UnityEngine.InputSystem.Users;

public struct InputUser : IEquatable<InputUser>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static TypedRestore<GlobalState> <>9__88_0; //Field offset: 0x4
		public static Action <>9__88_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <SaveAndResetState>b__88_0(ref GlobalState state) { }

		internal void <SaveAndResetState>b__88_1() { }

	}

	private struct CompareDevicesByUserAccount : IComparer<InputDevice>
	{
		public InputUserAccountHandle platformUserAccountHandle; //Field offset: 0x0

		public override int Compare(InputDevice x, InputDevice y) { }

		private static Nullable<InputUserAccountHandle> GetUserAccountHandleForDevice(InputDevice device) { }

	}

	internal struct ControlSchemeChangeSyntax
	{
		internal int m_UserIndex; //Field offset: 0x0

		public ControlSchemeChangeSyntax AndPairRemainingDevices() { }

	}

	private struct GlobalState
	{
		internal int pairingStateVersion; //Field offset: 0x0
		internal uint lastUserId; //Field offset: 0x4
		internal int allUserCount; //Field offset: 0x8
		internal int allPairedDeviceCount; //Field offset: 0xC
		internal int allLostDeviceCount; //Field offset: 0x10
		internal InputUser[] allUsers; //Field offset: 0x14
		internal UserData[] allUserData; //Field offset: 0x18
		internal InputDevice[] allPairedDevices; //Field offset: 0x1C
		internal InputDevice[] allLostDevices; //Field offset: 0x20
		internal InlinedArray<OngoingAccountSelection> ongoingAccountSelections; //Field offset: 0x24
		internal CallbackArray<Action`3<InputUser, InputUserChange, InputDevice>> onChange; //Field offset: 0x34
		internal CallbackArray<Action`2<InputControl, InputEventPtr>> onUnpairedDeviceUsed; //Field offset: 0x5C
		internal CallbackArray<Func`3<InputDevice, InputEventPtr, Boolean>> onPreFilterUnpairedDeviceUsed; //Field offset: 0x84
		internal Action<Object, InputActionChange> actionChangeDelegate; //Field offset: 0xAC
		internal Action<InputDevice, InputDeviceChange> onDeviceChangeDelegate; //Field offset: 0xB0
		internal Action<InputEventPtr, InputDevice> onEventDelegate; //Field offset: 0xB4
		internal bool onActionChangeHooked; //Field offset: 0xB8
		internal bool onDeviceChangeHooked; //Field offset: 0xB9
		internal bool onEventHooked; //Field offset: 0xBA
		internal int listenForUnpairedDeviceActivity; //Field offset: 0xBC

	}

	private struct OngoingAccountSelection
	{
		public InputDevice device; //Field offset: 0x0
		public uint userId; //Field offset: 0x4

	}

	private struct UserData
	{
		public Nullable<InputUserAccountHandle> platformUserAccountHandle; //Field offset: 0x0
		public string platformUserAccountName; //Field offset: 0x18
		public string platformUserAccountId; //Field offset: 0x1C
		public int deviceCount; //Field offset: 0x20
		public int deviceStartIndex; //Field offset: 0x24
		public IInputActionCollection actions; //Field offset: 0x28
		public Nullable<InputControlScheme> controlScheme; //Field offset: 0x2C
		public MatchResult controlSchemeMatch; //Field offset: 0x3C
		public int lostDeviceCount; //Field offset: 0x70
		public int lostDeviceStartIndex; //Field offset: 0x74
		public UserFlags flags; //Field offset: 0x78

	}

	[Flags]
	public enum UserFlags
	{
		BindToAllDevices = 1,
		UserAccountSelectionInProgress = 2,
	}

	public const uint InvalidId = 0; //Field offset: 0x0
	private static readonly ProfilerMarker k_InputUserOnChangeMarker; //Field offset: 0x0
	private static readonly ProfilerMarker k_InputCheckForUnpairMarker; //Field offset: 0x4
	private static GlobalState s_GlobalState; //Field offset: 0x8
	private uint m_Id; //Field offset: 0x0

	public static event Action<InputUser, InputUserChange, InputDevice> onChange
	{
		 add { } //Length: 163
		 remove { } //Length: 163
	}

	public static event Func<InputDevice, InputEventPtr, Boolean> onPrefilterUnpairedDeviceActivity
	{
		 add { } //Length: 165
		 remove { } //Length: 165
	}

	public static event Action<InputControl, InputEventPtr> onUnpairedDeviceUsed
	{
		 add { } //Length: 206
		 remove { } //Length: 230
	}

	public IInputActionCollection actions
	{
		 get { } //Length: 106
	}

	public static ReadOnlyArray<InputUser> all
	{
		 get { } //Length: 120
	}

	public Nullable<InputControlScheme> controlScheme
	{
		 get { } //Length: 113
	}

	public MatchResult controlSchemeMatch
	{
		 get { } //Length: 140
	}

	public bool hasMissingRequiredDevices
	{
		 get { } //Length: 118
	}

	public uint id
	{
		 get { } //Length: 10
	}

	public int index
	{
		 get { } //Length: 373
	}

	public static int listenForUnpairedDeviceActivity
	{
		 get { } //Length: 64
		 set { } //Length: 278
	}

	public ReadOnlyArray<InputDevice> lostDevices
	{
		 get { } //Length: 186
	}

	public ReadOnlyArray<InputDevice> pairedDevices
	{
		 get { } //Length: 181
	}

	public Nullable<InputUserAccountHandle> platformUserAccountHandle
	{
		 get { } //Length: 126
	}

	public string platformUserAccountId
	{
		 get { } //Length: 106
	}

	public string platformUserAccountName
	{
		 get { } //Length: 106
	}

	public bool valid
	{
		 get { } //Length: 156
	}

	private static InputUser() { }

	public ControlSchemeChangeSyntax ActivateControlScheme(string schemeName) { }

	public ControlSchemeChangeSyntax ActivateControlScheme(InputControlScheme scheme) { }

	private void ActivateControlSchemeInternal(int userIndex, InputControlScheme scheme) { }

	public static void add_onChange(Action<InputUser, InputUserChange, InputDevice> value) { }

	public static void add_onPrefilterUnpairedDeviceActivity(Func<InputDevice, InputEventPtr, Boolean> value) { }

	public static void add_onUnpairedDeviceUsed(Action<InputControl, InputEventPtr> value) { }

	private static void AddDeviceToUser(int userIndex, InputDevice device, bool asLostDevice = false, bool dontUpdateControlScheme = false) { }

	private static int AddUser() { }

	public void AssociateActionsWithUser(IInputActionCollection actions) { }

	public static InputUser CreateUserWithoutPairedDevices() { }

	private static void DisposeAndResetGlobalState() { }

	public override bool Equals(InputUser other) { }

	public virtual bool Equals(object obj) { }

	internal void FindControlScheme(string schemeName, out InputControlScheme scheme) { }

	private static int FindLostDevice(InputDevice device, int startIndex = 0) { }

	public static Nullable<InputUser> FindUserByAccount(InputUserAccountHandle platformUserAccountHandle) { }

	public static Nullable<InputUser> FindUserPairedToDevice(InputDevice device) { }

	public IInputActionCollection get_actions() { }

	public static ReadOnlyArray<InputUser> get_all() { }

	public Nullable<InputControlScheme> get_controlScheme() { }

	public MatchResult get_controlSchemeMatch() { }

	public bool get_hasMissingRequiredDevices() { }

	public uint get_id() { }

	public int get_index() { }

	public static int get_listenForUnpairedDeviceActivity() { }

	public ReadOnlyArray<InputDevice> get_lostDevices() { }

	public ReadOnlyArray<InputDevice> get_pairedDevices() { }

	public Nullable<InputUserAccountHandle> get_platformUserAccountHandle() { }

	public string get_platformUserAccountId() { }

	public string get_platformUserAccountName() { }

	public bool get_valid() { }

	public virtual int GetHashCode() { }

	public static InputControlList<InputDevice> GetUnpairedInputDevices() { }

	public static int GetUnpairedInputDevices(ref InputControlList<InputDevice>& list) { }

	private static void HookIntoActionChange() { }

	private static void HookIntoDeviceChange() { }

	private static void HookIntoEvents() { }

	private static bool InitiateUserAccountSelection(int userIndex, InputDevice device, InputUserPairingOptions options) { }

	private static bool InitiateUserAccountSelectionAtPlatformLevel(InputDevice device) { }

	private static void Notify(int userIndex, InputUserChange change, InputDevice device) { }

	private static void OnActionChange(object obj, InputActionChange change) { }

	private static void OnDeviceChange(InputDevice device, InputDeviceChange change) { }

	private static void OnEvent(InputEventPtr eventPtr, InputDevice device) { }

	public static bool op_Equality(InputUser left, InputUser right) { }

	public static bool op_Inequality(InputUser left, InputUser right) { }

	public static InputUser PerformPairingWithDevice(InputDevice device, InputUser user = null, InputUserPairingOptions options = 0) { }

	private static long QueryPairedPlatformUserAccount(InputDevice device, out Nullable<InputUserAccountHandle>& platformAccountHandle, out string platformAccountName, out string platformAccountId) { }

	public static void remove_onChange(Action<InputUser, InputUserChange, InputDevice> value) { }

	public static void remove_onPrefilterUnpairedDeviceActivity(Func<InputDevice, InputEventPtr, Boolean> value) { }

	public static void remove_onUnpairedDeviceUsed(Action<InputControl, InputEventPtr> value) { }

	private static void RemoveDeviceFromUser(int userIndex, InputDevice device, bool asLostDevice = false) { }

	private static void RemoveLostDevicesForUser(int userIndex) { }

	private static void RemoveUser(int userIndex) { }

	internal static void ResetGlobals() { }

	internal static ISavedState SaveAndResetState() { }

	public static void set_listenForUnpairedDeviceActivity(int value) { }

	public virtual string ToString() { }

	private bool TryFindControlScheme(string schemeName, out InputControlScheme scheme) { }

	private static int TryFindUserIndex(InputDevice device) { }

	private static int TryFindUserIndex(uint userId) { }

	private static int TryFindUserIndex(InputUserAccountHandle platformHandle) { }

	private static void UnhookFromActionChange() { }

	private static void UnhookFromDeviceChange() { }

	private static void UnhookFromDeviceStateChange() { }

	public void UnpairDevice(InputDevice device) { }

	public void UnpairDevices() { }

	public void UnpairDevicesAndRemoveUser() { }

	private static void UpdateControlSchemeMatch(int userIndex, bool autoPairMissing = false) { }

	private static long UpdatePlatformUserAccount(int userIndex, InputDevice device) { }

}

