namespace UnityEngine.Localization.Metadata;

[Metadata(AllowedTypes = MetadataType::Locale (1))]
public class FallbackLocale : IMetadata
{
	[SerializeField]
	private Locale m_Locale; //Field offset: 0x8

	public Locale Locale
	{
		 get { } //Length: 11
		 set { } //Length: 329
	}

	public FallbackLocale() { }

	public FallbackLocale(Locale fallback) { }

	public Locale get_Locale() { }

	private bool IsCyclic(Locale locale) { }

	public void set_Locale(Locale value) { }

}

