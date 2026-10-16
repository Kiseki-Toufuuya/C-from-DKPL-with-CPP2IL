namespace UnityEngine.Localization.PropertyVariants.TrackedProperties;

public class StringTrackedProperty : TrackedProperty<String>
{

	public StringTrackedProperty() { }

	protected virtual string ConvertFromString(string value) { }

	protected virtual string ConvertToString(string value) { }

}

