namespace UnityEngine.Localization.Settings;

public interface IStartupLocaleSelector
{

	public Locale GetStartupLocale(ILocalesProvider availableLocales) { }

}

