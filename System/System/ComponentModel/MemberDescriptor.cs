namespace System.ComponentModel;

[ComVisible(True)]
public abstract class MemberDescriptor
{
	private string name; //Field offset: 0x8
	private string displayName; //Field offset: 0xC
	private int nameHash; //Field offset: 0x10
	private AttributeCollection attributeCollection; //Field offset: 0x14
	private Attribute[] attributes; //Field offset: 0x18
	private Attribute[] originalAttributes; //Field offset: 0x1C
	private bool attributesFiltered; //Field offset: 0x20
	private bool attributesFilled; //Field offset: 0x21
	private int metadataVersion; //Field offset: 0x24
	private string category; //Field offset: 0x28
	private string description; //Field offset: 0x2C
	private object lockCookie; //Field offset: 0x30

	protected override Attribute[] AttributeArray
	{
		 get { } //Length: 32
		 set { } //Length: 235
	}

	public override AttributeCollection Attributes
	{
		 get { } //Length: 256
	}

	public override string DisplayName
	{
		 get { } //Length: 261
	}

	public override string Name
	{
		 get { } //Length: 53
	}

	protected override int NameHashCode
	{
		 get { } //Length: 11
	}

	protected MemberDescriptor(string name, Attribute[] attributes) { }

	protected MemberDescriptor(MemberDescriptor oldMemberDescriptor, Attribute[] newAttributes) { }

	private void CheckAttributesValid() { }

	protected override AttributeCollection CreateAttributeCollection() { }

	public virtual bool Equals(object obj) { }

	protected override void FillAttributes(IList attributeList) { }

	private void FilterAttributesIfNeeded() { }

	protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType) { }

	protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType, bool publicOnly) { }

	protected override Attribute[] get_AttributeArray() { }

	public override AttributeCollection get_Attributes() { }

	public override string get_DisplayName() { }

	public override string get_Name() { }

	protected override int get_NameHashCode() { }

	public virtual int GetHashCode() { }

	protected override object GetInvocationTarget(Type type, object instance) { }

	protected static ISite GetSite(object component) { }

	protected override void set_AttributeArray(Attribute[] value) { }

}

