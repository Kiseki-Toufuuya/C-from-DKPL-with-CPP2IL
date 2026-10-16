namespace UnityEngine.Localization;

[UxmlObject]
public abstract class LocalizedReference : CustomBinding, ISerializationCallbackReceiver
{
	[CompilerGenerated]
	internal abstract class UxmlSerializedData : UxmlSerializedData
	{
		[SerializeField]
		[UxmlAttribute("table")]
		private TableReference TableReferenceUXML; //Field offset: 0x18
		[SerializeField]
		[UxmlAttribute("entry")]
		private TableEntryReference TableEntryReferenceUXML; //Field offset: 0x38
		[SerializeField]
		[UxmlAttribute("fallback")]
		private FallbackBehavior FallbackStateUXML; //Field offset: 0x50
		[HideInInspector]
		[SerializeField]
		[UxmlIgnore]
		private UxmlAttributeFlags TableReferenceUXML_UxmlAttributeFlags; //Field offset: 0x54
		[HideInInspector]
		[SerializeField]
		[UxmlIgnore]
		private UxmlAttributeFlags TableEntryReferenceUXML_UxmlAttributeFlags; //Field offset: 0x55
		[HideInInspector]
		[SerializeField]
		[UxmlIgnore]
		private UxmlAttributeFlags FallbackStateUXML_UxmlAttributeFlags; //Field offset: 0x56

		protected UxmlSerializedData() { }

		public virtual void Deserialize(object obj) { }

		[Conditional("UNITY_EDITOR")]
		[RegisterUxmlCache]
		public static void Register() { }

	}

	[SerializeField]
	private TableReference m_TableReference; //Field offset: 0x14
	[SerializeField]
	private TableEntryReference m_TableEntryReference; //Field offset: 0x30
	[SerializeField]
	private FallbackBehavior m_FallbackState; //Field offset: 0x48
	[SerializeField]
	private bool m_WaitForCompletion; //Field offset: 0x4C
	internal Locale m_LocaleOverride; //Field offset: 0x50
	private int m_ActivatedCount; //Field offset: 0x54

	public FallbackBehavior FallbackState
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[UxmlAttribute("fallback")]
	internal FallbackBehavior FallbackStateUXML
	{
		internal get { } //Length: 11
		internal set { } //Length: 14
	}

	internal abstract bool ForceSynchronous
	{
		internal get { } //Length: 0
	}

	public bool IsEmpty
	{
		 get { } //Length: 120
	}

	public Locale LocaleOverride
	{
		 get { } //Length: 11
		 set { } //Length: 118
	}

	public TableEntryReference TableEntryReference
	{
		 get { } //Length: 28
		 set { } //Length: 141
	}

	[UxmlAttribute("entry")]
	internal TableEntryReference TableEntryReferenceUXML
	{
		internal get { } //Length: 28
		internal set { } //Length: 40
	}

	public TableReference TableReference
	{
		 get { } //Length: 34
		 set { } //Length: 185
	}

	[UxmlAttribute("table")]
	internal TableReference TableReferenceUXML
	{
		internal get { } //Length: 34
		internal set { } //Length: 46
	}

	public override bool WaitForCompletion
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public LocalizedReference() { }

	protected abstract void Cleanup() { }

	internal BindingResult CreateErrorResult(in BindingContext context, VisitReturnCode errorCode, Type sourceType) { }

	protected private abstract void ForceUpdate() { }

	public FallbackBehavior get_FallbackState() { }

	internal FallbackBehavior get_FallbackStateUXML() { }

	internal abstract bool get_ForceSynchronous() { }

	public bool get_IsEmpty() { }

	public Locale get_LocaleOverride() { }

	public TableEntryReference get_TableEntryReference() { }

	internal TableEntryReference get_TableEntryReferenceUXML() { }

	public TableReference get_TableReference() { }

	internal TableReference get_TableReferenceUXML() { }

	public override bool get_WaitForCompletion() { }

	protected abstract void Initialize() { }

	protected virtual void OnActivated(in BindingActivationContext context) { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

	protected virtual void OnDeactivated(in BindingActivationContext context) { }

	protected abstract void Reset() { }

	public void set_FallbackState(FallbackBehavior value) { }

	internal void set_FallbackStateUXML(FallbackBehavior value) { }

	public void set_LocaleOverride(Locale value) { }

	public void set_TableEntryReference(TableEntryReference value) { }

	internal void set_TableEntryReferenceUXML(TableEntryReference value) { }

	public void set_TableReference(TableReference value) { }

	internal void set_TableReferenceUXML(TableReference value) { }

	public override void set_WaitForCompletion(bool value) { }

	public void SetReference(TableReference table, TableEntryReference entry) { }

	public virtual string ToString() { }

}

