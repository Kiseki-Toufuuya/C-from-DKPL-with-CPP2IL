namespace UnityEngine.UIElements.Internal;

internal class AutoCompletePathVisitor : ITypeVisitor, IPropertyVisitor, IPropertyBagVisitor, IListPropertyVisitor
{
	private struct InspectedTypeScope : IDisposable
	{
		private VisitContext m_VisitContext; //Field offset: 0x0

		public InspectedTypeScope`1(VisitContext context) { }

		public override void Dispose() { }

	}

	private class VisitContext
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private List<PropertyPathInfo> <propertyPathInfos>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private readonly HashSet<Type> <types>k__BackingField; //Field offset: 0xC
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private PropertyPath <current>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private int <currentDepth>k__BackingField; //Field offset: 0x58

		public PropertyPath current
		{
			[CompilerGenerated]
			 get { } //Length: 52
			[CompilerGenerated]
			 set { } //Length: 64
		}

		public int currentDepth
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 14
		}

		public List<PropertyPathInfo> propertyPathInfos
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 27
		}

		public HashSet<Type> types
		{
			[CompilerGenerated]
			 get { } //Length: 11
		}

		public VisitContext() { }

		[CompilerGenerated]
		public PropertyPath get_current() { }

		[CompilerGenerated]
		public int get_currentDepth() { }

		[CompilerGenerated]
		public List<PropertyPathInfo> get_propertyPathInfos() { }

		[CompilerGenerated]
		public HashSet<Type> get_types() { }

		[CompilerGenerated]
		public void set_current(PropertyPath value) { }

		[CompilerGenerated]
		public void set_currentDepth(int value) { }

		[CompilerGenerated]
		public void set_propertyPathInfos(List<PropertyPathInfo> value) { }

	}

	private struct VisitedPropertyScope : IDisposable
	{
		private VisitContext m_VisitContext; //Field offset: 0x0

		public VisitedPropertyScope(VisitContext context, IProperty property) { }

		public VisitedPropertyScope(VisitContext context, int index, Type type) { }

		public override void Dispose() { }

	}

	private VisitContext m_VisitContext; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <maxDepth>k__BackingField; //Field offset: 0xC

	public int maxDepth
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public AutoCompletePathVisitor() { }

	[CompilerGenerated]
	public int get_maxDepth() { }

	private bool HasReachedEnd(Type containerType) { }

	public void Reset() { }

	private override void Unity.Properties.IListPropertyVisitor.Visit(Property<TContainer, TList> property, ref TContainer container, ref TList list) { }

	private override void Unity.Properties.IPropertyBagVisitor.Visit(IPropertyBag<TContainer> properties, ref TContainer container) { }

	private override void Unity.Properties.IPropertyVisitor.Visit(Property<TContainer, TValue> property, ref TContainer container) { }

	private override void Unity.Properties.ITypeVisitor.Visit() { }

	private void VisitPropertyType(Type type) { }

}

