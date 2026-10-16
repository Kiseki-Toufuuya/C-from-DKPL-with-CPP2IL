namespace UnityEngine.InputSystem;

[DebuggerDisplay("{DebuggerDisplay(),nq}")]
[DefaultMember("Item")]
public abstract class InputControl
{
	[Flags]
	public enum ControlFlags
	{
		ConfigUpToDate = 1,
		IsNoisy = 2,
		IsSynthetic = 4,
		IsButton = 8,
		DontReset = 16,
		SetupFinished = 32,
		UsesStateFromOtherControl = 64,
	}

	protected private InputStateBlock m_StateBlock; //Field offset: 0x8
	internal InternedString m_Name; //Field offset: 0x18
	internal string m_Path; //Field offset: 0x20
	internal string m_DisplayName; //Field offset: 0x24
	internal string m_DisplayNameFromLayout; //Field offset: 0x28
	internal string m_ShortDisplayName; //Field offset: 0x2C
	internal string m_ShortDisplayNameFromLayout; //Field offset: 0x30
	internal InternedString m_Layout; //Field offset: 0x34
	internal InternedString m_Variants; //Field offset: 0x3C
	internal InputDevice m_Device; //Field offset: 0x44
	internal InputControl m_Parent; //Field offset: 0x48
	internal int m_UsageCount; //Field offset: 0x4C
	internal int m_UsageStartIndex; //Field offset: 0x50
	internal int m_AliasCount; //Field offset: 0x54
	internal int m_AliasStartIndex; //Field offset: 0x58
	internal int m_ChildCount; //Field offset: 0x5C
	internal int m_ChildStartIndex; //Field offset: 0x60
	internal ControlFlags m_ControlFlags; //Field offset: 0x64
	internal bool m_CachedValueIsStale; //Field offset: 0x68
	internal bool m_UnprocessedCachedValueIsStale; //Field offset: 0x69
	internal PrimitiveValue m_DefaultState; //Field offset: 0x70
	internal PrimitiveValue m_MinValue; //Field offset: 0x80
	internal PrimitiveValue m_MaxValue; //Field offset: 0x90
	internal FourCC m_OptimizedControlDataType; //Field offset: 0xA0

	public ReadOnlyArray<InternedString> aliases
	{
		 get { } //Length: 100
	}

	public ReadOnlyArray<InputControl> children
	{
		 get { } //Length: 100
	}

	protected private Void* currentStatePtr
	{
		private get { } //Length: 32
	}

	protected private Void* defaultStatePtr
	{
		private get { } //Length: 40
	}

	public InputDevice device
	{
		 get { } //Length: 11
	}

	public string displayName
	{
		 get { } //Length: 80
		 set { } //Length: 27
	}

	internal bool dontReset
	{
		internal get { } //Length: 16
		internal set { } //Length: 29
	}

	internal bool hasDefaultState
	{
		internal get { } //Length: 24
	}

	internal bool isButton
	{
		internal get { } //Length: 16
		internal set { } //Length: 29
	}

	internal bool isConfigUpToDate
	{
		internal get { } //Length: 13
		internal set { } //Length: 29
	}

	internal bool isSetupFinished
	{
		internal get { } //Length: 16
		internal set { } //Length: 29
	}

	public InputControl Item
	{
		 get { } //Length: 138
	}

	public string layout
	{
		 get { } //Length: 24
	}

	public float magnitude
	{
		 get { } //Length: 51
	}

	public string name
	{
		 get { } //Length: 24
	}

	protected private Void* noiseMaskPtr
	{
		private get { } //Length: 41
	}

	public internal bool noisy
	{
		 get { } //Length: 15
		internal set { } //Length: 203
	}

	public FourCC optimizedControlDataType
	{
		 get { } //Length: 14
	}

	public InputControl parent
	{
		 get { } //Length: 11
	}

	public string path
	{
		 get { } //Length: 217
	}

	protected private Void* previousFrameStatePtr
	{
		private get { } //Length: 32
	}

	public string shortDisplayName
	{
		 get { } //Length: 66
		 set { } //Length: 27
	}

	public InputStateBlock stateBlock
	{
		 get { } //Length: 18
	}

	protected private uint stateOffsetRelativeToDeviceRoot
	{
		private get { } //Length: 79
	}

