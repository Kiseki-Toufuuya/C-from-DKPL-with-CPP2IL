namespace Ionic;

internal class NameCriterion : SelectionCriterion
{
	private Regex _re; //Field offset: 0xC
	private string _regexString; //Field offset: 0x10
	internal ComparisonOperator Operator; //Field offset: 0x14
	private string _MatchingFileSpec; //Field offset: 0x18

	internal override string MatchingFileSpec
	{
		internal set { } //Length: 746
	}

	private bool _Evaluate(string fullpath) { }

	public NameCriterion() { }

	internal virtual bool Evaluate(string filename) { }

	internal virtual bool Evaluate(ZipEntry entry) { }

	internal override void set_MatchingFileSpec(string value) { }

	public virtual string ToString() { }

}

