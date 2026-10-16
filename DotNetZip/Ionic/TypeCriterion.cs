namespace Ionic;

internal class TypeCriterion : SelectionCriterion
{
	private char ObjectType; //Field offset: 0xC
	internal ComparisonOperator Operator; //Field offset: 0x10

	internal string AttributeString
	{
		internal get { } //Length: 44
		internal set { } //Length: 669
	}

	public TypeCriterion() { }

	internal virtual bool Evaluate(string filename) { }

	internal virtual bool Evaluate(ZipEntry entry) { }

	internal string get_AttributeString() { }

	internal void set_AttributeString(string value) { }

	public virtual string ToString() { }

}