	public internal bool synthetic
	{
		 get { } //Length: 15
		internal set { } //Length: 29
	}

	public ReadOnlyArray<InternedString> usages
	{
		 get { } //Length: 100
	}

	internal bool usesStateFromOtherControl
	{
		internal get { } //Length: 16
		internal set { } //Length: 29
	}

	public abstract int valueSizeInBytes
	{
		 get { } //Length: 0
	}

	public abstract Type valueType
	{
		 get { } //Length: 0
	}

	public string variants
	{
		 get { } //Length: 24
	}

	protected InputControl() { }

	internal override void AddProcessor(object first) { }

	public void ApplyParameterChanges() { }

	internal void BakeOffsetIntoStateBlockRecursive(uint offset) { }

	protected override FourCC CalculateOptimizedControlDataType() { }

	internal void CallFinishSetupRecursive() { }

	public abstract bool CompareValue(Void* firstStatePtr, Void* secondStatePtr) { }

	private string DebuggerDisplay() { }

	[Conditional("UNITY_EDITOR")]
	internal void EnsureOptimizationTypeHasNotChanged() { }

	public override float EvaluateMagnitude(Void* statePtr) { }

	public float EvaluateMagnitude() { }

	protected override void FinishSetup() { }

	public ReadOnlyArray<InternedString> get_aliases() { }

	public ReadOnlyArray<InputControl> get_children() { }

	protected private Void* get_currentStatePtr() { }

	protected private Void* get_defaultStatePtr() { }

	public InputDevice get_device() { }

	public string get_displayName() { }

	internal bool get_dontReset() { }

	internal bool get_hasDefaultState() { }

	internal bool get_isButton() { }

	internal bool get_isConfigUpToDate() { }

	internal bool get_isSetupFinished() { }

	public InputControl get_Item(string path) { }

	public string get_layout() { }

	public float get_magnitude() { }

	public string get_name() { }

	protected private Void* get_noiseMaskPtr() { }

	public bool get_noisy() { }

	public FourCC get_optimizedControlDataType() { }

	public InputControl get_parent() { }

	public string get_path() { }

	protected private Void* get_previousFrameStatePtr() { }

	public string get_shortDisplayName() { }

	public InputStateBlock get_stateBlock() { }

	protected private uint get_stateOffsetRelativeToDeviceRoot() { }

	public bool get_synthetic() { }

	public ReadOnlyArray<InternedString> get_usages() { }

	internal bool get_usesStateFromOtherControl() { }

	public abstract int get_valueSizeInBytes() { }

	public abstract Type get_valueType() { }

	public string get_variants() { }

	public InputControl GetChildControl(string path) { }

	public TControl GetChildControl(string path) { }

	internal int GetDeviceIndex() { }

	internal bool IsValueConsideredPressed(float value) { }

	internal string MakeChildPath(string path) { }

	internal void MarkAsStale() { }

	internal void MarkAsStaleRecursively() { }

	public abstract object ReadValueFromBufferAsObject(Void* buffer, int bufferSize) { }

	public abstract object ReadValueFromStateAsObject(Void* statePtr) { }

	public abstract void ReadValueFromStateIntoBuffer(Void* statePtr, Void* bufferPtr, int bufferSize) { }

	protected override void RefreshConfiguration() { }

	protected void RefreshConfigurationIfNeeded() { }

	protected void set_displayName(string value) { }

	internal void set_dontReset(bool value) { }

	internal void set_isButton(bool value) { }

	internal void set_isConfigUpToDate(bool value) { }

	internal void set_isSetupFinished(bool value) { }

	internal void set_noisy(bool value) { }

	protected void set_shortDisplayName(string value) { }

	internal void set_synthetic(bool value) { }

	internal void set_usesStateFromOtherControl(bool value) { }

	private void SetOptimizedControlDataType() { }

	internal void SetOptimizedControlDataTypeRecursively() { }

	public virtual string ToString() { }

	public InputControl TryGetChildControl(string path) { }

	public TControl TryGetChildControl(string path) { }

	public override void WriteValueFromBufferIntoState(Void* bufferPtr, int bufferSize, Void* statePtr) { }

	public override void WriteValueFromObjectIntoState(object value, Void* statePtr) { }

}

