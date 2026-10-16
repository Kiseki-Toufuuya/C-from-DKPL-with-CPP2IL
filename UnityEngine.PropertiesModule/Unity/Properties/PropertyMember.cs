namespace Unity.Properties;

[IsReadOnly]
internal struct PropertyMember : IMemberInfo
{
	internal readonly PropertyInfo m_PropertyInfo; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly string <Name>k__BackingField; //Field offset: 0x4

	public override bool IsReadOnly
	{
		 get { } //Length: 44
	}

	public override string Name
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public override Type ValueType
	{
		 get { } //Length: 39
	}

	public PropertyMember(PropertyInfo propertyInfo) { }

	public override bool get_IsReadOnly() { }

	[CompilerGenerated]
	public override string get_Name() { }

	public override Type get_ValueType() { }

	public override IEnumerable<Attribute> GetCustomAttributes() { }

	public override object GetValue(object obj) { }

	public override void SetValue(object obj, object value) { }

}

