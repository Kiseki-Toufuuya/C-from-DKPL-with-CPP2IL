namespace System.ComponentModel;

internal sealed class ExtendedPropertyDescriptor : PropertyDescriptor
{
	private readonly ReflectPropertyDescriptor _extenderInfo; //Field offset: 0x48
	private readonly IExtenderProvider _provider; //Field offset: 0x4C

	public virtual Type ComponentType
	{
		 get { } //Length: 40
	}

	public virtual string DisplayName
	{
		 get { } //Length: 562
	}

	public virtual bool IsReadOnly
	{
		 get { } //Length: 197
	}

	public virtual Type PropertyType
	{
		 get { } //Length: 40
	}

	public ExtendedPropertyDescriptor(ReflectPropertyDescriptor extenderInfo, Type receiverType, IExtenderProvider provider, Attribute[] attributes) { }

	public virtual bool CanResetValue(object comp) { }

	public virtual Type get_ComponentType() { }

	public virtual string get_DisplayName() { }

	public virtual bool get_IsReadOnly() { }

	public virtual Type get_PropertyType() { }

	public virtual object GetValue(object comp) { }

	public virtual void ResetValue(object comp) { }

	public virtual void SetValue(object component, object value) { }

	public virtual bool ShouldSerializeValue(object comp) { }

}

