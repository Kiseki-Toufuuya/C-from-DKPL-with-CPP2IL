namespace Ionic;

internal class TimeCriterion : SelectionCriterion
{
	internal ComparisonOperator Operator; //Field offset: 0xC
	internal WhichTime Which; //Field offset: 0x10
	internal DateTime Time; //Field offset: 0x18

	private bool _Evaluate(DateTime x) { }

	public TimeCriterion() { }

	internal virtual bool Evaluate(string filename) { }

	internal virtual bool Evaluate(ZipEntry entry) { }

	public virtual string ToString() { }

}

