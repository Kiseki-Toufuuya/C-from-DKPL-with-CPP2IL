namespace UnityEngine.Localization.Settings;

public class SystemLocaleSelector : IStartupLocaleSelector
{

	public SystemLocaleSelector() { }

	private static Locale FindLocaleOrFallback(LocaleIdentifier localeIdentifier, ILocalesProvider availableLocales) { }

	protected override SystemLanguage GetApplicationSystemLanguage() { }

	public override Locale GetStartupLocale(ILocalesProvider availableLocales) { }

	protected override CultureInfo GetSystemCulture() { }

}

