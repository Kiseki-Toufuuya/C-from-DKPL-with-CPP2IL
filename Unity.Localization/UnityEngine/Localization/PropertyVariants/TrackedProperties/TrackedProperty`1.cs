namespace UnityEngine.Localization.PropertyVariants.TrackedProperties;

public class TrackedProperty : ITrackedPropertyValue<TPrimitive>, ITrackedProperty, IStringProperty, ISerializationCallbackReceiver, ITrackedPropertyRemoveVariant
{
	public class LocaleIdentifierValuePair
	{
		public LocaleIdentifier localeIdentifier; //Field offset: 0x0
		public TPrimitive value; //Field offset: 0x0

		public LocaleIdentifierValuePair() { }

	}

	[SerializeField]
	private string m_PropertyPath; //Field offset: 0x0
	[SerializeField]
	private List<LocaleIdentifierValuePair<TPrimitive>> m_VariantData; //Field offset: 0x0
	internal Dictionary<LocaleIdentifier, LocaleIdentifierValuePair<TPrimitive>> m_VariantLookup; //Field offset: 0x0

	public override string PropertyPath
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public TrackedProperty`1() { }

	protected override TPrimitive ConvertFromString(string value) { }

	protected override string ConvertToString(TPrimitive value) { }

	public override string get_PropertyPath() { }

	public override bool GetValue(LocaleIdentifier localeIdentifier, out TPrimitive foundValue) { }

	public override bool GetValue(LocaleIdentifier localeIdentifier, LocaleIdentifier fallback, out TPrimitive foundValue) { }

	public override string GetValueAsString(LocaleIdentifier localeIdentifier) { }

	public override string GetValueAsString(LocaleIdentifier localeIdentifier, LocaleIdentifier fallback) { }

	public override bool HasVariant(LocaleIdentifier localeIdentifier) { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

	public override void RemoveVariant(LocaleIdentifier localeIdentifier) { }

	public override void set_PropertyPath(string value) { }

	public override void SetValue(LocaleIdentifier localeIdentifier, TPrimitive value) { }

	public override void SetValueFromString(LocaleIdentifier localeIdentifier, string stringValue) { }

	public virtual string ToString() { }

}

