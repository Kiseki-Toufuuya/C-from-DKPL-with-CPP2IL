namespace System;

[AttributeUsage(AttributeTargets::Class (4), Inherited = True)]
public sealed class AttributeUsageAttribute : Attribute
{
	internal static AttributeUsageAttribute Default; //Field offset: 0x0
	private AttributeTargets _attributeTarget; //Field offset: 0x8
	private bool _allowMultiple; //Field offset: 0xC
	private bool _inherited; //Field offset: 0xD

	public bool AllowMultiple
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public bool Inherited
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static AttributeUsageAttribute() { }

	public AttributeUsageAttribute(AttributeTargets validOn) { }

	public bool get_AllowMultiple() { }

	public bool get_Inherited() { }

	public void set_AllowMultiple(bool value) { }

	public void set_Inherited(bool value) { }

}

