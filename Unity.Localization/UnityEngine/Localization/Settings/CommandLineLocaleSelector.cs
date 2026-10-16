namespace UnityEngine.Localization.Settings;

public class CommandLineLocaleSelector : IStartupLocaleSelector
{
	[SerializeField]
	private string m_CommandLineArgument; //Field offset: 0x8

	public string CommandLineArgument
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public CommandLineLocaleSelector() { }

	public string get_CommandLineArgument() { }

	public override Locale GetStartupLocale(ILocalesProvider availableLocales) { }

	public void set_CommandLineArgument(string value) { }

}

