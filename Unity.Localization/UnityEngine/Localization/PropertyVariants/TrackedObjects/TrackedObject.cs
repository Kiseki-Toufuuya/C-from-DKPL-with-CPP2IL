namespace UnityEngine.Localization.PropertyVariants.TrackedObjects;

public abstract class TrackedObject : ISerializationCallbackReceiver
{
	public class TrackedPropertiesCollection
	{
		[SerializeReference]
		public List<ITrackedProperty> items; //Field offset: 0x8

		public TrackedPropertiesCollection() { }

	}

	[HideInInspector]
	[SerializeField]
	private object m_Target; //Field offset: 0x8
	[SerializeField]
	private TrackedPropertiesCollection m_TrackedProperties; //Field offset: 0xC
	private readonly Dictionary<String, ITrackedProperty> m_PropertiesLookup; //Field offset: 0x10

	public object Target
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public IList<ITrackedProperty> TrackedProperties
	{
		 get { } //Length: 23
	}

	protected TrackedObject() { }

	public T AddTrackedProperty(string propertyPath) { }

	public override void AddTrackedProperty(ITrackedProperty trackedProperty) { }

	public abstract AsyncOperationHandle ApplyLocale(Locale variantLocale, Locale defaultLocale) { }

	public override bool CanTrackProperty(string propertyPath) { }

	public override ITrackedProperty CreateCustomTrackedProperty(string propertyPath) { }

	public object get_Target() { }

	public IList<ITrackedProperty> get_TrackedProperties() { }

	public T GetTrackedProperty(string propertyPath, bool create = true) { }

	public override ITrackedProperty GetTrackedProperty(string propertyPath) { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

	protected override void PostApplyTrackedProperties() { }

	public override bool RemoveTrackedProperty(ITrackedProperty trackedProperty) { }

	public void set_Target(object value) { }

}

