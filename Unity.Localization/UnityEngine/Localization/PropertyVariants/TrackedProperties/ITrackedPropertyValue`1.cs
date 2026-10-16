namespace UnityEngine.Localization.PropertyVariants.TrackedProperties;

public interface ITrackedPropertyValue : ITrackedProperty
{

	public bool GetValue(LocaleIdentifier localeIdentifier, out T foundValue) { }

	public bool GetValue(LocaleIdentifier localeIdentifier, LocaleIdentifier fallback, out T foundValue) { }

	public void SetValue(LocaleIdentifier localeIdentifier, T value) { }

}

