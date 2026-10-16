//Type is in global namespace

[CustomTrackedObject(typeof(AtlasImage), False)]
[DisplayName("Atlas Image", null)]
public class TrackedAtlasImage : TrackedObject
{

	public TrackedAtlasImage() { }

	public virtual AsyncOperationHandle ApplyLocale(Locale variantLocale, Locale defaultLocale) { }

	public virtual bool CanTrackProperty(string propertyPath) { }

}

