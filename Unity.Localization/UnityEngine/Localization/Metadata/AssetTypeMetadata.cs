namespace UnityEngine.Localization.Metadata;

[HideInInspector]
internal class AssetTypeMetadata : SharedTableCollectionMetadata
{
	[HideInInspector]
	[SerializeField]
	internal string m_TypeString; //Field offset: 0x10
	[CompilerGenerated]
	private Type <Type>k__BackingField; //Field offset: 0x14

	public Type Type
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public AssetTypeMetadata() { }

	[CompilerGenerated]
	public Type get_Type() { }

	public virtual void OnAfterDeserialize() { }

	public virtual void OnBeforeSerialize() { }

	[CompilerGenerated]
	public void set_Type(Type value) { }

}

