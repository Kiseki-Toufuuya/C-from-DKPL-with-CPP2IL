namespace Ionic;

internal abstract class SelectionCriterion
{
	[CompilerGenerated]
	private bool <Verbose>k__BackingField; //Field offset: 0x8

	internal override bool Verbose
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 14
	}

	protected SelectionCriterion() { }

	[Conditional("SelectorTrace")]
	protected static void CriterionTrace(string format, Object[] args) { }

	internal abstract bool Evaluate(string filename) { }

	internal abstract bool Evaluate(ZipEntry entry) { }

	[CompilerGenerated]
	internal override bool get_Verbose() { }

	[CompilerGenerated]
	internal override void set_Verbose(bool value) { }

}

