namespace UnityEngine.InputSystem;

[DefaultMember("Item")]
public class InputActionAsset : ScriptableObject, IInputActionCollection2, IInputActionCollection, IEnumerable<InputAction>, IEnumerable
{
	[CompilerGenerated]
	private sealed class <get_bindings>d__9 : IEnumerable<InputBinding>, IEnumerable, IEnumerator<InputBinding>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private InputBinding <>2__current; //Field offset: 0xC
		private int <>l__initialThreadId; //Field offset: 0x38
		public InputActionAsset <>4__this; //Field offset: 0x3C
		private int <numActionMaps>5__2; //Field offset: 0x40
		private int <i>5__3; //Field offset: 0x44
		private InputBinding[] <bindings>5__4; //Field offset: 0x48
		private int <numBindings>5__5; //Field offset: 0x4C
		private int <n>5__6; //Field offset: 0x50

		private override InputBinding System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBinding>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 42
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 92
		}

		[DebuggerHidden]
		public <get_bindings>d__9(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<InputBinding> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding>.GetEnumerator() { }

		[DebuggerHidden]
		private override InputBinding System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBinding>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <GetEnumerator>d__33 : IEnumerator<InputAction>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private InputAction <>2__current; //Field offset: 0xC
		public InputActionAsset <>4__this; //Field offset: 0x10
		private int <i>5__2; //Field offset: 0x14
		private ReadOnlyArray<InputAction> <actions>5__3; //Field offset: 0x18
		private int <actionCount>5__4; //Field offset: 0x24
		private int <n>5__5; //Field offset: 0x28

		private override InputAction System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		[DebuggerHidden]
		public <GetEnumerator>d__33(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override InputAction System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private static class JsonVersion
	{
		public const int Version0 = 0; //Field offset: 0x0
		public const int Version1 = 1; //Field offset: 0x0
		public const int Current = 1; //Field offset: 0x0

	}

	public struct ReadFileJson
	{
		public int version; //Field offset: 0x0
		public string name; //Field offset: 0x4
		public ReadMapJson[] maps; //Field offset: 0x8
		public SchemeJson[] controlSchemes; //Field offset: 0xC

		public void ToAsset(InputActionAsset asset) { }

	}

	public struct WriteFileJson
	{
		public int version; //Field offset: 0x0
		public string name; //Field offset: 0x4
		public WriteMapJson[] maps; //Field offset: 0x8
		public SchemeJson[] controlSchemes; //Field offset: 0xC

	}

	public struct WriteFileJsonNoName
	{
		public WriteMapJson[] maps; //Field offset: 0x0
		public SchemeJson[] controlSchemes; //Field offset: 0x4

	}

	public const string Extension = "inputactions"; //Field offset: 0x0
	internal const string kDefaultAssetLayoutJson = "{}"; //Field offset: 0x0
	[SerializeField]
	internal InputActionMap[] m_ActionMaps; //Field offset: 0xC
	[SerializeField]
	internal InputControlScheme[] m_ControlSchemes; //Field offset: 0x10
	[SerializeField]
	internal bool m_IsProjectWide; //Field offset: 0x14
	internal InputActionState m_SharedStateForAllMaps; //Field offset: 0x18
	internal Nullable<InputBinding> m_BindingMask; //Field offset: 0x1C
	internal int m_ParameterOverridesCount; //Field offset: 0x4C
	internal ParameterOverride[] m_ParameterOverrides; //Field offset: 0x50
	internal DeviceArray m_Devices; //Field offset: 0x54

	public ReadOnlyArray<InputActionMap> actionMaps
	{
		 get { } //Length: 77
	}

	public override Nullable<InputBinding> bindingMask
	{
		 get { } //Length: 34
		 set { } //Length: 268
	}

	public override IEnumerable<InputBinding> bindings
	{
		[IteratorStateMachine(typeof(<get_bindings>d__9))]
		 get { } //Length: 95
	}

	public override ReadOnlyArray<InputControlScheme> controlSchemes
	{
		 get { } //Length: 77
	}

	public override Nullable<ReadOnlyArray`1<InputDevice>> devices
	{
		 get { } //Length: 40
		 set { } //Length: 89
	}

	public bool enabled
	{
		 get { } //Length: 432
	}

	public InputAction Item
	{
		 get { } //Length: 105
	}

	public InputActionAsset() { }

	public override bool Contains(InputAction action) { }

	public override void Disable() { }

	public override void Enable() { }

	public override InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false) { }

	public InputAction FindAction(Guid guid) { }

	public InputActionMap FindActionMap(string nameOrId, bool throwIfNotFound = false) { }

	public InputActionMap FindActionMap(Guid id) { }

	public override int FindBinding(InputBinding mask, out InputAction action) { }

	public Nullable<InputControlScheme> FindControlScheme(string name) { }

	public int FindControlSchemeIndex(string name) { }

	public static InputActionAsset FromJson(string json) { }

	public ReadOnlyArray<InputActionMap> get_actionMaps() { }

	public override Nullable<InputBinding> get_bindingMask() { }

	[IteratorStateMachine(typeof(<get_bindings>d__9))]
	public override IEnumerable<InputBinding> get_bindings() { }

	public override ReadOnlyArray<InputControlScheme> get_controlSchemes() { }

	public override Nullable<ReadOnlyArray`1<InputDevice>> get_devices() { }

	public bool get_enabled() { }

	public InputAction get_Item(string actionNameOrId) { }

	[IteratorStateMachine(typeof(<GetEnumerator>d__33))]
	public override IEnumerator<InputAction> GetEnumerator() { }

	internal bool IsEmpty() { }

	public bool IsUsableWithDevice(InputDevice device) { }

	public void LoadFromJson(string json) { }

	internal void MarkAsDirty() { }

	internal void MigrateJson(ref ReadFileJson parsedJson) { }

	private void OnDestroy() { }

	internal void OnSetupChanged() { }

	internal void OnWantToChangeSetup() { }

	private void ReResolveIfNecessary(bool fullResolve) { }

	internal void ResolveBindingsIfNecessary() { }

	public override void set_bindingMask(Nullable<InputBinding> value) { }

	public override void set_devices(Nullable<ReadOnlyArray`1<InputDevice>> value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public string ToJson() { }

}

