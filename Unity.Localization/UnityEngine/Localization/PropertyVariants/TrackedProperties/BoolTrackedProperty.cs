namespace UnityEngine.Localization.PropertyVariants.TrackedProperties;

public class BoolTrackedProperty : TrackedProperty<Boolean>
{

	public BoolTrackedProperty() { }

	protected virtual bool ConvertFromString(string value) { }

	protected virtual string ConvertToString(bool value) { }

}

