namespace UnityEngine.Localization.Settings;

public interface ILocalesProvider
{

	public List<Locale> Locales
	{
		 get { } //Length: 0
	}

	public void AddLocale(Locale locale) { }

	public List<Locale> get_Locales() { }

	public Locale GetLocale(LocaleIdentifier id) { }

	public bool RemoveLocale(Locale locale) { }

}

