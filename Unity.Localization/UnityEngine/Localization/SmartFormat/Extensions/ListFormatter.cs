namespace UnityEngine.Localization.SmartFormat.Extensions;

public class ListFormatter : FormatterBase, ISource, IFormatterLiteralExtractor
{
	[CompilerGenerated]
	private static int <CollectionIndex>k__BackingField; //Field offset: 0x0
	[HideInInspector]
	[SerializeReference]
	private SmartSettings m_SmartSettings; //Field offset: 0xC

	private static int CollectionIndex
	{
		[CompilerGenerated]
		private get { } //Length: 60
		[CompilerGenerated]
		private set { } //Length: 78
	}

	public virtual String[] DefaultNames
	{
		 get { } //Length: 177
	}

	private static ListFormatter() { }

	public ListFormatter(SmartFormatter formatter) { }

	[CompilerGenerated]
	private static int get_CollectionIndex() { }

	public virtual String[] get_DefaultNames() { }

	[CompilerGenerated]
	private static void set_CollectionIndex(int value) { }

	public virtual bool TryEvaluateFormat(IFormattingInfo formattingInfo) { }

	public override bool TryEvaluateSelector(ISelectorInfo selectorInfo) { }

	public override void WriteAllLiterals(IFormattingInfo formattingInfo) { }

}

