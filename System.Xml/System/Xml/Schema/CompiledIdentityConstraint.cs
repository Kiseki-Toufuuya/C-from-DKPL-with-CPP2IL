namespace System.Xml.Schema;

internal class CompiledIdentityConstraint
{
	internal enum ConstraintRole
	{
		Unique = 0,
		Key = 1,
		Keyref = 2,
	}

	public static readonly CompiledIdentityConstraint Empty; //Field offset: 0x0
	internal XmlQualifiedName name; //Field offset: 0x8
	private ConstraintRole role; //Field offset: 0xC
	private Asttree selector; //Field offset: 0x10
	private Asttree[] fields; //Field offset: 0x14
	internal XmlQualifiedName refer; //Field offset: 0x18

	public Asttree[] Fields
	{
		 get { } //Length: 11
	}

	public ConstraintRole Role
	{
		 get { } //Length: 11
	}

	public Asttree Selector
	{
		 get { } //Length: 11
	}

	private static CompiledIdentityConstraint() { }

	private CompiledIdentityConstraint() { }

	public CompiledIdentityConstraint(XmlSchemaIdentityConstraint constraint, XmlNamespaceManager nsmgr) { }

	public Asttree[] get_Fields() { }

	public ConstraintRole get_Role() { }

	public Asttree get_Selector() { }

}

