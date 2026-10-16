namespace UnityEngine.Localization.SmartFormat.Core.Formatting;

public class FormattingInfo : IFormattingInfo, ISelectorInfo
{
	[CompilerGenerated]
	private FormattingInfo <Parent>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private Selector <Selector>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private FormatDetails <FormatDetails>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private object <CurrentValue>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private Placeholder <Placeholder>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Format <Format>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private readonly List<FormattingInfo> <Children>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private object <Result>k__BackingField; //Field offset: 0x24

	public override int Alignment
	{
		 get { } //Length: 23
	}

	public List<FormattingInfo> Children
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public override object CurrentValue
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public private override Format Format
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private override FormatDetails FormatDetails
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public override string FormatterOptions
	{
		 get { } //Length: 23
	}

	public private FormattingInfo Parent
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private override Placeholder Placeholder
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public override object Result
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public Selector Selector
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public override int SelectorIndex
	{
		 get { } //Length: 23
	}

	public override string SelectorOperator
	{
		 get { } //Length: 72
	}

	public override string SelectorText
	{
		 get { } //Length: 34
	}

	public FormattingInfo() { }

	private FormattingInfo CreateChild(Format format, object currentValue) { }

	public FormattingInfo CreateChild(Placeholder placeholder) { }

	public override FormattingException FormattingException(string issue, FormatItem problemItem = null, int startIndex = -1) { }

	public override int get_Alignment() { }

	[CompilerGenerated]
	public List<FormattingInfo> get_Children() { }

	[CompilerGenerated]
	public override object get_CurrentValue() { }

	[CompilerGenerated]
	public override Format get_Format() { }

	[CompilerGenerated]
	public override FormatDetails get_FormatDetails() { }

	public override string get_FormatterOptions() { }

	[CompilerGenerated]
	public FormattingInfo get_Parent() { }

	[CompilerGenerated]
	public override Placeholder get_Placeholder() { }

	[CompilerGenerated]
	public override object get_Result() { }

	[CompilerGenerated]
	public Selector get_Selector() { }

	public override int get_SelectorIndex() { }

	public override string get_SelectorOperator() { }

	public override string get_SelectorText() { }

	public void Init(FormattingInfo parent, FormatDetails formatDetails, Placeholder placeholder, object currentValue) { }

	public void Init(FormattingInfo parent, FormatDetails formatDetails, Format format, object currentValue) { }

	public void Init(FormatDetails formatDetails, Format format, object currentValue) { }

	public void ReleaseToPool() { }

	[CompilerGenerated]
	public void set_CurrentValue(object value) { }

	[CompilerGenerated]
	private void set_Format(Format value) { }

	[CompilerGenerated]
	private void set_FormatDetails(FormatDetails value) { }

	[CompilerGenerated]
	private void set_Parent(FormattingInfo value) { }

	[CompilerGenerated]
	private void set_Placeholder(Placeholder value) { }

	[CompilerGenerated]
	public override void set_Result(object value) { }

	[CompilerGenerated]
	public void set_Selector(Selector value) { }

	public override void Write(string text) { }

	public override void Write(Format format, object value) { }

	public override void Write(string text, int startIndex, int length) { }

}

