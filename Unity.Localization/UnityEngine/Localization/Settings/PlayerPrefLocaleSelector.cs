namespace UnityEngine.Localization.Settings;

public class PlayerPrefLocaleSelector : IStartupLocaleSelector, IInitialize
{
	[SerializeField]
	private string m_PlayerPreferenceKey; //Field offset: 0x8

	public string PlayerPreferenceKey
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public PlayerPrefLocaleSelector() { }

	public string get_PlayerPreferenceKey() { }

	public override Locale GetStartupLocale(ILocalesProvider availableLocales) { }

	public override void PostInitialization(LocalizationSettings settings) { }

	public void set_PlayerPreferenceKey(string value) { }

}

