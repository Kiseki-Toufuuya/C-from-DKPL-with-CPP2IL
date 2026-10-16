namespace D4L.Repository;

public interface IPreferenceAccessor
{

	public int GetInt(string key, int defaultValue = 0) { }

	public void Save() { }

	public void SetInt(string key, int value) { }

}

