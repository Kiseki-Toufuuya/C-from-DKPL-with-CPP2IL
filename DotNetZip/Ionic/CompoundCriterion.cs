namespace Ionic;

internal class CompoundCriterion : SelectionCriterion
{
	internal LogicalConjunction Conjunction; //Field offset: 0xC
	internal SelectionCriterion Left; //Field offset: 0x10
	private SelectionCriterion _Right; //Field offset: 0x14

	internal SelectionCriterion Right
	{
		internal get { } //Length: 11
		internal set { } //Length: 59
	}

	public CompoundCriterion() { }

	internal virtual bool Evaluate(string filename) { }

	internal virtual bool Evaluate(ZipEntry entry) { }

	internal SelectionCriterion get_Right() { }

	internal void set_Right(SelectionCriterion value) { }

	public virtual string ToString() { }

}

