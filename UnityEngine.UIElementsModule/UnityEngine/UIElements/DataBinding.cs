namespace UnityEngine.UIElements;

[UxmlObject]
public class DataBinding : Binding, IDataSourceProvider
{
	private static MethodInfo s_UpdateUIMethodInfo; //Field offset: 0x0
	private BindingMode m_BindingMode; //Field offset: 0x14
	private ConverterGroup m_SourceToUiConverters; //Field offset: 0x18
	private ConverterGroup m_UiToSourceConverters; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private object <dataSource>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Type <dataSourceType>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private PropertyPath <dataSourcePath>k__BackingField; //Field offset: 0x28

	[CreateProperty]
	public BindingMode bindingMode
	{
		 get { } //Length: 11
		 set { } //Length: 23
	}

	[CreateProperty]
	public override object dataSource
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	[CreateProperty]
	public override PropertyPath dataSourcePath
	{
		[CompilerGenerated]
		 get { } //Length: 52
		[CompilerGenerated]
		 set { } //Length: 64
	}

	public Type dataSourceType
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	[CreateProperty(ReadOnly = True)]
	public ConverterGroup sourceToUiConverters
	{
		 get { } //Length: 104
	}

	[CreateProperty(ReadOnly = True)]
	public ConverterGroup uiToSourceConverters
	{
		 get { } //Length: 104
	}

	internal static MethodInfo updateUIMethod
	{
		internal get { } //Length: 424
	}

	public void ApplyConverterGroupToSource(ConverterGroup group) { }

	public void ApplyConverterGroupToUI(ConverterGroup group) { }

	private static MethodInfo CacheReflectionInfo() { }

	public BindingMode get_bindingMode() { }

	[CompilerGenerated]
	public override object get_dataSource() { }

	[CompilerGenerated]
	public override PropertyPath get_dataSourcePath() { }

	[CompilerGenerated]
	public Type get_dataSourceType() { }

	public ConverterGroup get_sourceToUiConverters() { }

	public ConverterGroup get_uiToSourceConverters() { }

	internal static MethodInfo get_updateUIMethod() { }

	internal static string GetSetValueErrorString(VisitReturnCode returnCode, object source, in PropertyPath sourcePath, object target, in BindingId targetPath, TValue extractedValueFromSource) { }

	public void set_bindingMode(BindingMode value) { }

	[CompilerGenerated]
	public void set_dataSource(object value) { }

	[CompilerGenerated]
	public void set_dataSourcePath(PropertyPath value) { }

	[CompilerGenerated]
	public void set_dataSourceType(Type value) { }

	protected private override BindingResult UpdateSource(in BindingContext context, ref TValue value) { }

	protected private override BindingResult UpdateUI(in BindingContext context, ref TValue value) { }

}

