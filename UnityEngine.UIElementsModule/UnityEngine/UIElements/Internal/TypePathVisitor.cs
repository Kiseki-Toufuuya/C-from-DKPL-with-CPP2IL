namespace UnityEngine.UIElements.Internal;

internal class TypePathVisitor : ITypeVisitor, IPropertyBagVisitor, IPropertyVisitor
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private PropertyPath <Path>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Type <resolvedType>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private VisitReturnCode <ReturnCode>k__BackingField; //Field offset: 0x54
	private Type m_LastType; //Field offset: 0x58
	private int m_PathIndex; //Field offset: 0x5C

	public PropertyPath Path
	{
		[CompilerGenerated]
		 get { } //Length: 52
		[CompilerGenerated]
		 set { } //Length: 64
	}

	private Type resolvedType
	{
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public internal VisitReturnCode ReturnCode
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 14
	}

	public TypePathVisitor() { }

	[CompilerGenerated]
	public PropertyPath get_Path() { }

	[CompilerGenerated]
	public VisitReturnCode get_ReturnCode() { }

	private static Type GetElementType(Type type) { }

	private bool IsLastPartReached() { }

	public void Reset() { }

	[CompilerGenerated]
	public void set_Path(PropertyPath value) { }

	[CompilerGenerated]
	private void set_resolvedType(Type value) { }

	[CompilerGenerated]
	internal void set_ReturnCode(VisitReturnCode value) { }

	private override void Unity.Properties.IPropertyBagVisitor.Visit(IPropertyBag<TContainer> properties, ref TContainer container) { }

	private override void Unity.Properties.IPropertyVisitor.Visit(Property<TContainer, TValue> property, ref TContainer container) { }

	private override void Unity.Properties.ITypeVisitor.Visit() { }

}

