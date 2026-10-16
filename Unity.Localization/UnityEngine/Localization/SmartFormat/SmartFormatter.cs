namespace UnityEngine.Localization.SmartFormat;

public class SmartFormatter : ISerializationCallbackReceiver
{
	private static readonly Object[] k_Empty; //Field offset: 0x0
	[SerializeReference]
	private SmartSettings m_Settings; //Field offset: 0x8
	[SerializeReference]
	private Parser m_Parser; //Field offset: 0xC
	[SerializeReference]
	private List<ISource> m_Sources; //Field offset: 0x10
	[SerializeReference]
	private List<IFormatter> m_Formatters; //Field offset: 0x14
	private List<String> m_NotEmptyFormatterExtensionNames; //Field offset: 0x18
	[CompilerGenerated]
	private EventHandler<FormattingErrorEventArgs> OnFormattingFailure; //Field offset: 0x1C

	public event EventHandler<FormattingErrorEventArgs> OnFormattingFailure
	{
		[CompilerGenerated]
		 add { } //Length: 125
		[CompilerGenerated]
		 remove { } //Length: 125
	}

	public List<IFormatter> FormatterExtensions
	{
		 get { } //Length: 11
	}

	public Parser Parser
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public SmartSettings Settings
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public List<ISource> SourceExtensions
	{
		 get { } //Length: 11
	}

	private static SmartFormatter() { }

	public SmartFormatter() { }

	[CompilerGenerated]
	public void add_OnFormattingFailure(EventHandler<FormattingErrorEventArgs> value) { }

	public void AddExtensions(ISource[] sourceExtensions) { }

	public void AddExtensions(IFormatter[] formatterExtensions) { }

	private void CheckForExtensions() { }

	private void EvaluateFormatters(FormattingInfo formattingInfo) { }

	private void EvaluateSelectors(FormattingInfo formattingInfo) { }

	public string Format(IFormatProvider provider, IList<Object> args, string format) { }

	public override void Format(FormattingInfo formattingInfo) { }

	private void Format(FormatDetails formatDetails, Format format, object current) { }

	public string Format(IList<Object> args, string format) { }

	public string Format(string format, Object[] args) { }

	public string Format(IFormatProvider provider, string format, Object[] args) { }

	private void FormatError(FormatItem errorItem, Exception innerException, int startIndex, FormattingInfo formattingInfo) { }

	public void FormatInto(IOutput output, string format, Object[] args) { }

	public string FormatWithCache(ref FormatCache cache, string format, IList<Object> args) { }

	public string FormatWithCache(ref FormatCache cache, string format, IFormatProvider formatProvider, IList<Object> args) { }

	public void FormatWithCacheInto(ref FormatCache cache, IOutput output, string format, Object[] args) { }

	public List<IFormatter> get_FormatterExtensions() { }

	public Parser get_Parser() { }

	public SmartSettings get_Settings() { }

	public List<ISource> get_SourceExtensions() { }

	public T GetFormatterExtension() { }

	public List<String> GetNotEmptyFormatterExtensionNames() { }

	public T GetSourceExtension() { }

	private bool InvokeFormatterExtensions(FormattingInfo formattingInfo) { }

	private bool InvokeSourceExtensions(FormattingInfo formattingInfo) { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

	[CompilerGenerated]
	public void remove_OnFormattingFailure(EventHandler<FormattingErrorEventArgs> value) { }

	public void set_Parser(Parser value) { }

	public void set_Settings(SmartSettings value) { }

}

