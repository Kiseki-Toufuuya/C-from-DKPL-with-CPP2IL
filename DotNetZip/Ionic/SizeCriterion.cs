namespace Ionic;

internal class SizeCriterion : SelectionCriterion
{
	internal ComparisonOperator Operator; //Field offset: 0xC
	internal long Size; //Field offset: 0x10

	private bool _Evaluate(long Length) { }

	public SizeCriterion() { }

	internal virtual bool Evaluate(string filename) { }

	internal virtual bool Evaluate(ZipEntry entry) { }

	public virtual string ToString() { }

}

