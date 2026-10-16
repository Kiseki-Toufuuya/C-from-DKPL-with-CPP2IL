namespace D4L.Repository;

[Extension]
public static class PreferenceAccessorExtensions
{

	[Extension]
	public static int IncrementInt(IPreferenceAccessor preferenceAccessor, string key, int initialValue = 0) { }

}

