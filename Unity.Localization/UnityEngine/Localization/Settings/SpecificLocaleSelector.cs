namespace UnityEngine.Localization.Settings;

public class SpecificLocaleSelector : IStartupLocaleSelector
{
	[SerializeField]
	private LocaleIdentifier m_LocaleId; //Field offset: 0x8

	public LocaleIdentifier LocaleId
	{
		 get { } //Length: 14
		 set { } //Length: 34
	}

	public SpecificLocaleSelector() { }

	public LocaleIdentifier get_LocaleId() { }

	public override Locale GetStartupLocale(ILocalesProvider availableLocales) { }

	public void set_LocaleId(LocaleIdentifier value) { }

}

