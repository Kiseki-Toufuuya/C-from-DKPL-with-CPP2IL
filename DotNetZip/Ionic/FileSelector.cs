namespace Ionic;

public class FileSelector
{
	private enum ParseState
	{
		Start = 0,
		OpenParen = 1,
		CriterionDone = 2,
		ConjunctionPending = 3,
		Whitespace = 4,
	}

	private static class RegexAssertions
	{
		public static readonly string PrecededByOddNumberOfSingleQuotes; //Field offset: 0x0
		public static readonly string FollowedByOddNumberOfSingleQuotesAndLineEnd; //Field offset: 0x4
		public static readonly string PrecededByEvenNumberOfSingleQuotes; //Field offset: 0x8
		public static readonly string FollowedByEvenNumberOfSingleQuotesAndLineEnd; //Field offset: 0xC

		private static RegexAssertions() { }

	}

	internal SelectionCriterion _Criterion; //Field offset: 0x8
	[CompilerGenerated]
	private bool <TraverseReparsePoints>k__BackingField; //Field offset: 0xC

	public string SelectionCriteria
	{
		 get { } //Length: 41
		 set { } //Length: 123
	}

	public bool TraverseReparsePoints
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	private static SelectionCriterion _ParseCriterion(string s) { }

	public FileSelector(string selectionCriteria) { }

	public FileSelector(string selectionCriteria, bool traverseDirectoryReparsePoints) { }

	private bool Evaluate(string filename) { }

	private bool Evaluate(ZipEntry entry) { }

	public string get_SelectionCriteria() { }

	[CompilerGenerated]
	public bool get_TraverseReparsePoints() { }

	private static string NormalizeCriteriaExpression(string source) { }

	public ICollection<ZipEntry> SelectEntries(ZipFile zip) { }

	public ICollection<ZipEntry> SelectEntries(ZipFile zip, string directoryPathInArchive) { }

	public ICollection<String> SelectFiles(string directory) { }

	public ReadOnlyCollection<String> SelectFiles(string directory, bool recurseDirectories) { }

	[Conditional("SelectorTrace")]
	private void SelectorTrace(string format, Object[] args) { }

	public void set_SelectionCriteria(string value) { }

	[CompilerGenerated]
	public void set_TraverseReparsePoints(bool value) { }

	public virtual string ToString() { }

}

