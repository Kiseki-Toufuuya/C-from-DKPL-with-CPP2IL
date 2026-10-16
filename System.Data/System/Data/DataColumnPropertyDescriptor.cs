namespace System.Data;

internal sealed class DataColumnPropertyDescriptor : PropertyDescriptor
{
	[CompilerGenerated]
	private readonly DataColumn <Column>k__BackingField; //Field offset: 0x48

	public virtual AttributeCollection Attributes
	{
		 get { } //Length: 371
	}

	internal DataColumn Column
	{
		[CompilerGenerated]
		internal get { } //Length: 11
	}

	public virtual Type ComponentType
	{
		 get { } //Length: 69
	}

	public virtual bool IsReadOnly
	{
		 get { } //Length: 23
	}

	public virtual Type PropertyType
	{
		 get { } //Length: 23
	}

	internal DataColumnPropertyDescriptor(DataColumn dataColumn) { }

	public virtual bool CanResetValue(object component) { }

	public virtual bool Equals(object other) { }

	public virtual AttributeCollection get_Attributes() { }

	[CompilerGenerated]
	internal DataColumn get_Column() { }

	public virtual Type get_ComponentType() { }

	public virtual bool get_IsReadOnly() { }

	public virtual Type get_PropertyType() { }

	public virtual int GetHashCode() { }

	public virtual object GetValue(object component) { }

	public virtual void ResetValue(object component) { }

	public virtual void SetValue(object component, object value) { }

	public virtual bool ShouldSerializeValue(object component) { }

}

