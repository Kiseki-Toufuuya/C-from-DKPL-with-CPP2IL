namespace UnityEngine.Localization.PropertyVariants.TrackedProperties;

public interface IStringProperty : ITrackedProperty
{

	public string GetValueAsString(LocaleIdentifier localeIdentifier) { }

	public string GetValueAsString(LocaleIdentifier localeIdentifier, LocaleIdentifier fallback) { }

	public void SetValueFromString(LocaleIdentifier localeIdentifier, string value) { }

}

