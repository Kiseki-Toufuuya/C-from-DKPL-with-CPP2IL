namespace UnityEngine.Localization.Pseudo;

[CreateAssetMenu(menuName = "Localization/Pseudo-Locale", fileName = "Pseudo-Locale(pseudo)")]
public class PseudoLocale : Locale
{
	[SerializeReference]
	private List<IPseudoLocalizationMethod> m_Methods; //Field offset: 0x28

	public List<IPseudoLocalizationMethod> Methods
	{
		 get { } //Length: 11
	}

	private PseudoLocale() { }

	public static PseudoLocale CreatePseudoLocale() { }

	public List<IPseudoLocalizationMethod> get_Methods() { }

	public override string GetPseudoString(string input) { }

	internal void Reset() { }

	public virtual string ToString() { }

}

