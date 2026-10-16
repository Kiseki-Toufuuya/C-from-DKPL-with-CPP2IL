namespace System.ComponentModel;

public abstract class CustomTypeDescriptor : ICustomTypeDescriptor
{
	private readonly ICustomTypeDescriptor _parent; //Field offset: 0x8

	protected CustomTypeDescriptor() { }

	public override AttributeCollection GetAttributes() { }

	public override TypeConverter GetConverter() { }

	public override PropertyDescriptorCollection GetProperties() { }

	public override PropertyDescriptorCollection GetProperties(Attribute[] attributes) { }

	public override object GetPropertyOwner(PropertyDescriptor pd) { }

}

