namespace UnityEngine.Localization.PropertyVariants.TrackedProperties;

public class UnityObjectProperty : ITrackedPropertyValue<Object>, ITrackedProperty, ISerializationCallbackReceiver
{
	public class LocaleIdentifierValuePair
	{
		public LocaleIdentifier localeIdentifier; //Field offset: 0x8
		public LazyLoadReference<Object> value; //Field offset: 0x10

		public LocaleIdentifierValuePair() { }

	}

	[SerializeField]
	private string m_PropertyPath; //Field offset: 0x8
	[SerializeField]
	private string m_TypeString; //Field offset: 0xC
	[SerializeField]
	private List<LocaleIdentifierValuePair> m_VariantData; //Field offset: 0x10
	internal Dictionary<LocaleIdentifier, LocaleIdentifierValuePair> m_VariantLookup; //Field offset: 0x14
	[CompilerGenerated]
	private Type <PropertyType>k__BackingField; //Field offset: 0x18

	public override string PropertyPath
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public Type PropertyType
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public UnityObjectProperty() { }

	public override string get_PropertyPath() { }

	[CompilerGenerated]
	public Type get_PropertyType() { }

	public override bool GetValue(LocaleIdentifier localeIdentifier, out object foundValue) { }

	public override bool GetValue(LocaleIdentifier localeIdentifier, LocaleIdentifier fallback, out object foundValue) { }

	public override bool HasVariant(LocaleIdentifier localeIdentifier) { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

	public void RemoveVariant(LocaleIdentifier localeIdentifier) { }

	public override void set_PropertyPath(string value) { }

	[CompilerGenerated]
	public void set_PropertyType(Type value) { }

	public override void SetValue(LocaleIdentifier localeIdentifier, object newValue) { }

}

