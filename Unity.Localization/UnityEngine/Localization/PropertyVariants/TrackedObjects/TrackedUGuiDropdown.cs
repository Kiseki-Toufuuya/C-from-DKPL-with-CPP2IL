namespace UnityEngine.Localization.PropertyVariants.TrackedObjects;

[CustomTrackedObject(typeof(Dropdown), True)]
[DisplayName("UI Dropdown", null)]
public class TrackedUGuiDropdown : JsonSerializerTrackedObject
{

	public TrackedUGuiDropdown() { }

	protected virtual void PostApplyTrackedProperties() { }

}

