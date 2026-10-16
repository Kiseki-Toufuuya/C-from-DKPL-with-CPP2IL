namespace D4L.Repository;

public class UnityPreferenceAccessor : IPreferenceAccessor
{
	public static IPreferenceAccessor Default; //Field offset: 0x0

	private static UnityPreferenceAccessor() { }

	private UnityPreferenceAccessor() { }

	public override int GetInt(string key, int defaultValue = 0) { }

	public override void Save() { }

	public override void SetInt(string key, int value) { }

}

