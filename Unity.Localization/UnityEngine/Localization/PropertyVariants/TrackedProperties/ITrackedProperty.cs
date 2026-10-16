namespace UnityEngine.Localization.PropertyVariants.TrackedProperties;

public interface ITrackedProperty
{

	public string PropertyPath
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public string get_PropertyPath() { }

	public bool HasVariant(LocaleIdentifier localeIdentifier) { }

	public void set_PropertyPath(string value) { }

}

