namespace System.Dynamic;

public class DynamicMetaObject
{
	public static readonly DynamicMetaObject[] EmptyMetaObjects; //Field offset: 0x0
	private static readonly object s_noValueSentinel; //Field offset: 0x4
	private readonly object _value; //Field offset: 0x8
	[CompilerGenerated]
	private readonly Expression <Expression>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private readonly BindingRestrictions <Restrictions>k__BackingField; //Field offset: 0x10

	public Expression Expression
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public bool HasValue
	{
		 get { } //Length: 76
	}

	public Type LimitType
	{
		 get { } //Length: 193
	}

	public BindingRestrictions Restrictions
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public Type RuntimeType
	{
		 get { } //Length: 171
	}

	public object Value
	{
		 get { } //Length: 88
	}

	private static DynamicMetaObject() { }

	public DynamicMetaObject(Expression expression, BindingRestrictions restrictions) { }

	public DynamicMetaObject(Expression expression, BindingRestrictions restrictions, object value) { }

	public override DynamicMetaObject BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg) { }

	public override DynamicMetaObject BindConvert(ConvertBinder binder) { }

	public override DynamicMetaObject BindCreateInstance(CreateInstanceBinder binder, DynamicMetaObject[] args) { }

	public override DynamicMetaObject BindDeleteIndex(DeleteIndexBinder binder, DynamicMetaObject[] indexes) { }

	public override DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder) { }

	public override DynamicMetaObject BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes) { }

	public override DynamicMetaObject BindGetMember(GetMemberBinder binder) { }

	public override DynamicMetaObject BindInvoke(InvokeBinder binder, DynamicMetaObject[] args) { }

	public override DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args) { }

	public override DynamicMetaObject BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value) { }

	public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value) { }

	public override DynamicMetaObject BindUnaryOperation(UnaryOperationBinder binder) { }

	public static DynamicMetaObject Create(object value, Expression expression) { }

	[CompilerGenerated]
	public Expression get_Expression() { }

	public bool get_HasValue() { }

	public Type get_LimitType() { }

	[CompilerGenerated]
	public BindingRestrictions get_Restrictions() { }

	public Type get_RuntimeType() { }

	public object get_Value() { }

	public override IEnumerable<String> GetDynamicMemberNames() { }

}

