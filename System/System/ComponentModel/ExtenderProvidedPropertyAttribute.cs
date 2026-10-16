namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::All (32767))]
public sealed class ExtenderProvidedPropertyAttribute : Attribute
{
	[CompilerGenerated]
	private PropertyDescriptor <ExtenderProperty>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private IExtenderProvider <Provider>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private Type <ReceiverType>k__BackingField; //Field offset: 0x10

	public private PropertyDescriptor ExtenderProperty
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private IExtenderProvider Provider
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private Type ReceiverType
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public ExtenderProvidedPropertyAttribute() { }

	internal static ExtenderProvidedPropertyAttribute Create(PropertyDescriptor extenderProperty, Type receiverType, IExtenderProvider provider) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public PropertyDescriptor get_ExtenderProperty() { }

	[CompilerGenerated]
	public IExtenderProvider get_Provider() { }

	[CompilerGenerated]
	public Type get_ReceiverType() { }

	public virtual int GetHashCode() { }

	public virtual bool IsDefaultAttribute() { }

	[CompilerGenerated]
	private void set_ExtenderProperty(PropertyDescriptor value) { }

	[CompilerGenerated]
	private void set_Provider(IExtenderProvider value) { }

	[CompilerGenerated]
	private void set_ReceiverType(Type value) { }

}

