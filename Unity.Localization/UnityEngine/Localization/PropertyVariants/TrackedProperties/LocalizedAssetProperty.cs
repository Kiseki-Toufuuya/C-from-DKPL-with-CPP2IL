namespace UnityEngine.Localization.PropertyVariants.TrackedProperties;

public class LocalizedAssetProperty : ITrackedProperty
{
	[SerializeReference]
	private LocalizedAssetBase m_Localized; //Field offset: 0x8
	[SerializeField]
	private string m_PropertyPath; //Field offset: 0xC

	public LocalizedAssetBase LocalizedObject
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public override string PropertyPath
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public LocalizedAssetProperty() { }

	public LocalizedAssetBase get_LocalizedObject() { }

	public override string get_PropertyPath() { }

	public override bool HasVariant(LocaleIdentifier localeIdentifier) { }

	public void set_LocalizedObject(LocalizedAssetBase value) { }

	public override void set_PropertyPath(string value) { }

}

