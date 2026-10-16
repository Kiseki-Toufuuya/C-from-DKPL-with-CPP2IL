namespace UnityEngine.Localization.PropertyVariants.TrackedObjects;

[CustomTrackedObject(typeof(Graphic), True)]
[DisplayName("UI Graphic", null)]
public class TrackedUGuiGraphic : JsonSerializerTrackedObject
{

	public TrackedUGuiGraphic() { }

	protected virtual void PostApplyTrackedProperties() { }

}

