namespace UnityEngine.Localization.PropertyVariants.TrackedProperties;

public class LocalizedStringProperty : ITrackedProperty
{
	[SerializeField]
	private LocalizedString m_Localized; //Field offset: 0x8
	[SerializeField]
	private string m_PropertyPath; //Field offset: 0xC

	public LocalizedString LocalizedString
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public override string PropertyPath
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public LocalizedStringProperty() { }

	public LocalizedString get_LocalizedString() { }

	public override string get_PropertyPath() { }

	public override bool HasVariant(LocaleIdentifier localeIdentifier) { }

	public void set_LocalizedString(LocalizedString value) { }

	public override void set_PropertyPath(string value) { }

}

