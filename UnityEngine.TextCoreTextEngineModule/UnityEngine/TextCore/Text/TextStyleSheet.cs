namespace UnityEngine.TextCore.Text;

[ExcludeFromObjectFactory]
[ExcludeFromPreset]
public class TextStyleSheet : ScriptableObject
{
	[SerializeField]
	private List<TextStyle> m_StyleList; //Field offset: 0xC
	private Dictionary<Int32, TextStyle> m_StyleLookupDictionary; //Field offset: 0x10
	private object styleLookupLock; //Field offset: 0x14

	internal List<TextStyle> styles
	{
		internal get { } //Length: 11
	}

	public TextStyleSheet() { }

	internal List<TextStyle> get_styles() { }

	public TextStyle GetStyle(int hashCode) { }

	public TextStyle GetStyle(string name) { }

	private void LoadStyleDictionaryInternal() { }

	public void RefreshStyles() { }

	private void Reset() { }

}

