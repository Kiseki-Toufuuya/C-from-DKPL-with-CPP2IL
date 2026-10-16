namespace UnityEngine.UIElements;

[UxmlObject]
public abstract class Binding
{
	[ExcludeFromDocs]
	internal abstract class UxmlSerializedData : UxmlSerializedData
	{
		[HideInInspector]
		[SerializeField]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal string property; //Field offset: 0xC
		[HideInInspector]
		[SerializeField]
		[Tooltip("This informs the binding system of whether the binding object should be updated on every frame, when a change occurs in the source or on every frame if change detection is impossible, and when explicitly marked as dirty.")]
		private BindingUpdateTrigger updateTrigger; //Field offset: 0x10
		[HideInInspector]
		[SerializeField]
		[UxmlIgnore]
		private UxmlAttributeFlags property_UxmlAttributeFlags; //Field offset: 0x14
		[HideInInspector]
		[SerializeField]
		[UxmlIgnore]
		private UxmlAttributeFlags updateTrigger_UxmlAttributeFlags; //Field offset: 0x15

		protected UxmlSerializedData() { }

		public virtual void Deserialize(object obj) { }

	}

	internal const string k_UpdateTriggerTooltip = "This informs the binding system of whether the binding object should be updated on every frame, when a change occurs in the source or on every frame if change detection is impossible, and when explicitly marked as dirty."; //Field offset: 0x0
	private bool m_Dirty; //Field offset: 0x8
	private BindingUpdateTrigger m_UpdateTrigger; //Field offset: 0xC
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <property>k__BackingField; //Field offset: 0x10

	public bool isDirty
	{
		 get { } //Length: 11
	}

	internal string property
	{
		[CompilerGenerated]
		internal set { } //Length: 27
	}

	[CreateProperty]
	public BindingUpdateTrigger updateTrigger
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	internal Binding() { }

	internal void ClearDirty() { }

	public bool get_isDirty() { }

	public BindingUpdateTrigger get_updateTrigger() { }

	public void MarkDirty() { }

	protected private override void OnActivated(in BindingActivationContext context) { }

	protected private override void OnDataSourceChanged(in DataSourceContextChanged context) { }

	protected private override void OnDeactivated(in BindingActivationContext context) { }

	public static void ResetPanelLogLevel(IPanel panel) { }

	[CompilerGenerated]
	internal void set_property(string value) { }

	public void set_updateTrigger(BindingUpdateTrigger value) { }

	public static void SetGlobalLogLevel(BindingLogLevel logLevel) { }

	public static void SetPanelLogLevel(IPanel panel, BindingLogLevel logLevel) { }

}

