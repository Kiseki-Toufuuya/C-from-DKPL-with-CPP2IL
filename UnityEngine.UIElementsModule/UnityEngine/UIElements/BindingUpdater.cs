namespace UnityEngine.UIElements;

internal class BindingUpdater
{
	private sealed class CastDataSourceVisitor : ConcreteTypeVisitor
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private DataBinding <Binding>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private BindingContext <bindingContext>k__BackingField; //Field offset: 0xC
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private BindingResult <result>k__BackingField; //Field offset: 0xA8

		public DataBinding Binding
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 27
		}

		public BindingContext bindingContext
		{
			[CompilerGenerated]
			 get { } //Length: 27
			[CompilerGenerated]
			 set { } //Length: 39
		}

		public BindingResult result
		{
			[CompilerGenerated]
			 get { } //Length: 20
			[CompilerGenerated]
			 set { } //Length: 43
		}

		public CastDataSourceVisitor() { }

		[CompilerGenerated]
		public DataBinding get_Binding() { }

		[CompilerGenerated]
		public BindingContext get_bindingContext() { }

		[CompilerGenerated]
		public BindingResult get_result() { }

		public void Reset() { }

		[CompilerGenerated]
		public void set_Binding(DataBinding value) { }

		[CompilerGenerated]
		public void set_bindingContext(BindingContext value) { }

		[CompilerGenerated]
		public void set_result(BindingResult value) { }

		protected virtual void VisitContainer(ref TContainer container) { }

	}

	private sealed class UIPathVisitor : PathVisitor
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private DataBinding <binding>k__BackingField; //Field offset: 0x60
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private BindingUpdateStage <direction>k__BackingField; //Field offset: 0x64
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private BindingContext <bindingContext>k__BackingField; //Field offset: 0x68
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private BindingResult <result>k__BackingField; //Field offset: 0x104

		public DataBinding binding
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 27
		}

		public BindingContext bindingContext
		{
			[CompilerGenerated]
			 get { } //Length: 27
			[CompilerGenerated]
			 set { } //Length: 39
		}

		public BindingUpdateStage direction
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 14
		}

		public BindingResult result
		{
			[CompilerGenerated]
			 get { } //Length: 20
			[CompilerGenerated]
			 set { } //Length: 43
		}

		public UIPathVisitor() { }

		[CompilerGenerated]
		public DataBinding get_binding() { }

		[CompilerGenerated]
		public BindingContext get_bindingContext() { }

		[CompilerGenerated]
		public BindingUpdateStage get_direction() { }

		[CompilerGenerated]
		public BindingResult get_result() { }

		public virtual void Reset() { }

		[CompilerGenerated]
		public void set_binding(DataBinding value) { }

		[CompilerGenerated]
		public void set_bindingContext(BindingContext value) { }

		[CompilerGenerated]
		public void set_direction(BindingUpdateStage value) { }

		[CompilerGenerated]
		public void set_result(BindingResult value) { }

		protected virtual void VisitPath(Property<TContainer, TValue> property, ref TContainer container, ref TValue value) { }

	}

	private static readonly CastDataSourceVisitor s_VisitDataSourceAsRootVisitor; //Field offset: 0x0
	private static readonly UIPathVisitor s_VisitDataSourceAtPathVisitor; //Field offset: 0x4

	private static BindingUpdater() { }

	public BindingUpdater() { }

	internal static string GetExtractValueErrorString(VisitReturnCode returnCode, object target, in PropertyPath path) { }

	internal static string GetRootDataSourceError(object target) { }

	internal static string GetVisitationErrorString(VisitReturnCode returnCode, in BindingContext context) { }

	public bool ShouldProcessBindingAtStage(Binding bindingObject, BindingUpdateStage stage, bool versionChanged, bool dirty) { }

	private bool ShouldProcessBindingAtStage(CustomBinding customBinding, BindingUpdateStage stage, bool versionChanged, bool dirty) { }

	private static bool ShouldProcessBindingAtStage(DataBinding dataBinding, BindingUpdateStage stage, bool versionChanged, bool dirty) { }

	private static BindingResult TryUpdateUIWithNonContainer(in BindingContext context, DataBinding binding, object value) { }

	private BindingResult UpdateDataSource(in BindingContext context, DataBinding dataBinding) { }

	private BindingResult UpdateDataSource(in BindingContext context, CustomBinding customBinding) { }

	public BindingResult UpdateSource(in BindingContext context, Binding bindingObject) { }

	private BindingResult UpdateUI(in BindingContext context, CustomBinding customBinding) { }

	public BindingResult UpdateUI(in BindingContext context, Binding bindingObject) { }

	private BindingResult UpdateUI(in BindingContext context, DataBinding dataBinding) { }

	private static ValueTuple<Boolean, VisitReturnCode, VisitReturnCode, BindingResult> VisitAtPath(DataBinding dataBinding, BindingUpdateStage direction, ref TContainer container, in PropertyPath path, in BindingContext context) { }

	private static ValueTuple<Boolean, VisitReturnCode, BindingResult> VisitRoot(DataBinding dataBinding, ref object container, in BindingContext context) { }

}

