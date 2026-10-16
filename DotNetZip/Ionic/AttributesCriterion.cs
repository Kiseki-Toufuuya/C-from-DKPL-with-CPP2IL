namespace Ionic;

internal class AttributesCriterion : SelectionCriterion
{
	private FileAttributes _Attributes; //Field offset: 0xC
	internal ComparisonOperator Operator; //Field offset: 0x10

	internal string AttributeString
	{
		internal get { } //Length: 248
		internal set { } //Length: 784
	}

	private bool _Evaluate(FileAttributes fileAttrs) { }

	private bool _EvaluateOne(FileAttributes fileAttrs, FileAttributes criterionAttrs) { }

	public AttributesCriterion() { }

	internal virtual bool Evaluate(string filename) { }

	internal virtual bool Evaluate(ZipEntry entry) { }

	internal string get_AttributeString() { }

	internal void set_AttributeString(string value) { }

	public virtual string ToString() { }

}

