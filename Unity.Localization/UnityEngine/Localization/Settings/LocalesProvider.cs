namespace UnityEngine.Localization.Settings;

public class LocalesProvider : ILocalesProvider, IPreloadRequired, IReset, IDisposable
{
	private readonly List<Locale> m_Locales; //Field offset: 0x8
	private AsyncOperationHandle m_LoadOperation; //Field offset: 0xC

	public override List<Locale> Locales
	{
		 get { } //Length: 138
	}

	public override AsyncOperationHandle PreloadOperation
	{
		 get { } //Length: 293
	}

	public LocalesProvider() { }

	public override void AddLocale(Locale locale) { }

	protected virtual void Finalize() { }

	public Locale FindFallbackLocale(LocaleIdentifier localeIdentifier) { }

	public override List<Locale> get_Locales() { }

	public override AsyncOperationHandle get_PreloadOperation() { }

	public override Locale GetLocale(LocaleIdentifier id) { }

	public Locale GetLocale(string code) { }

	public Locale GetLocale(SystemLanguage systemLanguage) { }

	public override bool RemoveLocale(Locale locale) { }

	public override void ResetState() { }

	private override void System.IDisposable.Dispose() { }

}

